namespace Weather
{
    partial class FormWeather
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.GrpTemperature = new System.Windows.Forms.GroupBox();
            this.RdoKelvin = new System.Windows.Forms.RadioButton();
            this.RdoFahrenheit = new System.Windows.Forms.RadioButton();
            this.RdoCelcius = new System.Windows.Forms.RadioButton();
            this.GrpSpeed = new System.Windows.Forms.GroupBox();
            this.RdoMph = new System.Windows.Forms.RadioButton();
            this.RdoKph = new System.Windows.Forms.RadioButton();
            this.GrpTemperature.SuspendLayout();
            this.GrpSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(259, 526);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 69);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(259, 526);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(553, 69);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(259, 526);
            this.textBox3.TabIndex = 2;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(23, 12);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 6;
            this.BtnLoad.Text = "Load Data";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // GrpTemperature
            // 
            this.GrpTemperature.Controls.Add(this.RdoKelvin);
            this.GrpTemperature.Controls.Add(this.RdoFahrenheit);
            this.GrpTemperature.Controls.Add(this.RdoCelcius);
            this.GrpTemperature.Location = new System.Drawing.Point(567, 12);
            this.GrpTemperature.Name = "GrpTemperature";
            this.GrpTemperature.Size = new System.Drawing.Size(245, 51);
            this.GrpTemperature.TabIndex = 7;
            this.GrpTemperature.TabStop = false;
            // 
            // RdoKelvin
            // 
            this.RdoKelvin.AutoSize = true;
            this.RdoKelvin.Location = new System.Drawing.Point(157, 19);
            this.RdoKelvin.Name = "RdoKelvin";
            this.RdoKelvin.Size = new System.Drawing.Size(54, 17);
            this.RdoKelvin.TabIndex = 8;
            this.RdoKelvin.Text = "Kelvin";
            this.RdoKelvin.UseVisualStyleBackColor = true;
            this.RdoKelvin.Click += new System.EventHandler(this.RdoKelvin_Click);
            // 
            // RdoFahrenheit
            // 
            this.RdoFahrenheit.AutoSize = true;
            this.RdoFahrenheit.Location = new System.Drawing.Point(76, 19);
            this.RdoFahrenheit.Name = "RdoFahrenheit";
            this.RdoFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.RdoFahrenheit.TabIndex = 7;
            this.RdoFahrenheit.Text = "Fahrenheit";
            this.RdoFahrenheit.UseVisualStyleBackColor = true;
            this.RdoFahrenheit.Click += new System.EventHandler(this.RdoFahrenheit_Click);
            // 
            // RdoCelcius
            // 
            this.RdoCelcius.AutoSize = true;
            this.RdoCelcius.Checked = true;
            this.RdoCelcius.Location = new System.Drawing.Point(11, 19);
            this.RdoCelcius.Name = "RdoCelcius";
            this.RdoCelcius.Size = new System.Drawing.Size(59, 17);
            this.RdoCelcius.TabIndex = 6;
            this.RdoCelcius.TabStop = true;
            this.RdoCelcius.Text = "Celcius";
            this.RdoCelcius.UseVisualStyleBackColor = true;
            this.RdoCelcius.Click += new System.EventHandler(this.RdoCelcius_Click);
            // 
            // GrpSpeed
            // 
            this.GrpSpeed.Controls.Add(this.RdoMph);
            this.GrpSpeed.Controls.Add(this.RdoKph);
            this.GrpSpeed.Location = new System.Drawing.Point(412, 12);
            this.GrpSpeed.Name = "GrpSpeed";
            this.GrpSpeed.Size = new System.Drawing.Size(149, 51);
            this.GrpSpeed.TabIndex = 9;
            this.GrpSpeed.TabStop = false;
            // 
            // RdoMph
            // 
            this.RdoMph.AutoSize = true;
            this.RdoMph.Location = new System.Drawing.Point(76, 19);
            this.RdoMph.Name = "RdoMph";
            this.RdoMph.Size = new System.Drawing.Size(46, 17);
            this.RdoMph.TabIndex = 7;
            this.RdoMph.Text = "Mph";
            this.RdoMph.UseVisualStyleBackColor = true;
            this.RdoMph.Click += new System.EventHandler(this.RdoMph_Click);
            // 
            // RdoKph
            // 
            this.RdoKph.AutoSize = true;
            this.RdoKph.Checked = true;
            this.RdoKph.Location = new System.Drawing.Point(11, 19);
            this.RdoKph.Name = "RdoKph";
            this.RdoKph.Size = new System.Drawing.Size(44, 17);
            this.RdoKph.TabIndex = 6;
            this.RdoKph.TabStop = true;
            this.RdoKph.Text = "Kph";
            this.RdoKph.UseVisualStyleBackColor = true;
            this.RdoKph.Click += new System.EventHandler(this.RdoKph_Click);
            // 
            // FormWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 632);
            this.Controls.Add(this.GrpSpeed);
            this.Controls.Add(this.GrpTemperature);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FormWeather";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.FormWeather_Load);
            this.GrpTemperature.ResumeLayout(false);
            this.GrpTemperature.PerformLayout();
            this.GrpSpeed.ResumeLayout(false);
            this.GrpSpeed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.GroupBox GrpTemperature;
        private System.Windows.Forms.RadioButton RdoKelvin;
        private System.Windows.Forms.RadioButton RdoFahrenheit;
        private System.Windows.Forms.RadioButton RdoCelcius;
        private System.Windows.Forms.GroupBox GrpSpeed;
        private System.Windows.Forms.RadioButton RdoMph;
        private System.Windows.Forms.RadioButton RdoKph;
    }
}