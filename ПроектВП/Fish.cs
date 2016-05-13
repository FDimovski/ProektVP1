using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПроектВП
{
    public class Fish
    {
        public string ImageLocation { get; set; }
        public Point Location { get; set; }
        public static Size FishSize { get; set; }

        public Fish(Point location,Size fishSize)
        {
            this.Location = location;
            FishSize = fishSize;
        }
        public void MoveUp()
        {
            if (Location.Y > 15)
             Location = new Point(Location.X,Location.Y - 15);
        }
        public void MoveLeft()
        {
            if (Location.X > 15)
                Location = new Point(Location.X - 15, Location.Y);
        }
        public void MoveRight()
        {
            if (Location.X +15 < System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width  - FishSize.Width)
            Location = new Point(Location.X + 15, Location.Y);
        }
        public void MoveDown()
        {
            if ((Location.Y+15)<(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 100 - FishSize.Height))
                Location = new Point(Location.X, Location.Y + 15);
        }
        public void MoveUpLeft()
        {
            if (Location.Y > 15 && (Location.X > 15))
                Location = new Point(Location.X + (int)(15 * Math.Cos(135 * (Math.PI / 180))),
                  Location.Y - (int)(15 * Math.Sin(135 * (Math.PI / 180))));
        }
        public void MoveUpRight()
        {
            if (Location.Y > 15 && (Location.X+15 < System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width -FishSize.Width))
                Location = new Point(Location.X + (int)(15 * Math.Cos(45 * (Math.PI / 180))),
               Location.Y - (int)(15 * Math.Sin(45 * (Math.PI / 180))));
        }
        public void MoveDownLeft()
        {
            if (((Location.Y + 15) < (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 100 - FishSize.Height)) && (Location.X > 15))
                Location = new Point(Location.X - (int)(15 * Math.Cos(315 * (Math.PI / 180))),
                Location.Y - (int)(15 * Math.Sin(315 * (Math.PI / 180))));
        }
        public void MoveDownRight()
        {
            if (((Location.Y + 15) < (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 100 - FishSize.Height)) && (Location.X+15 < System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width  -FishSize.Width))
                Location = new Point(Location.X + (int)(15 * Math.Cos(315 * (Math.PI / 180))),
                Location.Y - (int)(15 * Math.Sin(315 * (Math.PI / 180))));

        }
    }
}
