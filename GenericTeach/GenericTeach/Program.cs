using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericTeach
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestMyStack();
            Console.WriteLine("********************************");
            TestMyGenericConstraint();
            Console.ReadLine();
        }

        static void test()
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Good day!");
        }
        /*
        static T3 Add<T1, T2, T3>(T1 a, T2 b)
        {
            return a + b;
        }*/

        static void TestMyStack()
        {
            // create a MyStack instance with type int size 5
            MyStack<int> stack1 = new MyStack<int>(5);
           
            //push item into stack
            stack1.Push(1);
            stack1.Push(2);
            Console.WriteLine(stack1);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Push(5);
            Console.WriteLine(stack1);
            // pop item out from stack
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());

            MyStack<string> stack2 = new MyStack<string>(5);

            stack2.Push("Generic type");
            stack2.Push("C# programming");
            stack2.Push("ASP.net MVC");
            stack2.Push("reflection");
            stack2.Push("test compelete!");
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());

        }

        /// <summary>
        /// test generic constraint 
        /// </summary>
        static void TestMyGenericConstraint()
        {
            MyGenericClassConstraint<int, Course, Teacher> myGeneric = new MyGenericClassConstraint<int, Course, Teacher>();
            myGeneric.Publisher = new Teacher { Name = "Mr. Tom", CourseCount = 3 };
            myGeneric.ProductList = new List<Course> {
                new Course {
                    CourseName = "C# fundamentals",
                    PeriodLasts = 4 //4 months course
                },
                new Course
                {
                    CourseName = ".NET Full Stack",
                    PeriodLasts = 4 //4 months course
                },
                new Course
                {
                    CourseName = "ASP.NET Frontend",
                    PeriodLasts = 3 //3 months course
                }
            };

            var myCourse = myGeneric.BuyCourse(1);

            Console.WriteLine($"The course I bought is {myCourse.CourseName}, lasts about {myCourse.PeriodLasts} months, Teacher is {myGeneric.Publisher.Name}.");
        }
    }
}
