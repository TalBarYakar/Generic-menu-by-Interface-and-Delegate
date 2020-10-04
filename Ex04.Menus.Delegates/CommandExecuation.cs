using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// /The class in responsible of execute the command, the command will be executed via suitible delegate 
/// </summary>
namespace Ex04.Menus.Delegates
{
    public delegate void CommandExecuationNotidier();

   public class CommandExecuation : ComponentForInstruction
    {
    public event CommandExecuationNotidier ExecuteCommad;

     public CommandExecuation(string i_InstructionHeadLine) : base(i_InstructionHeadLine)
        {
        }

    internal void OnExecuteCommand()
        {
            if(ExecuteCommad != null)
            {
                ExecuteCommad.Invoke();
            }
            else
            {
                throw new Exception("there is no command to execute ");
            }
        }

        public override void ExecuteCurrentInstruction(ref bool i_IsUserWantToGoBackOrFinishProgram)
        {
            Console.Clear();
            OnExecuteCommand();
            i_IsUserWantToGoBackOrFinishProgram = false;
            System.Threading.Thread.Sleep(4000);
        }

        public override string ToString()
        {
            return base.InstructionHeadLine;
        }
    }
}
