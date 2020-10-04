using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class Program
    { 
        public static void Main()
        {
        runProgram();
            Console.ReadLine();
        }

        public static void RunProgramForDelegate()
        {
             bool runingProgram = true;
            Menu mainMenu = MenuBuilder.SetMenuForCurrentTestInCaseOfDelegate();
            mainMenu.ExecuteCurrentInstruction(ref runingProgram);
        }

        public static void RunProgramForInterface()
        {
            Interfaces.InstructionComponent mainMenu = MenuBuilder.SetMenuForInterface();
            bool startProgram = true;
            mainMenu.ExecuteInstractionByInterface(ref startProgram);
        }

        internal static void runProgram()
        {
            int userChoice;
            while(true)
            {
                Console.WriteLine(@"Test Menu:
==================================
0-For Exit
1- for Checking the delegate menu
2- For checko the interface menu");
                try
                {
                    if (int.TryParse(Console.ReadLine(), out userChoice))
                    {
                        switch (userChoice)
                        {
                            case 0:
                                return;
                            case 1:
                                RunProgramForDelegate();
                                break;
                            case 2:
                                RunProgramForInterface();
                                break;
                            default:
                                Console.WriteLine("Error-you must choose intiger between 0-2");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error-please type an intiger");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
       
    }
}
