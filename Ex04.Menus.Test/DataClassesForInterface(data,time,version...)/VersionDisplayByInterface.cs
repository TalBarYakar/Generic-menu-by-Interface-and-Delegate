using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
    internal class VersionDisplayByInterface : Interfaces.InstructionComponent
    {
        public VersionDisplayByInterface() : base("Show version")
        {
        }

        public override void ExecuteInstractionByInterface(ref bool io_ContinueProgram)
        {
            UI.DisplayFunctionsResoultsAndUserInstruction.DisplayCommandOutput(string.Format("Version is:{0}==========={0}{1}", Environment.NewLine, Environment.Version.ToString()));
            io_ContinueProgram = false;
            System.Threading.Thread.Sleep(4000);
        }
    }
}
