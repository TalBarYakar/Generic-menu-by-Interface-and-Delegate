using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class ComponentForInstruction
    {
        private string m_InstructionHeadLine;

       protected ComponentForInstruction(string i_m_InstructionHeadLine)
        {
            m_InstructionHeadLine = i_m_InstructionHeadLine;
        }

        public abstract void ExecuteCurrentInstruction(ref bool i_IsUserWantToGoBackOrFinishProgram);

        public string InstructionHeadLine
        {
            get
            {
                return m_InstructionHeadLine;
            }

            set
            {
                m_InstructionHeadLine = value;
            }
        }
    }
}
