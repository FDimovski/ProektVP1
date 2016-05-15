using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПроектВП
{
    public partial class StatisticsForm : Form
    {
        
        public StatisticsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            FillData();
            DoubleBuffered = true;
        }
        private void FillData()
        {
            using (StreamReader w = new StreamReader("baza.txt"))
            {
                string[] doc = w.ReadToEnd().Split('\n');
                List<User> AllUsers = new List<User>();
                foreach (string s in doc)
                {
                    if (s.Trim().Length == 0) break;
                    string name = s.Split(' ')[0];
                    int points = Convert.ToInt32(s.Split(' ')[1]);
                    int minutes = Convert.ToInt32(s.Split(' ')[2]);
                    int seconds = Convert.ToInt32(s.Split(' ')[3]);
                    AllUsers.Add(new User(name, points, minutes, seconds));
                }
                AllUsers = AllUsers.OrderByDescending(x => x.Points).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Име", typeof(string));
                dt.Columns.Add("Поени", typeof(int));
                dt.Columns.Add("Време", typeof(string));
                foreach (User s in AllUsers)
                dt.Rows.Add(s.UserName,s.Points,s.CreateTime());
                dgvPodatoci.DataSource = dt;
                w.Close();
            }
        }

        private void dgvPodatoci_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //samo eden red mozhe da se selektira
           DataGridViewRow dg=dgvPodatoci.SelectedRows[0];
            DialogResult res = MessageBox.Show("Дали навистина сакате да го избришете корисникот "+dg.Cells[0].Value+" ?", "?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string[] s= dg.Cells[2].Value.ToString().Split(':');
                int min = Convert.ToInt32(s[0]);
                int sec = Convert.ToInt32(s[1]);
                var tempFile = Path.GetTempFileName();
                var linesToKeep = File.ReadLines("baza.txt").Where(l => l != dg.Cells[0].Value + " " + dg.Cells[1].Value.ToString()+" "+min.ToString()+" "+sec.ToString());
                File.WriteAllLines(tempFile, linesToKeep);
                File.Delete("baza.txt");
                File.Move(tempFile, "baza.txt");
                MessageBox.Show("Корисникот е избришан!");
            }
            
            else e.Cancel = true;
        }
    }
}
