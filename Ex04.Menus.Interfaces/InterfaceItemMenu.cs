using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// this Class is represnt the component in case it is -menu and not comand 
/// </summary>
namespace Ex04.Menus.Interfaces
{
    public class InterfaceItemMenu : InstructionComponent
    {
        private const int k_Exit = 0;
        private const int k_Back = 1;
        private static int s_QuitOrBackMessage = k_Exit;
        private readonly int r_QuiTOrBackForCurrentMenue;
        private readonly List<InstructionComponent> r_ListOfComponentForCurrentMenu; 

        public InterfaceItemMenu(string i_InstructionHeadLine) : base(i_InstructionHeadLine)
        {
            r_ListOfComponentForCurrentMenu = new List<InstructionComponent>();
            r_QuiTOrBackForCurrentMenue = s_QuitOrBackMessage; ////in order to set the MainMenu 0-option To Exit and Not go back
            s_QuitOrBackMessage = k_Back;
        }

        public List<InstructionComponent> ListOfComponentForCurrentMenu
        {
            get
            {
                return r_ListOfComponentForCurrentMenu;
            }
        }

        /// <summary>
        /// //// the interface ovveride instruction which in menu component print all of the menu options
        public override void ExecuteInstractionByInterface(ref bool io_ContinueProgram)
          {
            io_ContinueProgram = true;
            bool isUserWantToContinue = true;
            int? uesrChice = null;
            while (isUserWantToContinue)
            {
                Console.Clear();
                int index = 1;
                Console.WriteLine(string.Format("Menu{0}===============", Environment.NewLine));
                if (r_QuiTOrBackForCurrentMenue == k_Exit)
                {
                    Console.WriteLine("0-Exit");
                }
                else
                {
                    Console.WriteLine("0-Go back");
                }

                foreach (InstructionComponent currentItemAtMenu in r_ListOfComponentForCurrentMenu)
                {
                    Console.WriteLine(string.Format("{0}-{1}", index, currentItemAtMenu.ToString()));
                    index++;
                }

                if (GetUserChoice(ref uesrChice))
                {
                    r_ListOfComponentForCurrentMenu[(int)uesrChice - 1].ExecuteInstractionByInterface(ref io_ContinueProgram);
                    if (r_QuiTOrBackForCurrentMenue != k_Exit)
                    {
                        isUserWantToContinue = io_ContinueProgram;
                    }
                }
                else
                {
                    isUserWantToContinue = false;
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
                        if (userChoice < 0 || userChoice > r_ListOfComponentForCurrentMenu.Count)
                        {
                            Console.WriteLine("please type number between ({0} - {1}) !", 0, r_ListOfComponentForCurrentMenu.Count);
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
                        Console.WriteLine("Error-Please ytpe an intiger");
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
    }
}
