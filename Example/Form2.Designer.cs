namespace Example
{
    partial class Form2
    {
        private System.Windows.Forms.Button bt_OK;

        private void InitializeComponent()
        {
            bt_OK = new Button();
            SuspendLayout();
            // 
            // bt_OK
            // 
            bt_OK.Location = new Point(99, 100);
            bt_OK.Name = "bt_OK";
            bt_OK.Size = new Size(80, 25);
            bt_OK.TabIndex = 0;
            bt_OK.Text = "OK";
            bt_OK.Click += bt_OK_Click;
            // 
            // Form2
            // 
            ClientSize = new Size(282, 253);
            Controls.Add(bt_OK);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }
    }
}