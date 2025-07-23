using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Управление_самолетами.Models;


namespace Управление_самолетами.Services
{
    public class DbService
    {
        private readonly string _connStr;

        public DbService(AppConfig cfg)
        {
            _connStr = $"Server={cfg.DbHost};Port={cfg.DbPort};Database={cfg.DbName};Uid={cfg.DbUser};Pwd={cfg.DbPassword};";
        }

        public List<Manufacturer> GetManufacturers()
        {
            var list = new List<Manufacturer>();
            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT id,name,description FROM manufacturer", conn))
                {
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            list.Add(new Manufacturer
                            {
                                Id = rdr.GetInt32(0),
                                Name = rdr.GetString(1),
                                Description = rdr.GetString(2)
                            });
                        }
                    }
                }
            }
            return list;
        }

        public void AddManufacturer(string name, string description)
        {
            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("INSERT INTO manufacturer (name, description) VALUES (@n, @d)", conn);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@d", description);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateManufacturer(int id, string name, string description)
        {
            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("UPDATE manufacturer SET name = @n, description = @d WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@d", description);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteManufacturer(int id)
        {
            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("DELETE FROM manufacturer WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public bool CanDeleteManufacturer(int id)
        {
            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT COUNT(*) FROM aircraft WHERE manufacturer_id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                var count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 0;
            }
        }

        // Добавить самолёт
        public void AddAircraft(string sn, string name, string desc, int mId)
        {
            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("INSERT INTO aircraft (serial_number, name, description, manufacturer_id) VALUES (@sn, @n, @d, @m)", conn);
                cmd.Parameters.AddWithValue("@sn", sn);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@d", desc);
                cmd.Parameters.AddWithValue("@m", mId);
                cmd.ExecuteNonQuery();
            }
        }

        // Обновить самолёт
        public void UpdateAircraft(int id, string sn, string name, string desc, int mId)
        {
            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("UPDATE aircraft SET serial_number = @sn, name = @n, description = @d, manufacturer_id = @m WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@sn", sn);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@d", desc);
                cmd.Parameters.AddWithValue("@m", mId);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Удалить самолёт
        public void DeleteAircraft(int id)
        {
            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("DELETE FROM aircraft WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Получить все самолёты
        public List<Aircraft> GetAircrafts()
        {
            var list = new List<Aircraft>();

            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT id, serial_number, name, description, manufacturer_id FROM aircraft", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Aircraft
                        {
                            Id = reader.GetInt32("id"),
                            SerialNumber = reader.GetString("serial_number"),
                            Name = reader.GetString("name"),
                            Description = reader.IsDBNull(reader.GetOrdinal("description")) ? "" : reader.GetString("description"),
                            ManufacturerId = reader.GetInt32("manufacturer_id")
                        });
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// Читаю статус
        /// Записываю обновлённый статус
        /// Enum.Parse переводит string из SQL в TurnDirection
        public List<AircraftStatus> GetAircraftStatuses()
        {
            var list = new List<AircraftStatus>();
            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT id, aircraft_id, flight_speed, altitude, climb_rate, turn_direction, turn_speed, gear FROM aircraft_status", conn);

                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add(new AircraftStatus
                        {
                            Id = rdr.GetInt32("id"),
                            AircraftId = rdr.GetInt32("aircraft_id"),
                            FlightSpeed = rdr.GetFloat("flight_speed"),
                            Altitude = rdr.GetFloat("altitude"),
                            ClimbRate = rdr.GetFloat("climb_rate"),
                            TurnDirection = (TurnDirection)Enum.Parse(typeof(TurnDirection), rdr.GetString("turn_direction"), true),
                            TurnSpeed = rdr.GetFloat("turn_speed"),
                            Gear = rdr.GetBoolean("gear")
                        });
                    }
                }
            }
            return list;
        }

        public void UpdateAircraftStatus(AircraftStatus status)
        {
            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "UPDATE aircraft_status SET flight_speed=@fs, altitude=@al, climb_rate=@cr, turn_direction=@td, turn_speed=@ts, gear=@g WHERE id=@id",
                    conn);

                cmd.Parameters.AddWithValue("@fs", status.FlightSpeed);
                cmd.Parameters.AddWithValue("@al", status.Altitude);
                cmd.Parameters.AddWithValue("@cr", status.ClimbRate);
                cmd.Parameters.AddWithValue("@td", status.TurnDirection.ToString().ToLower());
                cmd.Parameters.AddWithValue("@ts", status.TurnSpeed);
                cmd.Parameters.AddWithValue("@g", status.Gear);
                cmd.Parameters.AddWithValue("@id", status.Id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
