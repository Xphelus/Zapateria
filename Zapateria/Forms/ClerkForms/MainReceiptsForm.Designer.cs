namespace Zapateria.Forms.ClerkForms
{
    partial class MainReceiptsForm
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
            this.dibsButton = new System.Windows.Forms.Button();
            this.receiptsButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dibsButton
            // 
            this.dibsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.dibsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.dibsButton.FlatAppearance.BorderSize = 0;
            this.dibsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dibsButton.ForeColor = System.Drawing.Color.White;
            this.dibsButton.Location = new System.Drawing.Point(90, 0);
            this.dibsButton.Name = "dibsButton";
            this.dibsButton.Size = new System.Drawing.Size(90, 39);
            this.dibsButton.TabIndex = 9;
            this.dibsButton.Text = "Dibs";
            this.dibsButton.UseVisualStyleBackColor = false;
            this.dibsButton.Click += new System.EventHandler(this.DibsButton_Click);
            // 
            // receiptsButton
            // 
            this.receiptsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.receiptsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.receiptsButton.FlatAppearance.BorderSize = 0;
            this.receiptsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptsButton.ForeColor = System.Drawing.Color.White;
            this.receiptsButton.Location = new System.Drawing.Point(0, 0);
            this.receiptsButton.Name = "receiptsButton";
            this.receiptsButton.Size = new System.Drawing.Size(90, 39);
            this.receiptsButton.TabIndex = 8;
            this.receiptsButton.Text = "Receipts";
            this.receiptsButton.UseVisualStyleBackColor = false;
            this.receiptsButton.Click += new System.EventHandler(this.ReceiptsButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.topPanel.Controls.Add(this.dibsButton);
            this.topPanel.Controls.Add(this.receiptsButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(727, 39);
            this.topPanel.TabIndex = 10;
            // 
            // centerPanel
            // 
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 39);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(727, 522);
            this.centerPanel.TabIndex = 11;
            // 
            // MainReceiptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(727, 561);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainReceiptsForm";
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button dibsButton;
        private Button receiptsButton;
        private Panel topPanel;
        private Panel centerPanel;
    }
}