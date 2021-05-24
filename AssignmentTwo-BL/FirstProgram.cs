using System;

namespace AssignmentTwo_BL
{
    public class FirstProgram
    {
        public static void PrintDateFormat()
        {
            //console will display the valid date formats
            Console.WriteLine("the Valid Date Formats are either yyyy/mm/dd or dd-mm-yyy");
        }

        public static void CalculateDays()
        {
            try
            {
                //function checking to get valid From date
                Console.Write("Enter From Date: ");
                DateTime fromDate = FromDateValid();
                //function checking to get valid To date
                Console.Write("Enter To Date: ");
                DateTime toDate = ToDateValid(fromDate);
                //function calculating days between To date and From date
                CalculateDaysBetweenDates(fromDate, toDate);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid Date Format , Please enter a valid date format");
            }

        }

        public static DateTime FromDateValid()
        {
            //ask user to enter from date
            string strOne = Console.ReadLine();
            DateTime fromDate = DateTime.Parse(strOne);


            //Check the FROM date should be less than today's date
            if (fromDate < DateTime.Today)
            {
                Console.WriteLine("FROM date is valid");
                return fromDate;
            }
            else
            {
                Console.WriteLine("please enter a FROM date less than today's date");
                //ask user to enter from date again
                Console.WriteLine("Enter again From date");
                return FromDateValid();
            }
        }
        public static DateTime ToDateValid(DateTime fromDate)
        {
            //ask user to enter the TO date
            string strTwo = Console.ReadLine();
            DateTime toDate = DateTime.Parse(strTwo);


            //Check the TO date should be greater than FROM date
            if (toDate >= fromDate)
            {
                Console.WriteLine("TO date is valid");
                return toDate;
            }
            else
            {
                Console.WriteLine("Please enter a valid TO date to calculate");
                //ask user to enter to date again
                Console.WriteLine("enter again To date");
                return ToDateValid(fromDate);
            }
        }
        public static void CalculateDaysBetweenDates(DateTime fromDate, DateTime toDate)
        {

            //calculate days between from date and to date
            int days = (int)(toDate - fromDate).TotalDays;

            int month = days / 30;
            int year = days / 365;

            //checking if days we get is less than 30 then giving the answer in days
            if (days < 30)
            {
                Console.WriteLine("no of days between TO date and FROM date is : {0}", days);
            }
            //checking if days we get is greater than 30 and less than 365 then giving the answer in Months,Days
            else if (days >= 30 && days <= 365)
            {
                Console.WriteLine("no of days between TO date and FROM date is : {0}", days);
                Console.WriteLine("there are {0} month and {1} days between TO date and FROM date ", month, days % 30);
            }
            //checking if days we get is greater than 365 and less than 30 then giving the answer in years,month,days
            else
            {
                Console.WriteLine("no of days between TO date and FROM date is : {0}", days);
                Console.WriteLine("there are {0} year and {1} month and {2} days between TO date and FROM date ", year, (days % 365) / 30, (days % 365) % 30);

            }


        }

    }

}
