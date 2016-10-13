using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorEx
{
   
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            BtOpenFile.Click += BtOpenFile_Click;
            BtSave.Click += BtSave_Click;
            TextEditorFld.TextChanged += TextEditorFld_TextChanged;
            BtOpenFile.Click += butSelectFiles;
            BtSave.Click += butSaveFiles;
            TextEditorFld.TextChanged += textSize;

        }
        #region Events

        private void TextEditorFld_TextChanged(object sender, EventArgs e)
        {
            if (ContentChange != null) ContentChange(this, EventArgs.Empty);
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null) FileSaveClick(this, EventArgs.Empty);
        }

        private void BtOpenFile_Click(object sender, EventArgs e)
        {
            if (FIleOpenClick != null) FIleOpenClick(this, EventArgs.Empty);
        }

       

        public event EventHandler ContentChange;
        public event EventHandler FIleOpenClick;
        public event EventHandler FileSaveClick;
        #endregion

        #region IMainForm

        public string Content
        {
            get
            {
                return TextEditorFld.Text;
            }

            set
            {
                TextEditorFld.Text = value;
            }
        }

        public string FilePath
        {
            get
            {
                return filePathEd.Text;
            }
        }
        public void SetSymbolCount(int count)
        {
            symbolCountFld.Text = Convert.ToString(count);
        }
        #endregion

        private void butSelectFiles(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "*.txt|*.txt| all files|*.*";
            if(op.ShowDialog() == DialogResult.OK)
            {
                filePathEd.Text = op.FileName;
                if(FIleOpenClick != null) { FIleOpenClick(this, EventArgs.Empty); }
            }
        }
        private void butSaveFiles(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "*.txt|*.txt| all files|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                filePathEd.Text = sv.FileName;
                if (FileSaveClick != null) { FileSaveClick(this, EventArgs.Empty); }
            }
        }
        private void textSymbleCount(object sender, EventArgs e)
        {


            symbolCountFld.Text = TextEditorFld.Text.Length.ToString();
            
        }
        private void textSize(object senter, EventArgs e)
        {
            TextEditorFld.Font = new Font("TimesNewRoman", (float)UpDoFontSize.Value);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
