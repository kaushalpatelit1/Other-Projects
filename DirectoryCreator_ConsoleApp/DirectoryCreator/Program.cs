using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path where you want to create the folder:");
            string path = @"D:\STUDY\LinkedIn Learnings\Docker\2 Docker First Project";

            string userInput;

            int i = 1;
            do
            {
                userInput = string.Empty;
                Console.WriteLine($"Enter Folder Name = ");
                userInput = Console.ReadLine();
                if(!string.IsNullOrEmpty(userInput) && userInput.ToLower() != "x")
                {
                    //inputList.Add(userInput);
                    string folderName = $"{i.ToString()} {userInput}";
                    CreateFolder(path, folderName);
                    i++;
                }
            }
            while(userInput.ToLower() != "x");

        }

        public static void CreateFolder(string path, string folderName)
        {
            string fullPath = Path.Combine(path, folderName);
            try
            {
                // Check if the directory already exists
                if(!Directory.Exists(fullPath))
                {
                    // Create the directory
                    Directory.CreateDirectory(fullPath);
                    Console.WriteLine($"Folder {folderName} created");
                }
                else
                {
                    Console.WriteLine($"Folder already exists.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
