using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void MenuInstrctionsNotifier();

    public class Menu : ComponentForInstruction
    {
        private const int k_ExitMessage = 0;
        private const int k_QuitMessage = 1;
        private static int s_MenuSituation = k_ExitMessage;
         private int WhichMessageToPrint = k_ExitMessage;
       internal List<ComponentForInstruction> m_ListOfComponnontForMenue;
      
       public Menu(string i_HeadLine) : base(i_HeadLine)
        {
            m_ListOfComponnontForMenue = new List<ComponentForInstruction>();
            WhichMessageToPrint = s_MenuSituation;
            if (s_MenuSituation == k_ExitMessage)
            {
                m_ListOfComponnontForMenue.Add(new CommandExecuation("0-for Exit?"));
                s_MenuSituation = k_QuitMessage;
            }
            else
            {
                m_ListOfComponnontForMenue.Add(new CommandExecuation("0-for go back?"));
            }
        }

        public override void ExecuteCurrentInstruction(ref bool io_IsUserWantToGoBackOrFinishProgram)//// the main methood which has the reponsibility of printing the menu and execute the commands
        {           
            bool isUserWillingToGoBack = true;
            while (isUserWillingToGoBack)
            {
                Console.Clear();
                int? userChoice = null;
                if (m_ListOfComponnontForMenue.Count == 0)
                {
                    throw new Exception("There are no messages of commands");
                }

                int index = 0;
                Console.WriteLine(string.Format("Menu:{0}==================", Environment.NewLine));
                foreach (var currentInstruction in m_ListOfComponnontForMenue)
                {
                    {
                        Console.WriteLine(string.Format("{0} - {1} ", index++, currentInstruction.ToString()));
                    }      
                }

                if (GetUserChoice(ref userChoice))
                {
                    m_ListOfComponnontForMenue[(int)userChoice].ExecuteCurrentInstruction(ref io_IsUserWantToGoBackOrFinishProgram);
                        if (WhichMessageToPrint != k_ExitMessage && !io_IsUserWantToGoBackOrFinishProgram)
                        {
                         isUserWillingToGoBack = io_IsUserWantToGoBackOrFinishProgram;
                        }
                        else
                        {
                        io_IsUserWantToGoBackOrFinishProgram = true;
                        isUserWillingToGoBack = true; 
                        }
                }
                 else
                 {
                    isUserWillingToGoBack = false;
                 }
            }
        }

        public bool GetUserChoice(ref int? o_UserChoice)
        {
            bool isValidInput = false, WantToContinue = true;
            int userChoice;
            while (!isValidInput)
            {
                try
                {
                    if (int.TryParse(Console.ReadLine(), out userChoice))
                    {
                        if (userChoice < 0 || (userChoice > (m_ListOfComponnontForMenue.Count - 1)))
                        {
                            Console.WriteLine("please type number between ({0} - {1}) !", 0, m_ListOfComponnontForMenue.Count - 1);
                        }
                        else
                        {
                            o_UserChoice = userChoice;
                            if (o_UserChoice == 0)
                            {
                                WantToContinue = false;
                            }

                            isValidInput = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input- you must choose an intiger");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    isValidInput = false;
                }
            }

            return WantToContinue;
        }
        
        public override string ToString()
        {            
        return base.InstructionHeadLine;
        }

        public void AddInstructionToMenu(ComponentForInstruction i_NewInstruction)
        {
            m_ListOfComponnontForMenue.Add(i_NewInstruction);
        }
    }
}
