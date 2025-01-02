namespace OOP01
{
    internal class Program
    {
        #region Q01
        //enum WeekDays
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday,
        //} 
        #endregion
        #region Q02

        //enum Season
        //{
        //    Spring=10, Summer, Autumn, Winter
        //}


        #endregion
        #region Q03
        //[Flags]
        //enum permissions:byte
        //{
        //    Read=1, write=2, Delete=4, Execute=8
        //}
        //class Employee
        //{
        //    public string Name;
        //    public int Age;
        //    public decimal Salary;
        //    public permissions permissions;
        //}
        #endregion
        #region Q04

        enum Colors
        {
            Red =10, Green, Blue
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q01


            //for(int i =0; i<7; i++)
            //{
            //    WeekDays days = (WeekDays)i;
            //    Console.WriteLine(days);
            //}
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region Q02


            //Console.WriteLine("Enter A Month ");


            //Enum.TryParse<Season>(Console.ReadLine(), true, out Season result);


            //switch (result)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("spring march to may");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("summer june to august");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("winter December to February");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("autumn September to November");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid");
            //        break;
            //}




            #endregion

            #region Q03

            //Employee employee = new Employee();
            //employee.Name = "Ali";
            //employee.permissions = (permissions)3;
            //Console.WriteLine(employee.permissions); // Read, write

            //employee.permissions = employee.permissions ^ permissions.Delete;
            //Console.WriteLine(employee.permissions); // Read, write ,Delete

            //employee.permissions = employee.permissions ^ permissions.Delete;
            //Console.WriteLine(employee.permissions); // Read, write 

            //employee.permissions = employee.permissions | permissions.Execute;
            //Console.WriteLine(employee.permissions); // Read, write, Execute

            //if((employee.permissions & permissions.Execute) == permissions.Execute)
            //{
            //    Console.WriteLine("Already exists");
            //}
            //else
            //{
            //    employee.permissions = employee.permissions ^ permissions.Execute;
            //}


            #endregion

            #region Q04

            Console.WriteLine("Enter A Colors ");


            Enum.TryParse<Colors>(Console.ReadLine(), true, out Colors result);
            

            switch (result)
            {
                case Colors.Green:
                case Colors.Blue:
                case Colors.Red:
                    Console.WriteLine($"{result} is a Primary Color");
                    break;
                default:
                    Console.WriteLine("Color is Not Primary Color");
                    break;
            }

            #endregion
        }
    }
}
