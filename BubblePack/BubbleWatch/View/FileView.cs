using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleWatch.View
{
	public class FileView : TreeNode
	{
		File InternalFile;
		public FileView(File Internal)
		{
			InternalFile = Internal;
			Text = InternalFile.Filename;
			this.ImageIndex = InternalFile.Processes.Count > 0 ? 1 : 0;
		}
		public override string ToString()
		{
			return InternalFile.ToString();
		}

		public void Release()
		{

		}
	}
}
