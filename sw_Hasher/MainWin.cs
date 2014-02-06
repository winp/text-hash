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
			byte hashValue = 0;
			byte[] textBytes = Encoding.ASCII.GetBytes(text);
			foreach ( byte textByte in textBytes )
			{
				hashValue ^= textByte;
			}
			return hashValue;
		}
		private void btnHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Text", "Help - Hasher[8-bit]");
		}
		private void txtHashText_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
