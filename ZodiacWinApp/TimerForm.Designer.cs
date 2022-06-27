
namespace ZodiacWinApp
{
    partial class TimerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTimer
            // 
            this.labelTimer.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimer.Location = new System.Drawing.Point(71, 43);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(255, 94);
            this.labelTimer.TabIndex = 0;
            this.labelTimer.Text = "0.00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(103, 182);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(195, 51);
            this.buttonStartStop.TabIndex = 1;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.labelTimer);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TimerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zodiac App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimerForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Timer timer1;
    }
}

