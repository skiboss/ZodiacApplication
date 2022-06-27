
namespace ZodiacWinApp
{
    partial class ZodiacForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownDay = new System.Windows.Forms.NumericUpDown();
            this.labelSign = new System.Windows.Forms.Label();
            this.buttonShowSign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(287, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "™";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Birth Month";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "JAN",
            "FEB",
            "MAR",
            "APR",
            "MAY",
            "JUN",
            "JUL",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DEC"});
            this.comboBoxMonth.Location = new System.Drawing.Point(165, 40);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(84, 29);
            this.comboBoxMonth.TabIndex = 2;
            this.comboBoxMonth.TextChanged += new System.EventHandler(this.comboBoxMonth_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Birth Day";
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.Location = new System.Drawing.Point(165, 82);
            this.numericUpDownDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay.Name = "numericUpDownDay";
            this.numericUpDownDay.Size = new System.Drawing.Size(84, 29);
            this.numericUpDownDay.TabIndex = 4;
            this.numericUpDownDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelSign
            // 
            this.labelSign.BackColor = System.Drawing.Color.AliceBlue;
            this.labelSign.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSign.Location = new System.Drawing.Point(25, 132);
            this.labelSign.Name = "labelSign";
            this.labelSign.Size = new System.Drawing.Size(273, 78);
            this.labelSign.TabIndex = 5;
            this.labelSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonShowSign
            // 
            this.buttonShowSign.Location = new System.Drawing.Point(63, 230);
            this.buttonShowSign.Name = "buttonShowSign";
            this.buttonShowSign.Size = new System.Drawing.Size(199, 40);
            this.buttonShowSign.TabIndex = 6;
            this.buttonShowSign.Text = "Show Sign";
            this.buttonShowSign.UseVisualStyleBackColor = true;
            this.buttonShowSign.Click += new System.EventHandler(this.buttonShowSign_Click);
            // 
            // ZodiacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(326, 282);
            this.Controls.Add(this.buttonShowSign);
            this.Controls.Add(this.labelSign);
            this.Controls.Add(this.numericUpDownDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ZodiacForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZodiacForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownDay;
        private System.Windows.Forms.Label labelSign;
        private System.Windows.Forms.Button buttonShowSign;
    }
}