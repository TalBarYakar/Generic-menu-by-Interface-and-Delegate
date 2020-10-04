using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
   internal static class MenuBuilder
    {
        internal static Menu SetMenuForCurrentTestInCaseOfDelegate()
        {
            Menu mainMenu = new Menu("Main Menu");
            Menu submenu1 = new Menu("Version and Digit");
            Menu subMenu2 = new Menu("Show Date/Time");
            mainMenu.AddInstructionToMenu(submenu1);
            mainMenu.AddInstructionToMenu(subMenu2);
            CommandExecuation command1 = new CommandExecuation("Show Time");
            CommandExecuation command2 = new CommandExecuation("Show date");
            CommandExecuation command3 = new CommandExecuation(" show Version");
            CommandExecuation command4 = new CommandExecuation("Count Captials");
            command1.ExecuteCommad += ShowDateAndTime.CommandExecute_GetWhatTimeIsIt;
            command2.ExecuteCommad += ShowDateAndTime.CommandExecute_GetTodayDate;
            subMenu2.AddInstructionToMenu(command1);
            subMenu2.AddInstructionToMenu(command2);
            submenu1.AddInstructionToMenu(command3);
            submenu1.AddInstructionToMenu(command4);
            command3.ExecuteCommad += VersionAndDigits.CommandExecute_GetComputerVersion;
            command4.ExecuteCommad += VersionAndDigits.CommandExecute_GetNumberOfUpperCase;
            return mainMenu;
        }

        internal static Ex04.Menus.Interfaces.InstructionComponent SetMenuForInterface()
        {
            Interfaces.InstructionComponent mainMenue = new Interfaces.InterfaceItemMenu("Main Menu");
            Interfaces.InstructionComponent subMenue1 = new Interfaces.InterfaceItemMenu("Show Date/Time");
            Interfaces.InstructionComponent subMenue2 = new Interfaces.InterfaceItemMenu("Version and Digits");
            (mainMenue as Interfaces.InterfaceItemMenu).ListOfComponentForCurrentMenu.Add(subMenue1);
            (mainMenue as Interfaces.InterfaceItemMenu).ListOfComponentForCurrentMenu.Add(subMenue2);
            Interfaces.InstructionComponent DisplayDateMenuOption = new DateDisplayByIntrface();
            Interfaces.InstructionComponent DisplayTimeMenuOption = new TimeDisplayByInterface();
            (subMenue1 as Interfaces.InterfaceItemMenu).ListOfComponentForCurrentMenu.Add(DisplayTimeMenuOption);
            (subMenue1 as Interfaces.InterfaceItemMenu).ListOfComponentForCurrentMenu.Add(DisplayDateMenuOption);
            Interfaces.InstructionComponent DisplayVersionMenuOption = new VersionDisplayByInterface();
            Interfaces.InstructionComponent DisplayAmountOfUpperCaseMenuOption = new AmountOfUpperCaseByInterface();
            (subMenue2 as Interfaces.InterfaceItemMenu).ListOfComponentForCurrentMenu.Add(DisplayVersionMenuOption);
            (subMenue2 as Interfaces.InterfaceItemMenu).ListOfComponentForCurrentMenu.Add(DisplayAmountOfUpperCaseMenuOption);
            return mainMenue;
        }
    }
}
