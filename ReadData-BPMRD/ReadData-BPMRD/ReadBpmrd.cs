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
    public partial class ReadBpmrd : Form
    {
        public ReadBpmrd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.OracleClient.OracleConnection bpmrdconn = new System.Data.OracleClient.OracleConnection();
                bpmrdconn.ConnectionString = "Data Source=EDGDCMT.DB.ATT.COM;User ID=sb834g;Password=Arthur@80;Unicode=True";
                bpmrdconn.Open();
                ConnStat.Text = "Connected to BPMRD TEST !!!";
            }
            catch (Exception ex)
            {
                ConnStat.Text = "Connection Failed !!!";
            }
                
        }
    }
}
