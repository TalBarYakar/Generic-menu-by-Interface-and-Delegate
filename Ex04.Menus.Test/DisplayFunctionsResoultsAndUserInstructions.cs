using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    namespace UI
    {
        public static class DisplayFunctionsResoultsAndUserInstruction
        {
            public static string GetStringFromUser()
            {
                Console.WriteLine("please type a string");
                return Console.ReadLine();
            }
        
            public static void DisplayCommandOutput(string i_String)
            {
                Console.WriteLine(i_String);
            }
        }
    }
}
