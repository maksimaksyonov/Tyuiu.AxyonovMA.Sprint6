namespace Tyuiu.AxyonovMA.Sprint6.Task5.V15
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewValues;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.PictureBox pictureBoxChart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewValues = new System.Windows.Forms.DataGridView();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.pictureBoxChart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(430, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Чтение из InPutFileTask5V15.txt, выбор чисел в диапазоне [2;7],\r\nвывод в DataGrid" +
    "View и построение диаграммы (V15)";
            // 
            // dataGridViewValues
            // 
            this.dataGridViewValues.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValues.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewValues.Name = "dataGridViewValues";
            this.dataGridViewValues.Size = new System.Drawing.Size(180, 250);
            this.dataGridViewValues.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 310);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(180, 30);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Загрузить и построить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // pictureBoxChart
            // 
            this.pictureBoxChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxChart.Location = new System.Drawing.Point(210, 50);
            this.pictureBoxChart.Name = "pictureBoxChart";
            this.pictureBoxChart.Size = new System.Drawing.Size(320, 290);
            this.pictureBoxChart.TabIndex = 3;
            this.pictureBoxChart.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 351);
            this.Controls.Add(this.pictureBoxChart);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dataGridViewValues);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Task5 | V15";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
