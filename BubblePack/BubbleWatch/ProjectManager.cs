using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleWatch
{
	static class ProjectManager
	{
		public static List<Project> Projects { get; set; }
		static DateTime LastUpdate;
		static bool BuildNeeded = false;
		public static void Load()
		{
			if (System.IO.File.Exists("projectData"))
			{
				string data = System.IO.File.ReadAllText("projectData");
				Projects = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Project>>(data);
				LastUpdate = DateTime.Now;
			}

		}

		public static void Save()
		{
			string data = Newtonsoft.Json.JsonConvert.SerializeObject(Projects);
			System.IO.File.WriteAllText("projectData", data);
			LastUpdate = DateTime.Now;
			BuildNeeded = true;
		}
		
		public static void RunBuild(Project p, EasyPackage.PackageHandler.Output Output)
		{
			EasyPackage.Package pkg = BuildPackage(p);
			EasyPackage.PackageHandler hdl = new EasyPackage.PackageHandler(pkg);
			hdl.LogOutput = Output;
			hdl.Package("windows");

		}

		static ProjectManager()
		{
			LastUpdate = DateTime.Now;
		}

		static EasyPackage.Package BuildPackage(Project p )
		{
			EasyPackage.Package result = new EasyPackage.Package();
			result.ClearCache = false;
			result.Packagers = new List<Dictionary<string, string>>();
			Dictionary<string, string> pkgSettings = new Dictionary<string, string>();
			pkgSettings.Add("outputFolder", p.Location + "/dist");
			pkgSettings.Add("packager", "EasyPackage.Packagers.CopyPackager");
			pkgSettings.Add("configuration", "*");
			result.Packagers.Add(pkgSettings);
			result.Directories = new List<EasyPackage.PackageFolder>();
			EasyPackage.PackageFolder folder = new EasyPackage.PackageFolder();
			result.Directories.Add(folder);
			folder.Path = p.ContentFolder.Path;
			folder.UploadPath = "";
			AddFolder(folder, p.ContentFolder);
			return result;
		}

		static void AddFolder( EasyPackage.PackageFolder pkgfolder, Folder folder)
		{
			pkgfolder.Directories = new List<EasyPackage.PackageFolder>();
			pkgfolder.Files = new List<EasyPackage.PackageFile>();
			foreach ( Folder f in folder.Folders)
			{
				EasyPackage.PackageFolder newFolder = new EasyPackage.PackageFolder();
				newFolder.Path = f.FolderName;
				newFolder.UploadPath = f.FolderName;
				pkgfolder.Directories.Add(newFolder);
				AddFolder(newFolder, f);
			}

			foreach (File f in folder.Files)
			{
				EasyPackage.PackageFile newFile = new EasyPackage.PackageFile();
				newFile.File = f.Filename;
				newFile.Processors = new List<Dictionary<string, string>>();
				foreach (var process in f.Processes)
				{
					Dictionary<string, string> settings = new Dictionary<string, string>();
					settings.Add("processor", process.Processor);
					foreach(var kvp in process.Settings)
					{
						settings.Add(kvp.Key, kvp.Value);
					}
					newFile.Processors.Add(settings);
				}
				pkgfolder.Files.Add(newFile);
			}
		}
	}
}
