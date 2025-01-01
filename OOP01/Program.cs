using common;

namespace OOP01
{
    enum Gender
    {
        Male , Famele
    }
    enum Days
    {
        saturday,
        Sunday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    enum Grades
    {
        A,B,C,D,E,F
    }
    internal class Program
    {
        #region video01
        public static void DoSomeProtectiveCode()
        {
            //int x, y, z;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter First Number");
            //    flag = int.TryParse(Console.ReadLine(), out x);
            //} while (!flag);
            //do
            //{
            //    Console.WriteLine("Enter Second Number");
            //    flag = int.TryParse(Console.ReadLine(), out y);
            //} while (!flag || y == 0);
            //z = x / y;
            //int[] numbers = null;
            //if (numbers?.Length > 10)
            //{
            //    numbers[10] = 100;
            //}
        }
        #endregion
        static void Main(string[] args)
        {
            #region video01

            #region Exception Handling

            /*
             Exceptons
            1.System Exceptions
                
               1.1 FormatException
               1.2 IndexOutOfRangeException
               1.3 NullReferenceException
               1.4 InvalidOperationException
               1.5 ArithmeticException
                 A. DivideByZeroException
                 B. OverflowException
            -------------------------------

            2.Application Exceptions
            */
            #endregion
            #region ProtectiveCode
            //try
            //{
            //    DoSomeProtectiveCode();
            //    throw new Exception("Yo have Exception");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    // close - free - delet - Dealocte Unmanged Recouvces
            //    // open file
            //    // open connection database
            //    Console.WriteLine("finaly");
            //}
            //Console.WriteLine("After Try Catch");

            #endregion
            #endregion
            #region video02
            #region Acces Modifiers

            //1. private
            //2. private protected
            //3. protected
            //4. Internal 
            //5. protected internal
            //6. public

            #endregion

            #region Acces Modifiers

            //TypeA typeA = new TypeA();

            //TypeB  // invaled
            //typeA.x = 10;
            //typeA.y = 10;
            //typeA.z = 10;


            #endregion

            #endregion
            #region video03
            #region Enum
            #region Ex01
            //string Day = "ahmed";
            //Days day = Days.Friday;

            //Grades grade = Grades.B;
            //if (grade == Grades.A)
            //{
            //    Console.WriteLine(":)");
            //}
            //else
            //{
            //    Console.WriteLine(":(");
            //}
            #endregion
            #region Ex02
            //Grades grade = (Grades)2;
            //Console.WriteLine(grade);// c   // Excplicit Casting
            //Grades grade = (Grades)10;
            //Console.WriteLine(grade);// 10   //UnSafe

            #endregion
            #region Ex03
            //Grades grade = (Grades)Enum.Parse(typeof(Grades), Console.ReadLine());
            //Enum.TryParse(typeof(Grades), Console.ReadLine(), out object Result);
            //Grades grade = (Grades)Result;
            //Console.WriteLine(grade);
            #endregion

            #region Ex04
            //Gender gender = new Gender();
            //Console.WriteLine(gender);
            #endregion
            #endregion
            #endregion
        }
        class Employee
        {
            string Name;
            int Age;
            decimal Salary;
            Gender Gender; // Male - Female
        }
    }
}
