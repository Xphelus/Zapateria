namespace Zapateria.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.viewUserButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.adminSubmenu = new System.Windows.Forms.Panel();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.adminMenuButton = new System.Windows.Forms.Button();
            this.mainSubmenu = new System.Windows.Forms.Panel();
            this.receiptsButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.topLeftPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.paylessLogo = new System.Windows.Forms.PictureBox();
            this.leftPanel.SuspendLayout();
            this.adminSubmenu.SuspendLayout();
            this.mainSubmenu.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paylessLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // viewUserButton
            // 
            this.viewUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.viewUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewUserButton.FlatAppearance.BorderSize = 0;
            this.viewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewUserButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewUserButton.ForeColor = System.Drawing.Color.White;
            this.viewUserButton.Location = new System.Drawing.Point(0, 0);
            this.viewUserButton.Name = "viewUserButton";
            this.viewUserButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.viewUserButton.Size = new System.Drawing.Size(207, 30);
            this.viewUserButton.TabIndex = 0;
            this.viewUserButton.Text = "View Users";
            this.viewUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewUserButton.UseVisualStyleBackColor = false;
            this.viewUserButton.Click += new System.EventHandler(this.ViewUserButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.addButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(0, 30);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.addButton.Size = new System.Drawing.Size(207, 30);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add User";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.editUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editUserButton.FlatAppearance.BorderSize = 0;
            this.editUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editUserButton.ForeColor = System.Drawing.Color.White;
            this.editUserButton.Location = new System.Drawing.Point(0, 60);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.editUserButton.Size = new System.Drawing.Size(207, 30);
            this.editUserButton.TabIndex = 3;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editUserButton.UseVisualStyleBackColor = false;
            this.editUserButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(12, 519);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(100, 30);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.AutoScroll = true;
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.leftPanel.Controls.Add(this.usernameLabel);
            this.leftPanel.Controls.Add(this.adminSubmenu);
            this.leftPanel.Controls.Add(this.logOutButton);
            this.leftPanel.Controls.Add(this.adminMenuButton);
            this.leftPanel.Controls.Add(this.mainSubmenu);
            this.leftPanel.Controls.Add(this.menuButton);
            this.leftPanel.Controls.Add(this.topLeftPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(207, 561);
            this.leftPanel.TabIndex = 6;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(12, 501);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(12, 15);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "-";
            // 
            // adminSubmenu
            // 
            this.adminSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.adminSubmenu.Controls.Add(this.deleteUserButton);
            this.adminSubmenu.Controls.Add(this.editUserButton);
            this.adminSubmenu.Controls.Add(this.addButton);
            this.adminSubmenu.Controls.Add(this.viewUserButton);
            this.adminSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminSubmenu.Location = new System.Drawing.Point(0, 232);
            this.adminSubmenu.Name = "adminSubmenu";
            this.adminSubmenu.Size = new System.Drawing.Size(207, 121);
            this.adminSubmenu.TabIndex = 6;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.deleteUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteUserButton.FlatAppearance.BorderSize = 0;
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteUserButton.ForeColor = System.Drawing.Color.White;
            this.deleteUserButton.Location = new System.Drawing.Point(0, 90);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.deleteUserButton.Size = new System.Drawing.Size(207, 30);
            this.deleteUserButton.TabIndex = 7;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // adminMenuButton
            // 
            this.adminMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.adminMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminMenuButton.FlatAppearance.BorderSize = 0;
            this.adminMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminMenuButton.ForeColor = System.Drawing.Color.White;
            this.adminMenuButton.Location = new System.Drawing.Point(0, 193);
            this.adminMenuButton.Name = "adminMenuButton";
            this.adminMenuButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminMenuButton.Size = new System.Drawing.Size(207, 39);
            this.adminMenuButton.TabIndex = 1;
            this.adminMenuButton.Text = "Admin Menu";
            this.adminMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminMenuButton.UseVisualStyleBackColor = false;
            this.adminMenuButton.Click += new System.EventHandler(this.AdminMenuButton_Click);
            // 
            // mainSubmenu
            // 
            this.mainSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.mainSubmenu.Controls.Add(this.receiptsButton);
            this.mainSubmenu.Controls.Add(this.orderButton);
            this.mainSubmenu.Controls.Add(this.inventoryButton);
            this.mainSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainSubmenu.Location = new System.Drawing.Point(0, 103);
            this.mainSubmenu.Name = "mainSubmenu";
            this.mainSubmenu.Size = new System.Drawing.Size(207, 90);
            this.mainSubmenu.TabIndex = 8;
            // 
            // receiptsButton
            // 
            this.receiptsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.receiptsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.receiptsButton.FlatAppearance.BorderSize = 0;
            this.receiptsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.receiptsButton.ForeColor = System.Drawing.Color.White;
            this.receiptsButton.Location = new System.Drawing.Point(0, 60);
            this.receiptsButton.Name = "receiptsButton";
            this.receiptsButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.receiptsButton.Size = new System.Drawing.Size(207, 30);
            this.receiptsButton.TabIndex = 3;
            this.receiptsButton.Text = "Receipts";
            this.receiptsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.receiptsButton.UseVisualStyleBackColor = false;
            this.receiptsButton.Click += new System.EventHandler(this.ReceiptsButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.orderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Location = new System.Drawing.Point(0, 30);
            this.orderButton.Name = "orderButton";
            this.orderButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.orderButton.Size = new System.Drawing.Size(207, 30);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "Create Order";
            this.orderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.inventoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventoryButton.FlatAppearance.BorderSize = 0;
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventoryButton.ForeColor = System.Drawing.Color.White;
            this.inventoryButton.Location = new System.Drawing.Point(0, 0);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.inventoryButton.Size = new System.Drawing.Size(207, 30);
            this.inventoryButton.TabIndex = 0;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.menuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(0, 64);
            this.menuButton.Name = "menuButton";
            this.menuButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuButton.Size = new System.Drawing.Size(207, 39);
            this.menuButton.TabIndex = 7;
            this.menuButton.Text = "Menu";
            this.menuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // topLeftPanel
            // 
            this.topLeftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.topLeftPanel.Name = "topLeftPanel";
            this.topLeftPanel.Size = new System.Drawing.Size(207, 64);
            this.topLeftPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.paylessLogo);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(207, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(727, 561);
            this.mainPanel.TabIndex = 7;
            // 
            // paylessLogo
            // 
            this.paylessLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paylessLogo.Image = ((System.Drawing.Image)(resources.GetObject("paylessLogo.Image")));
            this.paylessLogo.Location = new System.Drawing.Point(92, 150);
            this.paylessLogo.Name = "paylessLogo";
            this.paylessLogo.Size = new System.Drawing.Size(549, 262);
            this.paylessLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paylessLogo.TabIndex = 11;
            this.paylessLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Customer Maintenance";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.adminSubmenu.ResumeLayout(false);
            this.mainSubmenu.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paylessLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button viewUserButton;
        private Button addButton;
        private Button editUserButton;
        private Button logOutButton;
        private Panel leftPanel;
        private Panel topLeftPanel;
        private Button adminMenuButton;
        private Panel adminSubmenu;
        private Button deleteUserButton;
        private Panel mainPanel;
        private PictureBox paylessLogo;
        private Button menuButton;
        private Panel mainSubmenu;
        private Button inventoryButton;
        private Button receiptsButton;
        private Button orderButton;
        private Label usernameLabel;
    }
}