using IssueCheck.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueCheck
{
    class C_Control
    {

        public void keypressedJustNumber(Object o, KeyPressEventArgs e)
        {
            // The keypressed method uses the KeyChar property to check 
            // whether the ENTER key is pressed. 

            // If the ENTER key is pressed, the Handled property is set to true, 
            // to indicate the event is handled.

            //if (e.KeyChar == (char)Keys.Return)
            //{
            //    e.Handled = true;
            //}
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
        public void keypressedJustMoney(Object o, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
        public void keypressedNotAction(Object o, KeyPressEventArgs e)
        {
                e.Handled = false;
        }
        public string Loginname()
        {
            return UserData.Firstname + " " + UserData.LastName;
        }
        public string DateToday()
        {
            var persianDateTimeNow = PersianDateTime.Now;
            //persianDateTimeNow.EnglishNumber = true;
            return persianDateTimeNow.ToString("yyyy/MM/dd");
        }
        public string TimeNow()
        {
            return DateTime.Now.ToString("HH:mm");
        }
        public string DateToNumber(string strDate)
        {
            strDate = strDate.Trim();
            if ((strDate == "" && strDate == null) || (strDate.Length != 10))
                return "";
            return strDate.Replace("/", "");
        }
        public string NumberToDate(string strDate)
        {
            strDate = strDate.Trim();
            string strResultPart1 = "", strResultPart2 = "", strResultPart3 = "";
            if ((strDate == "" && strDate == null) || (strDate.Length !=8)) 
            {
                return "";
            }
            else
            {
                strResultPart1 = strDate.Substring(0, 4) + "/";
                strResultPart2 = strDate.Substring(4, 2) + "/";
                strResultPart3 = strDate.Substring(6, 2);
                return strResultPart1 + strResultPart2 + strResultPart3;
            }
        }
    }
}
