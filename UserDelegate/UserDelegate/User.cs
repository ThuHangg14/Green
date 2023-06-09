using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDelegate
{
    public class User
    {
        public int Id;
        public string Name;
        public string Location;
        public string gold;
        public string Level;

        public User()
        {

        }

        public User(int Id , string Name , string Location , string gold , string Level)
        {
            this.Id = Id;
            this.Name = Name;
            this.Location = Location;
            this.gold = gold;
            this.Level = Level;
        }
    }
}
