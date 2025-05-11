using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotelApp
{
    internal class GuestSDAO
    {
        string connectionString = "datasource=localhost;port=8889;username=root;password=root;database=default;";

        public List<Guest> getAllGuests()
        {
            List<Guest> returnThese = new List<Guest>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            // define the sql statement to fetch all albums

            MySqlCommand command = new MySqlCommand("SELECT * FROM GUESTS", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Guest a = new Guest
                    {
                        Guest_ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2),
                        Phone_Number = reader.GetInt32(3),
                        Password = reader.GetInt32(4),
                    };
                    returnThese.Add(a);
                }
            }

            connection.Close();

            return returnThese;
        }

        public List<Guest> searchNames(String searchTerm)
        {
            List<Guest> returnThese = new List<Guest>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string searchWildPhrase = "%" + searchTerm + "%";

            // define the sql statement to fetch all albums

            MySqlCommand command = new MySqlCommand();

            command.CommandText = "SELECT * FROM GUESTS WHERE Name LIKE @search";

            command.Parameters.AddWithValue("@search", searchWildPhrase);

            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Guest a = new Guest
                    {
                        Guest_ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2),
                        Phone_Number = reader.GetInt32(3),
                        Password = reader.GetInt32(4),
                    };
                    returnThese.Add(a);
                }
            }

            connection.Close();

            return returnThese;
        }

        internal int addOneGuest(Guest guest)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            // define the sql statement to fetch all albums

            MySqlCommand command = new MySqlCommand("INSERT INTO `guests`(`Name`, `Email`, `Phone_Number`, `Password`) VALUES (@Name, @email, @phone_number, @password)", connection);

            command.Parameters.AddWithValue("@Name", guest.Name);
            command.Parameters.AddWithValue("@email", guest.Email);
            command.Parameters.AddWithValue("@phone_number", guest.Phone_Number);
            command.Parameters.AddWithValue("@password", guest.Password);

            int newRows = command.ExecuteNonQuery();

            connection.Close();

            return newRows;
        }

        public List<Bookings> getBookingsForGuest(int bookingID)
        {
            List<Bookings> returnThese = new List<Bookings>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            

            // define the sql statement to fetch all albums

            MySqlCommand command = new MySqlCommand();

            command.CommandText = "SELECT * FROM BOOKINGS WHERE Booking_ID LIKE @booking_id";

            command.Parameters.AddWithValue("@booking_id", bookingID);

            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Bookings b = new Bookings
                    {
                        Booking_ID = reader.GetInt32(0),
                        Guest_ID = reader.GetInt32(1),
                        Check_in = reader.GetDateTime(2),
                        Check_out = reader.GetDateTime(3),
                        Price = reader.GetInt32(4),
                        Room_Number = reader.GetInt32(5),
                    };
                    returnThese.Add(b);
                }
            }

            connection.Close();

            return returnThese;
        }

        internal int deleteBooking(int bookingID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            // define the sql statement to fetch all albums

            MySqlCommand command = new MySqlCommand("DELETE FROM `bookings` WHERE `bookings`.`Booking_ID` = @bookingID;", connection);

            command.Parameters.AddWithValue("@bookingID", bookingID);
            
            int result = command.ExecuteNonQuery();

            connection.Close();

            return result;
        }
    }
}

