using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bots.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;

namespace TelegramBotExperiments
{
	class Program
	{
		static ITelegramBotClient bot = new TelegramBotClient("5811550558:AAFVcgalkNIaCFhfDzTDvuObG85GeOsB99g");
		public static async Task HandleUpdateAsync(ITelegramBotClient botClient,
		   Update update, CancellationToken cancellationToken)
		{
			Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
			if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
			{
				var message = update.Message;
				string ask = message.Text.ToLower();
				if (ask == "/start")
				{
					await botClient.SendTextMessageAsync(message.Chat, "Hi");
					return;
				}
				await botClient.SendTextMessageAsync(message.Chat, "Error");
				return;
			}
		}
		public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception
			, CancellationToken cancellationToken)
		{
			Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

			var cts = new CancellationTokenSource();
			var cancellationToken = cts.Token;
			var receiverOptions = new ReceiverOptions
			{
				AllowedUpdates = { }, // receive all update types
			};
			bot.StartReceiving(
				HandleUpdateAsync,
				HandleErrorAsync,
				receiverOptions,
				cancellationToken
			);
			Console.ReadLine();
		}
	}
}

