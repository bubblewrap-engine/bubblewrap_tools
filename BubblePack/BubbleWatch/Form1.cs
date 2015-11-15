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
		File CurrentFile { get; set; }
		ImageList checkImages;
		public Form1()
		{
			InitializeComponent();
			checkImages = new ImageList();
			CheckBox cb = new CheckBox();

			checkImages.Images.Add(GetImage("BubbleWatch.unselected.png"));
			checkImages.Images.Add(GetImage("BubbleWatch.selected.png"));
			fileTreeView.ImageList = checkImages;
			UpdateFile();

			ProjectManager.Load();
			foreach (var p in ProjectManager.Projects)
			{
				lstProjects.Items.Add(p);
			}
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
				ProjectManager.Projects.Add(p);
				lstProjects.Items.Add(p);
				
				ProjectManager.Save();
			}
		}

		private void lstProjects_SelectedValueChanged(object sender, EventArgs e)
		{
			Project p = lstProjects.SelectedItem as Project;
			if (p == null)
				return;
			fileTreeView.Nodes.Clear();
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
			Process newProcess = new Process();
			CurrentFile.Processes.Add(newProcess);
			View.ProcessView pv = new View.ProcessView(newProcess);
			processPanel.Controls.Add(pv);
			pv.Dock = DockStyle.Top;
			ProjectManager.Save();
		}

		private void fileTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (fileTreeView.SelectedNode is View.FileView)
			{
				File oldFile = ((View.FileView)fileTreeView.SelectedNode).InternalFile;
				if (oldFile != CurrentFile)
				{
					CurrentFile = oldFile;
					UpdateFile();
				}
			}
			else
			{
				CurrentFile = null;
				UpdateFile();
			}
		}

		void UpdateFile()
		{
			processPanel.Controls.Clear();
			btnAddProcessor.Enabled = false;
			if (CurrentFile != null)
			{
				btnAddProcessor.Enabled = true;
				foreach (Process p in CurrentFile.Processes)
				{
					View.ProcessView view = new View.ProcessView(p);
					processPanel.Controls.Add(view);
				}
			}
		}

		private void btnBuild_Click(object sender, EventArgs e)
		{
			Project p = lstProjects.SelectedItem as Project;
			if (p == null)
				return;
			ProjectManager.RunBuild(p, Output);
		}

		void Output(string output, object va, object vb)
		{
			textBox1.Text += string.Format(output, va, vb) + "\r\n";
		}
	}
}
