using System;
using System.IO;
using System.Text;



namespace TextEditorBL 
{
   
    public class FileManager : ITextEditor
    {
        private readonly Encoding defaultEncode = Encoding.GetEncoding(1251);
        
        public bool IsExists(string filePath)
        {
        return File.Exists(filePath);
        }

        public string GetContent(string filePath, Encoding encoding)
        {
            return File.ReadAllText(filePath, encoding);

        }

        public string GetContent(string filePath)
        {
            return File.ReadAllText(filePath, defaultEncode);
        }

        public void SetContent(string filePath, string content, Encoding encoding)
        {
            File.WriteAllText(filePath, content, encoding);

        }

        public void SetContent(string filePath, string content)
        {
            File.WriteAllText(filePath, content, defaultEncode);

        }

        public int getSysmbolCount(string content)
        {
            return content.Length;
        }


    }
}
