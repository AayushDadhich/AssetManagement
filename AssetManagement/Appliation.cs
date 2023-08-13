using AssetManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement
{
    class Program
    {
       public static void Main(string[] args)
        {
            string unameInput, passwordInput;
            bool loggedIn = false;
            int choice;
            while (loggedIn == false)
            {
                Console.Write("Asset Management Tool\n\n");
                Console.Write("Login to continue\n");
                Console.Write("Username : ");
                unameInput = Console.ReadLine();
                Console.Write("Password : ");
                passwordInput = Console.ReadLine();
                if (validate(unameInput, passwordInput))
                {   
                    loggedIn = true;
                    Console.WriteLine("Logged in Succesfully..\n\n");
                    Console.WriteLine("Welcome, {0}!\n",unameInput);
                    Console.WriteLine("1.Add an asset.\n");
                    Console.WriteLine("2.Update an asset.\n");
                    Console.WriteLine("3.Delete an asset.\n");
                    Console.WriteLine("Enter your choice (1-3) : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your Choice : {0}",choice);
                }
                else
                {
                    Console.WriteLine("Wrong Username or Password");
                }
            }
            


            //addUser();
            //readProduct();
            //Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        static bool validate(string unameInput, string passwordInput)
        {
            using (var db = new MyDbContext())
            {
                List<Users> users = db.Users.ToList();
                foreach (Users user in users)
                {
                    if (user.uname == unameInput && user.pass == passwordInput)
                    { 
                        return true;
                    }
                }
                return false;
            }
        }

        static void addUser()
        {
            using (var db = new MyDbContext())
            {
                Users user = new Users();
                
                user.uname = "Aayush";
                user.pass = "1234";
                user.type = 0;
                db.Add(user);

                user = new Users();
                user.uname = "Vishnu";
                user.pass = "2345";
                user.type = 1;
                db.Add(user);


                db.SaveChanges();
            }
            return;
        }

        static void readProduct()
        {

            using (var db = new MyDbContext())
            {
                List<Users> users = db.Users.ToList();
                foreach (Users user in users)
                {
                    Console.WriteLine("{0} {1} {2}", user.uid, user.uname, user.pass);
                }
            }
            return;
        }

    }
}
