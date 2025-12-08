namespace Tyuiu.AxyonovMA.Sprint6.Task7.V23
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewIn;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPathIn;
        private System.Windows.Forms.TextBox textBoxPathOut;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelOut;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewIn = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut = new System.Windows.Forms.DataGridView();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPathIn = new System.Windows.Forms.TextBox();
            this.textBoxPathOut = new System.Windows.Forms.TextBox();
            this.labelIn = new System.Windows.Forms.Label();
            this.labelOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIn
            // 
            this.dataGridViewIn.AllowUserToAddRows = false;
            this.dataGridViewIn.AllowUserToDeleteRows = false;
            this.dataGridViewIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn.Location = new System.Drawing.Point(12, 70);
            this.dataGridViewIn.Name = "dataGridViewIn";
            this.dataGridViewIn.RowHeadersVisible = false;
            this.dataGridViewIn.Size = new System.Drawing.Size(360, 250);
            this.dataGridViewIn.TabIndex = 0;
            // 
            // dataGridViewOut
            // 
            this.dataGridViewOut.AllowUserToAddRows = false;
            this.dataGridViewOut.AllowUserToDeleteRows = false;
            this.dataGridViewOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut.Location = new System.Drawing.Point(408, 70);
            this.dataGridViewOut.Name = "dataGridViewOut";
            this.dataGridViewOut.RowHeadersVisible = false;
            this.dataGridViewOut.Size = new System.Drawing.Size(360, 250);
            this.dataGridViewOut.TabIndex = 1;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(150, 30);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Открыть файл";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(408, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 30);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить результат";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxPathIn
            // 
            this.textBoxPathIn.Location = new System.Drawing.Point(12, 44);
            this.textBoxPathIn.Name = "textBoxPathIn";
            this.textBoxPathIn.ReadOnly = true;
            this.textBoxPathIn.Size = new System.Drawing.Size(360, 23);
            this.textBoxPathIn.TabIndex = 4;
            // 
            // textBoxPathOut
            // 
            this.textBoxPathOut.Location = new System.Drawing.Point(408, 44);
            this.textBoxPathOut.Name = "textBoxPathOut";
            this.textBoxPathOut.ReadOnly = true;
            this.textBoxPathOut.Size = new System.Drawing.Size(360, 23);
            this.textBoxPathOut.TabIndex = 5;
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Location = new System.Drawing.Point(12, 332);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(111, 15);
            this.labelIn.TabIndex = 6;
            this.labelIn.Text = "Исходная матрица";
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(408, 332);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(129, 15);
            this.labelOut.TabIndex = 7;
            this.labelOut.Text = "Изменённая матрица";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.textBoxPathOut);
            this.Controls.Add(this.textBoxPathIn);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.dataGridViewOut);
            this.Controls.Add(this.dataGridViewIn);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 23 | Аксёнов М.А.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
