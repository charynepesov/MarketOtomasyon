
namespace MarketManagementSystem
{
    partial class SellerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            this.label_logout = new System.Windows.Forms.Label();
            this.dataGridView_seller = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.comboBox_categories = new System.Windows.Forms.ComboBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_category = new System.Windows.Forms.Button();
            this.button_Product = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_age = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_selling = new System.Windows.Forms.Button();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seller)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label_logout.Location = new System.Drawing.Point(738, 481);
            this.label_logout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(59, 30);
            this.label_logout.TabIndex = 32;
            this.label_logout.Text = "Çıkış";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            this.label_logout.MouseEnter += new System.EventHandler(this.label_logout_MouseEnter);
            this.label_logout.MouseLeave += new System.EventHandler(this.label_logout_MouseLeave);
            // 
            // dataGridView_seller
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_seller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_seller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_seller.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView_seller.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_seller.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_seller.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_seller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_seller.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_seller.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_seller.EnableHeadersVisualStyles = false;
            this.dataGridView_seller.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_seller.Location = new System.Drawing.Point(279, 66);
            this.dataGridView_seller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_seller.Name = "dataGridView_seller";
            this.dataGridView_seller.RowHeadersVisible = false;
            this.dataGridView_seller.RowHeadersWidth = 51;
            this.dataGridView_seller.RowTemplate.Height = 24;
            this.dataGridView_seller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_seller.Size = new System.Drawing.Size(410, 400);
            this.dataGridView_seller.TabIndex = 16;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_seller.ThemeStyle.BackColor = System.Drawing.Color.Lavender;
            this.dataGridView_seller.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_seller.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_seller.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_seller.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_seller.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_seller.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_seller.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_seller.ThemeStyle.ReadOnly = false;
            this.dataGridView_seller.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_seller.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_seller.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_seller.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_seller.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_seller.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_seller.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_seller.Click += new System.EventHandler(this.dataGridView_seller_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.FlatAppearance.BorderSize = 0;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Refresh.ForeColor = System.Drawing.Color.White;
            this.button_Refresh.Location = new System.Drawing.Point(495, 63);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(85, 27);
            this.button_Refresh.TabIndex = 14;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            // 
            // comboBox_categories
            // 
            this.comboBox_categories.FormattingEnabled = true;
            this.comboBox_categories.Location = new System.Drawing.Point(338, 67);
            this.comboBox_categories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_categories.Name = "comboBox_categories";
            this.comboBox_categories.Size = new System.Drawing.Size(154, 21);
            this.comboBox_categories.TabIndex = 13;
            this.comboBox_categories.Text = "Select Category";
            // 
            // button_delete
            // 
            this.button_delete.AutoSize = true;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_delete.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_delete.Location = new System.Drawing.Point(239, 334);
            this.button_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(39, 30);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Sil";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.AutoSize = true;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_update.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_update.Location = new System.Drawing.Point(102, 334);
            this.button_update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(90, 30);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "Güncelle";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.AutoSize = true;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_add.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_add.Location = new System.Drawing.Point(1, 334);
            this.button_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(54, 30);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Ekle";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "ŞİFRE";
            // 
            // TextBox_phone
            // 
            this.TextBox_phone.BorderRadius = 18;
            this.TextBox_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_phone.DefaultText = "";
            this.TextBox_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_phone.FillColor = System.Drawing.Color.Lavender;
            this.TextBox_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_phone.Location = new System.Drawing.Point(127, 225);
            this.TextBox_phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_phone.Name = "TextBox_phone";
            this.TextBox_phone.PasswordChar = '\0';
            this.TextBox_phone.PlaceholderText = "";
            this.TextBox_phone.SelectedText = "";
            this.TextBox_phone.Size = new System.Drawing.Size(147, 27);
            this.TextBox_phone.TabIndex = 7;
            // 
            // button_category
            // 
            this.button_category.AutoSize = true;
            this.button_category.FlatAppearance.BorderSize = 0;
            this.button_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_category.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button_category.Location = new System.Drawing.Point(710, 156);
            this.button_category.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(107, 40);
            this.button_category.TabIndex = 30;
            this.button_category.Text = "Kategori";
            this.button_category.UseVisualStyleBackColor = true;
            this.button_category.Click += new System.EventHandler(this.button_category_Click);
            // 
            // button_Product
            // 
            this.button_Product.AutoSize = true;
            this.button_Product.FlatAppearance.BorderSize = 0;
            this.button_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Product.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_Product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button_Product.Location = new System.Drawing.Point(710, 112);
            this.button_Product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Product.Name = "button_Product";
            this.button_Product.Size = new System.Drawing.Size(72, 40);
            this.button_Product.TabIndex = 29;
            this.button_Product.Text = "Ürün";
            this.button_Product.UseVisualStyleBackColor = true;
            this.button_Product.Click += new System.EventHandler(this.button_Product_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label_exit.Location = new System.Drawing.Point(800, -9);
            this.label_exit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(27, 32);
            this.label_exit.TabIndex = 28;
            this.label_exit.Text = "x";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "YAŞ";
            // 
            // TextBox_age
            // 
            this.TextBox_age.BorderRadius = 18;
            this.TextBox_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_age.DefaultText = "";
            this.TextBox_age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_age.FillColor = System.Drawing.Color.Lavender;
            this.TextBox_age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_age.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_age.Location = new System.Drawing.Point(127, 172);
            this.TextBox_age.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_age.Name = "TextBox_age";
            this.TextBox_age.PasswordChar = '\0';
            this.TextBox_age.PlaceholderText = "";
            this.TextBox_age.SelectedText = "";
            this.TextBox_age.Size = new System.Drawing.Size(147, 27);
            this.TextBox_age.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "TEL NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "İSİM";
            // 
            // TextBox_id
            // 
            this.TextBox_id.BorderRadius = 18;
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.DefaultText = "";
            this.TextBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.FillColor = System.Drawing.Color.Lavender;
            this.TextBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Location = new System.Drawing.Point(127, 66);
            this.TextBox_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.Size = new System.Drawing.Size(147, 27);
            this.TextBox_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // button_selling
            // 
            this.button_selling.AutoSize = true;
            this.button_selling.FlatAppearance.BorderSize = 0;
            this.button_selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selling.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_selling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button_selling.Location = new System.Drawing.Point(710, 200);
            this.button_selling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(69, 40);
            this.button_selling.TabIndex = 31;
            this.button_selling.Text = "Satış";
            this.button_selling.UseVisualStyleBackColor = true;
            this.button_selling.Click += new System.EventHandler(this.button_selling_Click);
            // 
            // TextBox_name
            // 
            this.TextBox_name.BorderRadius = 18;
            this.TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_name.DefaultText = "";
            this.TextBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.FillColor = System.Drawing.Color.Lavender;
            this.TextBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Location = new System.Drawing.Point(127, 119);
            this.TextBox_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.PlaceholderText = "";
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.Size = new System.Drawing.Size(147, 27);
            this.TextBox_name.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.TextBox_pass);
            this.panel1.Controls.Add(this.dataGridView_seller);
            this.panel1.Controls.Add(this.button_Refresh);
            this.panel1.Controls.Add(this.comboBox_categories);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TextBox_phone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBox_age);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 479);
            this.panel1.TabIndex = 27;
            // 
            // TextBox_pass
            // 
            this.TextBox_pass.BorderRadius = 18;
            this.TextBox_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_pass.DefaultText = "";
            this.TextBox_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_pass.FillColor = System.Drawing.Color.Lavender;
            this.TextBox_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_pass.Location = new System.Drawing.Point(127, 278);
            this.TextBox_pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_pass.Name = "TextBox_pass";
            this.TextBox_pass.PasswordChar = '●';
            this.TextBox_pass.PlaceholderText = "";
            this.TextBox_pass.SelectedText = "";
            this.TextBox_pass.Size = new System.Drawing.Size(147, 27);
            this.TextBox_pass.TabIndex = 17;
            this.TextBox_pass.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(160, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 36);
            this.label9.TabIndex = 35;
            this.label9.Text = "◀";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(55, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 34);
            this.label7.TabIndex = 33;
            this.label7.Text = "SATICI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(10, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 36);
            this.label8.TabIndex = 34;
            this.label8.Text = "▶";
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(825, 528);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.button_Product);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seller)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_logout;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_seller;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.ComboBox comboBox_categories;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_phone;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.Button button_Product;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_selling;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_pass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}