
namespace TP1
{
    partial class MainMenu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_nim = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.bt_home = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.bt_catalouge = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.TableLayoutPanel();
            this.cb_harga = new System.Windows.Forms.ComboBox();
            this.cb_jenis = new System.Windows.Forms.ComboBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_logo = new System.Windows.Forms.Button();
            this.menu_table = new System.Windows.Forms.TableLayoutPanel();
            this.item_table = new System.Windows.Forms.TableLayoutPanel();
            this.lb_menuDetail = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.menu_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sidebar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_logo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.menu_table, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.88889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1020, 546);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.bt_home, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bt_logout, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.bt_catalouge, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(170, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(850, 82);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lb_nim, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lb_name, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(636, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(214, 82);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // lb_nim
            // 
            this.lb_nim.AutoSize = true;
            this.lb_nim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_nim.Location = new System.Drawing.Point(3, 3);
            this.lb_nim.Margin = new System.Windows.Forms.Padding(3);
            this.lb_nim.Name = "lb_nim";
            this.lb_nim.Size = new System.Drawing.Size(208, 35);
            this.lb_nim.TabIndex = 0;
            this.lb_nim.Text = "1908919";
            this.lb_nim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_name.Location = new System.Drawing.Point(3, 44);
            this.lb_name.Margin = new System.Windows.Forms.Padding(3);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(208, 35);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Ahmad Izzuddin";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_home
            // 
            this.bt_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_home.Location = new System.Drawing.Point(3, 3);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(206, 76);
            this.bt_home.TabIndex = 1;
            this.bt_home.Text = "Home";
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.showHome);
            // 
            // bt_logout
            // 
            this.bt_logout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_logout.Location = new System.Drawing.Point(427, 3);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(206, 76);
            this.bt_logout.TabIndex = 2;
            this.bt_logout.Text = "Logout";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logoutClick);
            // 
            // bt_catalouge
            // 
            this.bt_catalouge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_catalouge.Location = new System.Drawing.Point(215, 3);
            this.bt_catalouge.Name = "bt_catalouge";
            this.bt_catalouge.Size = new System.Drawing.Size(206, 76);
            this.bt_catalouge.TabIndex = 3;
            this.bt_catalouge.Text = "Catalouge";
            this.bt_catalouge.UseVisualStyleBackColor = true;
            this.bt_catalouge.Click += new System.EventHandler(this.bt_catalougeClick);
            // 
            // sidebar
            // 
            this.sidebar.ColumnCount = 1;
            this.sidebar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sidebar.Controls.Add(this.cb_harga, 0, 1);
            this.sidebar.Controls.Add(this.cb_jenis, 0, 0);
            this.sidebar.Controls.Add(this.bt_search, 0, 2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebar.Location = new System.Drawing.Point(0, 82);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.RowCount = 3;
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.84211F));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.15789F));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.sidebar.Size = new System.Drawing.Size(170, 106);
            this.sidebar.TabIndex = 2;
            // 
            // cb_harga
            // 
            this.cb_harga.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cb_harga.FormattingEnabled = true;
            this.cb_harga.Items.AddRange(new object[] {
            "100rb - 200rb",
            "200rb - 500rb",
            "500rb - 1jt",
            "All"});
            this.cb_harga.Location = new System.Drawing.Point(3, 52);
            this.cb_harga.Name = "cb_harga";
            this.cb_harga.Size = new System.Drawing.Size(164, 21);
            this.cb_harga.TabIndex = 1;
            this.cb_harga.Text = "Harga";
            // 
            // cb_jenis
            // 
            this.cb_jenis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cb_jenis.FormattingEnabled = true;
            this.cb_jenis.Items.AddRange(new object[] {
            "Elektronik",
            "Baju",
            "Makanan",
            "All"});
            this.cb_jenis.Location = new System.Drawing.Point(3, 23);
            this.cb_jenis.Name = "cb_jenis";
            this.cb_jenis.Size = new System.Drawing.Size(164, 21);
            this.cb_jenis.TabIndex = 0;
            this.cb_jenis.Text = "Jenis Barang";
            // 
            // bt_search
            // 
            this.bt_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_search.Location = new System.Drawing.Point(3, 79);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(164, 24);
            this.bt_search.TabIndex = 2;
            this.bt_search.Text = "Cari";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_searchClick);
            // 
            // bt_logo
            // 
            this.bt_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_logo.Location = new System.Drawing.Point(3, 3);
            this.bt_logo.Name = "bt_logo";
            this.bt_logo.Size = new System.Drawing.Size(164, 76);
            this.bt_logo.TabIndex = 3;
            this.bt_logo.UseVisualStyleBackColor = true;
            // 
            // menu_table
            // 
            this.menu_table.ColumnCount = 1;
            this.menu_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu_table.Controls.Add(this.item_table, 0, 1);
            this.menu_table.Controls.Add(this.lb_menuDetail, 0, 0);
            this.menu_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_table.Location = new System.Drawing.Point(173, 85);
            this.menu_table.Name = "menu_table";
            this.menu_table.RowCount = 2;
            this.menu_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.100796F));
            this.menu_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.8992F));
            this.menu_table.Size = new System.Drawing.Size(844, 458);
            this.menu_table.TabIndex = 4;
            // 
            // item_table
            // 
            this.item_table.ColumnCount = 4;
            this.item_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.item_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.item_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.item_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.item_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_table.Location = new System.Drawing.Point(3, 30);
            this.item_table.Name = "item_table";
            this.item_table.RowCount = 2;
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.item_table.Size = new System.Drawing.Size(838, 425);
            this.item_table.TabIndex = 2;
            // 
            // lb_menuDetail
            // 
            this.lb_menuDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_menuDetail.AutoSize = true;
            this.lb_menuDetail.Location = new System.Drawing.Point(3, 7);
            this.lb_menuDetail.Margin = new System.Windows.Forms.Padding(3);
            this.lb_menuDetail.Name = "lb_menuDetail";
            this.lb_menuDetail.Size = new System.Drawing.Size(80, 13);
            this.lb_menuDetail.TabIndex = 0;
            this.lb_menuDetail.Text = "Semua Barang:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1036, 585);
            this.MinimumSize = new System.Drawing.Size(1036, 585);
            this.Name = "MainMenu";
            this.Text = "mainMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.menu_table.ResumeLayout(false);
            this.menu_table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.TableLayoutPanel sidebar;
        private System.Windows.Forms.Label lb_nim;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button bt_catalouge;
        private System.Windows.Forms.Button bt_logo;
        private System.Windows.Forms.ComboBox cb_harga;
        private System.Windows.Forms.ComboBox cb_jenis;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TableLayoutPanel menu_table;
        private System.Windows.Forms.TableLayoutPanel item_table;
        private System.Windows.Forms.Label lb_menuDetail;
    }
}