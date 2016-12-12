using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace MVC_6_CORE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                // устанавливает в качестве веб-сервера Kestrel. Хотя необязательно использовать именно Kestrel
                .UseKestrel()
                // определяет каталог содержимого приложения или Content Root.
                .UseContentRoot(Directory.GetCurrentDirectory())
                // обеспечивает интеграцию приложения с веб-сервером IIS, через который по умолчанию перенаправляются запросы на сервер Kestrel. Однако также необязательно использовать этот метод, если мы не используем IIS.
                .UseIISIntegration()
                // устанавливается стартовый класс приложения - класс Startup, с которого и будет начинаться обработка входящих запросов
                .UseStartup<Startup>()
                // создает хост - объект IWebHost, в рамках которого развертывается веб-приложение
                .Build();
            // запускается приложение
            host.Run();
        }
    }
}
