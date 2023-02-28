using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFromYoutubeApp
{
	internal class VideoInfoGetter : Command
	{
		public VideoInfoGetter(string url, VideoReciever videoReciever) : base(url, videoReciever) { }

		public override async Task Execute()
		{
			await VideoReciever.GetInfo(URL);
		}
	}
}
