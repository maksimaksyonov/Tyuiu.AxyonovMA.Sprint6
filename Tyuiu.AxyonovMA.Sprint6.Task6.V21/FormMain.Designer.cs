namespace Tyuiu.AxyonovMA.Sprint6.Task6.V21
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonProcess;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(430, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Загрузка файла InPutFileTask6V21.txt через OpenFileDialog,\r\nпоиск слов с буквой 'g' и вывод результата (Вариант 21)";
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(12, 50);
            this.textBoxIn.Multiline = true;
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn.Size = new System.Drawing.Size(360, 150);
            this.textBoxIn.TabIndex = 1;
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(12, 230);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Size = new System.Drawing.Size(360, 120);
            this.textBoxOut.TabIndex = 2;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(390, 50);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(150, 30);
            this.buttonOpenFile.TabIndex = 3;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(390, 90);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(150, 30);
            this.buttonProcess.TabIndex = 4;
            this.buttonProcess.Text = "Найти слова с 'g'";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 361);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Task6 | V21";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
