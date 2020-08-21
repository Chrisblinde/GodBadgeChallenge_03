using Challenge_03_Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Challenge_03_Security
{
    class _03_Security_UI
    {
        private bool _IsRunning = true;
        private readonly Challenge_03_Security_Repo _securityRepo = new Challenge_03_Security_Repo();

        public void Start()
        {
            // SeedDictionary();
            RunMenu();
        }

        private void RunMenu()
        {
            while (_IsRunning)
            {
                string userInput = GetMenuSelection();
                OpenMenuItem(userInput);
            }

        }

        private string GetMenuSelection()
        {
            Console.Clear();
            Console.WriteLine("Hello Friendly Administrator! What Can I Do For You?\n" +
                "1. Add A Badge:\n" +
                "2. Edit A Badge:\n" +
                "3. List All Badges\n" +
                "4. Exit");
            string userInput = Console.ReadLine();
            return userInput;

        }

        private void OpenMenuItem(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    CreateNewBadge();
                    break;
                case "2":
                    //UpdateBadge();
                    break;
                case "3":
                    ListAllBadges();
                    break;
                case "4":
                    _IsRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid Selection.");
                    return;
            }

            Console.WriteLine("press any key to return to menu...");
            Console.ReadKey();
        }

        private void CreateNewBadge()
        {
            //Console.WriteLine("Enter A Badge Name:");
            //string name = Console.ReadLine();
            Console.WriteLine("Enter A Badge Number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter all doors required, seperate with commas:");
            string response = Console.ReadLine();
            List<string> doorsRequired = new List<string>();
            string[] doorArray = response.Split(',');
            doorsRequired = doorArray.ToList();
            foreach ( string door in  doorsRequired)
            {
                _securityRepo.AddToDictionary(number, doorsRequired);
            }

        }     
             
           private void ListAllBadges()
            {
                Dictionary<int , List<string>> listOfBadges = _securityRepo.GetDictionary();
            foreach (KeyValuePair<int, List<string>> badge in listOfBadges) 
            { 
            
                ListBadges(badge.Key, badge.Value);
            }
        }

        private void ListBadges(int badgeId, List<string> doorNames)
        {
            Console.WriteLine($"Badge ID: {badgeId}\n" +

                $"Door Names: {doorNames}");
        }


        /*private void SeedDictionary()
        {
            _03_Security_Badge badgeOne = new _03_Security_Badge(1, "A1""A2""A3");
        }*/    
    }    
    


}

            


            
            
            

            
                
            


        


        
            
        

    
     
