namespace Zapateria.Forms.ClerkForms
{
    partial class InvForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addLabel = new System.Windows.Forms.Label();
            this.editLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.categoryAddTB = new System.Windows.Forms.TextBox();
            this.nameAddTB = new System.Windows.Forms.TextBox();
            this.idAddTB = new System.Windows.Forms.TextBox();
            this.categoryEditTB = new System.Windows.Forms.TextBox();
            this.nameEditTB = new System.Windows.Forms.TextBox();
            this.idEditTB = new System.Windows.Forms.TextBox();
            this.idAddLabel = new System.Windows.Forms.Label();
            this.idEditLabel = new System.Windows.Forms.Label();
            this.nameAddLabel = new System.Windows.Forms.Label();
            this.nameEditLabel = new System.Windows.Forms.Label();
            this.priceAddLabel = new System.Windows.Forms.Label();
            this.priceEditLabel = new System.Windows.Forms.Label();
            this.categoryAddLabel = new System.Windows.Forms.Label();
            this.categoryEditLabel = new System.Windows.Forms.Label();
            this.amountAddLabel = new System.Windows.Forms.Label();
            this.amountEditLabel = new System.Windows.Forms.Label();
            this.fetchButton = new System.Windows.Forms.Button();
            this.priceAddTB = new System.Windows.Forms.NumericUpDown();
            this.priceEditTB = new System.Windows.Forms.NumericUpDown();
            this.amountAddTB = new System.Windows.Forms.NumericUpDown();
            this.amountEditTB = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.priceAddTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceEditTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountAddTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountEditTB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.panel1.Location = new System.Drawing.Point(358, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 561);
            this.panel1.TabIndex = 0;
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addLabel.ForeColor = System.Drawing.Color.White;
            this.addLabel.Location = new System.Drawing.Point(12, 9);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(66, 37);
            this.addLabel.TabIndex = 1;
            this.addLabel.Text = "Add";
            // 
            // editLabel
            // 
            this.editLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editLabel.AutoSize = true;
            this.editLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editLabel.ForeColor = System.Drawing.Color.White;
            this.editLabel.Location = new System.Drawing.Point(652, 9);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(63, 37);
            this.editLabel.TabIndex = 2;
            this.editLabel.Text = "Edit";
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.editButton.Enabled = false;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(630, 514);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(85, 35);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(12, 514);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 35);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // categoryAddTB
            // 
            this.categoryAddTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryAddTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.categoryAddTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryAddTB.ForeColor = System.Drawing.Color.White;
            this.categoryAddTB.Location = new System.Drawing.Point(12, 325);
            this.categoryAddTB.Name = "categoryAddTB";
            this.categoryAddTB.Size = new System.Drawing.Size(128, 23);
            this.categoryAddTB.TabIndex = 17;
            // 
            // nameAddTB
            // 
            this.nameAddTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameAddTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.nameAddTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameAddTB.ForeColor = System.Drawing.Color.White;
            this.nameAddTB.Location = new System.Drawing.Point(12, 174);
            this.nameAddTB.Name = "nameAddTB";
            this.nameAddTB.Size = new System.Drawing.Size(128, 23);
            this.nameAddTB.TabIndex = 15;
            // 
            // idAddTB
            // 
            this.idAddTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idAddTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.idAddTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idAddTB.Enabled = false;
            this.idAddTB.ForeColor = System.Drawing.Color.White;
            this.idAddTB.Location = new System.Drawing.Point(12, 101);
            this.idAddTB.Name = "idAddTB";
            this.idAddTB.Size = new System.Drawing.Size(128, 23);
            this.idAddTB.TabIndex = 14;
            // 
            // categoryEditTB
            // 
            this.categoryEditTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryEditTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.categoryEditTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryEditTB.ForeColor = System.Drawing.Color.White;
            this.categoryEditTB.Location = new System.Drawing.Point(587, 325);
            this.categoryEditTB.Name = "categoryEditTB";
            this.categoryEditTB.Size = new System.Drawing.Size(128, 23);
            this.categoryEditTB.TabIndex = 22;
            // 
            // nameEditTB
            // 
            this.nameEditTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameEditTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.nameEditTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameEditTB.ForeColor = System.Drawing.Color.White;
            this.nameEditTB.Location = new System.Drawing.Point(587, 174);
            this.nameEditTB.Name = "nameEditTB";
            this.nameEditTB.Size = new System.Drawing.Size(128, 23);
            this.nameEditTB.TabIndex = 20;
            // 
            // idEditTB
            // 
            this.idEditTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idEditTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.idEditTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idEditTB.ForeColor = System.Drawing.Color.White;
            this.idEditTB.Location = new System.Drawing.Point(587, 101);
            this.idEditTB.Name = "idEditTB";
            this.idEditTB.Size = new System.Drawing.Size(128, 23);
            this.idEditTB.TabIndex = 19;
            // 
            // idAddLabel
            // 
            this.idAddLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idAddLabel.AutoSize = true;
            this.idAddLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idAddLabel.ForeColor = System.Drawing.Color.White;
            this.idAddLabel.Location = new System.Drawing.Point(12, 79);
            this.idAddLabel.Name = "idAddLabel";
            this.idAddLabel.Size = new System.Drawing.Size(75, 19);
            this.idAddLabel.TabIndex = 24;
            this.idAddLabel.Text = "Product ID";
            // 
            // idEditLabel
            // 
            this.idEditLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idEditLabel.AutoSize = true;
            this.idEditLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idEditLabel.ForeColor = System.Drawing.Color.White;
            this.idEditLabel.Location = new System.Drawing.Point(640, 79);
            this.idEditLabel.Name = "idEditLabel";
            this.idEditLabel.Size = new System.Drawing.Size(75, 19);
            this.idEditLabel.TabIndex = 25;
            this.idEditLabel.Text = "Product ID";
            // 
            // nameAddLabel
            // 
            this.nameAddLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameAddLabel.AutoSize = true;
            this.nameAddLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameAddLabel.ForeColor = System.Drawing.Color.White;
            this.nameAddLabel.Location = new System.Drawing.Point(12, 152);
            this.nameAddLabel.Name = "nameAddLabel";
            this.nameAddLabel.Size = new System.Drawing.Size(97, 19);
            this.nameAddLabel.TabIndex = 26;
            this.nameAddLabel.Text = "Product Name";
            // 
            // nameEditLabel
            // 
            this.nameEditLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameEditLabel.AutoSize = true;
            this.nameEditLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameEditLabel.ForeColor = System.Drawing.Color.White;
            this.nameEditLabel.Location = new System.Drawing.Point(618, 152);
            this.nameEditLabel.Name = "nameEditLabel";
            this.nameEditLabel.Size = new System.Drawing.Size(97, 19);
            this.nameEditLabel.TabIndex = 27;
            this.nameEditLabel.Text = "Product Name";
            // 
            // priceAddLabel
            // 
            this.priceAddLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceAddLabel.AutoSize = true;
            this.priceAddLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceAddLabel.ForeColor = System.Drawing.Color.White;
            this.priceAddLabel.Location = new System.Drawing.Point(12, 226);
            this.priceAddLabel.Name = "priceAddLabel";
            this.priceAddLabel.Size = new System.Drawing.Size(90, 19);
            this.priceAddLabel.TabIndex = 28;
            this.priceAddLabel.Text = "Product Price";
            // 
            // priceEditLabel
            // 
            this.priceEditLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceEditLabel.AutoSize = true;
            this.priceEditLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceEditLabel.ForeColor = System.Drawing.Color.White;
            this.priceEditLabel.Location = new System.Drawing.Point(625, 226);
            this.priceEditLabel.Name = "priceEditLabel";
            this.priceEditLabel.Size = new System.Drawing.Size(90, 19);
            this.priceEditLabel.TabIndex = 29;
            this.priceEditLabel.Text = "Product Price";
            // 
            // categoryAddLabel
            // 
            this.categoryAddLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryAddLabel.AutoSize = true;
            this.categoryAddLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryAddLabel.ForeColor = System.Drawing.Color.White;
            this.categoryAddLabel.Location = new System.Drawing.Point(12, 303);
            this.categoryAddLabel.Name = "categoryAddLabel";
            this.categoryAddLabel.Size = new System.Drawing.Size(117, 19);
            this.categoryAddLabel.TabIndex = 30;
            this.categoryAddLabel.Text = "Product Category";
            // 
            // categoryEditLabel
            // 
            this.categoryEditLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryEditLabel.AutoSize = true;
            this.categoryEditLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryEditLabel.ForeColor = System.Drawing.Color.White;
            this.categoryEditLabel.Location = new System.Drawing.Point(598, 303);
            this.categoryEditLabel.Name = "categoryEditLabel";
            this.categoryEditLabel.Size = new System.Drawing.Size(117, 19);
            this.categoryEditLabel.TabIndex = 31;
            this.categoryEditLabel.Text = "Product Category";
            // 
            // amountAddLabel
            // 
            this.amountAddLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountAddLabel.AutoSize = true;
            this.amountAddLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountAddLabel.ForeColor = System.Drawing.Color.White;
            this.amountAddLabel.Location = new System.Drawing.Point(12, 385);
            this.amountAddLabel.Name = "amountAddLabel";
            this.amountAddLabel.Size = new System.Drawing.Size(111, 19);
            this.amountAddLabel.TabIndex = 32;
            this.amountAddLabel.Text = "Product Amount";
            // 
            // amountEditLabel
            // 
            this.amountEditLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountEditLabel.AutoSize = true;
            this.amountEditLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountEditLabel.ForeColor = System.Drawing.Color.White;
            this.amountEditLabel.Location = new System.Drawing.Point(604, 385);
            this.amountEditLabel.Name = "amountEditLabel";
            this.amountEditLabel.Size = new System.Drawing.Size(111, 19);
            this.amountEditLabel.TabIndex = 33;
            this.amountEditLabel.Text = "Product Amount";
            // 
            // fetchButton
            // 
            this.fetchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fetchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.fetchButton.FlatAppearance.BorderSize = 0;
            this.fetchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchButton.ForeColor = System.Drawing.Color.White;
            this.fetchButton.Location = new System.Drawing.Point(497, 101);
            this.fetchButton.MaximumSize = new System.Drawing.Size(84, 23);
            this.fetchButton.MinimumSize = new System.Drawing.Size(84, 23);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(84, 23);
            this.fetchButton.TabIndex = 34;
            this.fetchButton.Text = "Fetch";
            this.fetchButton.UseVisualStyleBackColor = false;
            this.fetchButton.Click += new System.EventHandler(this.FetchButton_Click);
            // 
            // priceAddTB
            // 
            this.priceAddTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceAddTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.priceAddTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceAddTB.ForeColor = System.Drawing.Color.White;
            this.priceAddTB.Location = new System.Drawing.Point(12, 248);
            this.priceAddTB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceAddTB.Name = "priceAddTB";
            this.priceAddTB.Size = new System.Drawing.Size(128, 23);
            this.priceAddTB.TabIndex = 35;
            // 
            // priceEditTB
            // 
            this.priceEditTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceEditTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.priceEditTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceEditTB.ForeColor = System.Drawing.Color.White;
            this.priceEditTB.Location = new System.Drawing.Point(587, 248);
            this.priceEditTB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceEditTB.Name = "priceEditTB";
            this.priceEditTB.Size = new System.Drawing.Size(128, 23);
            this.priceEditTB.TabIndex = 36;
            // 
            // amountAddTB
            // 
            this.amountAddTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountAddTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.amountAddTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountAddTB.ForeColor = System.Drawing.Color.White;
            this.amountAddTB.Location = new System.Drawing.Point(12, 407);
            this.amountAddTB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.amountAddTB.Name = "amountAddTB";
            this.amountAddTB.Size = new System.Drawing.Size(128, 23);
            this.amountAddTB.TabIndex = 37;
            // 
            // amountEditTB
            // 
            this.amountEditTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountEditTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.amountEditTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountEditTB.ForeColor = System.Drawing.Color.White;
            this.amountEditTB.Location = new System.Drawing.Point(587, 407);
            this.amountEditTB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.amountEditTB.Name = "amountEditTB";
            this.amountEditTB.Size = new System.Drawing.Size(128, 23);
            this.amountEditTB.TabIndex = 38;
            // 
            // InvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(727, 561);
            this.Controls.Add(this.amountEditTB);
            this.Controls.Add(this.amountAddTB);
            this.Controls.Add(this.priceEditTB);
            this.Controls.Add(this.priceAddTB);
            this.Controls.Add(this.fetchButton);
            this.Controls.Add(this.amountEditLabel);
            this.Controls.Add(this.amountAddLabel);
            this.Controls.Add(this.categoryEditLabel);
            this.Controls.Add(this.categoryAddLabel);
            this.Controls.Add(this.priceEditLabel);
            this.Controls.Add(this.priceAddLabel);
            this.Controls.Add(this.nameEditLabel);
            this.Controls.Add(this.nameAddLabel);
            this.Controls.Add(this.idEditLabel);
            this.Controls.Add(this.idAddLabel);
            this.Controls.Add(this.categoryEditTB);
            this.Controls.Add(this.nameEditTB);
            this.Controls.Add(this.idEditTB);
            this.Controls.Add(this.categoryAddTB);
            this.Controls.Add(this.nameAddTB);
            this.Controls.Add(this.idAddTB);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceAddTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceEditTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountAddTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountEditTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label addLabel;
        private Label editLabel;
        private Button editButton;
        private Button addButton;
        private TextBox categoryAddTB;
        private TextBox nameAddTB;
        private TextBox idAddTB;
        private TextBox categoryEditTB;
        private TextBox nameEditTB;
        private TextBox idEditTB;
        private Label idAddLabel;
        private Label idEditLabel;
        private Label nameAddLabel;
        private Label nameEditLabel;
        private Label priceAddLabel;
        private Label priceEditLabel;
        private Label categoryAddLabel;
        private Label categoryEditLabel;
        private Label amountAddLabel;
        private Label amountEditLabel;
        private Button fetchButton;
        private NumericUpDown priceAddTB;
        private NumericUpDown priceEditTB;
        private NumericUpDown amountAddTB;
        private NumericUpDown amountEditTB;
    }
}