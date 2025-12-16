using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            // Lệnh này được tạo tự động và gọi InitializeComponent() trong Form12.Designer.cs
            InitializeComponent();

            // Tự động gán các sự kiện (dựa trên hình ảnh bạn cung cấp)
            SetupEventHandlers();
        }

        // Khởi tạo các event handlers
        private void SetupEventHandlers()
        {
            // Các sự kiện Click cho Buttons
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            this.btDeselect.Click += new System.EventHandler(this.btDeselect_Click);
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
            this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click);

            // Các sự kiện Double Click cho ListBoxes
            this.lbSong.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSong_MouseDoubleClick);
            this.lbFavorite.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFavorite_MouseDoubleClick);
        }

        // ==========================================================
        // 1. CHỌN MỘT MỤC (lbSong -> lbFavorite)
        // ==========================================================

        private void btSelect_Click(object sender, EventArgs e)
        {
            TransferItem(lbSong, lbFavorite);
        }

        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TransferItem(lbSong, lbFavorite);
        }

        // ==========================================================
        // 2. BỎ CHỌN MỘC MỤC (lbFavorite -> lbSong)
        // ==========================================================

        private void btDeselect_Click(object sender, EventArgs e)
        {
            TransferItem(lbFavorite, lbSong);
        }

        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TransferItem(lbFavorite, lbSong);
        }

        /// <summary>
        /// Hàm chung để chuyển một mục từ ListBox nguồn sang ListBox đích.
        /// </summary>
        private void TransferItem(ListBox sourceListBox, ListBox destinationListBox)
        {
            int selectedIndex = sourceListBox.SelectedIndex;

            if (selectedIndex != -1) // Đảm bảo có mục được chọn
            {
                string song = sourceListBox.SelectedItem.ToString();
                destinationListBox.Items.Add(song);
                sourceListBox.Items.RemoveAt(selectedIndex);
            }
        }


        // ==========================================================
        // 3. CHUYỂN TẤT CẢ (Select All / Deselect All)
        // ==========================================================

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            TransferAllItems(lbSong, lbFavorite);
        }

        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            TransferAllItems(lbFavorite, lbSong);
        }

        /// <summary>
        /// Hàm chung để chuyển tất cả các mục từ ListBox nguồn sang ListBox đích.
        /// Sử dụng vòng lặp ngược để xóa an toàn.
        /// </summary>
        private void TransferAllItems(ListBox sourceListBox, ListBox destinationListBox)
        {
            // Lặp ngược từ cuối về đầu (i = Count - 1; i >= 0; i--)
            for (int i = sourceListBox.Items.Count - 1; i >= 0; i--)
            {
                string song = sourceListBox.Items[i].ToString();
                destinationListBox.Items.Add(song);
                sourceListBox.Items.RemoveAt(i);
            }
        }
    }
}