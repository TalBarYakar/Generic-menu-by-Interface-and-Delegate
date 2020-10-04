using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
      internal class AmountOfUpperCaseByInterface : Interfaces.InstructionComponent
      {
        public AmountOfUpperCaseByInterface() : base("Count Captials")
        {
        }

        public override void ExecuteInstractionByInterface(ref bool io_ContinueProgram)
        {
            int numberOfUpperCase = 0;
            string userInputedString = UI.DisplayFunctionsResoultsAndUserInstruction.GetStringFromUser();
            foreach (char ch in userInputedString)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    numberOfUpperCase++;
                }
            }

            UI.DisplayFunctionsResoultsAndUserInstruction.DisplayCommandOutput(
            string.Format("Amount Of UpperCase for user string- {0} is:{1}", userInputedString, numberOfUpperCase.ToString()));
            io_ContinueProgram = false;
            System.Threading.Thread.Sleep(4000);
        }
    }
}
