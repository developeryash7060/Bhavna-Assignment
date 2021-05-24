using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo_BL
{
     public  class SecondProgram
    {
        public static void ConvertUpperCase()
        {
            try
            { 
            //ask the user to enter the string
            Console.WriteLine("Enter the sentence");
            string sentence = (Console.ReadLine()).ToLower();

            //split the string into string array
            string[] array = sentence.Split(" ");

            //taking a string array for the ignore words
            string[] word = { "and", "or", "but", "nor", "yet", "so", "for", "a", "an", "the", "in", "to", "of", "at", "by", "up", "for", "off", "on" };

           
            
                //Checking if the string is empty or not
                if (sentence.Length != 0)
                {
                    //taking an empty string
                    string temp = string.Empty;

                    //traversing through the whole array
                    foreach (string str in array)
                    {

                        //checking for the words we want to ignore
                        if (word.Contains(str))
                        {
                            //print as it is
                            temp = str;
                        }
                        else
                        {
                            //uppercasing the first character of the word
                            temp = char.ToUpper(str[0]) + "";
                            //if string is more than one character long then adding the remaining string
                            if (str.Length > 1)
                            {
                                temp += str.Substring(1);
                            }
                        }
                        //printing the output string
                        Console.Write(temp + " ");

                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured while capitalizing words: {e.Message}");
            }

        }
    }
}
