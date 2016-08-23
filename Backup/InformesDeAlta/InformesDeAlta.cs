using System;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;

namespace InformesDeAlta
{
    public partial class InformesDeAlta : Form
    {
        static string constr = "User Id=DIGAWEB;Password=DIGAWEB;Data Source=DESARROLLO;Enlist=false;Pooling=true";
        OracleConnection con = new OracleConnection(constr);
        public InformesDeAlta()
        {
            InitializeComponent();
        }

        private void InformesDeAlta_Load(object sender, EventArgs e)
        {
            con.Open();
            string cmdStr = "SELECT ROWID, IALNHIS, IALNREF, IALINFO FROM VLMFIAL WHERE ROWNUM = 1";
            OracleCommand cmd = new OracleCommand(cmdStr, con);
            OracleTransaction txn = con.BeginTransaction();
            OracleDataReader reader = cmd.ExecuteReader();
            OracleClob Clob_IALINFO;
            reader.Read();
            if (!reader.IsDBNull(0))
            {
                //Clob_IALINFO = reader.GetOracleClobForUpdate(3);
                Clob_IALINFO = reader.GetOracleClob(3);
                // Close the reader
                reader.Close();
                rTxt_Informe.Text = Clob_IALINFO.Value;
                // Update the job description Clob object
                //char[] jobDesc = "-SALES".ToCharArray();
                //Clob_IALINFO.Append(jobDesc, 0, jobDesc.Length);
                // Now commit the transaction
                txn.Commit();
            }
            else
                reader.Close();
        }

        private void InformesDeAlta_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
            con.Dispose();
        }
    }
}
