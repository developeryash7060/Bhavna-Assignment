using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo_BL
{
    public class ThirdProgram
    {
        public static void IfEnteredPathIsValid()
        {
            //Enter the Directory Path
            Console.WriteLine("Enter the directory");

            // ask user to enter the directory path
            try
            {
                string path = Console.ReadLine();
                //Calling the function to get files and directories
                ListFilesInDirectory(path, "");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("User has entered Invalid Path");
            }

        }


        public static void ListFilesInDirectory(string path, string spaces)
        {

            //creating string array for getting all the files
            string[] filePaths = Directory.GetFiles(path);

            //creating string array for getting all the directories
            string[] dirs = Directory.GetDirectories(path);


            //foreach loop for getting the names of all directories
            foreach (string directory in dirs)
            {
                String dName = (new FileInfo(directory)).Name;
                Console.WriteLine(spaces + "--" + dName);
                Console.Write("\n");
                ListFilesInDirectory(directory, spaces + "  ");
            }


            //foreach loop for getting the name of all files
            foreach (string filePath in filePaths)
            {
                String fName = (new FileInfo(filePath)).Name;

                Console.WriteLine(spaces + "-" + fName);
                Console.Write("\n");

            }

        }
    }
}
