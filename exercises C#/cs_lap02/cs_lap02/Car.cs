namespace cs_lap02
{

    public class Car
    {
        private string make;
        private string model;
        public string color;
        private int year;

        public Car(string m, string mo, string c, int y)
        {
            make = m;
            model = mo;
            color = c;
            year = y;
        }



        // public string Make => make; //get
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public int Year { get => year; }

        public string Make { get => make; }

        public void Start()
        {
            System.Console.WriteLine(model + " khoi dong");
        }


        public void Stop()
        {
            System.Console.WriteLine(model + " dung");
        }

        public override string ToString()
        {
            return "make : " + make + "\t" + "year : " + year;
        }

    }
}
