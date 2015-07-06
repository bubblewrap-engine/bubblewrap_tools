using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleWatch
{
	public partial class Form1 : Form
	{
		ImageList checkImages;
		List<Project> Projects { get; set; }
		public Form1()
		{
			InitializeComponent();
			Projects = new List<Project>();
			checkImages = new ImageList();
			CheckBox cb = new CheckBox();

			checkImages.Images.Add(GetImage("BubbleWatch.unselected.png"));
			checkImages.Images.Add(GetImage("BubbleWatch.selected.png"));
			fileTreeView.ImageList = checkImages;
		}

		Image GetImage(string name )
		{
			System.Reflection.Assembly thisExe;
			thisExe = System.Reflection.Assembly.GetExecutingAssembly();
			System.IO.Stream file =
				thisExe.GetManifestResourceStream(name);
			return Image.FromStream(file);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if ( folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Project p = new Project(folderDialog.SelectedPath);
				Projects.Add(p);
				lstProjects.Items.Add(p);
				
			}
		}

		private void lstProjects_SelectedValueChanged(object sender, EventArgs e)
		{
			fileTreeView.Nodes.Clear();
			Project p = lstProjects.SelectedItem as Project;
			AddFolder(null, p.ContentFolder);
		}

		public void AddFolder( TreeNode parent, Folder folder )
		{
			foreach (Folder f in folder.Folders)
			{
				TreeNode newParent = new View.FolderView(f);
				if (parent == null)
					fileTreeView.Nodes.Add(newParent);
				else
					parent.Nodes.Add(newParent);
				AddFolder(newParent, f);
			}
			foreach (File f in folder.Files)
			{
				TreeNode newParent = new View.FileView(f);
				if (parent == null)
					fileTreeView.Nodes.Add(newParent);
				else
					parent.Nodes.Add(newParent);
			}
		}

		private void btnAddProcessor_Click(object sender, EventArgs e)
		{
			View.ProcessView pv = new View.ProcessView();
			processPanel.Controls.Add(pv);
			pv.Dock = DockStyle.Top;
		}

	}
}
