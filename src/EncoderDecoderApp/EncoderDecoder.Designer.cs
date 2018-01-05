namespace EncoderDecoder
{
	partial class EncoderDecoder
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
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonEncode = new System.Windows.Forms.Button();
			this.buttonDecode = new System.Windows.Forms.Button();
			this.groupBoxInput = new System.Windows.Forms.GroupBox();
			this.groupBoxOutput = new System.Windows.Forms.GroupBox();
			this.buttonSwap = new System.Windows.Forms.Button();
			this.groupBoxInput.SuspendLayout();
			this.groupBoxOutput.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxInput
			// 
			this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxInput.Location = new System.Drawing.Point(3, 16);
			this.textBoxInput.MaxLength = 1048575;
			this.textBoxInput.Multiline = true;
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxInput.Size = new System.Drawing.Size(629, 209);
			this.textBoxInput.TabIndex = 0;
			this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
			this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxOutput.Location = new System.Drawing.Point(3, 16);
			this.textBoxOutput.MaxLength = 1048575;
			this.textBoxOutput.Multiline = true;
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxOutput.Size = new System.Drawing.Size(629, 215);
			this.textBoxOutput.TabIndex = 3;
			this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
			this.textBoxOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOutput_KeyDown);
			// 
			// comboBoxType
			// 
			this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Items.AddRange(new object[] {
            "Base64"});
			this.comboBoxType.Location = new System.Drawing.Point(47, 9);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(121, 21);
			this.comboBoxType.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Type";
			// 
			// buttonEncode
			// 
			this.buttonEncode.Location = new System.Drawing.Point(174, 9);
			this.buttonEncode.Name = "buttonEncode";
			this.buttonEncode.Size = new System.Drawing.Size(75, 23);
			this.buttonEncode.TabIndex = 8;
			this.buttonEncode.Text = "Encode";
			this.buttonEncode.UseVisualStyleBackColor = true;
			this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
			// 
			// buttonDecode
			// 
			this.buttonDecode.Location = new System.Drawing.Point(255, 9);
			this.buttonDecode.Name = "buttonDecode";
			this.buttonDecode.Size = new System.Drawing.Size(75, 23);
			this.buttonDecode.TabIndex = 9;
			this.buttonDecode.Text = "Decode";
			this.buttonDecode.UseVisualStyleBackColor = true;
			this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
			// 
			// groupBoxInput
			// 
			this.groupBoxInput.Controls.Add(this.textBoxInput);
			this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBoxInput.Location = new System.Drawing.Point(0, 41);
			this.groupBoxInput.Name = "groupBoxInput";
			this.groupBoxInput.Size = new System.Drawing.Size(635, 228);
			this.groupBoxInput.TabIndex = 10;
			this.groupBoxInput.TabStop = false;
			this.groupBoxInput.Text = "Input";
			// 
			// groupBoxOutput
			// 
			this.groupBoxOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBoxOutput.Controls.Add(this.textBoxOutput);
			this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBoxOutput.Location = new System.Drawing.Point(0, 269);
			this.groupBoxOutput.Name = "groupBoxOutput";
			this.groupBoxOutput.Size = new System.Drawing.Size(635, 234);
			this.groupBoxOutput.TabIndex = 11;
			this.groupBoxOutput.TabStop = false;
			this.groupBoxOutput.Text = "Output";
			// 
			// buttonSwap
			// 
			this.buttonSwap.Location = new System.Drawing.Point(336, 9);
			this.buttonSwap.Name = "buttonSwap";
			this.buttonSwap.Size = new System.Drawing.Size(75, 23);
			this.buttonSwap.TabIndex = 12;
			this.buttonSwap.Text = "Swap";
			this.buttonSwap.UseVisualStyleBackColor = true;
			this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
			// 
			// EncoderDecoder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 503);
			this.Controls.Add(this.buttonSwap);
			this.Controls.Add(this.groupBoxInput);
			this.Controls.Add(this.buttonDecode);
			this.Controls.Add(this.buttonEncode);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxType);
			this.Controls.Add(this.groupBoxOutput);
			this.Name = "EncoderDecoder";
			this.Text = "EncoderDecoder";
			this.Resize += new System.EventHandler(this.EncoderDecoder_Resize);
			this.groupBoxInput.ResumeLayout(false);
			this.groupBoxInput.PerformLayout();
			this.groupBoxOutput.ResumeLayout(false);
			this.groupBoxOutput.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.ComboBox comboBoxType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonEncode;
		private System.Windows.Forms.Button buttonDecode;
		private System.Windows.Forms.GroupBox groupBoxInput;
		private System.Windows.Forms.GroupBox groupBoxOutput;
		private System.Windows.Forms.Button buttonSwap;
	}
}

