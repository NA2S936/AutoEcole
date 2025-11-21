using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoEcoleEF
{
    public partial class FrmMenu : Form
    {

        private autoecoleEntities mesDonneesEF;

        public FrmMenu()
        {
            InitializeComponent();
            mesDonneesEF = new autoecoleEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
