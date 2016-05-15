using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПроектВП
{
    public partial class LoginForm : Form
    {
        public string UserName { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnOtkazhi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                UserName = tbIme.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if(tbIme.Text.Length==0)
            {
                e.Cancel = true;
                epIme.SetError(tbIme, "Мора рибата да има име!");
                return;
            }
            if(!tbIme.Text.All(Char.IsLetter))
            {
                epIme.SetError(tbIme, "Името се состои само од букви!");
                e.Cancel = true;
                return;
            }
            epIme.SetError(tbIme, "");
            
        }

        private void btnOK_MouseEnter(object sender, EventArgs e)
        {
            btnOK.ForeColor = Color.Red;
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.ForeColor = Color.Black;
        }

        private void btnOtkazhi_MouseEnter(object sender, EventArgs e)
        {
            btnOtkazhi.ForeColor = Color.Red;
        }

        private void btnOtkazhi_MouseLeave(object sender, EventArgs e)
        {
            btnOtkazhi.ForeColor = Color.Black;
        }
    }
}
