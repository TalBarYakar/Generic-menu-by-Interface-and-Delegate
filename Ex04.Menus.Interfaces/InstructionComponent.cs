using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// /Base for two components (menu,the ExecuteCommand classes), he is obligating his accessors to override the interface "ExecuteInstractionByInterface" function
/// </summary>
namespace Ex04.Menus.Interfaces
{
    public abstract class InstructionComponent : ICommandExecuteInterface
    {
        private readonly string r_InstructionHeadLine;

        public InstructionComponent(string i_InstructionHeadLine)
        {
            r_InstructionHeadLine = i_InstructionHeadLine;
        }

        public abstract void ExecuteInstractionByInterface(ref bool io_ExecuteOccur);

        public override string ToString()
        {
            return r_InstructionHeadLine;
        }
    }
}
