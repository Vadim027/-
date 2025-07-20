using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Управление_самолетами.Services
{
    public class AppConfig
    {
        public string DbHost { get; set; }
        public int DbPort { get; set; }
        public string DbUser { get; set; }
        public string DbPassword { get; set; }
        public string DbName { get; set; }
        public string ServerAddress { get; set; }
        public int ServerPort { get; set; }
        public string Protocol { get; set; }

        public static AppConfig Load(string path)
        {
            var doc = XDocument.Load(path);
            var db = doc.Root.Element("database");
            var net = doc.Root.Element("network");
            return new AppConfig
            {
                DbHost = db.Element("host").Value,
                DbPort = int.Parse(db.Element("port").Value),
                DbUser = db.Element("user").Value,
                DbPassword = db.Element("password").Value,
                DbName = db.Element("databaseName").Value,
                ServerAddress = net.Element("serverAddress").Value,
                ServerPort = int.Parse(net.Element("port").Value),
                Protocol = net.Element("protocol").Value
            };
        }
    }
}
