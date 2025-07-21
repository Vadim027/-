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

        // Тут я потом добавлю еще Aircraft и AircraftStatus.
    }
}
