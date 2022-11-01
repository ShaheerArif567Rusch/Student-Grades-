using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AssignmentMenu
{
    public class Program
    {
        public static void Main(string[] args)
        {
                      
            MainMenu();
            
        }
        
        static void MainMenu()
        {

            Random rnd = new Random();
            
            int[] StudentGrades = new int[35];

            for (int i = 0; i < StudentGrades.Length; i++)
            {
                StudentGrades[i] = rnd.Next(1,101);             
            }
            bool stopProg = true;

            while (stopProg) 
            {
                    Console.Clear();
                    Console.WriteLine("MAIN MENU");
                    Console.WriteLine("---------");
                    Console.WriteLine("1. Display All Grades");
                    Console.WriteLine("2. Display Honours");
                    Console.WriteLine("3. Stats");
                    Console.WriteLine("4. Randomize Grades");
                    Console.WriteLine("5. Exit");

                    
                    string optionValue="";
                    
                    Console.WriteLine("");
                    Console.WriteLine("Select your option from 1, 2, 3, 4, or 5.");
                    optionValue= Console.ReadLine(); 
                    
                    switch (optionValue)
                    {
                        case "1":

                            Console.WriteLine("");
                            Console.WriteLine("Displaying ALL GRADES");
                            Console.WriteLine("---------------------");

                            foreach (var number in StudentGrades)
                            {
                                Console.WriteLine("" + number +"%");    
                            }
                            Console.WriteLine("");
                            
                            Console.WriteLine("Press Enter key to continue.");
                            Console.ReadLine(); 
                            break;

                        case "2":
                            
                            Console.WriteLine("");
                            Console.WriteLine("Display Honours!");
                            Console.WriteLine("----------------");
                            Console.WriteLine("Honours Greator than 80%");

                            int numOfHonours = 0;

                            foreach (var number in StudentGrades)
                            {
                                if (number > 80)
                                {
                                    Console.WriteLine(number +"%");
                                    numOfHonours ++;
                                }
                            }

                            Console.WriteLine("");
                            Console.WriteLine("Number of Honours: " + numOfHonours);
                            Console.WriteLine("");
                            Console.WriteLine("Press Enter key to continue.");
                            Console.ReadLine(); 
                            break;

                        case "3":
                            
                            int MaxVal = StudentGrades[0];
                            int MinVal = StudentGrades[0];
                            int AvgVal = 0;

                            foreach (var number in StudentGrades)
                            {
                                if (number > MaxVal)
                                {
                                    MaxVal = number;
                                }
                                if (number < MinVal)
                                {
                                    MinVal = number;
                                }
                                AvgVal = AvgVal + number;
                            }

                            Console.WriteLine("");
                            Console.WriteLine("STATS");
                            Console.WriteLine("-----");                            
                            Console.WriteLine("Highest Grade : " + MaxVal + "%");
                            Console.WriteLine("Lowest Grade  : " + MinVal + "%");
                            Console.WriteLine("Average Grade : " + AvgVal / StudentGrades.Length + "%" );
                            Console.WriteLine("");

                            Console.WriteLine("Press Enter key to continue.");
                            Console.ReadLine(); 
                            break;

                        case "4":

                            Console.WriteLine("");
                            Console.WriteLine("Assign new Randomize Grades");
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("Assigning new Randomize Grades.....");

                            for (int i = 0; i < StudentGrades.Length; i++)
                            {
                                StudentGrades[i] = rnd.Next(1,101);
                            
                            }

                            foreach (var number in StudentGrades)
                            {
                                Console.WriteLine("" + number +"%");    
                            }
                            
                            Console.WriteLine("");

                            Console.WriteLine("");
                            Console.WriteLine("Confirmation : GRADES HAVE BEEN RANDOMIZED.");
                            Console.WriteLine("");
                            Console.WriteLine("Press Enter key to continue.");
                            Console.ReadLine(); 

                            break;

                        case "5":

                            Console.WriteLine("");
                            Console.WriteLine("Exiting the program");
                            Console.WriteLine("Press Enter key to continue.");
                            Console.ReadLine(); 
                            stopProg = false;
                            break;

                        default:

                            Console.WriteLine("Not a valid input, try again with selecting you option from 1, 2, 3, 4, or 5.");
                            Console.WriteLine("Press Enter key to continue.");
                            Console.ReadLine();                         
                            break;
                        
                    }
            }

            Console.Clear();

        }       
    }
}

