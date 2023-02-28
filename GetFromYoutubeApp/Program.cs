using System.Linq;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace GetFromYoutubeApp;

internal class Program
{
	async static Task Main(string[] args)
	{
		VideoReciever videoReciever = new VideoReciever();
		
		Console.WriteLine("Введите ссылку на ролик в Youtube");
		try
		{
			string? videoURL = Console.ReadLine();

			Console.WriteLine("\nВведите 1 - чтобы скачать видео; \n\t2 - чтобы получить информацию о ролике.");
			string? operation = Console.ReadLine();

			if (operation == "1")
			{
				var comandSender = new CommandSender(new VideoLoader(videoURL, videoReciever));
				await comandSender.Run();
				Console.WriteLine("Скачивание завершено.");
			}
			else if (operation == "2")
			{
				var comandSender = new CommandSender(new VideoInfoGetter(videoURL, videoReciever));
				await comandSender.Run();
			}
			else
			{
				Console.WriteLine("Вы ввели неверные символы.");
			}
		}
		catch (ArgumentException)
		{
			Console.WriteLine("Вы ввели некорректную ссылку.");
		}
		catch (Exception)
		{
			Console.WriteLine("Упс... что-то пошло не так.");
		}
	}
}

