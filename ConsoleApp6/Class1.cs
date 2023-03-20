using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    abstract class Student
    {
        public int year;
        public string name;
        public Student(int year, string name)
        {
            this.year = year;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Year: {0}", year);
        }
        public abstract double Average();
    }
    class StudentCollage : Student
    {
        public int score1;
        public int score2;
        public int score3;
        public StudentCollage(int year, string name, int score1, int score2, int score3)
            : base(year, name)
        {
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }
        public override double Average()
        {
            return (score1 + score2 + score3) / 3;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Score1: {0}", score1);
            Console.WriteLine("Score2: {0}", score2);
            Console.WriteLine("Score3: {0}", score3);
        }
    }
    class StudentUniversity : StudentCollage
    {
        public int score4;
        public StudentUniversity(int year, string name, int score1, int score2, int score3, int score4)
            : base(year, name, score1, score2, score3)
        {
            this.score4 = score4;
        }
        public override double Average()
        {
            return (score1 + score2 + score3 + score4) / 4;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Score4: {0}", score4);
        }
    }
}
