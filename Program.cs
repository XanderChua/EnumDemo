using System;


namespace EnumDemo
{
    class Program
    {
        /*enum floordesignation
        {
            B1,
            L1,
            L2
        }*/
        enum CalanderMonths
        {
            InvalidMonth = 0, 
            Jan = 1,
            Feb = 2,
            Mar = 3,
            Apr = 4,
            May = 5,
            Jun = 6,
            Jul = 7,
            Aug = 8,
            Sep = 9,
            Oct = 10,
            Nov = 11,
            Dec = 12
        }

        [Flags]
        enum myEnum
        {
            flaga = 1,
            flagb = 2,
            flagc = 4,
            flagd = 8
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter your month number:");
            int mth = Int32.Parse(Console.ReadLine());
            CalanderMonths month = (CalanderMonths)mth;
            Console.WriteLine("Your month is: " + month);

            Console.WriteLine("Enter your month name:");
            string monthstring = Console.ReadLine();
            if (Enum.TryParse<CalanderMonths>(monthstring, out var monthstring1))// Convert back to int
            {
                Console.WriteLine("Your month is: " + (int)monthstring1);
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }*/

            var multipleFlag = myEnum.flaga | myEnum.flagb; //loop over all enum and print one by one
            Console.WriteLine(multipleFlag);
            

            
            //floordesignation floor = floordesignation.B1;
            //Console.WriteLine("Floor: " + floor);
        }
    }
}
