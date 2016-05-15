using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace ПроектВП
{
    public partial class Form1 : Form
    {
        public bool IsUserLogged { get; set; }
        public static bool PlayMusic { get; set; }
        public User NewUser;
        ToolTip ttInfo;
        public static SoundPlayer Music = new SoundPlayer("Sounds/background.wav");
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            ttInfo = new ToolTip();
            PlayMusic = false;
            pbZvuk_Click(null, null);
        }
        private void btnIgraj_Click(object sender, EventArgs e)
        {
            if(!IsUserLogged)
            { 
                ttInfo.ToolTipTitle = "Грешка";
                ttInfo.SetToolTip(btnIgraj, "Прво мора да се најавите за да играте");
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
          
            if (Login.ShowDialog()==DialogResult.OK)
            {
                if(IsUserLogged && NewUser!=null)
                {
                    StreamWriter w = File.AppendText("baza.txt");
                    w.WriteLine(NewUser.Write());
                    w.Close();
                }
                bool LoginAgain = false;
                
                using (StreamReader w = new StreamReader("baza.txt"))
                {
                    string[] doc = w.ReadToEnd().Split('\n');
                    foreach (string s in doc)
                    {
                        if (s.Trim().Length == 0) break;
                        string name = s.Split(' ')[0];
                        if(name==Login.UserName)
                        {
                            w.Close();
                            LoginAgain = true;
                            int points = Convert.ToInt32(s.Split(' ')[1]);
                            int min = Convert.ToInt32(s.Split(' ')[2]);
                            int sec = Convert.ToInt32(s.Split(' ')[3].Trim());
                            NewUser = new User(name, points,min,sec);   
                            var tempFile = Path.GetTempFileName();
                            var linesToKeep = File.ReadLines("baza.txt").Where(l => l != name + " " + points.ToString()+" " + min.ToString() + " " + sec.ToString());
                            File.WriteAllLines(tempFile, linesToKeep);
                            File.Delete("baza.txt");
                            File.Move(tempFile, "baza.txt");
                            MessageBox.Show("Досега се имате најавено: " + NewUser.UserName + "\nДосегашни поени: " + points.ToString()+"\nВреме: "+NewUser.CreateTime());
                        }                       
                    }
                }
                if (!LoginAgain)
                {
                    NewUser = new User(Login.UserName);
                    MessageBox.Show("Креиран е корисникот:"+Login.UserName, "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
        }
        private void btnRang_Click(object sender, EventArgs e)
        {
            StatisticsForm sf = new StatisticsForm();
            sf.ShowDialog();
        }
        private void btnNajava_MouseEnter(object sender, EventArgs e)
        {
            MouseOnEnter(btnNajava);
        }

        private void btnNajava_MouseLeave(object sender, EventArgs e)
        {
            MouseOnLeave(btnNajava);
        }

        private void btnInstrukcii_MouseEnter(object sender, EventArgs e)
        {
            MouseOnEnter(btnInstrukcii);
        }

        private void btnInstrukcii_MouseLeave(object sender, EventArgs e)
        {
            MouseOnLeave(btnInstrukcii);
        }

        private void btnIgraj_MouseLeave(object sender, EventArgs e)
        {

            ttInfo.SetToolTip(btnIgraj, null);
            MouseOnLeave(btnIgraj);
        }

        private void btnIgraj_MouseEnter(object sender, EventArgs e)
        {
            MouseOnEnter(btnIgraj);

        }

        private void btnRang_MouseLeave(object sender, EventArgs e)
        {
            MouseOnLeave(btnRang);
        }

        private void btnRang_MouseEnter(object sender, EventArgs e)
        {
            MouseOnEnter(btnRang);
        }
        private void MouseOnEnter(Button b)
        {
            b.ForeColor = Color.Red;
        }
        private void MouseOnLeave(Button b)
        {
            b.ForeColor = Color.Black;
        }
        private void MusicPlay()
        {
            Music.PlayLooping();
            PlayMusic = true;
            pbZvuk.Image = Properties.Resources.sound_on;
        }
        private void MusicStop()
        {
            Music.Stop();
            PlayMusic = false;
            pbZvuk.Image = Properties.Resources.sound_off;
        }
    }
}
