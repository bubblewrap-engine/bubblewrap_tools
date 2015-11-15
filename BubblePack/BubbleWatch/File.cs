using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleWatch
{
	public class File
	{
		public File(string Path)
		{
			Processes = new List<Process>();
			this.Path = Path;
			this.Filename = new FileInfo(Path).Name;
		}
		public string Path { get; set; }
		public string Filename { get; set; }
		public DateTime TimeStamp { get; set; }
		public List<Process> Processes { get; set;}
	}
}
