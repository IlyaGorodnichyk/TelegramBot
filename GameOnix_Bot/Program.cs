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
					await botClient.SendTextMessageAsync(message.Chat, "Hello, dear friend. This bot was created to help you" +
						" choose the best game in a particular genre");
					return;
				}
				if (ask == "/help")
				{
					await botClient.SendTextMessageAsync(message.Chat, "We can enter the command \"/genre\", and I will recommend " +
						"different genres to you, and I will offer you the best games from this genre");
					await botClient.SendTextMessageAsync(message.Chat, "Choose random game");
					return;
				}
				if (ask == "/genre")
				{
					await botClient.SendTextMessageAsync(message.Chat, "/action - Games that involve intense and fast-paced combat, often with a focus on shooting or melee combat.");
					await botClient.SendTextMessageAsync(message.Chat, "/adventure - Games that involve exploration, puzzle-solving, and often feature an immersive storyline.");
					await botClient.SendTextMessageAsync(message.Chat, "/rpg - Games that focus on character development, storylines, and role-playing mechanics.");
					await botClient.SendTextMessageAsync(message.Chat, "/strategy - Games that involve planning, resource management, and often real-time or turn-based battles.");
					await botClient.SendTextMessageAsync(message.Chat, "/sports - Games that simulate a sport or sports-related activity, often with a focus on realism and simulation.");
					await botClient.SendTextMessageAsync(message.Chat, "/puzzle - Games that challenge players to solve complex puzzles or problems using logic and critical thinking skills.");
					await botClient.SendTextMessageAsync(message.Chat, "/simulation - Games that simulate real-world activities, often with a focus on realism and accuracy.");
					await botClient.SendTextMessageAsync(message.Chat, "/horror - Games that focus on creating a sense of terror or suspense, often with a survival or exploration element.");
					await botClient.SendTextMessageAsync(message.Chat, "/shooter - Games that involve shooting or ranged combat, often with a focus on realism or tactical gameplay.");
					await botClient.SendTextMessageAsync(message.Chat, "/fighting - Games that involve one-on-one combat, often with a focus on timing and combos.");
					return;
				}
				if (ask == "/action")
				{
					await botClient.SendTextMessageAsync(message.Chat, "1. Doom Eternal - A fast-paced, intense first-person shooter with beautiful graphics and challenging gameplay." +
						"2. Devil May Cry 5 - A hack - and - slash game with stunning visuals, a great story, and plenty of over - the - top action." +
						"3. Sekiro: Shadows Die Twice - A challenging action - adventure game set in feudal Japan, with a beautiful world and satisfying combat.");
					return;
				}


				await botClient.SendTextMessageAsync(message.Chat, "Sorry, I don't know this command. we can enter the command \"/help\" " +
					"and look at my capabilities");
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

