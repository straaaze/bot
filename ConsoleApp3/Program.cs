using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;

namespace StrazeBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "792755004:AAGLiKKYKa5SZIIy4eLXVuR7UeDVIk2C9sg";
            var bot = new TelegramBotClient(token);
            var start = bot.GetMeAsync().Result;
            bot.OnMessage += (sender, e) =>
             {
                 string msg = $"{DateTime.Now}: {e.Message.Chat.FirstName} {e.Message.Chat.Id} {e.Message.Text}";
                 Console.WriteLine(msg);
                 
                 var name = e.Message.Chat.FirstName;
                 var messageText = e.Message.Text;

                 if (messageText == "/start") 
                {
                     bot.SendTextMessageAsync(e.Message.Chat.Id, $"Здарова {name}, тебе приветствует СтрейзБот, который способен на многое, но пока что он находиться в разработке. \n" +
                         $" Для связи с разработчиком используйте комманду: /razrab . \n" +
                         $" Список команд:\n /loh - Узнать лоха. \n" +
                         $" /mine - узнать нуб ты или про.\n" +
                         $" Это сделано для теста, если вы желаете что-либо предложить, то пишите. Спасибо .");

            
                 };

                 if (messageText == "/razrab")
                 {
                     bot.SendTextMessageAsync(e.Message.Chat.Id, $"@straaaze - пишите братва ");


                 };

                 if (messageText == "/loh")
                 {
                     bot.SendTextMessageAsync(e.Message.Chat.Id, $"Лох - это , конечно, Кокыч😂");

                 };
                 if (messageText == "/mine")
                 {
                     bot.SendTextMessageAsync(e.Message.Chat.Id, $"Поздравляю))) Ты проо");
                    

                 };

             };
            bot.StartReceiving();
            Thread.Sleep(int.MaxValue);
               
        }
    }
}
