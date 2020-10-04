using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
   public static class VersionAndDigits
    {
        public static void CommandExecute_GetComputerVersion()
        {
            Ex04.Menus.Test.UI.DisplayFunctionsResoultsAndUserInstruction.DisplayCommandOutput
            (string.Format("Version is:{0}==================={0}{1}", Environment.NewLine, Environment.Version.ToString()));
        }

        public static void CommandExecute_GetNumberOfUpperCase()
        {
            int numberOfUpperCase = 0;
            string userString = Ex04.Menus.Test.UI.DisplayFunctionsResoultsAndUserInstruction.GetStringFromUser();
            foreach (char ch in userString)
            {
                if(ch >= 'A' && ch <= 'Z')
                {
                    numberOfUpperCase++;
                }
            }

            Ex04.Menus.Test.UI.DisplayFunctionsResoultsAndUserInstruction.DisplayCommandOutput(
            string.Format("Amount Of UpperCase for user string- {0} is:{1}", userString, numberOfUpperCase.ToString()));
        }
    }
}
