namespace TextHash
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
			if ( disposing && (components != null) )
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.TText = new System.Windows.Forms.TextBox();
      this.LText = new System.Windows.Forms.Label();
      this.LValue = new System.Windows.Forms.Label();
      this.LValueDec = new System.Windows.Forms.Label();
      this.LValueHex = new System.Windows.Forms.Label();
      this.BHelp = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // TText
      // 
      this.TText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TText.Location = new System.Drawing.Point(18, 45);
      this.TText.Multiline = true;
      this.TText.Name = "TText";
      this.TText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.TText.Size = new System.Drawing.Size(279, 202);
      this.TText.TabIndex = 0;
      this.TText.TextChanged += new System.EventHandler(this.TText_TextChanged);
      // 
      // LText
      // 
      this.LText.AutoSize = true;
      this.LText.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LText.Location = new System.Drawing.Point(12, 9);
      this.LText.Name = "LText";
      this.LText.Size = new System.Drawing.Size(119, 33);
      this.LText.TabIndex = 1;
      this.LText.Text = "Hash Text";
      // 
      // LValue
      // 
      this.LValue.AutoSize = true;
      this.LValue.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LValue.Location = new System.Drawing.Point(334, 9);
      this.LValue.Name = "LValue";
      this.LValue.Size = new System.Drawing.Size(134, 33);
      this.LValue.TabIndex = 2;
      this.LValue.Text = "Hash Value";
      // 
      // LValueDec
      // 
      this.LValueDec.AutoSize = true;
      this.LValueDec.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LValueDec.Location = new System.Drawing.Point(326, 45);
      this.LValueDec.Name = "LValueDec";
      this.LValueDec.Size = new System.Drawing.Size(69, 81);
      this.LValueDec.TabIndex = 3;
      this.LValueDec.Text = "0";
      // 
      // LValueHex
      // 
      this.LValueHex.AutoSize = true;
      this.LValueHex.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LValueHex.Location = new System.Drawing.Point(326, 126);
      this.LValueHex.Name = "LValueHex";
      this.LValueHex.Size = new System.Drawing.Size(104, 81);
      this.LValueHex.TabIndex = 4;
      this.LValueHex.Text = "0h";
      // 
      // BHelp
      // 
      this.BHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BHelp.Location = new System.Drawing.Point(490, 9);
      this.BHelp.Name = "BHelp";
      this.BHelp.Size = new System.Drawing.Size(30, 31);
      this.BHelp.TabIndex = 5;
      this.BHelp.Text = "?";
      this.BHelp.UseVisualStyleBackColor = true;
      this.BHelp.Click += new System.EventHandler(this.BHelp_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(532, 270);
      this.Controls.Add(this.BHelp);
      this.Controls.Add(this.LValueHex);
      this.Controls.Add(this.LValueDec);
      this.Controls.Add(this.LValue);
      this.Controls.Add(this.LText);
      this.Controls.Add(this.TText);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "TextHash [8-bit ROR+XOR]";
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TText;
		private System.Windows.Forms.Label LText;
		private System.Windows.Forms.Label LValue;
		private System.Windows.Forms.Label LValueDec;
		private System.Windows.Forms.Label LValueHex;
		private System.Windows.Forms.Button BHelp;
	}
}

