using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace GetFromYoutubeApp
{
	internal class VideoReciever
	{
		private YoutubeClient _client;

		public VideoReciever()
		{
			_client = new YoutubeClient();
		}

		public async Task DownloadVideo(string url)
		{
			var streamManifest = await _client.Videos.Streams.GetManifestAsync(url);
			var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
			await _client.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
		}

		public async Task GetInfo(string url)
		{
			var video = await _client.Videos.GetAsync(url);

			var title = video.Title; 
			var author = video.Author.ChannelTitle; 
			var duration = video.Duration;

			Console.WriteLine($"Название: {title}");
			Console.WriteLine($"Автор: {author}");
			Console.WriteLine($"Продолжительность: {duration}");
		}
	}
}
