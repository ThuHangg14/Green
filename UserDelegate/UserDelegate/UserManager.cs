using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDelegate
{

    delegate void ShowUserDelegate(User user);

    public class UserManager
    {
        static Dictionary<int, User> userList = new Dictionary<int, User>();

        public void AddNewUser(User user)
        {
            userList.Add(user.Id, user);
        }

        public void RemoveUser(int id)
        {
            if (userList.ContainsKey(id))
            {
                userList.Remove(id);
            }
        }

        public User PutName(int id, string name)
        {
            if (userList.TryGetValue(id, out User value))
            {
                value.Name = name;
            }

            return value;
        }

        public void ShowUser(User user)
        {
            Console.WriteLine("id : " + user.Id);
            Console.WriteLine("name : " + user.Name);
            Console.WriteLine("location : " + user.Location);
            Console.WriteLine("level : " + user.Level);
            Console.WriteLine("gold : " + user.gold);

        }

        public void ShowAllUser(Dictionary<int, User> users)
        {
            ShowUserDelegate userDelegate = ShowUser;

            foreach (User u in users.Values)
            {
                userDelegate(u);
            }
        }

        public bool CheckUserByCollection(User users, bool condition)
        {
            if (condition)
                return true;
            return false;
        }

        

    }
}
