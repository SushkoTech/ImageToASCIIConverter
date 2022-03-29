
namespace ImageToASCIIConverter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bOpenFile = new System.Windows.Forms.Button();
            this.bConvert = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bBrowseFolder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_NameOfFile = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // bOpenFile
            // 
            this.bOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOpenFile.Location = new System.Drawing.Point(12, 12);
            this.bOpenFile.Name = "bOpenFile";
            this.bOpenFile.Size = new System.Drawing.Size(124, 42);
            this.bOpenFile.TabIndex = 0;
            this.bOpenFile.TabStop = false;
            this.bOpenFile.Text = "Open image";
            this.bOpenFile.UseVisualStyleBackColor = true;
            this.bOpenFile.Click += new System.EventHandler(this.bOpenFile_Click);
            // 
            // bConvert
            // 
            this.bConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bConvert.Location = new System.Drawing.Point(142, 12);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(183, 42);
            this.bConvert.TabIndex = 1;
            this.bConvert.TabStop = false;
            this.bConvert.Text = "Convert";
            this.bConvert.UseVisualStyleBackColor = true;
            this.bConvert.Click += new System.EventHandler(this.bConvert_Click);
            // 
            // bBrowseFolder
            // 
            this.bBrowseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBrowseFolder.Location = new System.Drawing.Point(12, 75);
            this.bBrowseFolder.Name = "bBrowseFolder";
            this.bBrowseFolder.Size = new System.Drawing.Size(124, 25);
            this.bBrowseFolder.TabIndex = 2;
            this.bBrowseFolder.TabStop = false;
            this.bBrowseFolder.Text = "Change save path:";
            this.bBrowseFolder.UseVisualStyleBackColor = true;
            this.bBrowseFolder.Click += new System.EventHandler(this.bBrowseFolder_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.Location = new System.Drawing.Point(142, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            // 
            // label_NameOfFile
            // 
            this.label_NameOfFile.AutoSize = true;
            this.label_NameOfFile.Location = new System.Drawing.Point(21, 55);
            this.label_NameOfFile.Name = "label_NameOfFile";
            this.label_NameOfFile.Size = new System.Drawing.Size(0, 13);
            this.label_NameOfFile.TabIndex = 4;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.LinkColor = System.Drawing.Color.Black;
            this.Author.Location = new System.Drawing.Point(216, 119);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(114, 13);
            this.Author.TabIndex = 5;
            this.Author.TabStop = true;
            this.Author.Text = "Author: ©SushkoTech";
            this.Author.VisitedLinkColor = System.Drawing.Color.Black;
            this.Author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Author_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(337, 141);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.label_NameOfFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bBrowseFolder);
            this.Controls.Add(this.bConvert);
            this.Controls.Add(this.bOpenFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageToASCIIConverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bOpenFile;
        private System.Windows.Forms.Button bConvert;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button bBrowseFolder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_NameOfFile;
        private System.Windows.Forms.LinkLabel Author;
    }
}

