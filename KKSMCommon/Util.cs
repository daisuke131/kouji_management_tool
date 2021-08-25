using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKSMCommon
{
    public class Util
    {
        //定数
        private const string daika_flg = "0";
        private const string sekou_flg = "1";

        #region yyyyMMdd　→　yyyy/MM/dd
        /// <summary>
        /// yyyyMMdd　→　yyyy/MM/dd
        /// </summary>
        /// <param name="ymd"></param>
        /// <returns></returns>
        public string formatYMD(string ymd)
        {
            ymd = ymd.Substring(0, 3) + "/" + ymd.Substring(4, 2) + "/" + ymd.Substring(6, 2);
            return ymd;
        }
        #endregion

        #region 年月日チェック
        /// <summary>
        /// 年月日チェック
        /// </summary>
        /// <param name="ymd"></param>
        /// <returns></returns>
        public bool chkYMD(string ymd)
        {
            int year;
            int month;
            int day;
            if(ymd.Length == 8)
            {
                year = int.Parse(ymd.Substring(0, 3));
                month = int.Parse(ymd.Substring(4, 2));
                day = int.Parse(ymd.Substring(6, 2));
                if ((DateTime.MinValue.Year > year) || (year > DateTime.MaxValue.Year))
                {
                    return false;
                }

                if ((DateTime.MinValue.Month > month) || (month > DateTime.MaxValue.Month))
                {
                    return false;
                }

                int iLastDay = DateTime.DaysInMonth(year, day);

                if ((DateTime.MinValue.Day > day) || (day > iLastDay))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        #endregion

        #region 代価～号 or 施工～号
        public string daika_sekou(string flg, string str)
        {
            string rtnstr = string.Empty;
            if (flg.Equals(daika_flg))
            {
                rtnstr = "代価　第" + str + "号　内訳表";
            }
            else if (flg.Equals(sekou_flg))
            {
                rtnstr = "施工　第" + str + "号　内訳表";
            }
            return rtnstr;
        }

        public string daika_sekou_number(string str)
        {
            if(!String.IsNullOrEmpty(str))
            {
                str = str.Replace("代価　第", "");
                str = str.Replace("施工　第", "");
                str = str.Replace("号　内訳表", "");
            }
            return str;
        }
        #endregion
        
        #region 金額フォーマット
        //カンマ区切り
        public string format_strkingaku(string kingaku)
        {
            double doublekingaku = 0;
            string rtnkingaku = string.Empty;
            if(!String.IsNullOrEmpty(kingaku))
            {
                doublekingaku = double.Parse(kingaku);
                rtnkingaku = doublekingaku.ToString("#,###.##");
            }
            return rtnkingaku;
        }
        //カンマ→数字
        public double format_doublekingaku(string kingaku)
        {
            double rtnkingaku = 0;
            if (!string.IsNullOrEmpty(kingaku))
            {
                rtnkingaku = double.Parse(kingaku.Replace(",", "").Trim());
            }
            return rtnkingaku;
        }
        #endregion
    }
}
