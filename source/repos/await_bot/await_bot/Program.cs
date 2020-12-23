using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace await_bot
{
    class Program
    {
        static ITelegramBotClient Bot;
        static readonly string token = "1448082591:AAGiW_-38djbQ4Jd-KjZ4STzoy905qB9v10";

        static void Main()
        {
            Bot = new TelegramBotClient(token);

            Bot.OnMessage += OnMessage;

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
        }

        static async void OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message == null) return;

            //if (e.Message.Type == MessageType.Text)
            //{
                
            //}

            await Bot.SendTextMessageAsync(
                    chatId: e.Message.Chat.Id,
                    parseMode: ParseMode.Html,
                    text: $"<a href=\"tg://user?id={e.Message.From.Id}\">You</a>"
                    );
        }
    }
}