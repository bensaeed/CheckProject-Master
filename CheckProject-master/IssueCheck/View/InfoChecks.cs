using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueCheck.View
{
    class InfoChecks
    {
        public int ID { get; set; }
        public string Issue_date { get; set; }
        public decimal Amount { get; set; }
        public string Pay_To { get; set; }
        public string National_No { get; set; }
        public string Serial_NoPart1 { get; set; }
        public string Serial_NoPart2 { get; set; }
        public string Serial_NoPart3 { get; set; }
        public string National_No_Foreigners { get; set; }
        public string DescriptionInCheck { get; set; }
        public string DescriptionMore { get; set; }
        public int Issue_User { get; set; }
        public string Issue_Time { get; set; }
        public string Is_Cancel { get; set; }
        public int ID_User { get; set; }
        public string FullName { get; set; }
    }
}
