using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleWatch
{
	public class Project
	{
		public Project(string Path)
		{
			Location = Path;
			if (!Directory.Exists(Path + "/content"))
			{
				Directory.CreateDirectory(Path + "/content");
			}
			ContentFolder = new Folder(Path + "/content");
		}

		public string Location { private get; set; }

		public override string ToString()
		{
			System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Location);
			return di.Name;
		}

		public void UpdatePaths()
		{
			ContentFolder.Update();
		}

		public Folder ContentFolder;

	}
}
