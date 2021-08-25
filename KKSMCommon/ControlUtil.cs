using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKSMCommon
{
    class ControlUtil
    {
        #region コンボボックス：キー＋バリューADD
        public class ComboBoxItems
        {
            private string m_id = "";
            private string m_name = "";
            //コンストラクタ
            public ComboBoxItems(string id, string name)
            {
                m_id = id;
                m_name = name;
            }
            public string Id
            {
                get
                {
                    return m_id;
                }
            }
            public string Name
            {
                get
                {
                    return m_name;
                }
            }
            public override string ToString()
            {
                return m_name;
            }
        }
        #endregion
    }
}
