using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    abstract class Student
    {
        protected int studentID;
        protected string studentName;
        protected string course;
        protected double grade;

        abstract public bool IsPass(double grade);
        abstract public void Accept(string course);
        abstract public void Display();
    }

    class UnderGraduate : Student
    {
        public override bool IsPass(double grade)
        {
            if (grade > 70)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public override void Accept(string course)
        {
            this.course = course;
            Console.WriteLine("Enter student ID: ");
            this.studentID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student name: ");
            this.studentName = Console.ReadLine();
            Console.WriteLine("Enter Grades: ");
            this.grade = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");
        }
        public override void Display()
        {
            Console.WriteLine("---------------------------");
            bool result = IsPass(grade);
            Console.WriteLine("Student Name  : {0}", studentName);
            Console.WriteLine("Student ID    : {0}", studentID);
            Console.WriteLine("Student Course: {0}", course);
            Console.WriteLine("Marks (Grade) : {0}", grade);
            if (result)
            {
                Console.WriteLine("Result        : Pass");
            }
            else
            {
                Console.WriteLine("Result        : Fail");
            }
            Console.WriteLine("---------------------------");
        }
    }

    class Graduate : Student
    {
        public override bool IsPass(double grade)
        {
            if (grade > 80)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public override void Accept(string course)
        {
            this.course = course;
            Console.WriteLine("Enter student ID: ");
            this.studentID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student name: ");
            this.studentName = Console.ReadLine();
            Console.WriteLine("Enter Grades: ");
            this.grade = double.Parse(Console.ReadLine());
        }
        public override void Display()
        {
            bool result = IsPass(grade);
            Console.WriteLine("Student Name  : {0}",studentName);
            Console.WriteLine("Student ID    : {0}", studentID);
            Console.WriteLine("Student Course: {0}", course);
            Console.WriteLine("Marks (Grade) : {0}", grade);
            if (result)
            {
                Console.WriteLine("Result        : Pass");
            }
            else
            {
                Console.WriteLine("Result        : Fail");
            }

        }
    }
    class UggResult
    {
        public static void Main(String[] args)
        {
            Student st;
            string course;
            int ch;
            do
            {
                Console.WriteLine("Selct course \n1. Under Graduate \n2. Graduate \n3. Exit");
                ch = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------");
                switch (ch)
                {
                    case 1:
                        course = "Under Graduate";
                        st = new UnderGraduate();
                        st.Accept(course);
                        st.Display();
                        break;
                    case 2:
                        course = "Graduate";
                        st = new Graduate();
                        st.Accept(course);
                        st.Display();
                        break;
                    case 3:
                        Console.WriteLine("Good Bye...!");
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }

                st = new UnderGraduate();
            } while (ch != 3);
        }
    }
}
