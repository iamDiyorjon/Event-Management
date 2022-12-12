using SqlExam.Brokers.Storages;
using SqlExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SqlExam.Services
{
     static class Service
    {
        private static StorageBroker storageBroker;
       
        public static List<Room> GetFreeRooms()
        {
           //orderlarda yo'q bo'lga roomlarni olish kerak
            List<Room> list = new List<Room>();
            list.Add(new Room());
            return list;
        }
        //user uchun eventlar ro'yhati
        public static List<Order>GetEvents()
        {
           //orderdan id bo'yicha eventlarni olish kerak
            List<Order> list = new List<Order>();
            list.Add(new Order());
            return list;
        }

        public static int CheckUserAndReturnRole(string parol,string login)
        {
            //user tabledan parol loginga togri keladiganini topib userni intdagi rolini qaytaraman 
            //0-admin,1-company,2-user
            return 0;
        }
        public static void CheckAddRoom(string name,int capacity,decimal price)
        {
            Room room = new Room();
            if(name != null && capacity != null && price != null )
            {
                room.Name = name;
                room.Price = price;
                room.Capacity = capacity;
                storageBroker.InsertRoomAsync(room);
                Console.WriteLine("Muvaffaqiyatli qo'shildi! ");
            }
            else
            {
                Console.WriteLine("Bo'sh qoldirilgan maydon aniqlandi shu sababli qo'shilmadi! ");
            }
        }


        public static void DeleteRoom(int id)
        {
            if(id != null)
            {
                
                storageBroker.DeleteRoomAsync(id);
            }
           else
                Console.WriteLine("bunday id mavjud emas");
        }

        public static void AdduUser(string name,string parol,string login)
        {
            User user = new User();
            if(name !=null  && parol != null && login != null)
            {
                user.Name = name;
                user.Parol = parol;
                user.Login = login;
                user.Role = 2;
                storageBroker.InsertUserasync(user);
            }
        }
    }
}
