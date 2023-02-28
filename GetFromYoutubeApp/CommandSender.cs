using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFromYoutubeApp
{
	internal class CommandSender
	{
		private Command _command;

		public CommandSender(Command command)
		{
			_command = command;
		}

		public async Task Run()
		{
			await _command.Execute();
		}
	}
}
