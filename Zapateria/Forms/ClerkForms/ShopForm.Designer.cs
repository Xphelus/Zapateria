namespace Zapateria.Forms.ClerkForms
{
    partial class ShopForm
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.idLabel = new System.Windows.Forms.Label();
            this.amountTB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.dibsButton = new System.Windows.Forms.Button();
            this.clientIdTB = new System.Windows.Forms.TextBox();
            this.clientIdLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.Silver;
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(703, 452);
            this.dataGrid.TabIndex = 4;
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(12, 467);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(75, 19);
            this.idLabel.TabIndex = 9;
            this.idLabel.Text = "Product ID";
            // 
            // amountTB
            // 
            this.amountTB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.amountTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.amountTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountTB.ForeColor = System.Drawing.Color.White;
            this.amountTB.Location = new System.Drawing.Point(146, 489);
            this.amountTB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(128, 23);
            this.amountTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Amount";
            // 
            // idTB
            // 
            this.idTB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.idTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.idTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTB.ForeColor = System.Drawing.Color.White;
            this.idTB.Location = new System.Drawing.Point(12, 489);
            this.idTB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(128, 23);
            this.idTB.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(280, 489);
            this.addButton.MaximumSize = new System.Drawing.Size(84, 23);
            this.addButton.MinimumSize = new System.Drawing.Size(84, 23);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add To Cart";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dibsButton
            // 
            this.dibsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dibsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.dibsButton.FlatAppearance.BorderSize = 0;
            this.dibsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dibsButton.ForeColor = System.Drawing.Color.White;
            this.dibsButton.Location = new System.Drawing.Point(370, 489);
            this.dibsButton.MaximumSize = new System.Drawing.Size(84, 23);
            this.dibsButton.MinimumSize = new System.Drawing.Size(84, 23);
            this.dibsButton.Name = "dibsButton";
            this.dibsButton.Size = new System.Drawing.Size(84, 23);
            this.dibsButton.TabIndex = 38;
            this.dibsButton.Text = "Add a Dibs";
            this.dibsButton.UseVisualStyleBackColor = false;
            this.dibsButton.Click += new System.EventHandler(this.DibsButton_Click);
            // 
            // clientIdTB
            // 
            this.clientIdTB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clientIdTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.clientIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientIdTB.ForeColor = System.Drawing.Color.White;
            this.clientIdTB.Location = new System.Drawing.Point(460, 489);
            this.clientIdTB.MaximumSize = new System.Drawing.Size(120, 23);
            this.clientIdTB.MinimumSize = new System.Drawing.Size(120, 23);
            this.clientIdTB.Name = "clientIdTB";
            this.clientIdTB.Size = new System.Drawing.Size(120, 23);
            this.clientIdTB.TabIndex = 39;
            // 
            // clientIdLabel
            // 
            this.clientIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clientIdLabel.AutoSize = true;
            this.clientIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientIdLabel.ForeColor = System.Drawing.Color.White;
            this.clientIdLabel.Location = new System.Drawing.Point(460, 467);
            this.clientIdLabel.Name = "clientIdLabel";
            this.clientIdLabel.Size = new System.Drawing.Size(62, 19);
            this.clientIdLabel.TabIndex = 40;
            this.clientIdLabel.Text = "Client ID";
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.acceptButton.FlatAppearance.BorderSize = 0;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.ForeColor = System.Drawing.Color.White;
            this.acceptButton.Location = new System.Drawing.Point(586, 489);
            this.acceptButton.MaximumSize = new System.Drawing.Size(84, 23);
            this.acceptButton.MinimumSize = new System.Drawing.Size(84, 23);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(84, 23);
            this.acceptButton.TabIndex = 41;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(727, 522);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.clientIdLabel);
            this.Controls.Add(this.clientIdTB);
            this.Controls.Add(this.dibsButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGrid;
        private Label idLabel;
        private NumericUpDown amountTB;
        private Label label1;
        private NumericUpDown idTB;
        private Button addButton;
        private Button dibsButton;
        private TextBox clientIdTB;
        private Label clientIdLabel;
        private Button acceptButton;
    }
}