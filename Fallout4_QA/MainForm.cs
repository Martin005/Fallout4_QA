using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fallout4_QA
{
	public partial class MainForm : MaterialForm
	{
		string inputFolderPath = "";
		string glossaryFilePath = "";
		string outputFolderPath = "";

		public MainForm()
		{
			InitializeComponent();
			InitializeTooltips();
			InitializeMaterialSkin();
			CenterToScreen();
		}

		private void InitializeMaterialSkin()
		{
			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
		}

		private void InitializeTooltips()
		{
			string inputFolderTooltipText = "Input folder with xml files";
			string glossaryFileTooltipText = "Glossary csv file with regex rules in UTF-8";
			string outputFolderTooltipText = "Output folder for html reports";

			tooltipInputFolder.SetToolTip(labelInputFolder, inputFolderTooltipText);
			tooltipGlossaryFile.SetToolTip(labelGlossaryFile, glossaryFileTooltipText);
			tooltipOutputFolder.SetToolTip(labelOutputFolder, outputFolderTooltipText);
		}

		public void setValueProgressBar(int value)
		{
			progressBar.Value = value;
		}

		public void setMaxValueProgressBar(int maxValue)
		{
			progressBar.Maximum = maxValue;
		}

		private void buttonOpenDialogInputFolder_Click(object sender, EventArgs e)
		{
			CommonOpenFileDialog inputFolderDialog = new CommonOpenFileDialog();
			inputFolderDialog.RestoreDirectory = false;
			inputFolderDialog.InitialDirectory = (inputFolderPath != "") ? inputFolderPath : "C:\\Users";
			inputFolderDialog.IsFolderPicker = true;
			if (inputFolderDialog.ShowDialog() == CommonFileDialogResult.Ok)
			{
				pathInputFolder.Text = inputFolderDialog.FileName;
				pathOutputFolder.Text = (outputFolderPath != "") ? outputFolderPath : inputFolderDialog.FileName;
			}
		}

		private void buttonOpenDialogGlossaryFile_Click(object sender, EventArgs e)
		{
			glossaryFileDialog.Filter = "CSV Glossary|*.csv";
			glossaryFileDialog.FileName = (glossaryFilePath != "") ? glossaryFilePath : "";
			DialogResult result = glossaryFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				pathGlossaryFile.Text = glossaryFileDialog.FileName;
			}
		}

		private void buttonOpenDialogOutputFolder_Click(object sender, EventArgs e)
		{
			CommonOpenFileDialog outputFolderDialog = new CommonOpenFileDialog();
			outputFolderDialog.InitialDirectory = (outputFolderPath != "") ? outputFolderPath : "C:\\Users";
			outputFolderDialog.IsFolderPicker = true;
			if (outputFolderDialog.ShowDialog() == CommonFileDialogResult.Ok)
			{
				pathOutputFolder.Text = outputFolderDialog.FileName;
			}
		}

		private void buttonRun_Click(object sender, EventArgs e)
		{
			if (inputFolderPath == "" || glossaryFilePath == "" || outputFolderPath == "")
			{
				MessageBox.Show("Please input all paths.");
			}
			else
			{
				RunQA.Process(inputFolderPath, glossaryFilePath, outputFolderPath, this);
			}
		}
		
		private void labelOpenRepository_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/Martin005/Fallout4_QA");
		}

		private void pathInputFolder_TextChanged(object sender, EventArgs e)
		{
			inputFolderPath = pathInputFolder.Text;
		}

		private void pathOutputFolder_TextChanged(object sender, EventArgs e)
		{
			outputFolderPath = pathOutputFolder.Text;
		}

		private void pathGlossaryFile_TextChanged(object sender, EventArgs e)
		{
			glossaryFilePath = pathGlossaryFile.Text;
		}
	}
}
