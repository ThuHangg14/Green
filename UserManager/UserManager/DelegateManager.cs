namespace UserManager
{

    public class DelegateManager
    {

        private static DelegateManager _intance = null;

        public static DelegateManager intance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new DelegateManager();
                }
                return _intance;
            }
        }

        //public Action<UserPanel> AddNewUser;

        public void AddNewUser()
        {
            UserManager.Instance.AddNewUser();
        }

        public void ChangeInfo()
        {
            UserManager.Instance.ChangeInfo();

        }

        public void RemoveUser()
        {
            UserManager.Instance.RemoveUser();
        }
        public void DisplayInfoUser()
        {
            UserManager.Instance.ShowAllUser();
        }
        public void FilterUser()
        {
            UserManager.Instance.FilterUser();
        }
        public void SortUser()
        {
            UserManager.Instance.SortUser();
        }
    }
}
