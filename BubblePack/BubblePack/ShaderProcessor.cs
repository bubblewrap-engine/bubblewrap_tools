using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubblePack
{
    public class ShaderProcessor : EasyPackage.Processors.IProcessor
    {
		public override byte[] ProcessFile(byte[] Data, Dictionary<string, string> Settings)
		{
			if (!System.IO.Directory.Exists(".temp"))
			{
				System.IO.Directory.CreateDirectory(".temp");
			}
			System.Reflection.Assembly Ass = System.Reflection.Assembly.GetAssembly(this.GetType());
			string tempFile = ".temp/" + DateTime.Now.Ticks + ".bin";
			string loc = (new FileInfo(Ass.Location)).DirectoryName + "/shadercRelease.exe";

			StringBuilder sb = new StringBuilder();
			sb.AppendFormat( "-f {0} -o {1} --platform {2} --type {3}", Settings["fullPathIn"], tempFile, Settings["platform"], Settings["type"]);
			FileInfo fi = new FileInfo(Settings["fullPathIn"]);
			var dir = fi.Directory;
			sb.AppendFormat(" --varyingdef {0}/{1}", dir, "/varying.def.sc");


			ProcessStartInfo psi = new ProcessStartInfo();
			psi.Arguments = sb.ToString();
			//psi.CreateNoWindow = true;
			psi.RedirectStandardOutput = true;
			psi.UseShellExecute = false;
			psi.FileName = loc;
			System.Console.WriteLine(psi.FileName);
			Process p = Process.Start(psi);
			
			p.WaitForExit();
			byte[] result = File.ReadAllBytes(tempFile);
			var ret = p.ExitCode;
			return result;
		}

		public override EasyPackage.Data.DataItem[] Settings()
		{
			return new EasyPackage.Data.DataItem[] 
			{ 
				new EasyPackage.Data.DataItem()
				{
					Name = "platform",
					DataType = EasyPackage.Data.DataType.Selection,
					Items = new string[] { "android", "windows" }
				},
				new EasyPackage.Data.DataItem()
				{
					Name = "type",
					DataType = EasyPackage.Data.DataType.Selection,
					Items = new string[] { "vertex", "fragment" }
				}
			};
			throw new NotImplementedException();
		}
	}
}
