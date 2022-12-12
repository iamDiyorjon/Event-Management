using SqlExam.Brokers.Storages;
using SqlExam.Models;
using SqlExam.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlExam
{
    public class Controler
    {
        public int SignIn()
        {
            Console.WriteLine("Parol: ");
            string checkParol=Console.ReadLine();
            Console.WriteLine("Login: ");
            string checklogin=Console.ReadLine();
            int role= Service.CheckUserAndReturnRole(checklogin, checklogin);
            return role;

        }
        public char AdminMenu()
        {
            Console.WriteLine("1.Add Room");
            Console.WriteLine("2.Update Romms");
            Console.WriteLine("3.Delete Room");
            Console.WriteLine("4.Chiqish");
            return (char)Console.ReadKey().Key;       
        }
        public void AddRoom()
        {
            Console.Write("Name: ");
            string name=Console.ReadLine();
            Console.Write("Capacity: ");
            int capacity = int.Parse(Console.ReadLine());
            Console.Write("Price: ");
            decimal price=decimal.Parse(Console.ReadLine());
            Service.CheckAddRoom(name, capacity, price);

        }

        public void PrintAllRoom()
        {
            var storageBroker=new StorageBroker();
            var allRooms=storageBroker.SelectAllRooms();
            foreach(var item in allRooms) 
            {
                Console.WriteLine(item.Id+"."+item.Name);
            }
        }

        public void DeleteRoom()
        {
            Console.Write("Xonanig id-sini kiriting: ");
            int roomId=int.Parse(Console.ReadLine());
            Service.DeleteRoom( roomId);
        }

        public void PintAllOrder()
        {
            var storageBroker =new StorageBroker();
            var allEvent=storageBroker.SelectAllOrders();
            foreach(var item in allEvent)
            {
                Console.WriteLine(item.Id+"."+item.Title);

            }
            Console.WriteLine(  "Qaysi eventda qatnashmoqchisiz? ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Eventdan siz uchun joy bron qilindi!");
            
        }

        public void SignUpForUser()
        {
            
            Console.Write("Entry your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Entry Parol: ");
            string parol=Console.ReadLine();
            Console.WriteLine("Entry login");
            string login=Console.ReadLine();
            Service.AdduUser(name, parol, login);

        }
        public char MainMenu()
        {
            Console.WriteLine("Sign up");
            Console.WriteLine("Sign in");
            return (char)Console.ReadKey().Key;
        }

    }
}
