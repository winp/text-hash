using System;
using System.Text;
using System.Windows.Forms;


namespace TextHash {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
    }


    private void BHelp_Click(object sender, EventArgs e) {
      MessageBox.Show(Properties.Resources.Help, "Help");
    }

    private void TText_TextChanged(object sender, EventArgs e) {
      int hash = GetHashValue(TText.Text);
      LValueDec.Text = hash.ToString();
      LValueHex.Text = hash.ToString("x").ToUpper() + "h";
    }

    // Finds 8-bit hash value of given text
    private static int GetHashValue(string text) {
      int hash = 0;
      byte[] bytes = Encoding.ASCII.GetBytes(text);
      foreach (byte b in bytes) {
        int msb = (hash & 1) << 7;
        hash = msb | (hash >> 1);
        hash ^= b;
      }
      return hash;
    }
  }
}
