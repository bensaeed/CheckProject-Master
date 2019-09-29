using IssueCheck.Classes;
using IssueCheck.View;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueCheck
{

    class C_Operation
    {
        //int CurrentUserID=0;
        DataSet ds;
        C_CRUD objC_CRUD = new C_CRUD();
        UserData objUserData = new UserData();
        C_DateToString objC_DateToString = new C_DateToString();
        C_Control objC_Control = new C_Control();
        public bool LoginUser(string _Login, string _Password)
        {
            var lstUsers = ALLUsers();
            lstUsers = lstUsers.Where(x => x.LoginName == _Login && x.Password == _Password).ToList();
            if (lstUsers.Count() > 0)
            {
                // CurrentUserID = lstUsers.FirstOrDefault().ID;

                UserData.ID = lstUsers.First().ID;
                UserData.LoginName = lstUsers.First().LastName;
                UserData.Firstname = lstUsers.First().Firstname;
                UserData.LastName = lstUsers.First().LastName;

                return true;
            }
            return false;
        }
        public List<Users> ALLUsers()
        {
            List<Users> lstUsers = new List<Users>();
            ds = new DataSet();
            ds = objC_CRUD.Select(" SELECT * FROM TBL_Users ");
            if (ds != null)
            {
                lstUsers = ds.Tables[0].AsEnumerable().Select(
                          dataRow => new Users
                          {
                              LoginName = dataRow.Field<string>("LoginName"),
                              Password = dataRow.Field<string>("Password"),
                              Firstname = dataRow.Field<string>("Firstname"),
                              LastName = dataRow.Field<string>("LastName"),
                              //FullName = dataRow.Field<string>("Firstname") + " " + dataRow.Field<string>("LastName"),
                              National_No = dataRow.Field<string>("National_No"),
                              Description = dataRow.Field<string>("Description"),
                              ID = dataRow.Field<int>("ID")
                          }).ToList();
            }
            return lstUsers;
        }
        public List<Checks> ALLChecks()
        {
            List<Checks> lstChecks = new List<Checks>();
            ds = new DataSet();
            ds = objC_CRUD.Select(" SELECT * FROM TBL_Checks where id is not null ");
            if (ds != null)
            {
                lstChecks = ds.Tables[0].AsEnumerable().Select(
                          dataRow => new Checks
                          {
                              ID = (dataRow.Field<int>("ID")),
                              Issue_date = dataRow.Field<string>("Issue_date"),
                              Amount = dataRow.Field<decimal>("Amount"),
                              Pay_To = dataRow.Field<string>("Pay_To"),
                              National_No = dataRow.Field<string>("National_No"),
                              Serial_NoPart1 = dataRow.Field<string>("Serial_NoPart1"),
                              Serial_NoPart2 = dataRow.Field<string>("Serial_NoPart2"),
                              Serial_NoPart3 = dataRow.Field<string>("Serial_NoPart3"),
                              National_No_Foreigners = dataRow.Field<string>("National_No_Foreigners"),
                              DescriptionInCheck = dataRow.Field<string>("DescriptionInCheck"),
                              DescriptionMore = dataRow.Field<string>("DescriptionMore"),
                              Issue_User = 1,//Convert.ToInt32(dataRow.Field<int>("Issue_User")),
                              Issue_Time = dataRow.Field<string>("Issue_Time"),
                              Is_Cancel = dataRow.Field<string>("Is_Cancel")
                          }).ToList();
            }
            return lstChecks;
        }
        public int LastID_Check()
        {
            int LstID=0;
            string strCommand = " SELECT Last(ID) FROM TBL_Checks";//"SELECT SCOPE_IDENTITY()";  
            LstID = objC_CRUD.last_ID(strCommand);
            return LstID;
        }
        //public int LastIDInserted()
        //{
        //    int LastID = 0;
        //    ds = new DataSet();
        //    ds = objC_CRUD.Select(" SELECT SCOPE_IDENTITY() ");
        //    if (ds != null)
        //    {
        //        LastID =Convert.ToInt32 (ds.Tables[0].AsEnumerable().Select(dataRow => dataRow.Field<int>("ID")).ToString());
        //     }
        //    return LastID;

        //}
        //**************************** creat datagrid *************
        public void AddDGVCol(string strDataPropertyName, string strName, int intWidth, DataGridView ODataGridView)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = strDataPropertyName;
            col.Name = strName;
            col.Width = intWidth;
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
            ODataGridView.Columns.Add(col);
        }

        //****************************** Print ********************
        public bool PrintCheck(int IDCheck)
        {
            if (IDCheck == 0)
            {
                return false;
            }
            else
            {
                var CurrentCheck = ALLChecks().Where(x => x.ID == IDCheck);

                var report = new StiReport();
                var StartPathReport = (Application.StartupPath).Replace("\\bin\\Debug","");
                
                report.Load(StartPathReport + ("\\Reports\\Check.mrt"));
                //report.Dictionary.DataStore.Clear();
                //CurrentCheck.Select(x => x.Issue_date).FirstOrDefault();
                report.Dictionary.Variables["DateReport"].ValueObject = CurrentCheck.Select(x => x.Issue_date).FirstOrDefault(); //Roozh.GregorianToPersian(DateTime.Today).ToString();
                var StrDate = objC_Control.NumberToDate(CurrentCheck.Select(x => x.Issue_date).FirstOrDefault());
                report.Dictionary.Variables["DateHorof"].ValueObject = objC_DateToString.convert_date(StrDate).ToString();

                //(string.IsNullOrEmpty(value) ? true : false || string.IsNullOrWhiteSpace(value) ? true : false);

                report.Dictionary.Variables["SerialPart1"].ValueObject = string.IsNullOrEmpty(CurrentCheck.Select(x => x.Serial_NoPart1).FirstOrDefault().ToString()) ? "" : CurrentCheck.Select(x => x.Serial_NoPart1).FirstOrDefault().ToString();
                report.Dictionary.Variables["SerialPart2"].ValueObject = string.IsNullOrEmpty(CurrentCheck.Select(x => x.Serial_NoPart2).FirstOrDefault().ToString()) ? "" : CurrentCheck.Select(x => x.Serial_NoPart2).FirstOrDefault().ToString();
                report.Dictionary.Variables["SerialPart3"].ValueObject = string.IsNullOrEmpty(CurrentCheck.Select(x => x.Serial_NoPart3).FirstOrDefault().ToString()) ? "" : CurrentCheck.Select(x => x.Serial_NoPart3).FirstOrDefault().ToString();
                report.Dictionary.Variables["CheckValue"].ValueObject = CurrentCheck.Select(x => x.Amount).FirstOrDefault().ToString();
                report.Dictionary.Variables["ValueHoroof"].ValueObject = objC_DateToString.convert_nmber(CurrentCheck.Select(x => x.Amount).FirstOrDefault().ToString());
                report.Dictionary.Variables["No_Number"].ValueObject = string.IsNullOrEmpty(CurrentCheck.Select(x => x.National_No).FirstOrDefault().ToString()) ? "" : CurrentCheck.Select(x => x.National_No).FirstOrDefault().ToString();
                report.Show();

                return true;
            }
        }
     public bool PrintReportCheck(List<InfoChecks> listData)
        {
            if (listData == null)
            {
                MessageBox.Show(" هيچ اطلاعاتي براي نمايش وجود ندارد");
                return false;
            }
            else
            {
               
                var report = new StiReport();
                report.Load(Application.StartupPath + ("\\Reports\\ListCheck.mrt"));
                report.Dictionary.DataStore.Clear();
                report.Dictionary.Variables["Reporter"].ValueObject = objC_Control.Loginname();
                report.Dictionary.Variables["DateReport"].ValueObject = objC_Control.DateToday();
                report.RegBusinessObject("CheckInfo", listData);
                report.Show();

                return true;
            }
        }

   
    }
}
