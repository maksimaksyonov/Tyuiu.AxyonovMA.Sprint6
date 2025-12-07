namespace Tyuiu.AxyonovMA.Sprint6.Task1.V13
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBoxResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelStop = new System.Windows.Forms.Label();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxStop = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(430, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "F(x) = 3cos(x)/(4x - 0,5) + sin(x) - 5x - 2. Табулирование, шаг 1, округление до 0.01";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(12, 40);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(72, 15);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "Начало (a):";
            // 
            // labelStop
            // 
            this.labelStop.AutoSize = true;
            this.labelStop.Location = new System.Drawing.Point(12, 69);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(77, 15);
            this.labelStop.TabIndex = 2;
            this.labelStop.Text = "Конец (b):";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(95, 37);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(60, 23);
            this.textBoxStart.TabIndex = 3;
            // 
            // textBoxStop
            // 
            this.textBoxStop.Location = new System.Drawing.Point(95, 66);
            this.textBoxStop.Name = "textBoxStop";
            this.textBoxStop.Size = new System.Drawing.Size(60, 23);
            this.textBoxStop.TabIndex = 4;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(12, 100);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(143, 29);
            this.buttonCalc.TabIndex = 5;
            this.buttonCalc.Text = "Выполнить";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(170, 37);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(220, 200);
            this.textBoxResult.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 251);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxStop);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.labelStop);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Task1 | V13";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
