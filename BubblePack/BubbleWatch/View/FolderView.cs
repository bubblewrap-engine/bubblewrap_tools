using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleWatch.View
{
	class FolderView : TreeNode
	{
		Folder InternalFolder;
		public FolderView(Folder Internal)
		{
			InternalFolder = Internal;
			Text = InternalFolder.FolderName;
		}
		public override string ToString()
		{
			return InternalFolder.ToString(); ;
		}

		public void Release()
		{

		}

	}
}
