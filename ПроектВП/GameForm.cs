using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace ПроектВП
{
   
    public partial class GameForm : Form
    {
        SoundPlayer SorryFish = new SoundPlayer("Sounds/riba2.wav");
        bool Left { get; set; }
        bool Right { get; set; }
        bool Up { get; set; }
        bool Down { get; set; }
        WormSharkDoc Animals;
        int count;
        User CurrentUser;
        Fish Fish;
        public GameForm(User FishUser)
        {
            InitializeComponent();
            CurrentUser = FishUser;
            count = 0;
            DoubleBuffered = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            pInfo.Bounds = new Rectangle(0,Screen.PrimaryScreen.Bounds.Height-100,Screen.PrimaryScreen.Bounds.Width, 100);   
            pbRiba.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRiba.BackColor = Color.Transparent;
            lblStatus.BackColor = Color.Transparent;
            Fish = new Fish(pbRiba.Location,pbRiba.Size);
            lblPoeni.BackColor = Color.Transparent;
            Animals = new WormSharkDoc(Height,Width);
            label1.BackColor = Color.Transparent;
            tRibaDvizhenje.Start();
            tPridvizhi.Start();

        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tPridvizhi.Stop();
                tRibaDvizhenje.Stop();
                DialogResult diag=MessageBox.Show("Дали саката да излезете? Резултатот нема да Ви биде зачуван.", "?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(diag==DialogResult.Yes)
                {
                    using (StreamWriter w = File.AppendText("baza.txt"))
                    {
                        w.WriteLine(CurrentUser.Write());
                    }
                  
                    this.Close();
                }
                else
                {
                    tPridvizhi.Start();
                    tRibaDvizhenje.Start();
                }
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) Left = true;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) Right = true;
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) Up = true;
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) Down = true;
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            Left = false;Right = false;Up = false;Down = false;
        }

        private void tRibaDvizhenje_Tick(object sender, EventArgs e)
        {
            if (Up && Left) Fish.MoveUpLeft();
            else if (Up && Right) Fish.MoveUpRight();
            else if (Down && Right) Fish.MoveDownRight();
            else if (Down && Left) Fish.MoveDownLeft();
            else if (Up) Fish.MoveUp();
            else if (Down) Fish.MoveDown();
            else if (Left) Fish.MoveLeft();
            else if (Right) Fish.MoveRight();
            pbRiba.Location = Fish.Location;
            string message = "";
            Animals.Hit(Fish.Location,out message);
            if(message!="")
            {
                lblStatus.Text = message;
                count = 10; //za da imame celosno vreme na prikaz na porakata
            }
           
        }

        private void tPridvizhi_Tick(object sender, EventArgs e)
        {
            ++count;
            if(count%2==0)
            Animals.AddAnimal();
            if (count % 5 == 0)
                lblStatus.Text = "";
            Animals.Move();
            lblPoeni.Text = Animals.Poeni.ToString();
            if (Animals.IsItOver)
            {
                tPridvizhi.Stop();
                tRibaDvizhenje.Stop();
                SorryFish.Play();
                
                pbRiba.Visible = false;
                if(CurrentUser.Points<Animals.Poeni)
                CurrentUser.Points = Animals.Poeni;
                MessageBox.Show("Total Points: " + Animals.Poeni, "Game Over");
                MessageBox.Show(CurrentUser.ToString(),"Најдобар резултат: ");
               
                using (StreamWriter w = File.AppendText("baza.txt"))
                {
                    w.WriteLine(CurrentUser.Write());
                }
                this.Close();
                if (Form1.PlayMusic)
                    Form1.Music.PlayLooping();
            }
            tPridvizhi.Interval = Math.Abs(tPridvizhi.Interval - 3)+1;
            Invalidate();
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
           Animals.Draw(e.Graphics);
        }

        
    }
}