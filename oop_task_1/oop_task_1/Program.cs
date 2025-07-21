using static oop_task_1.Program;

namespace oop_task_1
{
    internal class Program
    {
        #region 1.1

        //1-	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
        private enum WeekDays : byte
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        #endregion 1.1

        #region 1.2

        //2.	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
        public struct Person
        {
            public string Name;
            public int Age;

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}";
            }
        }

        #endregion 1.2

        #region 1.3

        //3.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        public void DisplaySeason(Season season)
        {
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("March to May");
                    break;

                case Season.Summer:
                    Console.WriteLine("June to August");
                    break;

                case Season.Autumn:
                    Console.WriteLine("September to November");
                    break;

                case Season.Winter:
                    Console.WriteLine("December to February");
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }

        #endregion 1.3

        #region 1.4

        //    4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
        [Flags]
        private enum Permissions : byte
        {
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }

        #endregion 1.4

        #region 1.5

        //5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not
        public enum Colors
        {
            Red,
            Green,
            Blue
        }

        #endregion 1.5

        #region 1.6

        //6.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
        public struct Point
        {
            public float X;
            public float Y;

            public Point(float x, float y)
            {
                X = x;
                Y = y;
            }

            public double DistanceTo(Point p2)
            {
                return Math.Sqrt(Math.Pow(p2.X - X, 2) + Math.Pow(p2.Y - Y, 2));
            }
        }

        #endregion 1.6

        #region 1.7

        //7.	Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
        // the struct is already defined in 1.2, so we can reuse it.
        public void oldest(Person[] persons)
        {
            Person oldest = persons[0];
            foreach (var person in persons)
            {
                if (person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }
            Console.WriteLine($"The oldest person is {oldest.Name} with age {oldest.Age}.");
        }

        #endregion 1.7

        #region 2

        //Design and implement a Class for the employees in a company:
        public class Employee
        {
            #region 2.1

            public int ID { get; set; }
            public string Name { get; set; }

            #endregion 2.1

            public SecurityLevel SecurityLevel { get; set; }

            private decimal salary;

            public decimal Salary
            {
                get { return salary; }
                set
                {
                    if (value > 0)
                    {
                        salary = value;
                    }
                    else
                    {

                        bool flag = false;
                        do
                        {
                            Console.WriteLine("the salary of the employee must be greater than 0:");
                            if (decimal.TryParse(Console.ReadLine(), out decimal inputSalary) && inputSalary > 0)
                            {
                                salary = inputSalary;
                                flag = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid salary. Please enter a valid number greater than 0.");
                            }
                        } while (!flag);
                    }
                }
            }

            public HireDate HireDate { get; set; }
            public gender Gender { get; set; }

            public Employee(int id, string name, SecurityLevel security, decimal salary, HireDate date, gender gender)
            {
                ID = id;
                Name = name;
                SecurityLevel = security;
                Salary = salary;
                HireDate = date;
                Gender = gender;
            }
            #region 2.5
            //5.	We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [ use String.Format Function]

            
            public override string ToString()
            {
                return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security: {SecurityLevel}, Salary: {string.Format("{0:C}", Salary)}, Hire Date: {HireDate}";
            }
            #endregion 2.5
        }

        #region 2.2

        //2.	Develop a Class to represent the Hiring Date Data:consisting of fields to hold the day, month and Years.
        public class HireDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public HireDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public override string ToString()
            {
                return $"{Day:D2}/{Month:D2}/{Year}";
            }
        }

        #endregion 2.2

        #region 2.3

        //3.	We need to restrict the Gender field to be only M or F [Male or Female]
        public enum gender
        { m, f }

        #endregion 2.3

        #region 2.4

        //4.	Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
        public enum SecurityLevel
        {
            Guest,
            Developer,
            Secretary,
            DBA,
            SecurityOfficer //full permissions level
        }

        #endregion 2.4

        #endregion 2

        private static void Main(string[] args)
        {
            Program program = new Program();

            #region 1.1main

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine((WeekDays)i);
            }

            #endregion 1.1main

            #region 1.2Main

            Person[] persons = new Person[3];
            persons[0] = new Person("adham", 20);
            persons[1] = new Person("alaa", 50);
            persons[2] = new Person("fouad", 70);

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

            #endregion 1.2Main

            #region 1.3Main

            Console.WriteLine("Enter a season:");
            Season a = Console.ReadLine() switch
            {
                "Spring" or "spring" => Season.Spring,
                "Summer" or "summer" => Season.Summer,
                "Autumn" or "autumn" => Season.Autumn,
                "Winter" or "winter" => Season.Winter,
                _ => throw new ArgumentException("Invalid season name")
            };

            program.DisplaySeason(a);

            #endregion 1.3Main

            #region 1.4Main

            Permissions add_remove = Permissions.Delete | Permissions.Read;
            Console.WriteLine($"Current permissions: {add_remove}");
            add_remove |= Permissions.Write;
            Console.WriteLine($"After adding write permission: {add_remove}");
            add_remove &= ~Permissions.Read;
            Console.WriteLine($"Current permissions: {add_remove}");
            if ((add_remove & Permissions.Delete) == Permissions.Delete)
            {
                Console.WriteLine("Delete permission exists.");
            }
            else
            {
                Console.WriteLine("Delete permission does not exist.");
            }

            #endregion 1.4Main

            #region 1.5Main

            Console.WriteLine("Enter a color :");
            string c = Console.ReadLine();
            if (Enum.TryParse(typeof(Colors), c, true, out var color))
            {
                if (color is Colors.Red or Colors.Green or Colors.Blue)
                {
                    Console.WriteLine($"{c} is a primary color.");
                }
                else
                {
                    Console.WriteLine($"{c} is not a primary color.");
                }
            }

            #endregion 1.5Main

            #region 1.6Main

            Console.WriteLine("Enter the first point (x y):");
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            Point p1 = new Point(x1, y1);
            Console.WriteLine("Enter the second point (x y):");
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            Point p2 = new Point(x2, y2);
            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"Distance between points: {distance}");

            #endregion 1.6Main

            #region 1.7Main

            program.oldest(persons);

            #endregion 1.7Main
            #region 2.6Main
            //6.	Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            Employee[] EmpArr = new Employee[3];
            EmpArr[0]=new Employee(1,"adham",SecurityLevel.DBA,-1,new HireDate(17,2,2025),gender.m);
            EmpArr[1] = new Employee(2, "alaa", SecurityLevel.Guest, 48800, new HireDate(25, 11, 2020), gender.m);
            EmpArr[2] = new Employee(3, "ashraf", SecurityLevel.SecurityOfficer, 47500, new HireDate(4, 6, 2023), gender.m);

            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }
            #endregion 2.6Main
        }
    }
}