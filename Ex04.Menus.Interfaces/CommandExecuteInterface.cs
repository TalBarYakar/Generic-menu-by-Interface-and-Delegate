using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// The interface for Execute the command
/// </summary>
namespace Ex04.Menus.Interfaces
{
     interface ICommandExecuteInterface
    {
        void ExecuteInstractionByInterface(ref bool io_ExecuteOccur);
    }
}
