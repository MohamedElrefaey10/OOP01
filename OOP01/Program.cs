namespace OOP01
{
    internal class Program
    {
        #region Q01
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        } 
        #endregion
        static void Main(string[] args)
        {
            #region Q01
            

            for(int i =0; i<7; i++)
            {
                WeekDays days = (WeekDays)i;
                Console.WriteLine(days);
            }
            #endregion
        }
    }
}
