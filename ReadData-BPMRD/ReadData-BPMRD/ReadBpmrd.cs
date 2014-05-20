using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ReadData_BPMRD
{
    
    public partial class ReadBpmrd : Form
    {
        public ReadBpmrd()
        {
            InitializeComponent();
        }

        OracleConnection bpmrdconn;

     // Function to connect to the DB
        public void bpmrd_Connect()
        {
            try
            {
                OracleConnection bpmrdconn = new OracleConnection();
                bpmrdconn.ConnectionString = "Data Source=EDGDCMT.DB.ATT.COM;User ID=sb834g;Password=Arthur@80;Unicode=True";
                bpmrdconn.Open();
                ConnStat.Text = "Connected to BPMRD TEST !!!";
            }
            catch (Exception ex)
            {
                ConnStat.Text = "Connection Failed !!!";
            }
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            bpmrd_Connect();
            bpmrdconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection bpmrdconn = new OracleConnection();
                bpmrdconn.ConnectionString = "Data Source=EDGDCMT.DB.ATT.COM;User ID=sb834g;Password=Arthur@80;Unicode=True";
                bpmrdconn.Open();
                ConnStat.Text = "Connected to BPMRD TEST !!!";


                OracleCommand cmd = new OracleCommand("Select * from EDGEMW.IDDB_DAILY_RULES", bpmrdconn);
                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                dataGridView1.DataSource = ds.Tables["ss"];
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
