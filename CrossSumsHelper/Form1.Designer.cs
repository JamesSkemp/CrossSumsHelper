namespace CrossSumsHelper {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.OptionsGroup = new System.Windows.Forms.GroupBox();
			this.TempTextBox = new System.Windows.Forms.TextBox();
			this.ErrorText = new System.Windows.Forms.Label();
			this.ExcludeCheck = new System.Windows.Forms.CheckBox();
			this.IncludeCheck = new System.Windows.Forms.CheckBox();
			this.IncludeLabel = new System.Windows.Forms.Label();
			this.ExcludeLabel = new System.Windows.Forms.Label();
			this.SumLabel = new System.Windows.Forms.Label();
			this.BlanksLabel = new System.Windows.Forms.Label();
			this.ExcludeText = new System.Windows.Forms.TextBox();
			this.IncludeText = new System.Windows.Forms.TextBox();
			this.SumsCombo = new System.Windows.Forms.ComboBox();
			this.BlanksCombo = new System.Windows.Forms.ComboBox();
			this.ResultsGroup = new System.Windows.Forms.GroupBox();
			this.ResultsText = new System.Windows.Forms.TextBox();
			this.AboutContainer = new System.Windows.Forms.GroupBox();
			this.AboutButton = new System.Windows.Forms.Button();
			this.AboutLink = new System.Windows.Forms.LinkLabel();
			this.AboutText = new System.Windows.Forms.Label();
			this.MainLogo = new System.Windows.Forms.Label();
			this.OptionsGroup.SuspendLayout();
			this.ResultsGroup.SuspendLayout();
			this.AboutContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// OptionsGroup
			// 
			this.OptionsGroup.Controls.Add(this.TempTextBox);
			this.OptionsGroup.Controls.Add(this.ErrorText);
			this.OptionsGroup.Controls.Add(this.ExcludeCheck);
			this.OptionsGroup.Controls.Add(this.IncludeCheck);
			this.OptionsGroup.Controls.Add(this.IncludeLabel);
			this.OptionsGroup.Controls.Add(this.ExcludeLabel);
			this.OptionsGroup.Controls.Add(this.SumLabel);
			this.OptionsGroup.Controls.Add(this.BlanksLabel);
			this.OptionsGroup.Controls.Add(this.ExcludeText);
			this.OptionsGroup.Controls.Add(this.IncludeText);
			this.OptionsGroup.Controls.Add(this.SumsCombo);
			this.OptionsGroup.Controls.Add(this.BlanksCombo);
			this.OptionsGroup.Location = new System.Drawing.Point(12, 57);
			this.OptionsGroup.Name = "OptionsGroup";
			this.OptionsGroup.Size = new System.Drawing.Size(245, 140);
			this.OptionsGroup.TabIndex = 0;
			this.OptionsGroup.TabStop = false;
			this.OptionsGroup.Text = "Options";
			// 
			// TempTextBox
			// 
			this.TempTextBox.Location = new System.Drawing.Point(136, 59);
			this.TempTextBox.Multiline = true;
			this.TempTextBox.Name = "TempTextBox";
			this.TempTextBox.Size = new System.Drawing.Size(100, 69);
			this.TempTextBox.TabIndex = 11;
			this.TempTextBox.Visible = false;
			// 
			// ErrorText
			// 
			this.ErrorText.AutoSize = true;
			this.ErrorText.Location = new System.Drawing.Point(133, 75);
			this.ErrorText.Name = "ErrorText";
			this.ErrorText.Size = new System.Drawing.Size(0, 13);
			this.ErrorText.TabIndex = 10;
			// 
			// ExcludeCheck
			// 
			this.ExcludeCheck.AutoSize = true;
			this.ExcludeCheck.Location = new System.Drawing.Point(6, 114);
			this.ExcludeCheck.Name = "ExcludeCheck";
			this.ExcludeCheck.Size = new System.Drawing.Size(15, 14);
			this.ExcludeCheck.TabIndex = 9;
			this.ExcludeCheck.UseVisualStyleBackColor = true;
			this.ExcludeCheck.CheckedChanged += new System.EventHandler(this.CheckExclusions);
			// 
			// IncludeCheck
			// 
			this.IncludeCheck.AutoSize = true;
			this.IncludeCheck.Location = new System.Drawing.Point(6, 75);
			this.IncludeCheck.Name = "IncludeCheck";
			this.IncludeCheck.Size = new System.Drawing.Size(15, 14);
			this.IncludeCheck.TabIndex = 8;
			this.IncludeCheck.UseVisualStyleBackColor = true;
			this.IncludeCheck.CheckedChanged += new System.EventHandler(this.CheckInclusions);
			// 
			// IncludeLabel
			// 
			this.IncludeLabel.AutoSize = true;
			this.IncludeLabel.Location = new System.Drawing.Point(3, 56);
			this.IncludeLabel.Name = "IncludeLabel";
			this.IncludeLabel.Size = new System.Drawing.Size(54, 13);
			this.IncludeLabel.TabIndex = 7;
			this.IncludeLabel.Text = "Inclusions";
			// 
			// ExcludeLabel
			// 
			this.ExcludeLabel.AutoSize = true;
			this.ExcludeLabel.Location = new System.Drawing.Point(3, 95);
			this.ExcludeLabel.Name = "ExcludeLabel";
			this.ExcludeLabel.Size = new System.Drawing.Size(57, 13);
			this.ExcludeLabel.TabIndex = 6;
			this.ExcludeLabel.Text = "Exclusions";
			// 
			// SumLabel
			// 
			this.SumLabel.AutoSize = true;
			this.SumLabel.Location = new System.Drawing.Point(119, 16);
			this.SumLabel.Name = "SumLabel";
			this.SumLabel.Size = new System.Drawing.Size(66, 13);
			this.SumLabel.TabIndex = 5;
			this.SumLabel.Text = "Sum number";
			// 
			// BlanksLabel
			// 
			this.BlanksLabel.AutoSize = true;
			this.BlanksLabel.Location = new System.Drawing.Point(3, 16);
			this.BlanksLabel.Name = "BlanksLabel";
			this.BlanksLabel.Size = new System.Drawing.Size(90, 13);
			this.BlanksLabel.TabIndex = 4;
			this.BlanksLabel.Text = "Number of blanks";
			// 
			// ExcludeText
			// 
			this.ExcludeText.Location = new System.Drawing.Point(27, 111);
			this.ExcludeText.Name = "ExcludeText";
			this.ExcludeText.Size = new System.Drawing.Size(100, 20);
			this.ExcludeText.TabIndex = 3;
			this.ExcludeText.LocationChanged += new System.EventHandler(this.CheckExclusions);
			this.ExcludeText.Enter += new System.EventHandler(this.CheckExclusions);
			// 
			// IncludeText
			// 
			this.IncludeText.Location = new System.Drawing.Point(27, 72);
			this.IncludeText.Name = "IncludeText";
			this.IncludeText.Size = new System.Drawing.Size(100, 20);
			this.IncludeText.TabIndex = 2;
			this.IncludeText.Leave += new System.EventHandler(this.CheckInclusions);
			this.IncludeText.Enter += new System.EventHandler(this.CheckInclusions);
			// 
			// SumsCombo
			// 
			this.SumsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SumsCombo.FormattingEnabled = true;
			this.SumsCombo.Location = new System.Drawing.Point(122, 32);
			this.SumsCombo.Name = "SumsCombo";
			this.SumsCombo.Size = new System.Drawing.Size(110, 21);
			this.SumsCombo.TabIndex = 1;
			this.SumsCombo.SelectedIndexChanged += new System.EventHandler(this.SumsCombo_SelectedIndexChanged);
			// 
			// BlanksCombo
			// 
			this.BlanksCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BlanksCombo.FormattingEnabled = true;
			this.BlanksCombo.Location = new System.Drawing.Point(6, 32);
			this.BlanksCombo.Name = "BlanksCombo";
			this.BlanksCombo.Size = new System.Drawing.Size(110, 21);
			this.BlanksCombo.TabIndex = 0;
			this.BlanksCombo.SelectedIndexChanged += new System.EventHandler(this.BlanksCombo_SelectedIndexChanged);
			// 
			// ResultsGroup
			// 
			this.ResultsGroup.Controls.Add(this.ResultsText);
			this.ResultsGroup.Location = new System.Drawing.Point(12, 203);
			this.ResultsGroup.Name = "ResultsGroup";
			this.ResultsGroup.Size = new System.Drawing.Size(245, 270);
			this.ResultsGroup.TabIndex = 1;
			this.ResultsGroup.TabStop = false;
			this.ResultsGroup.Text = "asdf";
			// 
			// ResultsText
			// 
			this.ResultsText.Location = new System.Drawing.Point(9, 19);
			this.ResultsText.Multiline = true;
			this.ResultsText.Name = "ResultsText";
			this.ResultsText.Size = new System.Drawing.Size(230, 245);
			this.ResultsText.TabIndex = 0;
			// 
			// AboutContainer
			// 
			this.AboutContainer.Controls.Add(this.AboutButton);
			this.AboutContainer.Controls.Add(this.AboutLink);
			this.AboutContainer.Controls.Add(this.AboutText);
			this.AboutContainer.Location = new System.Drawing.Point(12, 479);
			this.AboutContainer.Name = "AboutContainer";
			this.AboutContainer.Size = new System.Drawing.Size(245, 52);
			this.AboutContainer.TabIndex = 2;
			this.AboutContainer.TabStop = false;
			this.AboutContainer.Text = "About";
			// 
			// AboutButton
			// 
			this.AboutButton.Location = new System.Drawing.Point(217, 11);
			this.AboutButton.Name = "AboutButton";
			this.AboutButton.Size = new System.Drawing.Size(26, 36);
			this.AboutButton.TabIndex = 2;
			this.AboutButton.Text = "?";
			this.AboutButton.UseVisualStyleBackColor = true;
			this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
			// 
			// AboutLink
			// 
			this.AboutLink.AutoSize = true;
			this.AboutLink.Location = new System.Drawing.Point(5, 32);
			this.AboutLink.Name = "AboutLink";
			this.AboutLink.Size = new System.Drawing.Size(27, 13);
			this.AboutLink.TabIndex = 1;
			this.AboutLink.TabStop = true;
			this.AboutLink.Text = "asdf";
			this.AboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLink_LinkClicked);
			// 
			// AboutText
			// 
			this.AboutText.AutoSize = true;
			this.AboutText.Location = new System.Drawing.Point(6, 16);
			this.AboutText.Name = "AboutText";
			this.AboutText.Size = new System.Drawing.Size(27, 13);
			this.AboutText.TabIndex = 0;
			this.AboutText.Text = "asdf";
			// 
			// MainLogo
			// 
			this.MainLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.MainLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainLogo.Location = new System.Drawing.Point(0, 0);
			this.MainLogo.Margin = new System.Windows.Forms.Padding(3);
			this.MainLogo.Name = "MainLogo";
			this.MainLogo.Size = new System.Drawing.Size(269, 51);
			this.MainLogo.TabIndex = 3;
			this.MainLogo.Text = "asdf";
			this.MainLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(269, 540);
			this.Controls.Add(this.MainLogo);
			this.Controls.Add(this.AboutContainer);
			this.Controls.Add(this.ResultsGroup);
			this.Controls.Add(this.OptionsGroup);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Cross Sums Helper";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.OptionsGroup.ResumeLayout(false);
			this.OptionsGroup.PerformLayout();
			this.ResultsGroup.ResumeLayout(false);
			this.ResultsGroup.PerformLayout();
			this.AboutContainer.ResumeLayout(false);
			this.AboutContainer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox OptionsGroup;
		private System.Windows.Forms.ComboBox SumsCombo;
		private System.Windows.Forms.ComboBox BlanksCombo;
		private System.Windows.Forms.GroupBox ResultsGroup;
		private System.Windows.Forms.TextBox ResultsText;
		private System.Windows.Forms.GroupBox AboutContainer;
		private System.Windows.Forms.Label AboutText;
		private System.Windows.Forms.LinkLabel AboutLink;
		private System.Windows.Forms.Label MainLogo;
		private System.Windows.Forms.CheckBox ExcludeCheck;
		private System.Windows.Forms.CheckBox IncludeCheck;
		private System.Windows.Forms.Label IncludeLabel;
		private System.Windows.Forms.Label ExcludeLabel;
		private System.Windows.Forms.Label SumLabel;
		private System.Windows.Forms.Label BlanksLabel;
		private System.Windows.Forms.TextBox ExcludeText;
		private System.Windows.Forms.TextBox IncludeText;
		private System.Windows.Forms.Button AboutButton;
		private System.Windows.Forms.Label ErrorText;
		private System.Windows.Forms.TextBox TempTextBox;
	}
}

