using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПроектВП
{
    public partial class Form1 : Form
    {
        public bool IsUserLogged { get; set; }
        public string FishName { get; set; }
        public static bool PlayMusic { get; set; }
        public User NewUser { get; set; }
        public static SoundPlayer Music = new SoundPlayer("Sounds/background.wav");
        public Form1()
        {
            InitializeComponent();
            PlayMusic = false;
            pbZvuk.BackColor = Color.Transparent;
            pbZvuk_Click(null, null);


        }
        private void MusicPlay()
        {
            Music.PlayLooping();
            PlayMusic = true;
            pbZvuk.ImageLocation = "Pictures//sound_on.png";
           


        }
        private void MusicStop()
        {
            Music.Stop();
            PlayMusic = false;
            pbZvuk.ImageLocation = "Pictures//sound_off.png";
        }
        private void btnNajava_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(btnNajava);
        }
        private void MouseEnter(Button b)
        {
            b.ForeColor = Color.Red;
        }
        private void MouseLeave(Button b)
        {
            b.ForeColor = Color.Black;
        }
        private void btnNajava_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(btnNajava);
        }

        private void btnInstrukcii_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(btnInstrukcii);
        }

        private void btnInstrukcii_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(btnInstrukcii);
        }

        private void btnIgraj_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(btnIgraj);
        }

        private void btnIgraj_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(btnIgraj);
           
        }

        private void btnIgraj_Click(object sender, EventArgs e)
        {
            if(!IsUserLogged)
            {
                ToolTip tt1 = new ToolTip();
                tt1.SetToolTip(btnIgraj, "Прво мора да се најавите за да играте");
                return;
            }
            MessageBox.Show("Со среќа рибо " + NewUser.UserName + " ^_^","Почеток на игра",MessageBoxButtons.OK,MessageBoxIcon.Information);
            GameForm Game = new GameForm(NewUser);
            IsUserLogged = false;
            Game.ShowDialog();

        }

        private void btnNajava_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            if(Login.ShowDialog()==DialogResult.OK)
            {
                bool LoginAgain = false;
                using (StreamReader w = new StreamReader("baza.txt"))
                {
                    string[] doc = w.ReadToEnd().Split('\n');
                    foreach (string s in doc)
                    {
                        if (s.Trim().Length == 0) break;
                        string name = s.Split(' ')[0];
                        if(name==Login.Name)
                        {
                            w.Close();
                            LoginAgain = true;
                            int points = Convert.ToInt32(s.Split(' ')[1]);
                            NewUser = new User(name, points);
                            var tempFile = Path.GetTempFileName();
                            var linesToKeep = File.ReadLines("baza.txt").Where(l => l != name + " " + points.ToString());
                            File.WriteAllLines(tempFile, linesToKeep);
                            File.Delete("baza.txt");
                            File.Move(tempFile, "baza.txt");
                            MessageBox.Show("Веќе сте најавени: " + name + "\n Досегашни поени: " + points.ToString());
                        }
                        // MessageBox.Show(s + "\n " + name + "\n" +s.Split(' ')[1]);
                       
                    }

                }
                if(!LoginAgain)
                    NewUser = new User(Login.Name);
               
                IsUserLogged = true;
                
                
            }
        }

        private void btnInstrukcii_Click(object sender, EventArgs e)
        {
            InstructionForm Instructions = new InstructionForm();
            Instructions.ShowDialog();
        }

        private void pbZvuk_Click(object sender, EventArgs e)
        {
            if (PlayMusic)
                MusicStop();
            else
                MusicPlay();
            pbZvuk.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnRang_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(btnRang);
        }

        private void btnRang_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(btnRang);
        }

        private void btnRang_Click(object sender, EventArgs e)
        {
            using (StreamReader w = new StreamReader("baza.txt"))
            {
               string[] doc = w.ReadToEnd().Split('\n');
                List<User> AllUsers = new List<User>();
                   foreach(string s in doc)
                {
                    if (s.Trim().Length == 0) break;
                    string name = s.Split(' ')[0];
                   // MessageBox.Show(s + "\n " + name + "\n" +s.Split(' ')[1]);
                    int points = Convert.ToInt32(s.Split(' ')[1]);

                    AllUsers.Add(new User(name, points));
                }
                AllUsers=AllUsers.OrderByDescending(x => x.Points).ToList();
                StringBuilder sb = new StringBuilder();
                int i = 1;
                foreach(User s in AllUsers)
                {
                    sb.Append(i + ". " + s.ToString()+"\n");
                    i++;
                }
                MessageBox.Show(sb.ToString());
                w.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayMusic = false;
            pbZvuk_Click(null, null);
        }
    }
}
