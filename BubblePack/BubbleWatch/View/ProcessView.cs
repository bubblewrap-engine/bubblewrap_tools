using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleWatch.View
{
	public partial class ProcessView : UserControl
	{
		private Process MyProcess_;
		public Process MyProcess
		{
			internal get
			{
				return MyProcess_;
			}
			set
			{
				MyProcess_ = value;
				UpdateValues();
			}
		}
		public ProcessView()
		{
			InitializeComponent();
			var processors = EasyPackage.AssemblyHandler.GetProcessors();
			cbxProcessType.Items.AddRange(processors.ToArray());
		}

		private void cbxProcessType_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		void UpdateValues()
		{
			cbxProcessType.Text = MyProcess.Processor;
			dgvSettings.DataSource = MyProcess.Settings;
		}
	}
}
