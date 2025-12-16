namespace Example
{
    partial class Form18
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
            this.components = new System.ComponentModel.Container();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.tmStopwatch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(12, 9);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(306, 85);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "00:00";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(70, 107);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 30);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(180, 107);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 30);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // tmStopwatch
            // 
            this.tmStopwatch.Interval = 100; // Giá trị trong Designer
            this.tmStopwatch.Tick += new System.EventHandler(this.tmStopwatch_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(330, 150);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Form1";
            this.Text = "Timer Article";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Timer tmStopwatch;
    }
}