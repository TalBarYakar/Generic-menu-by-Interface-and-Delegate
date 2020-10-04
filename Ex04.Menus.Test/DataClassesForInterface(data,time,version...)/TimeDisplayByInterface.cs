using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
    internal class TimeDisplayByInterface : Interfaces.InstructionComponent
    {
        public TimeDisplayByInterface() : base("Show Time")
        {
        }

         public override void ExecuteInstractionByInterface(ref bool io_ContinueProgram)
         {
            UI.DisplayFunctionsResoultsAndUserInstruction.DisplayCommandOutput
           (string.Format("The time is:{0}==================={0}{1}", Environment.NewLine, DateTime.Now.ToString("HH:mm")));
            io_ContinueProgram = false;
            System.Threading.Thread.Sleep(4000);
         }
    }
}
