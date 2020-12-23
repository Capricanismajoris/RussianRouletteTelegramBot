using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace HerokuTestBot1
{
    class Program
    {
        static TelegramBotClient Bot;
        static readonly string token = "1448082591:AAGiW_-38djbQ4Jd-KjZ4STzoy905qB9v10";

        static void Main()
        {
            Bot = new TelegramBotClient(token);

            Bot.OnMessage += OnMessage;

            Bot.StartReceiving();
            Console.WriteLine("start");
            Console.ReadLine();
            Bot.StopReceiving();
        }

        static async void OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message == null) return;

            await Bot.SendTextMessageAsync(
                chatId: e.Message.Chat.Id,
                text: "дарова"
                );
        }
    }
}