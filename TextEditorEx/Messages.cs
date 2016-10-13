using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorEx
{
    interface IMessage
    {
         void ShowMessage(string message);

         void ShowError(string message);

         void ShowExclamation(string massage);
      
    }

    class Messages: IMessage
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "собщение",  MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        public void ShowExclamation(string massage)
        {
            MessageBox.Show(massage, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
