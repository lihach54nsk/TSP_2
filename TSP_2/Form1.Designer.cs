namespace TSP_2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Start_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lyambdaTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOFExperimentsTextBox = new System.Windows.Forms.TextBox();
            this.TimeNRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MeanTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(12, 351);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(129, 42);
            this.Start_Button.TabIndex = 0;
            this.Start_Button.Text = "Начать";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Интенсивность потока: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Интервал моделирования: ";
            // 
            // lyambdaTextBox
            // 
            this.lyambdaTextBox.Location = new System.Drawing.Point(163, 6);
            this.lyambdaTextBox.Name = "lyambdaTextBox";
            this.lyambdaTextBox.Size = new System.Drawing.Size(100, 20);
            this.lyambdaTextBox.TabIndex = 3;
            this.lyambdaTextBox.Text = "8";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(163, 29);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 4;
            this.timeTextBox.Text = "100";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(269, 6);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(558, 387);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество симуляций: ";
            // 
            // NumberOFExperimentsTextBox
            // 
            this.NumberOFExperimentsTextBox.Location = new System.Drawing.Point(148, 55);
            this.NumberOFExperimentsTextBox.Name = "NumberOFExperimentsTextBox";
            this.NumberOFExperimentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOFExperimentsTextBox.TabIndex = 7;
            this.NumberOFExperimentsTextBox.Text = "100";
            // 
            // TimeNRichTextBox
            // 
            this.TimeNRichTextBox.Location = new System.Drawing.Point(12, 109);
            this.TimeNRichTextBox.Name = "TimeNRichTextBox";
            this.TimeNRichTextBox.ReadOnly = true;
            this.TimeNRichTextBox.Size = new System.Drawing.Size(251, 236);
            this.TimeNRichTextBox.TabIndex = 8;
            this.TimeNRichTextBox.Text = "";
            // 
            // MeanTextBox
            // 
            this.MeanTextBox.Location = new System.Drawing.Point(151, 81);
            this.MeanTextBox.Name = "MeanTextBox";
            this.MeanTextBox.ReadOnly = true;
            this.MeanTextBox.Size = new System.Drawing.Size(100, 20);
            this.MeanTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Среднее число событий: ";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(147, 351);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(116, 42);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 400);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MeanTextBox);
            this.Controls.Add(this.TimeNRichTextBox);
            this.Controls.Add(this.NumberOFExperimentsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.lyambdaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lyambdaTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumberOFExperimentsTextBox;
        private System.Windows.Forms.RichTextBox TimeNRichTextBox;
        private System.Windows.Forms.TextBox MeanTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearButton;
    }
}

