using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace MyBot
{
    class Program
    {
        private static string _token = "5718612277:AAHspBrCUOCsMMbSvSZbg6BE32C_nXOtZDY";
        private static TelegramBotClient _client;

        static void Main(string[] args)
        {
            _client = new TelegramBotClient(_token); //инициаализация бота
            _client.StartReceiving(); //начало приёма сообщений
            _client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            _client.StopReceiving(); //конец приёма сообщений
        }

        private static async void OnMessageHandler(object sender, MessageEventArgs e)
         {
            var msg = e.Message;
            if (msg.Text != null)
            {
                Console.WriteLine($"Пришло сообщение с текстом: {msg.Text}");

                switch (msg.Text.ToLower())
                {
                    case "пн":
                        await _client.SendPhotoAsync(
                            chatId: msg.Chat.Id,
                            photo: "https://sun9-east.userapi.com/sun9-34/s/v1/ig2/muUxpp3puCYD5fUnV3DvGaH64d8TaSRtpQDnKXYH1KfiU2U1ByiaECt6rchaQPFmPnFvLSuYPVz5hDgJAXSZQOmp.jpg?size=2236x428&quality=95&type=album",
                            replyToMessageId: msg.MessageId);
                        break;

                    case "вт":
                        await _client.SendPhotoAsync(
                            chatId: msg.Chat.Id,
                            photo: "https://sun9-west.userapi.com/sun9-67/s/v1/ig2/2F3zELC9Y_xd841k_2ZDlLLXT9YUUddHCVeWwOjglcUhINS45fQlVy-e7fhpz-0SHT91WVMYJIduImQfhwX0ltA_.jpg?size=2240x354&quality=95&type=album",
                            replyToMessageId: msg.MessageId);
                        break;

                    case "ср":
                        await _client.SendPhotoAsync(
                            chatId: msg.Chat.Id,
                            photo: "https://sun9-east.userapi.com/sun9-32/s/v1/ig2/7XnjwwwvbRCUT1vATtNf4gofW2--nojoOihfz6Cml01e3gFB-t14jDGqLVu12hA2IXcgvuqVNM9oj_AubC-2iQcF.jpg?size=2240x416&quality=95&type=album",
                            replyToMessageId: msg.MessageId);
                        break;

                    case "чт":
                        await _client.SendPhotoAsync(
                            chatId: msg.Chat.Id,
                            photo: "https://sun9-east.userapi.com/sun9-60/s/v1/ig2/l9TJsv8ko5sv-lcx5JuDR6E2s6vg36VSiMx7QoLKQ_IA6YVGaua-3Mn_XrmbwMgQ6VLALYuApqsZKfa6tfk2LYzu.jpg?size=2240x282&quality=95&type=album",
                            replyToMessageId: msg.MessageId);
                        break;

                    case "пт":
                        await _client.SendPhotoAsync(
                            chatId: msg.Chat.Id,
                            photo: "https://sun9-west.userapi.com/sun9-48/s/v1/ig2/cw2GopHkUjf26gAt8IbflGAPG1DNoBD7mHB6lwoassPq8LRTfqwVWYZ4IGC0Dlbcor8nKtEe_QlAfBciYnC-PzlB.jpg?size=2238x344&quality=95&type=album",
                            replyToMessageId: msg.MessageId);
                        break;

                    case "сб":
                        await _client.SendPhotoAsync(
                            chatId: msg.Chat.Id,
                            photo: "https://sun9-north.userapi.com/sun9-87/s/v1/ig2/1zOyUa_xXEuHvDTysRWCk9z1nMl4SQYbD8id4y-gmmdq60qeyH1yl0Y9YNNvbkXNqmsT-wv226EvLyYj4Z7qdpR5.jpg?size=2236x430&quality=95&type=album",
                            replyToMessageId: msg.MessageId);
                        break;

                    default:
                        await _client.SendTextMessageAsync(
                            chatId: msg.Chat.Id,
                            text: "Пожалуйста, уточните день (пн, вт, ср, чт, пт, сб)!",
                            replyToMessageId: msg.MessageId);
                        break;
                }
            }
        }
    }
}