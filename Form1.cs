using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_bancuuchuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            lsbketqua.Items.Clear();
            int cc = Convert.ToInt32(txtso.Text);
            for(int i= 1; i<= 10; i++)
            {
                lsbketqua.Items.Add(string.Format("{0}x(1)=(2)",txtso.Text,i.ToString(),Convert.ToString (cc * i)));
                

                
            }
        }
    }
}
