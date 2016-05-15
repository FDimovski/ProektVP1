using System;

namespace ПроектВП
{
    public class User
    {
        public string UserName { get; set; }
        public int Points { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public User(string userName):this(userName,0,0,0)
        {
        }
        public User(string userName,int points,int minutes,int seconds)
        {
            this.UserName = userName;
            Points = points;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        public string CreateTime()
        {
            return Minutes.ToString("00") + " : " + Seconds.ToString("00");
        }
        public override string ToString()
        {
            return String.Format("Име: {0} Поени: {1} Време: {2:00}:{3:00} ", UserName, Points,Minutes,Seconds);
        }
        public  string Write()
        {
            return UserName + " " + Points+" "+Minutes+" "+Seconds;
        }
    }
}
