namespace Fallout4_QA
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panelMain = new System.Windows.Forms.Panel();
			this.labelOpenRepository = new System.Windows.Forms.Label();
			this.buttonOpenDialogInputFolder = new MaterialSkin.Controls.MaterialFlatButton();
			this.buttonOpenDialogGlossaryFile = new MaterialSkin.Controls.MaterialFlatButton();
			this.buttonOpenDialogOutputFolder = new MaterialSkin.Controls.MaterialFlatButton();
			this.progressBar = new MaterialSkin.Controls.MaterialProgressBar();
			this.buttonRun = new MaterialSkin.Controls.MaterialRaisedButton();
			this.labelOutputFolder = new MaterialSkin.Controls.MaterialLabel();
			this.labelGlossaryFile = new MaterialSkin.Controls.MaterialLabel();
			this.labelInputFolder = new MaterialSkin.Controls.MaterialLabel();
			this.pathGlossaryFile = new System.Windows.Forms.TextBox();
			this.pathOutputFolder = new System.Windows.Forms.TextBox();
			this.pathInputFolder = new System.Windows.Forms.TextBox();
			this.tooltipInputFolder = new System.Windows.Forms.ToolTip(this.components);
			this.tooltipGlossaryFile = new System.Windows.Forms.ToolTip(this.components);
			this.tooltipOutputFolder = new System.Windows.Forms.ToolTip(this.components);
			this.glossaryFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.panelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelMain.BackColor = System.Drawing.SystemColors.Control;
			this.panelMain.Controls.Add(this.labelOpenRepository);
			this.panelMain.Controls.Add(this.buttonOpenDialogInputFolder);
			this.panelMain.Controls.Add(this.buttonOpenDialogGlossaryFile);
			this.panelMain.Controls.Add(this.buttonOpenDialogOutputFolder);
			this.panelMain.Controls.Add(this.progressBar);
			this.panelMain.Controls.Add(this.buttonRun);
			this.panelMain.Controls.Add(this.labelOutputFolder);
			this.panelMain.Controls.Add(this.labelGlossaryFile);
			this.panelMain.Controls.Add(this.labelInputFolder);
			this.panelMain.Controls.Add(this.pathGlossaryFile);
			this.panelMain.Controls.Add(this.pathOutputFolder);
			this.panelMain.Controls.Add(this.pathInputFolder);
			this.panelMain.Location = new System.Drawing.Point(0, 64);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(549, 372);
			this.panelMain.TabIndex = 0;
			// 
			// labelOpenRepository
			// 
			this.labelOpenRepository.AutoSize = true;
			this.labelOpenRepository.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labelOpenRepository.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelOpenRepository.Location = new System.Drawing.Point(416, 309);
			this.labelOpenRepository.Name = "labelOpenRepository";
			this.labelOpenRepository.Size = new System.Drawing.Size(119, 17);
			this.labelOpenRepository.TabIndex = 16;
			this.labelOpenRepository.Text = "GitHub repository";
			this.labelOpenRepository.Click += new System.EventHandler(this.labelOpenRepository_Click);
			// 
			// buttonOpenDialogInputFolder
			// 
			this.buttonOpenDialogInputFolder.AutoSize = true;
			this.buttonOpenDialogInputFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonOpenDialogInputFolder.Depth = 0;
			this.buttonOpenDialogInputFolder.Icon = null;
			this.buttonOpenDialogInputFolder.Location = new System.Drawing.Point(460, 41);
			this.buttonOpenDialogInputFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.buttonOpenDialogInputFolder.MaximumSize = new System.Drawing.Size(75, 23);
			this.buttonOpenDialogInputFolder.MinimumSize = new System.Drawing.Size(75, 23);
			this.buttonOpenDialogInputFolder.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonOpenDialogInputFolder.Name = "buttonOpenDialogInputFolder";
			this.buttonOpenDialogInputFolder.Primary = false;
			this.buttonOpenDialogInputFolder.Size = new System.Drawing.Size(75, 23);
			this.buttonOpenDialogInputFolder.TabIndex = 14;
			this.buttonOpenDialogInputFolder.Text = "...";
			this.buttonOpenDialogInputFolder.UseVisualStyleBackColor = true;
			this.buttonOpenDialogInputFolder.Click += new System.EventHandler(this.buttonOpenDialogInputFolder_Click);
			// 
			// buttonOpenDialogGlossaryFile
			// 
			this.buttonOpenDialogGlossaryFile.AutoSize = true;
			this.buttonOpenDialogGlossaryFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonOpenDialogGlossaryFile.Depth = 0;
			this.buttonOpenDialogGlossaryFile.Icon = null;
			this.buttonOpenDialogGlossaryFile.Location = new System.Drawing.Point(460, 121);
			this.buttonOpenDialogGlossaryFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.buttonOpenDialogGlossaryFile.MaximumSize = new System.Drawing.Size(75, 23);
			this.buttonOpenDialogGlossaryFile.MinimumSize = new System.Drawing.Size(75, 23);
			this.buttonOpenDialogGlossaryFile.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonOpenDialogGlossaryFile.Name = "buttonOpenDialogGlossaryFile";
			this.buttonOpenDialogGlossaryFile.Primary = false;
			this.buttonOpenDialogGlossaryFile.Size = new System.Drawing.Size(75, 23);
			this.buttonOpenDialogGlossaryFile.TabIndex = 13;
			this.buttonOpenDialogGlossaryFile.Text = "...";
			this.buttonOpenDialogGlossaryFile.UseVisualStyleBackColor = true;
			this.buttonOpenDialogGlossaryFile.Click += new System.EventHandler(this.buttonOpenDialogGlossaryFile_Click);
			// 
			// buttonOpenDialogOutputFolder
			// 
			this.buttonOpenDialogOutputFolder.AutoSize = true;
			this.buttonOpenDialogOutputFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonOpenDialogOutputFolder.Depth = 0;
			this.buttonOpenDialogOutputFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.buttonOpenDialogOutputFolder.Icon = null;
			this.buttonOpenDialogOutputFolder.Location = new System.Drawing.Point(460, 200);
			this.buttonOpenDialogOutputFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.buttonOpenDialogOutputFolder.MaximumSize = new System.Drawing.Size(75, 23);
			this.buttonOpenDialogOutputFolder.MinimumSize = new System.Drawing.Size(75, 23);
			this.buttonOpenDialogOutputFolder.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonOpenDialogOutputFolder.Name = "buttonOpenDialogOutputFolder";
			this.buttonOpenDialogOutputFolder.Primary = false;
			this.buttonOpenDialogOutputFolder.Size = new System.Drawing.Size(75, 23);
			this.buttonOpenDialogOutputFolder.TabIndex = 12;
			this.buttonOpenDialogOutputFolder.Text = "...";
			this.buttonOpenDialogOutputFolder.UseVisualStyleBackColor = true;
			this.buttonOpenDialogOutputFolder.Click += new System.EventHandler(this.buttonOpenDialogOutputFolder_Click);
			// 
			// progressBar
			// 
			this.progressBar.Depth = 0;
			this.progressBar.Location = new System.Drawing.Point(12, 355);
			this.progressBar.MouseState = MaterialSkin.MouseState.HOVER;
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(523, 5);
			this.progressBar.TabIndex = 11;
			// 
			// buttonRun
			// 
			this.buttonRun.AutoSize = true;
			this.buttonRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonRun.Depth = 0;
			this.buttonRun.Icon = null;
			this.buttonRun.Location = new System.Drawing.Point(199, 291);
			this.buttonRun.MinimumSize = new System.Drawing.Size(150, 36);
			this.buttonRun.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.Primary = true;
			this.buttonRun.Size = new System.Drawing.Size(150, 36);
			this.buttonRun.TabIndex = 10;
			this.buttonRun.Text = "RUN";
			this.buttonRun.UseVisualStyleBackColor = true;
			this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
			// 
			// labelOutputFolder
			// 
			this.labelOutputFolder.AutoSize = true;
			this.labelOutputFolder.Depth = 0;
			this.labelOutputFolder.Font = new System.Drawing.Font("Roboto", 11F);
			this.labelOutputFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labelOutputFolder.Location = new System.Drawing.Point(8, 180);
			this.labelOutputFolder.MouseState = MaterialSkin.MouseState.HOVER;
			this.labelOutputFolder.Name = "labelOutputFolder";
			this.labelOutputFolder.Size = new System.Drawing.Size(99, 19);
			this.labelOutputFolder.TabIndex = 8;
			this.labelOutputFolder.Text = "Output Folder";
			// 
			// labelGlossaryFile
			// 
			this.labelGlossaryFile.AutoSize = true;
			this.labelGlossaryFile.Depth = 0;
			this.labelGlossaryFile.Font = new System.Drawing.Font("Roboto", 11F);
			this.labelGlossaryFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labelGlossaryFile.Location = new System.Drawing.Point(8, 101);
			this.labelGlossaryFile.MouseState = MaterialSkin.MouseState.HOVER;
			this.labelGlossaryFile.Name = "labelGlossaryFile";
			this.labelGlossaryFile.Size = new System.Drawing.Size(96, 19);
			this.labelGlossaryFile.TabIndex = 7;
			this.labelGlossaryFile.Text = "Glossary File";
			// 
			// labelInputFolder
			// 
			this.labelInputFolder.AutoSize = true;
			this.labelInputFolder.Depth = 0;
			this.labelInputFolder.Font = new System.Drawing.Font("Roboto", 11F);
			this.labelInputFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labelInputFolder.Location = new System.Drawing.Point(9, 22);
			this.labelInputFolder.MouseState = MaterialSkin.MouseState.HOVER;
			this.labelInputFolder.Name = "labelInputFolder";
			this.labelInputFolder.Size = new System.Drawing.Size(88, 19);
			this.labelInputFolder.TabIndex = 6;
			this.labelInputFolder.Text = "Input Folder";
			// 
			// pathGlossaryFile
			// 
			this.pathGlossaryFile.Location = new System.Drawing.Point(12, 123);
			this.pathGlossaryFile.Name = "pathGlossaryFile";
			this.pathGlossaryFile.Size = new System.Drawing.Size(441, 20);
			this.pathGlossaryFile.TabIndex = 2;
			this.pathGlossaryFile.TextChanged += new System.EventHandler(this.pathGlossaryFile_TextChanged);
			// 
			// pathOutputFolder
			// 
			this.pathOutputFolder.Location = new System.Drawing.Point(12, 202);
			this.pathOutputFolder.Name = "pathOutputFolder";
			this.pathOutputFolder.Size = new System.Drawing.Size(441, 20);
			this.pathOutputFolder.TabIndex = 3;
			this.pathOutputFolder.TextChanged += new System.EventHandler(this.pathOutputFolder_TextChanged);
			// 
			// pathInputFolder
			// 
			this.pathInputFolder.Location = new System.Drawing.Point(12, 43);
			this.pathInputFolder.Name = "pathInputFolder";
			this.pathInputFolder.Size = new System.Drawing.Size(441, 20);
			this.pathInputFolder.TabIndex = 1;
			this.pathInputFolder.TextChanged += new System.EventHandler(this.pathInputFolder_TextChanged);
			// 
			// glossaryFileDialog
			// 
			this.glossaryFileDialog.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 436);
			this.Controls.Add(this.panelMain);
			this.Name = "MainForm";
			this.Text = "Fallout 4 QA";
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.TextBox pathInputFolder;
		private System.Windows.Forms.TextBox pathGlossaryFile;
		private System.Windows.Forms.TextBox pathOutputFolder;
		private System.Windows.Forms.ToolTip tooltipInputFolder;
		private System.Windows.Forms.ToolTip tooltipGlossaryFile;
		private System.Windows.Forms.ToolTip tooltipOutputFolder;
		private MaterialSkin.Controls.MaterialProgressBar progressBar;
		private MaterialSkin.Controls.MaterialRaisedButton buttonRun;
		private MaterialSkin.Controls.MaterialLabel labelOutputFolder;
		private MaterialSkin.Controls.MaterialLabel labelGlossaryFile;
		private MaterialSkin.Controls.MaterialLabel labelInputFolder;
		private MaterialSkin.Controls.MaterialFlatButton buttonOpenDialogOutputFolder;
		private MaterialSkin.Controls.MaterialFlatButton buttonOpenDialogInputFolder;
		private MaterialSkin.Controls.MaterialFlatButton buttonOpenDialogGlossaryFile;
		private System.Windows.Forms.Label labelOpenRepository;
		private System.Windows.Forms.OpenFileDialog glossaryFileDialog;
	}
}

