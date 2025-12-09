namespace Example01
{
    partial class Form2
    {
        private System.Windows.Forms.Button bt_OK;

        private void InitializeComponent()
        {
            this.bt_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // bt_OK
            this.bt_OK.Location = new System.Drawing.Point(100, 100);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(80, 25);
            this.bt_OK.Text = "OK";
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);

            // Form2
            this.Controls.Add(this.bt_OK);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
        }
    }
}