using _23032022.Exceptions;
using _23032022.Models;
using System;

namespace _23032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("test", 23, 2);
            Room room2 = new Room("test1", 23, 2);

            Hotel hotel = new Hotel("test hotel");
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);

            try
            {
                hotel.MakeReservation(1);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            hotel[0].Name = "test123";
            Console.WriteLine(hotel[0]);
        }
    }
}
