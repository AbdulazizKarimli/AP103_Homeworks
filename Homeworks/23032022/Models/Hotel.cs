using _23032022.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _23032022.Models
{
    internal class Hotel
    {
        public string Name { get; set; }
        private Room[] _rooms;

        public Room this[int index]
        {
            get
            {
                if (index < _rooms.Length)
                {
                    return _rooms[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < _rooms.Length)
                {
                    _rooms[index] = value;
                    return;
                }
                throw new IndexOutOfRangeException();
            }
        }

        public Hotel(string name)
        {
            _rooms = new Room[0];
            Name = name;
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            _rooms[_rooms.Length - 1] = room;
        }

        public void MakeReservation(int? roomId)
        {
            if (roomId == null)
                throw new NullReferenceException("null ola bilmez");

            foreach (var room in _rooms)
            {
                if (room.Id == roomId)
                {
                    if (!room.IsAvailable)
                        throw new NotAvailableException("rezerv olunub");

                    room.IsAvailable = false;
                    return;
                }
            }

            throw new NotFoundException("bele bir otaq yoxdur");
        }
    }
}
