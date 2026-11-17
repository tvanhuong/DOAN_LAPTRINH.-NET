using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiem.GUI
{
    public partial class frmFlash : Form
    {
        public frmFlash()
        {
            InitializeComponent();
        }

        private void frmFlash_Load(object sender, EventArgs e)
        {
            timer1.Interval = 3000; // Hiện 3 giây (3000 milliseconds)
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
    }
}
