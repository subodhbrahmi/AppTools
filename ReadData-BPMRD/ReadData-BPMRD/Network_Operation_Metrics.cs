using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadData_BPMRD
{
    public partial class Network_Operation_Metrics : Form
    {
        public Network_Operation_Metrics()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Network_Operation_Metrics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.BPMMETRICS' table. You can move, or remove it, as needed.
            this.bPMMETRICSTableAdapter.Fill(this.dataSet1.BPMMETRICS);

        }
    }
}
