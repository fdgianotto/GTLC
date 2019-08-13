namespace gtlc.View
{
    partial class RoleView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roleGridView = new System.Windows.Forms.DataGridView();
            this.roleSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnManageRemovedItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roleGridView
            // 
            this.roleGridView.AllowUserToAddRows = false;
            this.roleGridView.AllowUserToDeleteRows = false;
            this.roleGridView.AllowUserToResizeColumns = false;
            this.roleGridView.AllowUserToResizeRows = false;
            this.roleGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.roleGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roleGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.roleGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.roleGridView.ColumnHeadersHeight = 32;
            this.roleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roleGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.roleGridView.EnableHeadersVisualStyles = false;
            this.roleGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.roleGridView.Location = new System.Drawing.Point(12, 42);
            this.roleGridView.Margin = new System.Windows.Forms.Padding(12);
            this.roleGridView.MultiSelect = false;
            this.roleGridView.Name = "roleGridView";
            this.roleGridView.ReadOnly = true;
            this.roleGridView.RowHeadersVisible = false;
            this.roleGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.roleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roleGridView.Size = new System.Drawing.Size(300, 400);
            this.roleGridView.TabIndex = 3;
            this.roleGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roleGridView_CellClick);
            this.roleGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roleGridView_CellContentClick);
            // 
            // roleSearch
            // 
            this.roleSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roleSearch.Location = new System.Drawing.Point(65, 12);
            this.roleSearch.Name = "roleSearch";
            this.roleSearch.Size = new System.Drawing.Size(247, 20);
            this.roleSearch.TabIndex = 4;
            this.roleSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.roleSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisar";
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.Location = new System.Drawing.Point(192, 454);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 24);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Adicionar";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnManageRemovedItems
            // 
            this.btnManageRemovedItems.AutoSize = true;
            this.btnManageRemovedItems.Location = new System.Drawing.Point(12, 454);
            this.btnManageRemovedItems.Margin = new System.Windows.Forms.Padding(12);
            this.btnManageRemovedItems.Name = "btnManageRemovedItems";
            this.btnManageRemovedItems.Size = new System.Drawing.Size(120, 24);
            this.btnManageRemovedItems.TabIndex = 7;
            this.btnManageRemovedItems.Text = "Gerenciar exlusões";
            this.btnManageRemovedItems.UseVisualStyleBackColor = true;
            this.btnManageRemovedItems.Click += new System.EventHandler(this.btnManageRemovedItems_Click);
            // 
            // RoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(366, 505);
            this.Controls.Add(this.btnManageRemovedItems);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roleSearch);
            this.Controls.Add(this.roleGridView);
            this.MaximizeBox = false;
            this.Name = "RoleView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funções";
            this.Load += new System.EventHandler(this.RoleView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView roleGridView;
        private System.Windows.Forms.TextBox roleSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnManageRemovedItems;
    }
}