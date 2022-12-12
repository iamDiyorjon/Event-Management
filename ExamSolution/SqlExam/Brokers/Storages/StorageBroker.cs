using SqlExam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlExam.Brokers.Storages
{
     class   StorageBroker
    {
        public async  Task<Room>InsertRoomAsync(Room room)
        {
            return room;
        }
         public  List<Room>SelectAllRooms()
        {
            throw new NotImplementedException();
        }
        public async Task<Room>UpdateRoomAsync(Room room)
        {
            throw new NotImplementedException();
        }
        public async Task<Room>DeleteRoomAsync(int id)
        {
            throw new NotImplementedException();
        }

        
        public async Task<Order> InsertOrderAsync(Order order)
        {
            return order;
        }
        public List<Order> SelectAllOrders()
        {
            throw new NotImplementedException();
        }
        public async Task<Order> UpdateOrderAsync(Order order)
        {
            throw new NotImplementedException();
        }
        public async Task<Order> DeleteOrderAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task <User>InsertUserasync(User user)
        {
            throw new NotImplementedException();
        }


    }
}
