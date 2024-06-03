using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TicketMatic_V2
{
    public static class DbInitializer
    {
        private static string connectionString = "Data Source=..\\..\\Data\\FlightTicketMaticDb.db;Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists("..\\..\\Data\\FlightTicketMaticDb.db"))
            {
                SQLiteConnection.CreateFile("..\\..\\Data\\FlightTicketMaticDb.db");

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Users
                    string createUsersTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Users(
                        id INTEGER PRIMARY KEY NOT NULL,
                        userName TEXT NOT NULL,
                        password TEXT NOT NULL
                    );";
                    string insertUserQuery = @"
                    INSERT INTO Users (userName, password) VALUES ('user1', 'userpassword1');";

                    // Admins
                    string createAdminsTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Admins(
                        id INTEGER PRIMARY KEY NOT NULL,
                        adminName TEXT NOT NULL,
                        password TEXT NOT NULL
                    );";
                    string insertAdminQuery = @"
                    INSERT INTO Admins (adminName, password) VALUES ('admin1', 'adminpassword1');";

                    // Planes
                    string createPlanesTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Planes(
                        id INTEGER PRIMARY KEY NOT NULL,
                        airline TEXT NOT NULL,
                        serialNo TEXT NOT NULL,
                        seatCapacity INTEGER NOT NULL
                    );";
                    string insertPlaneQuery = @"
                    INSERT INTO Planes (airline, serialNo, seatCapacity) VALUES ('PEGASUS', 'A07T47', 50);
                    INSERT INTO Planes (airline, serialNo, seatCapacity) VALUES ('THY', 'A14P76', 50);";

                    // Flights
                    string createFlightsTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Flights(
                        id INTEGER PRIMARY KEY NOT NULL,
                        fromLocation TEXT NOT NULL,
                        toLocation TEXT NOT NULL,
                        departureDate TEXT NOT NULL,
                        departureTime TEXT NOT NULL,
                        
                        planeId INTEGER NOT NULL,
                        
                        FOREIGN KEY (planeId) REFERENCES Planes(id)
                    );";
                    string insertFlightQuery = @"
                    INSERT INTO Flights (fromLocation, toLocation, departureDate, departureTime, planeId) VALUES ('İstanbul', 'Ankara', '01-01-2024','21.00', 1);
                    INSERT INTO Flights (fromLocation, toLocation, departureDate, departureTime, planeId) VALUES ('Ankara', 'İstanbul', '02-01-2024','22.00', 1);
                    INSERT INTO Flights (fromLocation, toLocation, departureDate, departureTime, planeId) VALUES ('İstanbul', 'İzmir', '03-01-2024','23.00', 1);
                    INSERT INTO Flights (fromLocation, toLocation, departureDate, departureTime, planeId) VALUES ('İzmir', 'İstanbul', '04-01-2024','19.00', 2);
                    INSERT INTO Flights (fromLocation, toLocation, departureDate, departureTime, planeId) VALUES ('Ankara', 'İzmir', '05-01-2024','18.00', 2);
                    INSERT INTO Flights (fromLocation, toLocation, departureDate, departureTime, planeId) VALUES ('İzmir', 'Ankara', '06-01-2024','17.00', 2);";

                    // Reservations
                    string createReservationsTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Reservations(
                        id INTEGER PRIMARY KEY NOT NULL,
                        seatNo TEXT NOT NULL,
                        
                        flightId INTEGER NOT NULL,
                        userId INTEGER NOT NULL,

                        FOREIGN KEY (flightId) REFERENCES Flights(id),
                        FOREIGN KEY (userId) REFERENCES Users(id)
                    );";
                    string insertReservationQuery = @"
                    INSERT INTO Reservations (seatNo, flightId, userId) VALUES ('a1', 1, 1);
                    INSERT INTO Reservations (seatNo, flightId, userId) VALUES ('a2', 1, 1);
                    INSERT INTO Reservations (seatNo, flightId, userId) VALUES ('a3', 1, 1);";

                    using (var command = new SQLiteCommand(connection))
                    {
                        // Users
                        command.CommandText = createUsersTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertUserQuery;
                        command.ExecuteNonQuery();

                        // Admins
                        command.CommandText = createAdminsTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertAdminQuery;
                        command.ExecuteNonQuery();

                        // Planes
                        command.CommandText = createPlanesTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertPlaneQuery;
                        command.ExecuteNonQuery();

                        // Flights
                        command.CommandText = createFlightsTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertFlightQuery;
                        command.ExecuteNonQuery();

                        // Reservation
                        command.CommandText = createReservationsTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertReservationQuery;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}