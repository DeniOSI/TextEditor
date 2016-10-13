using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorEx
{
    interface IMainForm
    {
        string FilePath { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);
        event EventHandler FIleOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChange;
    }
}
