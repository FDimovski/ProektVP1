using System;
using System.Collections.Generic;
using System.Drawing;

namespace ПроектВП
{
  
    public class WormShark
    {
        public Bitmap Slika { get; set; }
        public Point Location { get; set; }
        public bool RemoveAnimal { get; set; }
        public bool Poen { get; set; }
        public Color Type { get; set; } 
        public Size Size { get; set; }
      
        public WormShark(Point p,double probShark,double probGreen)
        {
            Location = p;
            Random r = new Random();
            double randProb = r.NextDouble();
            if (randProb <= probShark)
            {
                Slika =Properties.Resources.shark;
                Size = new Size(180, 100);
                Type = WormTypes.NONE; //shark
            }
            else if (randProb >= probShark && randProb <= probGreen)
            {
                Size = new Size(60, 10);
                Type = WormTypes.GREEN;
            }
            else
            {
                Size = new Size(60, 10);
                Type = WormTypes.RED;
            }

        }
        
        internal bool IsItHit(Point p)
        {
            p = new Point(p.X + Fish.FishSize.Width/2, p.Y + Fish.FishSize.Height/2);//za da bide na sredina

            double d = ((Location.X + Size.Width / 2) - p.X) * ((Location.X + Size.Width / 2) - p.X) + ((Location.Y + Size.Height / 2) - p.Y) * ((Location.Y + Size.Height / 2) - p.Y);
            double radius = Math.Sqrt(Size.Width * Size.Width + Size.Height * Size.Height) / 2;
            if (Type != WormTypes.NONE)
                return (d <= 2*radius * radius);
            else
                return d <= radius * radius/2; //iako e stretch slikata pak ima sloboden prostor od stranite
        }

        public void Draw(Graphics g)
        {
            Rectangle rect = new Rectangle(Location, Size);
            if (Type!=WormTypes.NONE) g.FillRectangle(new SolidBrush(Type),rect);
         else  g.DrawImage(Slika, rect,new Rectangle(0,0,Slika.Width,Slika.Height),GraphicsUnit.Pixel);   
        }
        public void Move()
        {
            Location = new Point(Location.X - 60, Location.Y);
            if ((Location.X+Size.Width)<= 0)
                RemoveAnimal = true;
        }
    }
    public abstract class WormTypes
    {
        public static Color NONE = Color.Transparent;
        public static Color GREEN = Color.Green;
        public static Color RED = Color.Red;
    }
}
