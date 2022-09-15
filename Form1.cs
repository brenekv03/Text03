using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                int pcradku = 0;
                while(!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    if (char.IsUpper(line[0]) && line[line.Length-2]!='.'&& line.EndsWith(".")) pcradku++;
                }
                MessageBox.Show("Řádků velkým písmenem začínajících a končících tečkou je: " + pcradku);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
