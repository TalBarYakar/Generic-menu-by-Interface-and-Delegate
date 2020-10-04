using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
   public static class ShowDateAndTime
    { 
        public static void CommandExecute_GetWhatTimeIsIt()
        {
         Ex04.Menus.Test.UI.DisplayFunctionsResoultsAndUserInstruction.DisplayCommandOutput(string.Format("Current time is:{0}=================={0}{1}", Environment.NewLine, DateTime.Now.ToString("HH:mm")));
        }

        public static void CommandExecute_GetTodayDate()
        {
            Ex04.Menus.Test.UI.DisplayFunctionsResoultsAndUserInstruction.DisplayCommandOutput(string.Format("Today date is:{0}=================={0}{1}", Environment.NewLine, DateTime.Today.ToString("D")));
        }
    }
}
