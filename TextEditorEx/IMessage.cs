using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorEx
{
    interface IMessage
    {
        void ShowMessage(string message);
        void ShowError(string message);
        void ShowExclamation(string massage);

    }
}
