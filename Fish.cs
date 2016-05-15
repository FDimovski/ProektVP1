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
        /// <summary>
        /// Позицијата на рибата
        /// </summary>
        public Point Location { get; set; }
        /// <summary>
        /// Големината на рибата
        /// </summary>
        public static Size FishSize { get; set; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="location">локација на рибата</param>
        /// <param name="fishSize">големина на рибата</param>
        public Fish(Point location,Size fishSize)
        {
            this.Location = location;
            FishSize = fishSize;
        }
        /// <summary>
        /// Движење на рибата нагоре
        /// </summary>
        public void MoveUp()
        {
            if (Location.Y > 10)
             Location = new Point(Location.X,Location.Y - 10);
        }
        /// <summary>
        /// движење на рибата лево
        /// </summary>
        public void MoveLeft()
        {
            if (Location.X > 10)
                Location = new Point(Location.X - 10, Location.Y);
        }
        /// <summary>
        /// движење на рибата десно
        /// </summary>
        public void MoveRight()
        {
            if (Location.X +10 < System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width  - FishSize.Width)
            Location = new Point(Location.X + 10, Location.Y);
        }
        /// <summary>
        /// движење на рибата надоле
        /// </summary>
        public void MoveDown()
        {
           
            if ((Location.Y+10)<(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 100 - FishSize.Height))
                Location = new Point(Location.X, Location.Y + 10);
        }
        /// <summary>
        /// движење на рибата нагоре и надолу
        /// </summary>
        public void MoveUpLeft()
        {
            if (Location.Y > 10 && (Location.X > 10))
                Location = new Point(Location.X + (int)(10 * Math.Cos(135 * (Math.PI / 180))),
                  Location.Y - (int)(10 * Math.Sin(135 * (Math.PI / 180))));
        }
        /// <summary>
        /// движење на рибата нагоре и надесно
        /// </summary>
        public void MoveUpRight()
        {
            if (Location.Y > 10 && (Location.X+10 < System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width -FishSize.Width))
                Location = new Point(Location.X + (int)(10 * Math.Cos(45 * (Math.PI / 180))),
               Location.Y - (int)(10 * Math.Sin(45 * (Math.PI / 180))));
        }
        /// <summary>
        /// движење на рибата надолу и лево
        /// </summary>
        public void MoveDownLeft()
        {
            if (((Location.Y + 10) < (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 100 - FishSize.Height)) && (Location.X > 10))
                Location = new Point(Location.X - (int)(15 * Math.Cos(315 * (Math.PI / 180))),
                Location.Y - (int)(10 * Math.Sin(315 * (Math.PI / 180))));
        }
        /// <summary>
        /// движење на рибата надолу и десно
        /// </summary>
        public void MoveDownRight()
        {
            if (((Location.Y + 10) < (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 100 - FishSize.Height)) && (Location.X+10 < System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width  -FishSize.Width))
                Location = new Point(Location.X + (int)(10 * Math.Cos(315 * (Math.PI / 180))),
                Location.Y - (int)(10 * Math.Sin(315 * (Math.PI / 180))));

        }
    }
}
