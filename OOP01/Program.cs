using System;

namespace OOP01
{
    internal class Program
    {
        #region video01
        public static void DoSomeProtectiveCode()
        {
            int x, y, z;
            bool flag;
            do
            {
                Console.WriteLine("Enter First Number");
                flag = int.TryParse(Console.ReadLine(), out x);
            } while (!flag);
            do
            {
                Console.WriteLine("Enter Second Number");
                flag = int.TryParse(Console.ReadLine(), out y);
            } while (!flag || y == 0);
            z = x / y;
            int[] numbers = null;
            if (numbers?.Length > 10)
            {
                numbers[10] = 100;
            }
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
            try
            {
                DoSomeProtectiveCode();
                throw new Exception("Yo have Exception");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // close - free - delet - Dealocte Unmanged Recouvces
                // open file
                // open connection database
                Console.WriteLine("finaly");
            }
            Console.WriteLine("After Try Catch");

            #endregion
            #endregion
        }
    }
}
