using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Student
{
    class StudentUnivercity : StudentCollege
    {
        protected int score4;

        public StudentUnivercity(int id, string name, int score1, int score2, int score3 , int score4) : base(id, name,score1 , score2 , score3)
        {
            this.score4 = score4;
        }

        public override double Average()
        {
            return (score1 + score2 + score3 + score4) / 4;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Score 4: {0:N}", score4);
        }
    }
}
