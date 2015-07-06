using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleWatch
{
	public class Folder
	{
		public Folder( string Path )
		{
			Files = new List<File>();
			Folders = new List<Folder>();
			this.Path = Path;
			DirectoryInfo di = new DirectoryInfo(Path);
			FolderName = di.Name;
			var dirs = di.GetDirectories();
			var files = di.GetFiles();
			foreach (var dir in dirs)
			{
				Folders.Add(new Folder(dir.FullName));
			}
			foreach (var file in files)
			{
				Files.Add(new File(file.FullName));
			}
		}

		public string Path { get; set; }
		public string FolderName { get; set; }
		public List<File> Files { get; set; }
		public List<Folder> Folders { get; set; }


		public void Update()
		{

		}
	}
}
