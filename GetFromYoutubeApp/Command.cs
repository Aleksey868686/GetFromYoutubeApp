using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFromYoutubeApp
{
	internal abstract class Command
	{
		protected string URL { get; set; }
		protected VideoReciever VideoReciever { get; set; }

		public Command(string url, VideoReciever videoReciever)
		{
			URL = url;
			VideoReciever = videoReciever;
		}

		public abstract Task Execute();
	}
}
