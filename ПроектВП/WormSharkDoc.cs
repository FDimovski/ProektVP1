using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ПроектВП
{
    public class WormSharkDoc
    {
        List<WormShark> WormsSharks { get; set; }
        private double ProbShark { get; set; }
        private double ProbGreen { get; set; }
        public int Poeni { get; set; }
        private Random r;
        private int height;
        private int width;
        public bool IsItOver { get; set; }

        public WormSharkDoc(int height,int width)
        {
            WormsSharks = new List<WormShark>();
            ProbShark = 0.05;
            ProbGreen = 0.7;
            Poeni = 0;
            this.height = height;
            this.width = width;
            r = new Random();
        }
        public void AddAnimal()
        {
            int y = r.Next(Fish.FishSize.Height/2-20,height-80- Fish.FishSize.Height);//-80 bidejki imame panelInfo,-20 za da se crtaat crvite i gore
            Point loc = new Point(width, y);
            WormShark newAnimal = new WormShark(loc,ProbShark,ProbGreen);
            WormsSharks.Add(newAnimal);
            ProbShark += 0.001;
            ProbGreen -= 0.001;
        }
        public void Draw(Graphics g)
        {
            
            foreach (WormShark ws in WormsSharks)
               ws.Draw(g);
        }
        public void Hit(Point p,out string message)
        {
            message = "";
            foreach (WormShark ws in WormsSharks)
            {
                if (ws.IsItHit(p))
                {
                    if (ws.Type == WormTypes.NONE)
                    {
                        message = "Повеќе среќа следниот пат!";
                        IsItOver = true;
                    }
                    else if (ws.Type == WormTypes.GREEN)
                    {
                        message = "Бравоо!";
                        ++Poeni;
                    }
                else if (ws.Type == WormTypes.RED)
                {
                        if (Poeni == 0)
                        {
                            message = "Повеќе среќа следниот пат!";
                            IsItOver = true;
                        }
                        else {
                            message = "Внимавај! Поените се преполовени.";
                        Poeni = (int)(Poeni * 0.5);
                        }
                }
                    WormsSharks.Remove(ws);
                    break;
                }
            }
           
        }
        public void Move()
        {
            foreach (WormShark ws in WormsSharks)
                ws.Move();
            for(int i=WormsSharks.Count-1;i>=0;i--)
            {
                if (WormsSharks[i].RemoveAnimal)
                    WormsSharks.RemoveAt(i);
            }
        }
    }
}
