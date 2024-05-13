using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class SifreDegistirme : Form
    {
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void grpBox_mailAlani_Enter(object sender, EventArgs e)
        {

        }

        private void button_sorgula_Click(object sender, EventArgs e)
        {

        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {
            {
                grpBox_mailAlani.Enabled = false;
                grpBox_sifreDegistirmeAlani.Enabled = false;
            }
        }
    }
}
