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
        bool MoveLeft { get; set; }
        bool MoveRight { get; set; }
        bool MoveUp { get; set; }
        bool MoveDown { get; set; }
        WormSharkDoc Animals;
        private int count=0;
        User CurrentUser;
        Fish Fish;
        double pridvizhi = 500;
        private int sekundi = 0;
        private int minuti = 0;
        double prag=2.5;

        public GameForm(User FishUser)
        {
            InitializeComponent();
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.Cursor.Dispose();
            CurrentUser = FishUser;
            DoubleBuffered = true;
            //za da bide dole na full screen so visina 100
            pInfo.Bounds = new Rectangle(0,Screen.PrimaryScreen.Bounds.Height-100,Screen.PrimaryScreen.Bounds.Width, 100);   
            lblVreme.Location = new Point(Screen.PrimaryScreen.Bounds.Width-200,lblStatus.Location.Y);
            Fish = new Fish(pbRiba.Location,pbRiba.Size);
            Animals = new WormSharkDoc(Height,Width);
        }

        
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            //pauziranje na igrata
            if (e.KeyCode == Keys.Escape)
            {
                tPridvizhi.Stop();
                tRibaDvizhenje.Stop();
                tSekunda.Stop();
                DialogResult diag=MessageBox.Show("Дали сакате да излезете? Резултатот нема да Ви биде зачуван.", "?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(diag==DialogResult.Yes)
                {
                    WriteUser();
                    this.Close();
                }
                else
                {
                    tPridvizhi.Start();
                    tSekunda.Start();
                    tRibaDvizhenje.Start();
                }
            }
            //upravuvanje na ribata
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) MoveLeft = true;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) MoveRight = true;
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) MoveUp = true;
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) MoveDown = true;
            
            
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            MoveLeft = false;MoveRight = false;MoveUp = false;MoveDown = false;
        }
        
        private void tRibaDvizhenje_Tick(object sender, EventArgs e)
        {
            if (MoveUp && MoveLeft) Fish.MoveUpLeft();
            else if (MoveUp && MoveRight) Fish.MoveUpRight();
            else if (MoveDown && MoveRight) Fish.MoveDownRight();
            else if (MoveDown && MoveLeft) Fish.MoveDownLeft();
            else if (MoveUp) Fish.MoveUp();
            else if (MoveDown) Fish.MoveDown();
            else if (MoveLeft) Fish.MoveLeft();
            else if (MoveRight) Fish.MoveRight();
            pbRiba.Location = Fish.Location;
            string message = "";
            Animals.Hit(Fish.Location,out message);
            
            if(message!="")
            {
             lblStatus.Text = message;
           //za da imame celosno vreme na prikaz na porakata od 5 izbrojuvanja
             count = 10; 
            }
            if (Animals.IsItOver)
                GameOver();
        }

        private void tPridvizhi_Tick(object sender, EventArgs e)
        {
            ++count;
            Animals.AddAnimal();
            if (count % 5 == 0)
                lblStatus.Text = "";
            lblPoeni.Text = Animals.Poeni.ToString();
            Animals.Move();
            if (prag > 0)
            {
                pridvizhi -= prag;
                prag -= 0.01;
            }
            else pridvizhi -=0.5;
            if (pridvizhi <= 0)
                pridvizhi = 3;
            tPridvizhi.Interval = Math.Abs((int)Math.Floor(pridvizhi)) + 1;
            Invalidate();
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
           Animals.Draw(e.Graphics);
        }

        private void tSekunda_Tick(object sender, EventArgs e)
        {
                sekundi++;
                if (sekundi % 60 == 0)
                {
                minuti++;
                sekundi =0;
                }
            lblVreme.Text = minuti.ToString("00") + " : " + sekundi.ToString("00");
        }
        private void GameOver()
        {
            tPridvizhi.Stop();
            tRibaDvizhenje.Stop();
            tSekunda.Stop();
            if (Form1.PlayMusic)
                SorryFish.Play();
            pbRiba.Visible = false;
            if ((CurrentUser.Points < Animals.Poeni) || (CurrentUser.Points == Animals.Poeni && ((CurrentUser.Minutes > minuti) || (CurrentUser.Minutes == minuti && CurrentUser.Seconds > sekundi))) || (CurrentUser.Minutes == 0 && CurrentUser.Seconds == 0 && CurrentUser.Points == Animals.Poeni))
            {
                CurrentUser.Points = Animals.Poeni;
                CurrentUser.Minutes = minuti;
                CurrentUser.Seconds = sekundi;
            }
            MessageBox.Show("Вкупно поени: " + Animals.Poeni, "Играта заврши");
            MessageBox.Show(CurrentUser.ToString(), "Најдобар резултат: ");
            WriteUser();
            this.Close();
            if (Form1.PlayMusic)
                Form1.Music.PlayLooping();
        }
        private void WriteUser()
        {
            using (StreamWriter w = File.AppendText("baza.txt"))
            {
                w.WriteLine(CurrentUser.Write());
                w.Close();
            }
        }
    }
}