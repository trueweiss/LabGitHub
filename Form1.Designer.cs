
namespace CurrencyChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UAH = new System.Windows.Forms.Button();
            this.EUR = new System.Windows.Forms.Button();
            this.USD = new System.Windows.Forms.Button();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UAH);
            this.panel1.Controls.Add(this.EUR);
            this.panel1.Controls.Add(this.USD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 450);
            this.panel1.TabIndex = 0;
            // 
            // UAH
            // 
            this.UAH.Location = new System.Drawing.Point(13, 71);
            this.UAH.Name = "UAH";
            this.UAH.Size = new System.Drawing.Size(75, 23);
            this.UAH.TabIndex = 2;
            this.UAH.Text = "UAH/RUB";
            this.UAH.UseVisualStyleBackColor = true;
            this.UAH.Click += new System.EventHandler(this.UAH_Click);
            // 
            // EUR
            // 
            this.EUR.Location = new System.Drawing.Point(13, 42);
            this.EUR.Name = "EUR";
            this.EUR.Size = new System.Drawing.Size(75, 23);
            this.EUR.TabIndex = 1;
            this.EUR.Text = "EUR/RUB";
            this.EUR.UseVisualStyleBackColor = true;
            this.EUR.Click += new System.EventHandler(this.EUR_Click);
            // 
            // USD
            // 
            this.USD.Location = new System.Drawing.Point(12, 12);
            this.USD.Name = "USD";
            this.USD.Size = new System.Drawing.Size(75, 23);
            this.USD.TabIndex = 0;
            this.USD.Text = "USD/RUB";
            this.USD.UseVisualStyleBackColor = true;
            this.USD.Click += new System.EventHandler(this.USD_Click);
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart.Location = new System.Drawing.Point(100, 0);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(700, 450);
            this.Chart.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "MainTitle";
            this.Chart.Titles.Add(title1);
            this.Chart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Chart_MouseClick);
            this.Chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Currency Chart";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UAH;
        private System.Windows.Forms.Button EUR;
        private System.Windows.Forms.Button USD;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
    }
}

