using IssueCheck.Classes;
using IssueCheck.View;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueCheck
{
    public partial class FrmAddEditCheck : Form
    {
        int AddEdit, CurrentIDCheck; // // 1:Add , 2:Edit , 3:View
        C_Control objC_Control = new C_Control();
        C_NumbertToString objC_NumbertToString = new C_NumbertToString();
        C_Operation objC_Operation = new C_Operation();
        C_CRUD objCRUD = new C_CRUD();
        public FrmAddEditCheck()
        {
            InitializeComponent();
            InitializeTextboxJustNumber();
        }
        List<Checks> ListOfChecks;
        public FrmAddEditCheck(object _CurrentID, object TypeAction)
        {
            CurrentIDCheck = (int)_CurrentID;
            AddEdit = (int)TypeAction;
            ListOfChecks = new List<View.Checks>();
            ListOfChecks = objC_Operation.ALLChecks();
            ListOfChecks = ListOfChecks.Where(x => x.ID == Convert.ToInt32(_CurrentID)).ToList();
            InitializeComponent();
            InitializeTextboxJustNumber();
        }

        private void FrmAddCheck_Load(object sender, EventArgs e)
        {
            txtPay_To.Focus();
            txtPay_To.TabIndex = 1;
            //Application.Run(new FrmAddCheck());
            if (AddEdit == 1)
            {
                SetDateSystem();
                SetDateToString();
            }
            else if (AddEdit == 2)
            {
                SetInfoCheckInForm();
            }
            else if (AddEdit == 3)
            {
                SetInfoCheckInForm();
                btnSave.Visible = false;
            }

        }
        
        public void SetInfoCheckInForm()
        {
            var CurrentCheckInfo = ListOfChecks.Where(x => x.ID == CurrentIDCheck).ToList();
            txtValue.Text = CurrentCheckInfo.Select(x => x.Amount).FirstOrDefault().ToString();
            txtPay_To.Text = CurrentCheckInfo.Select(x => x.Pay_To).FirstOrDefault().ToString();
            txtNo_Number.Text = CurrentCheckInfo.Select(x => x.National_No).FirstOrDefault().ToString();
            txtSerPart1.Text = CurrentCheckInfo.Select(x => x.Serial_NoPart1).FirstOrDefault().ToString();
            txtSerPart2.Text = CurrentCheckInfo.Select(x => x.Serial_NoPart2).FirstOrDefault().ToString();
            txtSerPart3.Text = CurrentCheckInfo.Select(x => x.Serial_NoPart3).FirstOrDefault().ToString();
            txtDescriptionMore.Text = CurrentCheckInfo.Select(x => x.DescriptionMore).FirstOrDefault().ToString();

            txtDatePartYear1.Text = CurrentCheckInfo.Select(x => x.Issue_date).FirstOrDefault().ToString().Substring(0, 1);
            txtDatePartYear2.Text = CurrentCheckInfo.Select(x => x.Issue_date).FirstOrDefault().ToString().Substring(1, 1);
            txtDatePartYear3.Text = CurrentCheckInfo.Select(x => x.Issue_date).FirstOrDefault().ToString().Substring(2, 1);
            txtDatePartYear4.Text = CurrentCheckInfo.Select(x => x.Issue_date).FirstOrDefault().ToString().Substring(3, 1);

            txtDatePartMonth1.Text = CurrentCheckInfo.Select(x => x.Issue_date).FirstOrDefault().ToString().Substring(4, 1);
            txtDatePartMonth2.Text = CurrentCheckInfo.Select(x => x.Issue_date).FirstOrDefault().ToString().Substring(5, 1);

            txtDatePartDay1.Text = CurrentCheckInfo.Select(x => x.Issue_date).FirstOrDefault().ToString().Substring(6, 1);
            txtDatePartDay2.Text = CurrentCheckInfo.Select(x => x.Issue_date).FirstOrDefault().ToString().Substring(7, 1);

        }

        public void InitializeTextboxJustNumber()
        {
            //TextBox tb = new TextBox();
            //this.Controls.Add(tb);
            txtDatePartYear1.KeyPress += new KeyPressEventHandler(objC_Control.keypressedJustNumber);
            txtDatePartYear2.KeyPress += new KeyPressEventHandler(objC_Control.keypressedJustNumber);
            txtDatePartYear3.KeyPress += new KeyPressEventHandler(objC_Control.keypressedJustNumber);
            txtDatePartYear4.KeyPress += new KeyPressEventHandler(objC_Control.keypressedJustNumber);
            txtDatePartMonth1.KeyPress += new KeyPressEventHandler(objC_Control.keypressedJustNumber);
            txtDatePartMonth2.KeyPress += new KeyPressEventHandler(objC_Control.keypressedJustNumber);
            txtDatePartDay1.KeyPress += new KeyPressEventHandler(objC_Control.keypressedJustNumber);
            txtDatePartDay2.KeyPress += new KeyPressEventHandler(objC_Control.keypressedJustNumber);
            txtNo_Number.KeyPress += new KeyPressEventHandler(objC_Control.keypressedJustNumber);
            txtValue.KeyPress += new KeyPressEventHandler(objC_Control.keypressedJustNumber);
        }
        public void SetDateSystem()
        {
            string DToday = objC_Control.DateToday();
            var listDate = DToday.ToCharArray().Select(c => c.ToString()).ToArray();
            txtDatePartYear1.Text = listDate[0].ToString();
            txtDatePartYear2.Text = listDate[1].ToString();
            txtDatePartYear3.Text = listDate[2].ToString();
            txtDatePartYear4.Text = listDate[3].ToString();

            txtDatePartMonth1.Text = listDate[5].ToString();
            txtDatePartMonth2.Text = listDate[6].ToString();

            txtDatePartDay1.Text = listDate[8].ToString();
            txtDatePartDay2.Text = listDate[9].ToString();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            lblValueHoroof.Text = objC_DateToString.convert_nmber(txtValue.Text.Trim());  //objC_NumbertToString.GET_Number_To_PersianString(txtValue.Text);
            lblValueHoroof.RightToLeft = RightToLeft.Yes;
            ShowValueBySplit(txtValue.Text.Trim());
        }

        public void ShowValueBySplit(string value)
        {
            setDefaultValueTextBox();
            char[] array = value.ToCharArray();
            Array.Reverse(array);
            for (int j = 0; j < array.Length; j++)
            {
                int i = (array.Length - j - 1);
                switch (i + 1)
                {
                    case 1:
                        txtVal1.Text = array[i].ToString();
                        break;
                    case 2:
                        txtVal2.Text = array[i].ToString();
                        break;
                    case 3:
                        txtVal3.Text = array[i].ToString();
                        break;
                    case 4:
                        txtVal4.Text = array[i].ToString();
                        break;
                    case 5:
                        txtVal5.Text = array[i].ToString();
                        break;
                    case 6:
                        txtVal6.Text = array[i].ToString();
                        break;
                    case 7:
                        txtVal7.Text = array[i].ToString();
                        break;
                    case 8:
                        txtVal8.Text = array[i].ToString();
                        break;
                    case 9:
                        txtVal9.Text = array[i].ToString();
                        break;
                    case 10:
                        txtVal10.Text = array[i].ToString();
                        break;
                    case 11:
                        txtVal11.Text = array[i].ToString();
                        break;
                    case 12:
                        txtVal12.Text = array[i].ToString();
                        break;
                    case 13:
                        txtVal13.Text = array[i].ToString();
                        break;
                    case 14:
                        txtVal14.Text = array[i].ToString();
                        break;
                    case 15:
                        txtVal15.Text = array[i].ToString();
                        break;
                }
            }
        }
        public void setDefaultValueTextBox()
        {
            txtVal1.Text = "*";
            txtVal2.Text = "*";
            txtVal3.Text = "*";
            txtVal4.Text = "*";
            txtVal5.Text = "*";
            txtVal6.Text = "*";
            txtVal7.Text = "*";
            txtVal8.Text = "*";
            txtVal9.Text = "*";
            txtVal10.Text = "*";
            txtVal11.Text = "*";
            txtVal12.Text = "*";
            txtVal13.Text = "*";
            txtVal14.Text = "*";
            txtVal15.Text = "*";

        }
        C_DateToString objC_DateToString = new C_DateToString();

        public string retInputDate()
        {
            // Input Date ::: 13970520
            string strDate =
            txtDatePartYear1.Text.Trim() +
            txtDatePartYear2.Text.Trim() +
            txtDatePartYear3.Text.Trim() +
            txtDatePartYear4.Text.Trim() +
            //"/" +
            txtDatePartMonth1.Text.Trim() +
            txtDatePartMonth2.Text.Trim() +
            //"/" +
            txtDatePartDay1.Text.Trim() +
            txtDatePartDay2.Text.Trim();
            return strDate;
        }
        public void SetDateToString()
        {
            string strDate;
            strDate = retInputDate();

            if (strDate.Length == 8)
            {
                lblDateHorof.Text = objC_DateToString.convert_date(objC_Control.NumberToDate(strDate));
            }
            else
            {
                lblDateHorof.Text = "............................................................";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool Succesfull;
            if (CheckState())
            {
                Succesfull =
                objCRUD.InsertCheck(
                retInputDate(),
                Convert.ToDecimal(txtValue.Text),
                txtPay_To.Text.Trim(),
                txtNo_Number.Text.Trim().Length == 10 ? txtNo_Number.Text.Trim() : "",
                txtSerPart1.Text.Trim() == null ? "" : txtSerPart1.Text.Trim(),
                txtSerPart2.Text.Trim() == null ? "" : txtSerPart2.Text.Trim(),
                txtSerPart3.Text.Trim() == null ? "" : txtSerPart3.Text.Trim(),
                txtNo_Number.Text.Trim().Length > 0 && txtNo_Number.Text.Trim().Length != 10 ? txtNo_Number.Text.Trim() : "",
                "",
                txtDescriptionMore.Text.Trim() == null ? "" : txtDescriptionMore.Text.Trim(),
                UserData.ID,
                objC_Control.TimeNow()
                );
                //Print
                if (Succesfull)
                {
                    
                    objC_Operation.PrintCheck(objC_Operation.LastID_Check());
                   
                }
                else
                {
                    MessageBox.Show("خطا در چاپ چك");
                }

            }
        }
        public bool CheckState()
        {
            bool Flag = false;

            if (retInputDate().Length != 8)
            {
                MessageBox.Show("لطفا تاریخ صدور چک را صحیح وارد کنید");
                return Flag;
            }

            if (txtPay_To.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا بخش مربوط به دریافت کننده وجه را وارد کنید");
                return Flag;
            }

            if ((txtValue.Text.Trim().Length == 0) || (Convert.ToDecimal(txtValue.Text.Trim()) < 1))
            {
                MessageBox.Show("لطفا مبلغ چک را وارد کنید");
                return Flag;
            }

            return true;
        }

        private void txtDatePartYear4_TextChanged(object sender, EventArgs e)
        {
            SetDateToString();
        }

        private void txtDatePartYear1_TextChanged(object sender, EventArgs e)
        {
            SetDateToString();
        }

        private void txtDatePartYear2_TextChanged(object sender, EventArgs e)
        {
            SetDateToString();
        }

        private void txtDatePartYear3_TextChanged(object sender, EventArgs e)
        {
            SetDateToString();
        }

        private void txtDatePartMonth1_TextChanged(object sender, EventArgs e)
        {
            SetDateToString();
        }

        private void txtDatePartMonth2_TextChanged(object sender, EventArgs e)
        {
            SetDateToString();
        }

        private void txtDatePartDay1_TextChanged(object sender, EventArgs e)
        {
            SetDateToString();
        }

        private void txtDatePartDay2_TextChanged(object sender, EventArgs e)
        {
            SetDateToString();
        }
    }
}
