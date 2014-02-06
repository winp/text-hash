using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sw_Hasher
{
	public partial class MainWin : Form
	{
		public MainWin()
		{
			InitializeComponent();
		}

		// Finds 8-bit hash value of given text
		private static int GetHashValue(string text)
		{
			int msbValue, hashValue = 0;
			byte[] textBytes = Encoding.ASCII.GetBytes(text);
			foreach ( byte textByte in textBytes )
			{
				msbValue = (hashValue & 1) << 7;
				hashValue = msbValue | (hashValue >> 1);
				hashValue ^= textByte;
			}
			return hashValue;
		}
		private void btnHelp_Click(object sender, EventArgs e)
		{
			string msg = "This program calculates 8-bit ROR+XOR hash value of a given text.\n\n" +
						"Algorithm:\n" +
						"hashValue = 0;\n" +
						"foreach(byte textByte in textBytes)\n" +
						"    hashValue = RotateRight8(hashValue);\n" +
						"    hashValue = Xor8(hashValue, textByte);\n" +
						"end foreach;\n" +
						"return hashValue;\n\n" +
						"Subhajit Sahu\nNIT Rourkela";
			MessageBox.Show(msg, "Help - Hasher[8-bit]");
		}
		private void txtHashText_TextChanged(object sender, EventArgs e)
		{
			int hashValue = GetHashValue(txtHashText.Text);
			lblHashValueDec.Text = hashValue.ToString();
			lblHashValueHex.Text = hashValue.ToString("x").ToUpper() + "h";
		}
	}
}
