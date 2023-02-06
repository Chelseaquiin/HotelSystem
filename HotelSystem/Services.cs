using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    internal class Services
    {
        static string input = string.Empty;
        static Room room;
        public static IList<Room> RoomList { get; set; } = new List<Room>();
        public static IList<Room> CustomerList { get; set; } = new List<Room>();

        public static void Admin()
        {
            do
            {
                Console.WriteLine("What do you want to do?\n1. View All Rooms\n2. Add a room\n3. Remove a room\n4. Exit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ViewAllRooms();
                        break;
                    case "2":
                        room = RoomDetails();
                        AddARoom(room);
                        Logger.Log("Room has been successfully added");
                        break;
                    case "3":
                        int roomNumber = RoomNumber();
                        RemoveARoom(roomNumber);
                        Logger.Log("Room has been successfully removed");
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }
            while (true);
        }

        private static void RemoveARoom(int roomNumber)
        {
            var rooms = RoomList.FirstOrDefault(a => a.RoomNumber == roomNumber);
            
            if(rooms != null)
            {
                RoomList.Remove(rooms);
            }
        }

        private static void AddARoom(Room room)
        {
            RoomList.Add(room);
        }

        private static void ViewAllRooms()
        {
            foreach(Room room in RoomList)
            {
                Console.WriteLine($"Number: {room.RoomNumber}, Type: {room.RoomType}, Price: {room.RoomPrice}, Available? {room.IsAvailable}");
            }
        }

        public static void Customer()
        {
            do
            {
                Console.WriteLine("What do you want to do?\n1. View All Available Rooms\n2. Book a room\n3. Cancel a reservation\n4. View your reservation\n5. Exit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ViewAllAvailableRooms();
                        break;
                    case "2":
                        int roomNumber = RoomNumber();
                        ReserveARoom(roomNumber);
                        Logger.Log("Room Reserved");
                        break;
                    case "3":
                        int roomNumber1 = RoomNumber();
                        CancelAReservation(roomNumber1);
                        Logger.Log("Too bad");
                        break;
                    case "4":
                        ViewYourReservation();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            } while (true);
        }

        private static void ViewYourReservation()
        {
            foreach(Room r in CustomerList)
            {
                Console.WriteLine($"Room Number: {r.RoomNumber}, Room Type: {r.RoomType}, Room Price: {r.RoomPrice}");
            }
        }

        private static void CancelAReservation(int roomNumber)
        {
            var customerRoom = CustomerList.FirstOrDefault(a => a.RoomNumber == roomNumber);
            if (customerRoom != null)
            {
                CustomerList.Remove(customerRoom);
                RoomList.Add(customerRoom);
            }
        }

        private static void ReserveARoom(int roomNumber)
        {
            var customerRoom = RoomList.FirstOrDefault(a => a.RoomNumber == roomNumber);
            if (customerRoom != null)
            {
                CustomerList.Add(customerRoom);
                RoomList.Remove(customerRoom);
            }
        }

        private static void ViewAllAvailableRooms()
        {
            foreach (Room room in RoomList)
            {
                Console.WriteLine($"Number: {room.RoomNumber}, Type: {room.RoomType}, Price: {room.RoomPrice}, Available? {room.IsAvailable}");
            }
        }

        private static Room RoomDetails()
        {
            Logger.Log("Please enter a room number");
            int roomID = Convert.ToInt32(Console.ReadLine());
            Logger.Log("Please enter the price of the room");
            decimal price = Convert.ToInt32(Console.ReadLine());
            Logger.Log("Is this room available?");
            bool isAvailable = Convert.ToBoolean(Console.ReadLine());
            Room room1 = new Room() { RoomNumber = roomID, RoomType = RoomType.Suite, RoomPrice = price, IsAvailable = isAvailable };
            return room1;
        }

        private static int RoomNumber()
        {
            Console.WriteLine("Room Number?");
            int roomNumber = Convert.ToInt32(Console.ReadLine());
            return roomNumber;
        }
    }
}
