using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueCheck.Classes
{
    class C_DateToString
    {
        string[] handered = new string[10] {"", "يكصد","دويست", "سيصد", "چهارصد",
                                             "پانصد", "ششصد", "هفتصد", "هشتصد",  "نهصد"};
        string[] letter1_100 = new string[100] {"", "يك", "دو", "سه", "چهار","پنج", "شش", "هفت", "هشت",
            "نه",            "ده", "يازده",  "دوازده", "سيزده", "چهارده",  "پانزده",  "شانزده", "هفده",
            "هجده", "نوزده", "بيست", "بيست و يك",  "بيست و دو",  "بيست و سه",  "بيست و چهار",
            "بيست و پنج", "بيست و شش", "بيست و هفت", "بيست و هشت", "بيست و نه",  "سي",  "سي و يك",
            "سي و دو", "سي و سه","سي و چهار","سي و پنج", "سي و شش", "سي و هفت", "سي و هشت", "سي و نه",
            "چهل", "چهل و يك", "چهل و دو", "چهل و سه", "چهل و چهار", "چهل و پنج", "چهل و شش",
            "چهل و هفت", "چهل و هشت", "چهل و نه","پنجاه", "پنجاه و يك", "پنجاه و دو", "پنجاه و سه",
            "پنجاه و چهار", "پنجاه و پنج", "پنجاه و شش", "پنجاه و هفت","پنجاه و هشت", "پنجاه و نه", "شصت",
            "شصت و يك", "شصت و دو", "شصت و سه", "شصت و چهار", "شصت و پنج", "شصت و شش","شصت و هفت",
            "شصت و هشت", "شصت و نه", "هفتاد", "هفتاد و يك", "هفتاد و دو", "هفتاد و سه", "هفتاد و چهار",
            "هفتاد و پنج", "هفتاد و شش", "هفتاد و هفت", "هفتاد و هشت", "هفتاد و نه", "هشتاد","هشتاد و يك",
            "هشتاد و دو", "هشتاد و سه", "هشتاد و چهار", "هشتاد و پنج", "هشتاد و شش", "هشتاد و هفت",
            "هشتاد و هشت","هشتاد و نه","نود", "نود و يك", "نود و دو", "نود و سه", "نود و چهار", "نود و پنج",
            "نود و شش", "نود و هفت", "نود و هشت", "نود و نه"};
        string[] month = new string[12] {"فروردين","ارديبهشت", "خرداد","تير", "مرداد", "شهريور", "مهر",
            "آبان", "آذر", "دي", "بهمن",  "اسفند"};
        public string f1(string s)
        {
            return handered[Convert.ToInt16(s)];

        }
        public string f2(string s)
        {
            return letter1_100[Convert.ToInt16(s)];
        }
        public string c3d(string s)
        {
            string t = "";
            if (s.Length == 0) return ("");
            if (s.Length == 1) s = "00" + s;
            if (s.Length == 2) s = "0" + s;
            if (s == "000") return ("");
            string haveVa = "";
            if ((!(s.Substring(1, 2) == "00")) && (s.Substring(0, 1) != "0")) haveVa = " و ";
            t = f1(s.Substring(0, 1)) + haveVa + f2(s.Substring(1, 2));
            return t;
        }

        public string convert_nmber(string s)
        {
            string t = "";
            if (s.Length == 0) return ("نامشخص");

            if (s.Length == 1) s = "00000000000000" + s;
            if (s.Length == 2) s = "0000000000000" + s;
            if (s.Length == 3) s = "000000000000" + s;
            if (s.Length == 4) s = "00000000000" + s;
            if (s.Length == 5) s = "0000000000" + s;
            if (s.Length == 6) s = "000000000" + s;
            if (s.Length == 7) s = "00000000" + s;
            if (s.Length == 8) s = "0000000" + s;
            if (s.Length == 9) s = "000000" + s;
            if (s.Length == 10) s = "00000" + s;
            if (s.Length == 11) s = "0000" + s;
            if (s.Length == 12) s = "000" + s;
            if (s.Length == 13) s = "00" + s;
            if (s.Length == 14) s = "0" + s;
            if (s == "000000000000000") return ("صفر");



            if (!(s.Substring(0, 3) == "000"))
            {
                t = t + c3d((s.Substring(0, 3))) + " هزار";
                if (!(s.Substring(3, 12) == "000000000000"))
                {
                    if (!(s.Substring(3, 3) == "000"))
                        t = t + " و";
                }
            }

            if (!(s.Substring(3, 3) == "000"))
            {
                t = t + c3d((s.Substring(3, 3))) + " ميليارد";
                if (!(s.Substring(6, 9) == "000000000")) t = t + " و";
            }
            else
            {
                if (!(s.Substring(0, 3) == "000")) t = t + " ميليارد و";
            }

            if (!(s.Substring(6, 3) == "000"))
            {
                t = t + c3d((s.Substring(6, 3))) + " ميليون";
                if (!(s.Substring(9, 6) == "000000")) t = t + " و";
            }

            if (!(s.Substring(9, 3) == "000"))
            {
                t = t + c3d((s.Substring(9, 3))) + " هزار";
                if (!(s.Substring(12, 3) == "000")) t = t + " و";
            }

            if (!(s.Substring(12, 3) == "000"))
            {
                t = t + c3d((s.Substring(12, 3)));
            }
            return t;
        }

        public string cMonth(string s)
        {
            int mah = Convert.ToInt16(s);
            if (mah >= 1 && mah <= 12) return month[mah - 1];
            else return ("Err");
        }
        public string convert_date(string s)
        {
            if (s.Length != 10) return ("Err In RF_Date2Str");
            return ("" + convert_nmber(s.Substring(8, 2)) + " ام " + cMonth(s.Substring(5, 2)) + " ماه سال " + convert_nmber(s.Substring(0, 4)) + "");
        }

    }
}
