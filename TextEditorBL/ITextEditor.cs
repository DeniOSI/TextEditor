using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorBL
{
   public interface ITextEditor
    {


        bool IsExists(string filePath);
        string GetContent(string filePath, Encoding encoding);
        string GetContent(string filePath);
        void SetContent(string filePath, string content, Encoding encoding);
        void SetContent(string filePath, string content);
        int getSysmbolCount(string content);


    }
}
