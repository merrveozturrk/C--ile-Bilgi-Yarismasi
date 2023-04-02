using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarisması
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();   
            
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();

        }
    }
}
