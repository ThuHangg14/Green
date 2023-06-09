namespace cs_lap02
{
    public class Contact
    {
        private int id;
        public string firstname;
        public string lastname;
        private string address;
        private string phone;
        private string email;

        public int Id { get; set; }

        public string Address { get => address; set => address = value; }

        public string Phone { get => phone; set => phone = value; }

        public string Email { get => email; set => email = value; }

        public Contact(int id, string firstname, string lastname, string address, string phone, string email)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.phone = phone;
            this.email = email;

        }

        public Contact() { }

        public override string ToString()
        {
            return "id : " + id + "\n"
                    + "address : " + address;

        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
