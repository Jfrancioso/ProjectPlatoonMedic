using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPlatoonMedicClient.Views
{
    
    public class PlatoonMedicConsoleUI
    {

    //PRINT METHODS BELOW

    //LoginMenu
    public void PrintLoginMenu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Welcome to ProjectPlatoonMedic");
            Console.WriteLine("1: Login");
            Console.WriteLine("2: Register");
            Console.WriteLine("0: Exit");
            Console.WriteLine("---------");
        }

    //MainMenuScreen
    public void PrintMainMenuScreen()
        {
            Console.Clear();
            Console.WriteLine("1: Company Management");
            Console.WriteLine("2: Platoon Management");
            Console.WriteLine("3: Soldier Management");
            Console.WriteLine("4: Medical Record Management");
            Console.WriteLine("5: Logout");
            Console.WriteLine("0: Exit");
            Console.WriteLine("---------");
        }

    //CompanyManagementScreen

        public void CompanyManagementScreen()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Company Management");
            Console.WriteLine("1: Add Company");
            Console.WriteLine("2: List Companies");
            Console.WriteLine("3: Update Company");
            Console.WriteLine("4: Delete Company");
            Console.WriteLine("5: View Company Details");
            Console.WriteLine("0: Back");
            Console.WriteLine("---------");
        }

        //PlatoonManagementScreen
        public void PlatoonManagementScreen()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Platoon Management");
            Console.WriteLine("1: Add Platoon");
            Console.WriteLine("2: List Platoons");
            Console.WriteLine("3: Update Platoon");
            Console.WriteLine("4: Delete Platoon");
            Console.WriteLine("5: View Platoon Details");
            Console.WriteLine("0: Back");
            Console.WriteLine("---------");
        }

    }
}
