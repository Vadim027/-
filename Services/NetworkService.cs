using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.Threading;

namespace Управление_самолетами.Services
{
    public class NetworkService
    {
        private readonly AppConfig _cfg;
        private Thread _thread;

        // Событие для уведомления главного потока (UI)
        public event Action<string> JsonReceived;

        public NetworkService(AppConfig cfg)
        {
            _cfg = cfg;
        }

        public void Start()
        {
            _thread = new Thread(Run)
            {
                IsBackground = true
            };
            _thread.Start();
        }

        private void Run()
        {
            try
            {
                using (var client = new TcpClient())
                {
                    client.Connect(_cfg.ServerAddress, _cfg.ServerPort);

                    var ns = client.GetStream();

                    // Отправляю тестовый JSON (например, привет)
                    var message = new { action = "привет" };
                    var json = JsonConvert.SerializeObject(message);
                    var data = Encoding.UTF8.GetBytes(json + "\n");
                    ns.Write(data, 0, data.Length);

                    // Читаем ответ
                    var buffer = new byte[4096];
                    int read = ns.Read(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, read);

                    JsonReceived?.Invoke(response.Trim());
                }
            }
            catch (Exception ex)
            {
                // Можно вывести ошибку
                JsonReceived?.Invoke($"Error: {ex.Message}");
            }
        }
    }
}