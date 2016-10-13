namespace TextEditorEx
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.filePathEd = new System.Windows.Forms.TextBox();
            this.BtSelectFile = new System.Windows.Forms.Button();
            this.BtOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UpDoFontSize = new System.Windows.Forms.NumericUpDown();
            this.TextEditorFld = new System.Windows.Forms.TextBox();
            this.BtSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.symbolCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.symbolCountFld = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.UpDoFontSize)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбирите файл";
            // 
            // filePathEd
            // 
            this.filePathEd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathEd.Location = new System.Drawing.Point(147, 43);
            this.filePathEd.Name = "filePathEd";
            this.filePathEd.Size = new System.Drawing.Size(492, 20);
            this.filePathEd.TabIndex = 1;
            // 
            // BtSelectFile
            // 
            this.BtSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSelectFile.Location = new System.Drawing.Point(663, 26);
            this.BtSelectFile.Name = "BtSelectFile";
            this.BtSelectFile.Size = new System.Drawing.Size(74, 25);
            this.BtSelectFile.TabIndex = 2;
            this.BtSelectFile.Text = "Выбрать";
            this.BtSelectFile.UseVisualStyleBackColor = true;
            // 
            // BtOpenFile
            // 
            this.BtOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtOpenFile.Location = new System.Drawing.Point(662, 57);
            this.BtOpenFile.Name = "BtOpenFile";
            this.BtOpenFile.Size = new System.Drawing.Size(75, 23);
            this.BtOpenFile.TabIndex = 3;
            this.BtOpenFile.Text = "Открыть";
            this.BtOpenFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шрифт";
            // 
            // UpDoFontSize
            // 
            this.UpDoFontSize.Location = new System.Drawing.Point(109, 86);
            this.UpDoFontSize.Name = "UpDoFontSize";
            this.UpDoFontSize.Size = new System.Drawing.Size(67, 20);
            this.UpDoFontSize.TabIndex = 5;
            // 
            // TextEditorFld
            // 
            this.TextEditorFld.Location = new System.Drawing.Point(192, 86);
            this.TextEditorFld.Multiline = true;
            this.TextEditorFld.Name = "TextEditorFld";
            this.TextEditorFld.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextEditorFld.Size = new System.Drawing.Size(581, 299);
            this.TextEditorFld.TabIndex = 6;
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(600, 391);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(173, 23);
            this.BtSave.TabIndex = 7;
            this.BtSave.Text = "Сохранить";
            this.BtSave.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.symbolCount,
            this.symbolCountFld});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(799, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 17);
            this.toolStripStatusLabel1.Text = "Количество символов";
            // 
            // symbolCount
            // 
            this.symbolCount.Name = "symbolCount";
            this.symbolCount.Size = new System.Drawing.Size(0, 17);
            // 
            // symbolCountFld
            // 
            this.symbolCountFld.Name = "symbolCountFld";
            this.symbolCountFld.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 436);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BtSave);
            this.Controls.Add(this.TextEditorFld);
            this.Controls.Add(this.UpDoFontSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtOpenFile);
            this.Controls.Add(this.BtSelectFile);
            this.Controls.Add(this.filePathEd);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Текстовый редактор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDoFontSize)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePathEd;
        private System.Windows.Forms.Button BtSelectFile;
        private System.Windows.Forms.Button BtOpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown UpDoFontSize;
        private System.Windows.Forms.TextBox TextEditorFld;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel symbolCount;
        private System.Windows.Forms.ToolStripStatusLabel symbolCountFld;
    }
}

