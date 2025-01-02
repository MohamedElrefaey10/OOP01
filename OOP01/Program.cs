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
        enum Season
        {
            Spring=10, Summer, Autumn, Winter
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


            Console.WriteLine("Enter A Month ");


            Enum.TryParse<Season>(Console.ReadLine(), true, out Season result);


            switch (result)
            {
                case Season.Spring:
                    Console.WriteLine("spring march to may");
                    break;
                case Season.Summer:
                    Console.WriteLine("summer june to august");
                    break;
                case Season.Winter:
                    Console.WriteLine("winter December to February");
                    break;
                case Season.Autumn:
                    Console.WriteLine("autumn September to November");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }




            #endregion
        }
    }
}
