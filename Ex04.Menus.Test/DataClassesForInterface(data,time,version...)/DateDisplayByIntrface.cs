using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
      public class DateDisplayByIntrface : Interfaces.InstructionComponent
      {
        public DateDisplayByIntrface() : base("Show Date")
        {
        }

        public override void ExecuteInstractionByInterface(ref bool io_ContinueProgram)
        {
            UI.DisplayFunctionsResoultsAndUserInstruction.DisplayCommandOutput(string.Format
            ("Today date is:{0}================={0}{1}", Environment.NewLine, DateTime.Today.ToString("D")));
            io_ContinueProgram = false; 
            System.Threading.Thread.Sleep(4000);
        }
    }
}
