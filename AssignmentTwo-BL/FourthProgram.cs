using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo_BL
{
   public class FourthProgram
    {
        public static void BufferData()
        {
            //ask user to enter the size of buffer
            Console.WriteLine("Enter the size user want to give");

            //taking size as input
            int size = Convert.ToInt32(Console.ReadLine());

            //Creating the buffer for storing the Data
            Queue<string> boxType = new Queue<string>(size);

            //checking the box count it will be zero as no data is added to buffer
            Console.WriteLine("the box count is {0}", boxType.Count);


            //checking if box count is less than size
            if (boxType.Count < size)
            {
                //applying loop till the box count becomes equal to size of buffer
                while (boxType.Count != size)
                {
                    //if while condition is true you can enter more data
                    Console.WriteLine("You can enter more Data");

                    //entering more data untill box count becomes equal to size
                    boxType.Enqueue(Console.ReadLine());

                }


                //checking again if box count becomes equal to size
                if (boxType.Count == size)
                {

                    //showing a warning message that buffer is now full
                    Console.WriteLine("Warning ! Buffer is full ");


                    //providing choices to overwrite the data in buffer or print the stored data in buffer
                    Console.WriteLine("Do you want to overwrite the oldest data press Y");
                    Console.WriteLine("Do you want to print the stored data in buffer press ?");
                    Console.WriteLine("Enter your choice");
                    char character = Convert.ToChar(Console.ReadLine());


                    //working on the choices that user want to select
                    switch (character)
                    {
                        case 'Y':
                            //if user want to overwrite he can enter the new data
                            Console.WriteLine("Enter the new data you want to enter");
                            boxType.Dequeue();
                            boxType.Enqueue(Console.ReadLine());

                            Console.Write("\n");

                            //printing the newest data after overwrite
                            foreach (string strThree in boxType)
                            {
                                Console.WriteLine(strThree);
                            }
                            break;
                        case '?':

                            //printing the stored data in the buffer before overwrite
                            foreach (string strTwo in boxType)
                            {
                                Console.WriteLine(strTwo);
                            }
                            break;
                    }

                }
            }





        }
    }
}
