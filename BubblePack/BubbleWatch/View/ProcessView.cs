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
		bool CanUpdateText = true;
		bool UpdatingGrid = false;
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
		public ProcessView(Process newProcess)
		{
			InitializeComponent();
			var processors = EasyPackage.AssemblyHandler.GetProcessors();
			cbxProcessType.Items.AddRange(processors.ToArray());
			MyProcess = newProcess;
		}

		private void cbxProcessType_SelectedIndexChanged(object sender, EventArgs e)
		{
			MyProcess.Processor = cbxProcessType.Text;
			CanUpdateText = false;
			UpdateValues();
			CanUpdateText = true;
			ProjectManager.Save();
		}

		void UpdateValues()
		{
			UpdatingGrid = true;
			if (CanUpdateText)	
				cbxProcessType.Text = MyProcess.Processor;

			var processor = EasyPackage.AssemblyHandler.GetProcessor(cbxProcessType.Text);
			var items = processor.GetSettings();
			var itemNames = items.Select(e => e.Name);
			List<string> ToRemove = new List<string>();
			foreach (var item in MyProcess.Settings)
			{
				if (!itemNames.Contains(item.Key))
					ToRemove.Add(item.Key);
			}
			foreach ( var item in ToRemove)
			{
				MyProcess.Settings.Remove(item);
			}
			foreach (var item in itemNames)
			{
				if (!MyProcess.Settings.ContainsKey(item))
					MyProcess.Settings.Add(item, "");
			}
			dgvSettings.Rows.Clear();
			foreach (var item in items)
			{
				DataGridViewCell addControl = null;
				switch (item.DataType)
				{
					case EasyPackage.Data.DataType.Boolean:
						addControl = new DataGridViewCheckBoxCell();
						bool temp = false;
						bool.TryParse(MyProcess.Settings[item.Name], out temp);
						addControl.Value = temp;
						break;
					
					case EasyPackage.Data.DataType.Decimal:
						addControl = new DataGridViewTextBoxCell();
						float tempf = 0.0f;
						float.TryParse(MyProcess.Settings[item.Name], out tempf);
						addControl.Value = tempf;
						break;
					
					case EasyPackage.Data.DataType.Number:
						addControl = new DataGridViewTextBoxCell();
						int tempi = 0;
						int.TryParse(MyProcess.Settings[item.Name], out tempi);
						addControl.Value = tempi;
						break;

					case EasyPackage.Data.DataType.PlainText:
						addControl = new DataGridViewTextBoxCell();
						addControl.Value = MyProcess.Settings[item.Name];
						break;
		
					case EasyPackage.Data.DataType.Selection:
						addControl = new DataGridViewComboBoxCell();
						DataGridViewComboBoxCell cbx = (DataGridViewComboBoxCell)addControl;
						cbx.Items.AddRange(item.Items);
						addControl.Value = MyProcess.Settings[item.Name];
						break;
				}
				int row = dgvSettings.Rows.Add(new object[] { item.Name });
				dgvSettings[1, row] = addControl;
			}
			UpdatingGrid = false;
		}

		private void dgvSettings_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (UpdatingGrid || e.RowIndex < 0)
				return;
			object cell = dgvSettings[e.ColumnIndex, e.RowIndex].Value;
			string itemName = (string)dgvSettings[0, e.RowIndex].Value;
			MyProcess.Settings[itemName] = cell.ToString();
			ProjectManager.Save();
		}
	}
}
