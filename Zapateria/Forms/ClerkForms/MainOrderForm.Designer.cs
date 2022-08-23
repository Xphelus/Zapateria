namespace Zapateria.Forms.ClerkForms
{
    partial class MainOrderForm
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
            this.invButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.cartButton = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // invButton
            // 
            this.invButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.invButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.invButton.FlatAppearance.BorderSize = 0;
            this.invButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invButton.ForeColor = System.Drawing.Color.White;
            this.invButton.Location = new System.Drawing.Point(0, 0);
            this.invButton.Name = "invButton";
            this.invButton.Size = new System.Drawing.Size(90, 39);
            this.invButton.TabIndex = 8;
            this.invButton.Text = "Inventory";
            this.invButton.UseVisualStyleBackColor = false;
            this.invButton.Click += new System.EventHandler(this.InvButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.topPanel.Controls.Add(this.cartButton);
            this.topPanel.Controls.Add(this.invButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(727, 39);
            this.topPanel.TabIndex = 9;
            // 
            // cartButton
            // 
            this.cartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.cartButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.cartButton.FlatAppearance.BorderSize = 0;
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartButton.ForeColor = System.Drawing.Color.White;
            this.cartButton.Location = new System.Drawing.Point(90, 0);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(90, 39);
            this.cartButton.TabIndex = 9;
            this.cartButton.Text = "Cart";
            this.cartButton.UseVisualStyleBackColor = false;
            this.cartButton.Click += new System.EventHandler(this.CartButton_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 39);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(727, 522);
            this.centerPanel.TabIndex = 10;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(727, 561);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button invButton;
        private Panel topPanel;
        private Button cartButton;
        private Panel centerPanel;
    }
}