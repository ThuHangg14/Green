using System;

namespace UserManager
{
    public enum Rank
    {
        Copper = 1,
        Sliver = 2,
        Gold = 3,
        Diamond = 4
    }
    public class User
    {
        private int id;
        private string name;
        private string area;
        private int level;
        private double gold;
        private Rank rank;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Area { get { return area; } set { area = value; } }
        public int Level { get { return level; } set { level = value; } }
        public double Gold { get { return gold; } set { gold = value; } }
        public Rank Rank { get { return rank; } set { rank = value; } }

        public User()
        {

        }

        public User(int id, string name, string area, int level, double gold, Rank rank)
        {
            this.id = id;
            this.name = name;
            this.area = area;
            this.level = level;
            this.gold = gold;
            this.rank = rank;

        }

        public Rank GetRandomRank()
        {
            return (Rank)Utilities.RandomNumber(1, 4);
        }

        public static void ShowUser(User user)
        {
            Console.WriteLine("id :" + user.Id);
            Console.WriteLine("name : " + user.Name);
            Console.WriteLine("area : " + user.Area);
            Console.WriteLine("rank : " + user.rank);
            Console.WriteLine("level : " + user.level + " gold : " + user.Gold);
        }

        public static User InputUser()
        {
            User u = new User();
            u.Id = 0;
            UIManager.Instance.PrintMessenger("Name : ");
            u.Name = Console.ReadLine();
            UIManager.Instance.PrintMessenger("Area : ");
            u.Area = Console.ReadLine();
            u.Level = 0;
            u.Gold = 0;
            u.Rank = Rank.Copper;

            return u;
        }
    }
}
