using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickBootForWindows.common
{
    class Utils
    {
        /// <summary>
        /// 复制文本内容到剪贴板中
        /// </summary>
        /// <param name="value"></param>
        private static void copyContentToClipBoard(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                Clipboard.SetDataObject(value);
                MessageBox.Show("复制成功！", "提示信息");
            }
        }

        /// <summary>
        /// 复制文本框内容到剪贴板中
        /// </summary>
        /// <param name="textBox"></param>
        public static void copyTextBoxContentToClipBoard(TextBox textBox) {
            string textBoxValue = textBox.Text;
            copyContentToClipBoard(textBoxValue);
        }
    }
}
