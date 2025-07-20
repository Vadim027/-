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

        public void AddManufacturer(Manufacturer m)
        {
            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new MySqlCommand("INSERT INTO manufacturer(name,description) VALUES(@n,@d)", conn))
                {
                    cmd.Parameters.AddWithValue("@n", m.Name);
                    cmd.Parameters.AddWithValue("@d", m.Description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateManufacturer(Manufacturer m)
        {
            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new MySqlCommand("UPDATE manufacturer SET name=@n, description=@d WHERE id=@i", conn))
                {
                    cmd.Parameters.AddWithValue("@i", m.Id);
                    cmd.Parameters.AddWithValue("@n", m.Name);
                    cmd.Parameters.AddWithValue("@d", m.Description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteManufacturer(int id)
        {
            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new MySqlCommand("DELETE FROM manufacturer WHERE id=@i", conn))
                {
                    cmd.Parameters.AddWithValue("@i", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Тут потом добавишь Aircraft и AircraftStatus по такому же шаблону.
    }
}
