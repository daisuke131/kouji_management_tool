using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKSMCommon
{
    public class MessageUtil
    {
        public const string loginFail = "ログインＩＤまたはパスワードが正しくありません。";
        public const string needmeg = "を入力してください。";
        public const string alreadydatameg = "この{0}はすでに登録されています。";
        public const string failmeg = "を正しく入力してください。";
        public const string regmeg = "登録完了しました。";
        public const string updatemeg = "登録完了しました。";
        public const string needselectmeg = "必須項目を選択してください。";

        public string needMeg(string meg)
        {
            string rtnstr = meg + needmeg;
            return rtnstr;
        }
        public string failMeg(string meg)
        {
            string rtnstr = meg + failmeg;
            return rtnstr;
            
        }
        public string alreadyMeg(string meg)
        {
            string rtnstr = string.Format(alreadydatameg, meg);
            return rtnstr;
        }
    }
}
