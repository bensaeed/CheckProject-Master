
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;
using IssueCheck.View;

namespace IssueCheck
{
    class C_CRUD
    {
        OleDbConnection cnn;
        OleDbCommand cmd;
        public void ConfigurationApp()
        {
            string _ServerAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string _DatabaseProvider = ConfigurationManager.AppSettings["DatabaseProvider"];
            cnn = new OleDbConnection(@"Provider =" + _DatabaseProvider + " Data Source =" + _ServerAddress + "\\IssueCheckDB.mdb" + " ;Persist Security Info=False; Jet OLEDB:Database Password='123456789';");
        }
        public void Open()
        {
            ConfigurationApp();
            cmd.Connection = cnn;
            cnn.Close();
            cnn.Open();
        }
        public void Close()
        {
            cnn.Close();
            cnn.Dispose();
            cnn.ResetState();
        }


        public bool InsertCheck(string _Issue_date, decimal _Amount, string _Pay_To, string _National_No, string _Serial_NoPart1, string _Serial_NoPart2, string _Serial_NoPart3,
            string _National_No_Foreigners, string _DescriptionInCheck, string _DescriptionMore, int _Issue_User, string _Issue_Time)//, string _Is_Deleted)
        {
            //int primaryKey = 0;
            bool Flag = false;
            try
            {
                cmd = new OleDbCommand();
                cmd.CommandText = "INSERT INTO  TBL_Checks"
                            + " (Issue_date,Amount,Pay_To,National_No,Serial_NoPart1,Serial_NoPart2,Serial_NoPart3,National_No_Foreigners,DescriptionInCheck,DescriptionMore,Issue_User,Issue_Time) "
                            + " VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12);";
                //,Is_Deleted,@13

                cmd.Parameters.AddWithValue("@1", _Issue_date);
                cmd.Parameters.AddWithValue("@2", _Amount);
                cmd.Parameters.AddWithValue("@3", _Pay_To);
                cmd.Parameters.AddWithValue("@4", _National_No);
                cmd.Parameters.AddWithValue("@5", _Serial_NoPart1);
                cmd.Parameters.AddWithValue("@6", _Serial_NoPart2);
                cmd.Parameters.AddWithValue("@7", _Serial_NoPart3);
                cmd.Parameters.AddWithValue("@8", _National_No_Foreigners);
                cmd.Parameters.AddWithValue("@9", _DescriptionInCheck);
                cmd.Parameters.AddWithValue("@10", _DescriptionMore);
                cmd.Parameters.AddWithValue("@11", _Issue_User);
                cmd.Parameters.AddWithValue("@12", _Issue_Time);
                Open();
                cmd.ExecuteNonQuery();
                //primaryKey = (int)(cmd.ExecuteScalar());
                Flag = true;
                Close();
                return Flag;
            }

            catch { return Flag; }
        }

        public bool UpdateCheck(string Serial_No_, string Issue_date_, decimal Amount_, string Pay_To_, string National_No_,
            string National_No_Foreigners_, string DescriptionInCheck_, string DescriptionMore_, int Issue_User_, string Issue_Time_,
            int id_)
        {
            //int primaryKey = 0;
            bool Flag = false;
            try
            {
                cmd = new OleDbCommand();
                cmd.CommandText = "UPDATE TBL_Checks SET Serial_No=@Serial_No_,Issue_date=@Issue_date_,Amount=@Amount_,Pay_To=@Pay_To_,National_No=@National_No_,National_No_Foreigners=@National_No_Foreigners_ " +
                                  ",DescriptionInCheck=@DescriptionInCheck_,DescriptionMore=@DescriptionMore_,Issue_User=@Issue_User_,Issue_Time=Issue_Time_ WHERE ID=ID_";
                cmd.Parameters.AddWithValue("@Serial_No_", Serial_No_);
                cmd.Parameters.AddWithValue("@Issue_date_", Issue_date_);
                cmd.Parameters.AddWithValue("@Amount_", Amount_);
                cmd.Parameters.AddWithValue("@Pay_To_", Pay_To_);
                cmd.Parameters.AddWithValue("@National_No_", National_No_);
                cmd.Parameters.AddWithValue("@National_No_Foreigners_", National_No_Foreigners_);
                cmd.Parameters.AddWithValue("@DescriptionInCheck_", DescriptionInCheck_);
                cmd.Parameters.AddWithValue("@DescriptionMore_", DescriptionMore_);
                cmd.Parameters.AddWithValue("@Issue_User_", Issue_User_);
                cmd.Parameters.AddWithValue("@Issue_Time_", Issue_Time_);
                cmd.Parameters.AddWithValue("@id_", id_);
                Open();
                cmd.ExecuteNonQuery();
                //primaryKey = Convert.ToInt32(cmd.ExecuteScalar());
                Flag = true;
                Close();
                return Flag;
            }
            catch { return Flag; }
        }
        public bool CancelCheck(string TBL, int _ID)
        {
            bool Flag = false;
            try
            {
                cmd = new OleDbCommand();
                //string strDELETE = string.Format(" DELETE FROM {0} WHERE ID={1}", TBL, _ID);
                string strDELETE = string.Format(" UPDATE {0} SET Is_Cancel='1' WHERE ID={1} ", TBL, _ID);
                cmd.CommandText = strDELETE;
                Open();
                cmd.ExecuteNonQuery();
                Flag = true;
                Close();
                return Flag;
            }
            catch { return Flag; }
        }
        public bool ActiveCheck(string TBL, int _ID)
        {
            bool Flag = false;
            try
            {
                cmd = new OleDbCommand();
                //string strDELETE = string.Format(" DELETE FROM {0} WHERE ID={1}", TBL, _ID);
                string strActive = string.Format(" UPDATE {0} SET Is_Cancel=null WHERE ID={1} ", TBL, _ID);
                cmd.CommandText = strActive;
                Open();
                cmd.ExecuteNonQuery();
                Flag = true;
                Close();
                return Flag;
            }
            catch { return Flag; }
        }
        public DataSet Select(string strQuery)
        {
            cmd = new OleDbCommand(strQuery, cnn);
            Open();
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet OutputDS = new DataSet();
            adp.Fill(OutputDS);
            return OutputDS;
        }
        public int last_ID(string strString)
        {
            //Open();
            //cmd.CommandText = strString;
            cmd = new OleDbCommand(strString, cnn);
            Open();
            if (cmd.ExecuteScalar() is DBNull)
            {
                Close();
                return 0;
            }
            else
            {
                int intID = Convert.ToInt32(cmd.ExecuteScalar());
                Close();
                return intID;
            }
        }
    }
}
