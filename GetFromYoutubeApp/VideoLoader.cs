using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFromYoutubeApp
{
	internal class VideoLoader : Command
	{
		public VideoLoader(string url, VideoReciever videoReciever) : base(url, videoReciever) { }

		public override async Task Execute()
		{
			await VideoReciever.DownloadVideo(URL);
		}
	}
}
