using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Polling;
using System.Numerics;

namespace TelegramBot
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
				Random randomGame = new Random();
				string[] game = new string[] { "Doom Eternal", "Devil May Cry 5", "Sekiro: Shadows Die Twice", "The Legend of Zelda: Breath of the Wild",
				"Uncharted 4: A Thief's End", "Assassin's Creed: Odyssey", "The Witcher 3: Wild Hunt", "Final Fantasy VII Remake","Divinity: Original Sin 2",
				"Civilization VI","XCOM 2","Total War: Warhammer II","FIFA 22","NBA 2K22","MLB The Show 21","Portal 2","The Witness","Baba Is You","The Sims 4",
				"Cities: Skylines","Microsoft Flight Simulator","Resident Evil Village","Alien: Isolation","Dead Space 2","Half-Life: Alyx","Call of Duty: Modern Warfare",
				"Rainbow Six Siege","Mortal Kombat 11", "Dragon Ball FighterZ", "Super Smash Bros. Ultimate"};
				int randomIndex = randomGame.Next(game.Length);
				string casualGame = game[randomIndex];


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
					await botClient.SendTextMessageAsync(message.Chat, "Choose /random game ");
					return;
				}
				if (ask == "/random")
				{
					await botClient.SendTextMessageAsync(message.Chat, casualGame);
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
					await botClient.SendTextMessageAsync(message.Chat, "1. Doom Eternal - A fast-paced, intense first-person shooter with beautiful graphics and challenging gameplay.");
					await botClient.SendTextMessageAsync(message.Chat, "2. Devil May Cry 5 - A hack - and - slash game with stunning visuals, a great story, and plenty of over - the - top action.");
					await botClient.SendTextMessageAsync(message.Chat, "3. Sekiro: Shadows Die Twice - A challenging action - adventure game set in feudal Japan, with a beautiful world and satisfying combat.");
					return;
				}
						
				if (ask == "/adventure")
				{
					await botClient.SendTextMessageAsync(message.Chat, "1. The Legend of Zelda: Breath of the Wild - A beautiful open-world adventure game with a vast landscape, intricate puzzles, and satisfying combat.");
					await botClient.SendTextMessageAsync(message.Chat, "2. Uncharted 4: A Thief's End - A cinematic adventure game with stunning graphics and engaging characters, offering an immersive experience.");
					await botClient.SendTextMessageAsync(message.Chat, "3. Assassin's Creed: Odyssey - An epic adventure game set in Ancient Greece, with a massive open world, incredible graphics, and engaging gameplay.");
					return;
				}
				if (ask == "/rpg")
				{
					await botClient.SendTextMessageAsync(message.Chat, "1. The Witcher 3: Wild Hunt - A masterfully crafted RPG with an immersive open world, memorable characters, and excellent storytelling.");
					await botClient.SendTextMessageAsync(message.Chat, "2. Final Fantasy VII Remake - A stunningly beautiful and nostalgic remake of the beloved classic, with updated graphics and engaging combat.");
					await botClient.SendTextMessageAsync(message.Chat, "3. Divinity: Original Sin 2 - An incredible RPG with deep gameplay mechanics, complex storylines, and a well-designed world.");
					return;
				}
				if (ask == "/strategy")
				{
					await botClient.SendTextMessageAsync(message.Chat, "1. Civilization VI - A classic turn-based strategy game with deep mechanics and endless replayability.");
					await botClient.SendTextMessageAsync(message.Chat, "2. XCOM 2 - A tactical strategy game with a great story, challenging gameplay, and plenty of customization options.");
					await botClient.SendTextMessageAsync(message.Chat, "3. Total War: Warhammer II - A fantastic combination of real-time and turn-based strategy, set in the rich Warhammer fantasy universe.");
					return;
				}
				if (ask == "/sports")
				{
					await botClient.SendTextMessageAsync(message.Chat, "1. FIFA 22 - The latest installment in the popular soccer series, with updated graphics and engaging gameplay.");
					await botClient.SendTextMessageAsync(message.Chat, "2. NBA 2K22 - A great basketball game with realistic graphics and deep gameplay mechanics.");
					await botClient.SendTextMessageAsync(message.Chat, "3. MLB The Show 21 - A fantastic baseball game with excellent graphics, realistic gameplay, and plenty of customization options.");
					return;
				}
				if (ask == "/puzzle")
				{
					await botClient.SendTextMessageAsync(message.Chat, "1. Portal 2 - A critically acclaimed puzzle game with a great storyline, fun mechanics, and challenging puzzles.");
					await botClient.SendTextMessageAsync(message.Chat, "2. The Witness - A beautiful and immersive puzzle game with a vast open world, intricate puzzles, and a thought-provoking storyline.");
					await botClient.SendTextMessageAsync(message.Chat, "3. Baba Is You - A unique and creative puzzle game with a twist: you can change the rules of the game.");
					return;
				}
				if (ask == "/simulation")
				{
					await botClient.SendTextMessageAsync(message.Chat, "1. The Sims 4 - The latest installment in the popular life simulation series, with updated graphics and new features.");
					await botClient.SendTextMessageAsync(message.Chat, "2. Cities: Skylines - A fantastic city-building simulation game with deep mechanics and endless replayability.");
					await botClient.SendTextMessageAsync(message.Chat, "3. Microsoft Flight Simulator - A stunningly realistic flight simulation game with incredible graphics and attention to detail.");
					return;
				}
				if (ask == "/horror")
				{
					await botClient.SendTextMessageAsync(message.Chat, "1. Resident Evil Village - The latest installment in the Resident Evil series, with terrifying monsters and a compelling storyline.");
					await botClient.SendTextMessageAsync(message.Chat, "2. Alien: Isolation - A hauntingly beautiful horror game set in the Alien universe, with intense gameplay and a great atmosphere.");
					await botClient.SendTextMessageAsync(message.Chat, "3. Dead Space 2 - A survival horror game with excellent graphics, intense combat, and a fantastic storyline.");
					return;
				}
				if (ask == "/shooter")
				{
					await botClient.SendTextMessageAsync(message.Chat, "1. Half-Life: Alyx - A VR-exclusive first-person shooter set in the Half-Life universe, with incredible graphics and immersive gameplay.");
					await botClient.SendTextMessageAsync(message.Chat, "2. Call of Duty: Modern Warfare - A great first-person shooter with realistic graphics, engaging gameplay, and a compelling storyline.");
					await botClient.SendTextMessageAsync(message.Chat, "3. Rainbow Six Siege - A tactical first-person shooter with deep mechanics and intense gameplay.");
					return;
				}
				if (ask == "/fighting")
				{
					await botClient.SendTextMessageAsync(message.Chat, "1. Mortal Kombat 11 - The latest installment in the iconic fighting game series, with updated graphics and new characters");
					await botClient.SendTextMessageAsync(message.Chat, "2. Dragon Ball FighterZ - A fantastic fighting game with stunning visuals, fast-paced gameplay, and a deep combat system.");
					await botClient.SendTextMessageAsync(message.Chat, "3. Super Smash Bros. Ultimate - A fun and addictive fighting game featuring an extensive roster of beloved characters from various Nintendo franchises.");
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
			Console.WriteLine("Run bot " + bot.GetMeAsync().Result.FirstName);

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

