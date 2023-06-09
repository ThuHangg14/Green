using System;
using System.Collections.Generic;
using System.Linq;

namespace UserManager
{
    public class UserPanel
    {
        protected Dictionary<String, User> users;

        public UserPanel()
        {
            users = new Dictionary<String, User>();
        }


        public void AddUser(User user)
        {
            users.Add(user.Id.ToString(), user);
        }

        public int GetSizeUsers()
        {
            return users.Count;
        }

        public bool UpdateUser(String id)
        {
            if (users.TryGetValue(id, out User user))
            {
                Console.WriteLine("Name : ");
                user.Name = Console.ReadLine();

                User.ShowUser(user);

                return true;
            }
            else return false;
        }

        public void removeUser(String id)
        {
            if (users.ContainsKey(id))
            {

                users.Remove(id);

                UIManager.Instance.PrintMessengerSuccess();
            }
            else
            {
                UIManager.Instance.PrintMessengerFail();
            }

        }

        public void GetAllUser()
        {
            foreach (User u in users.Values)
            {
                User.ShowUser(u);
            }
        }

        public void SortUser()
        {
            List<KeyValuePair<string, User>> sortedList = users.ToList()
                                                                     .OrderBy(kvp => kvp.Value.Area)
                                                                     .ThenBy(kvp => kvp.Value.Rank)
                                                                     .ThenBy(kvp => kvp.Value.Gold)
                                                                     .ThenBy(kvp => kvp.Value.Level)
                                                                     .ToList();

            users = sortedList.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            GetAllUser();
        }

        public List<User> FillterArea(string key)
        {
            List<User> list = new List<User>();
            foreach (var u in users.Values)
            {
                if (u.Area.Equals(key))
                {
                    list.Add(u);
                }
            }

            return list;
        }

        public List<User> FillterLevel(int max, int min)
        {
            List<User> list = new List<User>();
            foreach (var u in users.Values)
            {
                if (u.Level <= max && u.Level >= min)
                {
                    list.Add(u);
                }
            }

            return list;
        }
    }
}
