using IssueCheck.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueCheck
{
    public partial class FrmManageChecks : Form
    {
        int Duration = 0;
        int FlagFirstLoad = 0;
        public FrmManageChecks()
        {
            InitializeComponent();
        }
        int CurrentRowID = 0;
        List<Checks> ListOfChecks;//= new List<Checks>();
        List<Users> ListOfUsers;
        List<InfoChecks> ListInfoChecks;
        List<InfoChecks> SearchList;
        string DToday;
        private void FrmManageChecks_Load(object sender, EventArgs e)
        {
            DToday = objC_Control.DateToday();
            SetCombobox();
            ListOfChecks = new List<Checks>();
            ListOfUsers = new List<Users>();
            ListInfoChecks = new List<InfoChecks>();

            ListOfChecks = objC_Operation.ALLChecks();
            ListOfUsers = objC_Operation.ALLUsers();

            ListInfoChecks = (from n in ListOfChecks
                              join u in ListOfUsers on n.Issue_User equals u.ID
                              orderby n.ID descending
                              select new InfoChecks
                              {
                                  ID = n.ID,
                                  Issue_date = n.Issue_date,
                                  Amount = n.Amount,
                                  Pay_To = n.Pay_To,
                                  National_No = n.National_No,
                                  Serial_NoPart1 = n.Serial_NoPart1,
                                  Serial_NoPart2 = n.Serial_NoPart2,
                                  Serial_NoPart3 = n.Serial_NoPart3,
                                  DescriptionMore = n.DescriptionMore,
                                  ID_User = u.ID,
                                  FullName = u.Firstname + " " + u.LastName,
                                  Is_Cancel = n.Is_Cancel
                              }).ToList();
            // پر کردن لیست تو در تو 
            //for(int i=0;i<ListOfChecks.Count();i++)
            //{
            //    int CrrUSID = ListOfChecks[i].Issue_User;
            //    ListOfChecks[i].ListUsers = ListOfUsers.Where(x => x.ID == CrrUSID).ToList();
            //}

            ShowDataInGrid();
        }
        C_Operation objC_Operation = new C_Operation();
        public void ShowDataInGrid()
        {
            createDataGridView();
            SearchDateInGrid();
            //ListInfoChecks = ListInfoChecks.Where(x => x.Issue_date.Substring(0, 6) == (DToday.Substring(0, 4) + DToday.Substring(5, 2))).ToList();
            //if (rBtnIssue.Checked == true)
            //{
            //    dGChecks.DataSource = ListInfoChecks.Where(x => x.Is_Cancel != "1").ToList();
            //}
            //else if (rBtnCancel.Checked == true)
            //{
            //    dGChecks.DataSource = ListInfoChecks.Where(x => x.Is_Cancel == "1").ToList();
            //}
            //else
            //{
            //    //rBtnAll.Checked==true
            //    // dGChecks.DataSource = ListOfChecks;
            //    dGChecks.DataSource = ListInfoChecks;
            //}
        }

        public void createDataGridView()
        {
            dGChecks.AutoGenerateColumns = false;
            dGChecks.Columns.Clear();
            GridSetStyle();
        }
        private void GridSetStyle()
        {
            objC_Operation.AddDGVCol("ID", "شناسه", 50, dGChecks);
            objC_Operation.AddDGVCol("Issue_date", "تاریخ صدور", 60, dGChecks);
            objC_Operation.AddDGVCol("Amount", " مبلغ ", 90, dGChecks);
            objC_Operation.AddDGVCol("Pay_To", " در وجه ", 100, dGChecks);
            objC_Operation.AddDGVCol("National_No", "شماره ملی", 70, dGChecks);
            objC_Operation.AddDGVCol("Serial_NoPart1", "سریال چک 1", 75, dGChecks);
            objC_Operation.AddDGVCol("Serial_NoPart2", "سریال چک 2", 75, dGChecks);
            objC_Operation.AddDGVCol("Serial_NoPart3", "سریال چک 3", 80, dGChecks);
            objC_Operation.AddDGVCol("DescriptionMore", " توضیحات ", 150, dGChecks);
            objC_Operation.AddDGVCol("FullName", " صادر کننده ", 90, dGChecks);
        }

        private void rBtnIssue_CheckedChanged(object sender, EventArgs e)
        {
            //SearchDateInGrid();
        }

        private void rBtnCancel_CheckedChanged(object sender, EventArgs e)
        {
            //SearchDateInGrid();
        }

        private void rBtnAll_CheckedChanged(object sender, EventArgs e)
        {
            //SearchDateInGrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // 1:Add , 2:Edit
            FrmAddEditCheck objFrmAddEditCheck = new IssueCheck.FrmAddEditCheck(0, 1);
            objFrmAddEditCheck.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchDateInGrid();

            //C_Control objC_Control = new C_Control();
            // MessageBox.Show(objC_Control.DateToNumber(txtDateFrom.Text));
            //MessageBox.Show(objC_Control.NumberToDate(txtDateFrom.Text));
        }
        C_Control objC_Control = new C_Control();
        public void SearchDateInGrid()
        {
            //createDataGridView();
            SearchList = new List<InfoChecks>();
            SearchList = ListInfoChecks;

            //string DToday = objC_Control.DateToday();
            if (Duration == 0) // ماه جاري
            {
                SearchList = SearchList.Where(x => x.Issue_date.Substring(0, 6) == (DToday.Substring(0, 4) + DToday.Substring(5, 2))).ToList();
            }
            else if (Duration == 1) //  سال جاري
            {
                SearchList = SearchList.Where(x => x.Issue_date.Substring(0, 4) == (DToday.Substring(0, 4))).ToList();
            }


            if (rBtnIssue.Checked == true)
            {
                SearchList = SearchList.Where(x => x.Is_Cancel != "1").ToList();
            }
            else if (rBtnCancel.Checked == true)
            {
                SearchList = SearchList.Where(x => x.Is_Cancel == "1").ToList();
            }
            else
            {
                //rBtnAll.Checked==true   
            }
            if (txtDateFrom.Text.Trim().Length == 8)
                SearchList = SearchList.Where(x => x.Issue_date.CompareTo(txtDateFrom.Text.Trim()) >= 0).ToList();

            if (txtDateTo.Text.Trim().Length == 8)
                SearchList = SearchList.Where(x => x.Issue_date.CompareTo(txtDateTo.Text.Trim()) <= 0).ToList();

            if (!((txtValueFrom.Text.Trim() == "") || (txtValueFrom.Text.Trim() == null)))
                SearchList = SearchList.Where(x => x.Amount >= Convert.ToDecimal(txtValueFrom.Text.Trim())).ToList();

            if (!((txtValueTo.Text.Trim() == "") || (txtValueTo.Text.Trim() == null)))
                SearchList = SearchList.Where(x => x.Amount <= Convert.ToDecimal(txtValueTo.Text.Trim())).ToList();

            if (!((txtPay_To.Text.Trim() == "") || (txtPay_To.Text.Trim() == null)))
                SearchList = SearchList.Where(x => x.Pay_To.Contains(txtPay_To.Text.Trim())).ToList();


            dGChecks.DataSource = SearchList;
        }

        private void txtDateFrom_TextChanged(object sender, EventArgs e)
        {
            //SearchDateInGrid();
        }

        private void txtDateTo_TextChanged(object sender, EventArgs e)
        {
            // SearchDateInGrid();
        }

        private void txtValueFrom_TextChanged(object sender, EventArgs e)
        {
            // SearchDateInGrid();
        }

        private void txtValueTo_TextChanged(object sender, EventArgs e)
        {
            //SearchDateInGrid();
        }

        private void txtPay_To_TextChanged(object sender, EventArgs e)
        {
            //SearchDateInGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        C_CRUD objC_CRUD = new C_CRUD();
        private void btnCancelCheck_Click(object sender, EventArgs e)
        {
            CurrentRowID = 0;
            try
            {
                CurrentRowID = Convert.ToInt32(dGChecks.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }
            if (CurrentRowID != 0)
            {
                string message = "  آیا مطمئن هستید چک مورد نظر ابطال شود ؟   ";
                string caption = " Delete  ";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        // Del_id__ = dGV_buyInvoice .CurrentRow.Cells[0].Value.ToString();

                        //dGChecks.Rows.RemoveAt(dGChecks.SelectedRows[0].Index);
                        if (objC_CRUD.CancelCheck("TBL_Checks", CurrentRowID))
                        {
                            MessageBox.Show("چک مورد نظر با موفقیت باطل گردید");
                            FrmManageChecks_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("خطا در ابطال چک");
                        }
                    }
                    catch { }
                }

            }
            else
            { MessageBox.Show("   هیچ چک ی برای ابطال شدن وجود ندارد   "); }
        }

        private void btnActiveCheck_Click(object sender, EventArgs e)
        {
            CurrentRowID = 0;
            try
            {
                CurrentRowID = Convert.ToInt32(dGChecks.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }
            var StatusCheck = ListOfChecks.Where(x => x.ID == CurrentRowID);
            if (StatusCheck.Where(x => x.Is_Cancel != "1").Count() >= 1)
            {
                MessageBox.Show("این چک در سیستم جاری می باشد و امکان ابطال آن وجود ندارد");
            }
            else
            {
                if (CurrentRowID != 0)
                {
                    string message = "  آیا مطمئن هستید چک مورد نظر از حالت ابطال خارج و در سیستم جاری شود ؟   ";
                    string caption = " To Active  ";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            if (objC_CRUD.ActiveCheck("TBL_Checks", CurrentRowID))
                            {
                                MessageBox.Show("چک مورد نظر با موفقیت از حالت ابطال خارج و به حالت جاری تبدیل گردید");
                                FrmManageChecks_Load(null, null);
                            }
                            else
                            {
                                MessageBox.Show("خطا در خروج از حالت ابطال چک");
                            }
                        }
                        catch { }
                    }

                }
                else
                {
                    MessageBox.Show("  هیچ چک ی برای خروج از حالت ابطال وجود ندارد   ");
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            CurrentRowID = Convert.ToInt32(dGChecks.CurrentRow.Cells[0].Value.ToString());

            if (CurrentRowID == 0)
            {
                MessageBox.Show(" لطفا يكي از سطرها را انتخاب كنيد");
            }
            else
            {
                objC_Operation.PrintCheck(CurrentRowID);

                //if (objC_Operation.PrintCheck(CurrentRowID))
                // {
                //    MessageBox.Show("چاپ با موفقيت انجام شد");
                // }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CurrentRowID = Convert.ToInt32(dGChecks.CurrentRow.Cells[0].Value.ToString());

            if (CurrentRowID == 0)
            {
                MessageBox.Show(" لطفا يكي از سطرها را انتخاب كنيد");
            }
            else
            {
                // 1:Add , 2:Edit , 3:View
                FrmAddEditCheck objFrmAddEditCheck = new IssueCheck.FrmAddEditCheck(CurrentRowID, 2);
                objFrmAddEditCheck.ShowDialog();
            }

        }


        private void btnView_Click(object sender, EventArgs e)
        {
            CurrentRowID = Convert.ToInt32(dGChecks.CurrentRow.Cells[0].Value.ToString());

            if (CurrentRowID == 0)
            {
                MessageBox.Show(" لطفا يكي از سطرها را انتخاب كنيد");
            }
            else
            {
                // 1:Add , 2:Edit , 3:View
                FrmAddEditCheck objFrmAddEditCheck = new IssueCheck.FrmAddEditCheck(CurrentRowID, 3);
                objFrmAddEditCheck.ShowDialog();
            }
        }

        public void SetCombobox()
        {
            CmbDuration.Items.Add("ماه جاري");
            FlagFirstLoad = 0;
            CmbDuration.Items.Add("سال جاري");
            FlagFirstLoad = 0;
            CmbDuration.Items.Add("همه");
            FlagFirstLoad = 0;
            CmbDuration.SelectedIndex = 0;
            
        }

        private void CmbDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            Duration = CmbDuration.SelectedIndex;
            if (FlagFirstLoad > 0)
            {
                SearchDateInGrid();
            }
            FlagFirstLoad++;
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            objC_Operation.PrintReportCheck(SearchList);
        }
    
    }
}
