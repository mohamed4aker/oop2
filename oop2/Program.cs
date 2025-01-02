using System;

namespace oop2
{
    internal class Program
    { struct person
        {
            public string name;
            public int age;
        }
        struct point
        {
            public double x; public double y;
            public point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public double Distance(point p)
            {
                return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
            }
            struct person
            {
                public string name;
                public int age;
            }
        }
        static void Main(string[] args)
        {
            //1

            //person[] persons = new person[3];
            //persons[0] = new person { name = "ahmed", age = 30 };
            //persons[1] = new person { name = "mohamed ", age = 31 };
            //persons[2] = new person { name = "mariam", age = 32 };
            //foreach (var person in persons)
            //{
            //    Console.WriteLine($"name :{person.name} age :{person.age}");
            //}
            //2
            //Console.WriteLine("enter point 1");
            //var p1 = new point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            //Console.WriteLine("enter point 2");
            //var p2 = new point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            //Console.WriteLine($"the distannce between the two points is {p1.Distance(p2)}");
            //3
           // person[]Person = new person[3];
           // for (int i = 0; i < 3; i++) {


           //     string name;
           //     do {

           //         Console.WriteLine($"Enter Name of pesron {i + 1}");
           //         name = Console.ReadLine();
           //     } while (string.IsNullOrEmpty(name));
           //     Person[i].name = name;
           //     int age;
           //     bool flag;
           //     do
           //     {
           //         Console.WriteLine($"Enter Age of pesron {i + 1}");
           //         flag = int.TryParse(Console.ReadLine(), out age);
           //     } while (!flag);
           //     Person[i].age = age;
           // }
           // person oldest = Person[0];
           // for (int j = 0; j < 3; j++)

           //     if (oldest.age < Person[j].age)
           //     {
           //         oldest = Person[j];
           //     }
           //Console.WriteLine(oldest.age);

        }

    }
}
