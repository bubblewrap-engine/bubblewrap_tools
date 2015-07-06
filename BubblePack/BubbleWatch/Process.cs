using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleWatch
{
	public class Process
	{
		public Process()
		{
			Settings = new Dictionary<string, string>();
		}
		public string Processor { get; set; }
		public Dictionary<string, string> Settings { get; set; }
	}
}
