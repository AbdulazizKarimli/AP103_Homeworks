using System;
using System.Collections.Generic;
using System.Text;

namespace _23032022.Models
{
    internal class Room
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Room(string name, double price, int personCapacity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }

        public string ShowInfo()
        {
            return $"Id: {Id} - Name: {Name} - Price: {Price} - PersonCapacity: {PersonCapacity} - IsAvialable: {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
