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
    public partial class InstructionForm : Form
    {
        public InstructionForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            tbInstrukcii.Text = "За да можете да ја играте оваа игра, мора најпрво да се најавите.Откако ќе го внесете Вашето име, кликнете на копчето „Играј“.Рибата можете да ја контролирате со стрелките од тастатурата, како и со W(нагоре),S(надолу),A(лево),D(десно), како и со комбинации од овие копчиња. Ваша задача е да изедете колку што можете повеќе зелени црви, и да ги одбегнувате црвените црви и ајкулите. Со среќа :)";
        }

        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.ForeColor = Color.Red;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.ForeColor = Color.Black;
        }
    }
}
