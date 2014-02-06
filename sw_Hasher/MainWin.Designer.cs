namespace sw_Hasher
{
	partial class MainWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
			this.txtHashText = new System.Windows.Forms.TextBox();
			this.lblHashText = new System.Windows.Forms.Label();
			this.lblHashValue = new System.Windows.Forms.Label();
			this.lblHashValueDec = new System.Windows.Forms.Label();
			this.lblHashValueHex = new System.Windows.Forms.Label();
			this.btnHelp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtHashText
			// 
			this.txtHashText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHashText.Location = new System.Drawing.Point(18, 45);
			this.txtHashText.Multiline = true;
			this.txtHashText.Name = "txtHashText";
			this.txtHashText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtHashText.Size = new System.Drawing.Size(279, 202);
			this.txtHashText.TabIndex = 0;
			this.txtHashText.TextChanged += new System.EventHandler(this.txtHashText_TextChanged);
			// 
			// lblHashText
			// 
			this.lblHashText.AutoSize = true;
			this.lblHashText.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHashText.Location = new System.Drawing.Point(12, 9);
			this.lblHashText.Name = "lblHashText";
			this.lblHashText.Size = new System.Drawing.Size(119, 33);
			this.lblHashText.TabIndex = 1;
			this.lblHashText.Text = "Hash Text";
			// 
			// lblHashValue
			// 
			this.lblHashValue.AutoSize = true;
			this.lblHashValue.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHashValue.Location = new System.Drawing.Point(334, 9);
			this.lblHashValue.Name = "lblHashValue";
			this.lblHashValue.Size = new System.Drawing.Size(134, 33);
			this.lblHashValue.TabIndex = 2;
			this.lblHashValue.Text = "Hash Value";
			// 
			// lblHashValueDec
			// 
			this.lblHashValueDec.AutoSize = true;
			this.lblHashValueDec.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHashValueDec.Location = new System.Drawing.Point(326, 45);
			this.lblHashValueDec.Name = "lblHashValueDec";
			this.lblHashValueDec.Size = new System.Drawing.Size(69, 81);
			this.lblHashValueDec.TabIndex = 3;
			this.lblHashValueDec.Text = "0";
			// 
			// lblHashValueHex
			// 
			this.lblHashValueHex.AutoSize = true;
			this.lblHashValueHex.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHashValueHex.Location = new System.Drawing.Point(326, 126);
			this.lblHashValueHex.Name = "lblHashValueHex";
			this.lblHashValueHex.Size = new System.Drawing.Size(104, 81);
			this.lblHashValueHex.TabIndex = 4;
			this.lblHashValueHex.Text = "0h";
			// 
			// btnHelp
			// 
			this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHelp.Location = new System.Drawing.Point(490, 9);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(30, 31);
			this.btnHelp.TabIndex = 5;
			this.btnHelp.Text = "?";
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// MainWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 270);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.lblHashValueHex);
			this.Controls.Add(this.lblHashValueDec);
			this.Controls.Add(this.lblHashValue);
			this.Controls.Add(this.lblHashText);
			this.Controls.Add(this.txtHashText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWin";
			this.Text = "Hasher [8-bit] v0.2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtHashText;
		private System.Windows.Forms.Label lblHashText;
		private System.Windows.Forms.Label lblHashValue;
		private System.Windows.Forms.Label lblHashValueDec;
		private System.Windows.Forms.Label lblHashValueHex;
		private System.Windows.Forms.Button btnHelp;
	}
}

