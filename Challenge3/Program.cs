
using Challenge3;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Room> rooms = new List<Room>();

        Console.WriteLine("How many rooms will be rented? ");
        int quantityOfRooms = Convert.ToInt16(Console.ReadLine());

        for (int i = 1; i <= quantityOfRooms; i++)
        {
            Console.WriteLine($"Rent #{i}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Room: ");
            int roomNumber = Convert.ToInt16(Console.ReadLine());

            Room newRoom = new Room
            {
                Name = name,
                Email = email,
                RoomNumber = roomNumber
            };

            rooms.Add(newRoom);
        }

        Console.WriteLine("Busy rooms: ");
        foreach (Room room in rooms)
        {
            Console.WriteLine($"{room.RoomNumber}: {room.Name}, {room.Email}");
        }
    }
}