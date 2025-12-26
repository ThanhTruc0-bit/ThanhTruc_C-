namespace Example
{
    partial class FormReport
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.Label lblFemale;
        private System.Windows.Forms.Label lblAvgAge;
        private System.Windows.Forms.DataGridView dgvReport;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblTotal = new Label();
            lblMale = new Label();
            lblFemale = new Label();
            lblAvgAge = new Label();
            dgvReport = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();

            // lblTitle
            lblTitle.Text = "BÁO CÁO NHÂN SỰ";
            lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Size = new Size(400, 40);

            // lblTotal
            lblTotal.Location = new Point(20, 80);
            lblTotal.Size = new Size(250, 40);

            // lblMale
            lblMale.Location = new Point(290, 80);
            lblMale.Size = new Size(250, 40);

            // lblFemale
            lblFemale.Location = new Point(560, 80);
            lblFemale.Size = new Size(250, 40);

            // dgvReport
            dgvReport.Location = new Point(20, 150);
            dgvReport.Size = new Size(800, 250);

            // lblAvgAge
            lblAvgAge.Location = new Point(20, 420);
            lblAvgAge.Size = new Size(300, 40);

            // FormReport
            ClientSize = new Size(850, 500);
            Controls.Add(lblTitle);
            Controls.Add(lblTotal);
            Controls.Add(lblMale);
            Controls.Add(lblFemale);
            Controls.Add(dgvReport);
            Controls.Add(lblAvgAge);
            Text = "Báo cáo";
            StartPosition = FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }
    }
}
