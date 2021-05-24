using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AssignmentTwo_BL
{
    public class FifthProgram
    {
        //ask for conversion rate for five currencies
        public static double conversionRateOne;
        public static double conversionRateTwo;
        public static double conversionRateThree;
        public static double conversionRateFour;
        public static double conversionRateFive;
        public static void CurrencyShow()
        {
            //showing 5 foreign currencies to user.
            Console.WriteLine("Console is Showing 5 Foreign Currencies");
            Console.WriteLine("1: US dollars");
            Console.WriteLine("2: EURO");
            Console.WriteLine("3: Japanese Yen");
            Console.WriteLine("4: British Pound");
            Console.WriteLine("5: Swiss Franc");

            Console.Write("\n");

            //user have choice either to continue with exisiting conversion rate or wants to create a new conversion rate
            Console.WriteLine("Do you want to continue with the existing conversion rate or to create a new conversion rate list");
            Console.Write("\n");
            Console.WriteLine("Press Y for continue");
            Console.Write("\n");
            Console.WriteLine("Press N for create a new conversion rate list");
            //taking choice is character input
            char choice = Convert.ToChar(Console.ReadLine());

            //declaring five conversion rate for five foreign currencies


            if (choice == 'Y')
            {
                ExistingRate();
            }
            else if (choice == 'N')
            {
                NewConversionRate();
            }
        }
        public static void ExistingRate()
        {

            Console.WriteLine("Conversion Rate for US Dollars is 76.06");
            conversionRateOne = 76.06;

            Console.WriteLine("Conversion Rate for EURO is 81.41");
            conversionRateTwo = 81.41;

            Console.WriteLine("Conversion Rate for Japanese Yen is 16.67");
            conversionRateThree = 16.67;

            Console.WriteLine("Conversion Rate for British Pound is 103.41");
            conversionRateFour = 103.41;

            Console.WriteLine("Conversion Rate for Swiss Franc is 65.18");
            conversionRateFive = 65.18;
            FetchData();
            Console.Write("\n");


            //symbols for each of the five currency
            Console.WriteLine("Conversion Symbol for US Dollars is USD");
            Console.WriteLine("Conversion Symbol for European Dollars is EURO");
            Console.WriteLine("Conversion Symbol for Japanese yen is JPY");
            Console.WriteLine("Conversion Symbol for British Pound is BPO");
            Console.WriteLine("Conversion Symbol for Swiss Franc is SWF");
            Console.Write("\n");

            //ask user to enter the conversion symbol
            Console.WriteLine("Enter the Conversion Symbol");
            string symbol = Console.ReadLine();


            //passing symbol inside switch so that user can select which foreign currency he wants to convert
            switch (symbol)
            {
                case "USD":
                    Console.WriteLine("Enter US Dollar to convert");
                    int usd = Convert.ToInt32(Console.ReadLine());
                    double indianRupeesOne = usd * conversionRateOne;
                    Console.WriteLine("The conversion of US Dollars to Indian Rupee: {0:0.00}", indianRupeesOne);
                    break;
                case "EURO":
                    Console.WriteLine("Enter EURO to convert");
                    int euro = Convert.ToInt32(Console.ReadLine());
                    double indianRupeesTwo = euro * conversionRateTwo;

                    Console.WriteLine("The conversion of Euro to Indian Rupee: {0:0.00}", indianRupeesTwo);
                    break;
                case "JPY":
                    Console.WriteLine("Enter Japenese Yen to convert");
                    int jpy = Convert.ToInt32(Console.ReadLine());
                    double indianRupeesThree = jpy * conversionRateThree;
                    Console.WriteLine("The conversion of japanese currency to Indian Rupee: {0:0.00}", indianRupeesThree);
                    break;
                case "BPO":
                    Console.WriteLine("Enter British Pound to convert");
                    int bpo = Convert.ToInt32(Console.ReadLine());
                    double indianRupeesFour = bpo * conversionRateFour;
                    Console.WriteLine("The conversion of british pound to Indian Rupee: {0:0.00}", indianRupeesFour);
                    break;
                case "SWF":
                    Console.WriteLine("Enter Swiss Franc to convert");
                    int swf = Convert.ToInt32(Console.ReadLine());
                    double indianRupeesFive = swf * conversionRateFive;
                    Console.WriteLine("The conversion of swiss franc to Indian Rupee: {0:0.00}", indianRupeesFive);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;


            }

        }
        public static void NewConversionRate()
        {
            Console.WriteLine("Create a new Rate List");

            Console.WriteLine("Conversion Rate for US Dollars");
            conversionRateOne = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Conversion Rate for EURO");
            conversionRateTwo = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Conversion Rate for Japanese Yen");
            conversionRateThree = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Conversion Rate for British Pound");
            conversionRateFour = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Conversion Rate for Swiss Franc");
            conversionRateFive = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("New Conversion list Created");

            Console.Write("\n");

            Console.WriteLine("Conversion Symbol for US Dollars is USD");
            Console.WriteLine("Conversion Symbol for European Dollars is EURO");
            Console.WriteLine("Conversion Symbol for Japanese yen is JPY");
            Console.WriteLine("Conversion Symbol for British Pound is BPO");
            Console.WriteLine("Conversion Symbol for Swiss Franc is SWF");
            Console.Write("\n");

            //user ask for the conversion symbol
            Console.WriteLine("Enter the Conversion Symbol");
            string symbolTwo = Console.ReadLine();

            switch (symbolTwo)
            {
                case "USD":
                    Console.WriteLine("Enter US Dollar to convert");
                    int usd = Convert.ToInt32(Console.ReadLine());
                    double indianRupeesFirst = usd * conversionRateOne;
                    Console.WriteLine("The conversion of US Dollars to Indian Rupee: {0:0.00}", indianRupeesFirst);
                    break;
                case "EURO":
                    Console.WriteLine("Enter EURO to convert");
                    int euro = Convert.ToInt32(Console.ReadLine());
                    double indianRupeesSecond = euro * conversionRateTwo;
                    Console.WriteLine("The conversion of Euro to Indian Rupee: {0:0.00}", indianRupeesSecond);
                    break;
                case "JPY":
                    Console.WriteLine("Enter Japenese Yen to convert");
                    int jpy = Convert.ToInt32(Console.ReadLine());
                    double indianRupeesThird = jpy * conversionRateThree;
                    Console.WriteLine("The conversion of  japenese to Indian Rupee: {0:0.00}", indianRupeesThird);
                    break;
                case "BPO":
                    Console.WriteLine("Enter British Pound to convert");
                    int bpo = Convert.ToInt32(Console.ReadLine());
                    double indianRupeesFourth = bpo * conversionRateFour;
                    Console.WriteLine("The conversion of british pound to Indian Rupee: {0:0.00}", indianRupeesFourth);
                    break;
                case "SWF":
                    Console.WriteLine("Enter Swiss Franc to convert");
                    int swf = Convert.ToInt32(Console.ReadLine());
                    double indianRupeesFifth = swf * conversionRateFive;
                    Console.WriteLine("The conversion of swiss franc to Indian Rupee: {0:0.00}", indianRupeesFifth);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }
        }
        public static void FetchData()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("Select conversionRate from conversionRate", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                while (sdr.Read())
                {
                    Console.WriteLine((sdr["conversionRate"])); // Displaying Record  
                }
                Console.WriteLine("data is fetching");
            }
            catch (Exception)
            {
                Console.WriteLine("OOPs, something went wrong.\n");
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
