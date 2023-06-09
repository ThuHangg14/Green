using System;
using System.Collections.Generic;

namespace UserManager
{
    public class UserManager
    {
        public static UserManager _intance = null;

        public static UserManager Instance
        {
            get
            {
                if (_intance == null)
                    _intance = new UserManager();
                return _intance;
            }
        }

        public UserPanel users;

        private UserManager()
        {
            users = new UserPanel();
        }



        public void ShowMainPanel()
        {
            UIElement[] element = new UIElement[6];
            DelegateManager delegateManager = new DelegateManager();
            element[0] = new UIElement("1", "Add new user", delegateManager.AddNewUser);
            element[1] = new UIElement("2", "Change Info", delegateManager.ChangeInfo);
            element[2] = new UIElement("3", "Remove user", delegateManager.RemoveUser);
            element[3] = new UIElement("4", "All User", delegateManager.DisplayInfoUser);
            element[4] = new UIElement("5", "Filter", delegateManager.FilterUser);
            element[5] = new UIElement("6", "Sort user", delegateManager.SortUser);

            UIManager.Instance.PrintMenu("The Program Manager User", element);
        }

        public void FilterUser()
        {
            UIElement[] element = new UIElement[2];

            element[0] = new UIElement("1", "Area", FilterArea);
            element[1] = new UIElement("2", "level", FilterLevel);

            UIManager.Instance.PrintMenu("Filter", element);
        }

        public void FilterArea()
        {
            UIManager.Instance.PrintMessenger("input area : ");
            string search = Console.ReadLine();

            List<User> list = users.FillterArea(search);

            foreach (User user in list)
            {
                User.ShowUser(user);
            }

            BackToMain();
        }

        public void FilterLevel()
        {
            UIManager.Instance.PrintMessenger("input min : ");
            int min = int.Parse(Console.ReadLine());
            UIManager.Instance.PrintMessenger("input max : ");
            int max = int.Parse(Console.ReadLine());

            List<User> list = users.FillterLevel(min, max);

            foreach (User user in list)
            {
                User.ShowUser(user);
            }
            BackToMain();
        }

        private void BackToMain()
        {
            UIManager.Instance.PrintMessenger("exit random key ");

            string rd = Console.ReadLine();

            ShowMainPanel();
        }

        public void AddNewUser()
        {
            User u = User.InputUser();

            u.Id = users.GetSizeUsers();

            users.AddUser(u);

            UIManager.Instance.PrintMessengerSuccess();

            User.ShowUser(u);

            BackToMain();
        }

        public void ChangeInfo()
        {
            string id;
            do
            {
                UIManager.Instance.PrintMessenger("Id : ");
                id = Console.ReadLine();
            }
            while (!users.UpdateUser(id));
            BackToMain();
        }

        public void RemoveUser()
        {
            UIManager.Instance.PrintMessenger("Id : ");
            string id = Console.ReadLine();
            users.removeUser(id);
            BackToMain();
        }

        public void ShowAllUser()
        {
            users.GetAllUser();
            BackToMain();
        }

        public void SortUser()
        {
            users.SortUser();
            BackToMain();
        }

    }
}
