using System;

namespace ПроектВП
{
    public class User
    {
        public string UserName { get; set; }
        public int Points { get; set; }
        public User(string userName):this(userName,0)
        {
        }
        public User(string userName,int points)
        {
            this.UserName = userName;
            Points = points;
        }
        public override string ToString()
        {
            return String.Format("Име: {0} Поени: {1}", UserName, Points);
        }
        public  string Write()
        {
            return UserName + " " + Points;
        }
    }
}
