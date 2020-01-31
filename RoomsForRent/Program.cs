using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomsForRent
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[] rooms = new Room[10];

            int rentedRooms;
            do
            {
                Console.Write("How many rooms will be rented [0/10]? ");
                rentedRooms = int.Parse(Console.ReadLine());
            } while (rentedRooms < 0 || rentedRooms > 10);

            for (int i = 1; i <= rentedRooms; i++)
            {
                Console.WriteLine($"\n-- Rent #{i} --");

                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();

                int room;
                bool isOccupied;
                do
                {
                    isOccupied = false;

                    Console.Write("Room [1/10]: ");
                    room = int.Parse(Console.ReadLine());

                    if (rooms[room-1] != null)
                    {
                        isOccupied = true;
                        Console.WriteLine("Room occupied...\n");
                    }

                } while (room < 0 || room > 10 || isOccupied == true);

                rooms[room-1] = new Room()
                {
                    Student = new Student(name, email)
                };
            }

            if (rentedRooms == 0)
                Console.WriteLine("There are vacant rooms.");
            else
            {
                Console.WriteLine("\nBusy Rooms:");

                for (int i = 0; i < rooms.Length; i++)
                {
                    if (rooms[i] != null)
                        Console.WriteLine($"{i+1}: {rooms[i].ToString()}");
                }
            }

            Console.ReadLine();
        }
    }
}
