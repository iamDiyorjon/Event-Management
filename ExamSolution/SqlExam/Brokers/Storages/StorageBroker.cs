using SqlExam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlExam.Brokers.Storages
{
     class   StorageBroker
    {
        public readonly string connectionString= @"Server=(localdb)\mssqllocaldb; Database=MyDB";
        public async  Task<Room>InsertRoomAsync(Room room)
        {
            using (var connection =
    new SqlConnection(connectionString))
            {
                string query = $"insert into Room(\r\nname,capacity,price)values \r\n('{room.Name}'," +
                    $"{room.Capacity}," +
                    $"{room.Price})";
                SqlCommand command = new SqlCommand(query, connection);

                await connection.OpenAsync();

            await  command.ExecuteNonQueryAsync();

                
            }
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
        public async Task<Room> DeleteRoomAsync(int id)
        {
            Room room = new Room();
            room.Id = id;
            using (var connection =
                 new SqlConnection(connectionString))
            {
                string query = $"";
                SqlCommand command = new SqlCommand(query, connection);

                await connection.OpenAsync();

                await command.ExecuteNonQueryAsync();
            }
            return room;
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
            using (var connection =
    new SqlConnection(connectionString))
            {
                string query = $"insert into Users(name,role,parol,login) values('{user.Name}', " +
                    $"{user.Role}, " +
                    $"'{user.Parol}', " +
                    $"'{user.Login}')";
                SqlCommand command = new SqlCommand(query, connection);

                await connection.OpenAsync();

                await command.ExecuteNonQueryAsync();


            }
            return user;
        }


    }
}



 