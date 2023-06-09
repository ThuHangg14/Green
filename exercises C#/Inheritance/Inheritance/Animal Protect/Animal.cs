namespace Inheritance.Animal_Protect
{
    public class Animal
    {
        protected string food;
        protected string activity;

        public virtual string Display()
        {
            return food;
        }
    }
}
