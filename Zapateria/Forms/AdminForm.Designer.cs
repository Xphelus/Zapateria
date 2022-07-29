namespace Zapateria.Forms
{
    partial class AdminForm
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
            this.viewUserButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.adminSubmenu = new System.Windows.Forms.Panel();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.adminMenuButton = new System.Windows.Forms.Button();
            this.topLeftPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.adminSubmenu.SuspendLayout();
            this.mainPanel.SuspendLayout();
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
            this.viewUserButton.Size = new System.Drawing.Size(207, 30);
            this.viewUserButton.TabIndex = 0;
            this.viewUserButton.Text = "View Users";
            this.viewUserButton.UseVisualStyleBackColor = false;
            this.viewUserButton.Click += new System.EventHandler(this.ViewUserButton_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGrid.Location = new System.Drawing.Point(14, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(701, 537);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.Visible = false;
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
            this.addButton.Size = new System.Drawing.Size(207, 30);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add User";
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
            this.editUserButton.Size = new System.Drawing.Size(207, 30);
            this.editUserButton.TabIndex = 3;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = false;
            this.editUserButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // logOutButton
            // 
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
            this.leftPanel.Controls.Add(this.adminSubmenu);
            this.leftPanel.Controls.Add(this.logOutButton);
            this.leftPanel.Controls.Add(this.adminMenuButton);
            this.leftPanel.Controls.Add(this.topLeftPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(207, 561);
            this.leftPanel.TabIndex = 6;
            // 
            // adminSubmenu
            // 
            this.adminSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.adminSubmenu.Controls.Add(this.deleteUserButton);
            this.adminSubmenu.Controls.Add(this.editUserButton);
            this.adminSubmenu.Controls.Add(this.addButton);
            this.adminSubmenu.Controls.Add(this.viewUserButton);
            this.adminSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminSubmenu.Location = new System.Drawing.Point(0, 103);
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
            this.deleteUserButton.Size = new System.Drawing.Size(207, 30);
            this.deleteUserButton.TabIndex = 7;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // adminMenuButton
            // 
            this.adminMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminMenuButton.FlatAppearance.BorderSize = 0;
            this.adminMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminMenuButton.ForeColor = System.Drawing.Color.White;
            this.adminMenuButton.Location = new System.Drawing.Point(0, 64);
            this.adminMenuButton.Name = "adminMenuButton";
            this.adminMenuButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminMenuButton.Size = new System.Drawing.Size(207, 39);
            this.adminMenuButton.TabIndex = 1;
            this.adminMenuButton.Text = "Admin";
            this.adminMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminMenuButton.UseVisualStyleBackColor = true;
            this.adminMenuButton.Click += new System.EventHandler(this.AdminMenuButton_Click);
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
            this.mainPanel.Controls.Add(this.dataGrid);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(207, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(727, 561);
            this.mainPanel.TabIndex = 7;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "Customer Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.adminSubmenu.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button viewUserButton;
        private DataGridView dataGrid;
        private Button addButton;
        private Button editUserButton;
        private Button logOutButton;
        private Panel leftPanel;
        private Panel topLeftPanel;
        private Button adminMenuButton;
        private Panel adminSubmenu;
        private Button deleteUserButton;
        private Panel mainPanel;
    }
}