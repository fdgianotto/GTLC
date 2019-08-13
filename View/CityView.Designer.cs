namespace gtlc.View
{
    partial class CityView
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
            this.cityGridView = new System.Windows.Forms.DataGridView();
            this.citySearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnManageRemovedItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cityGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cityGridView
            // 
            this.cityGridView.AllowUserToAddRows = false;
            this.cityGridView.AllowUserToDeleteRows = false;
            this.cityGridView.AllowUserToResizeColumns = false;
            this.cityGridView.AllowUserToResizeRows = false;
            this.cityGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.cityGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cityGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cityGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cityGridView.ColumnHeadersHeight = 32;
            this.cityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cityGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.cityGridView.EnableHeadersVisualStyles = false;
            this.cityGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.cityGridView.Location = new System.Drawing.Point(12, 42);
            this.cityGridView.Margin = new System.Windows.Forms.Padding(12);
            this.cityGridView.MultiSelect = false;
            this.cityGridView.Name = "cityGridView";
            this.cityGridView.ReadOnly = true;
            this.cityGridView.RowHeadersVisible = false;
            this.cityGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cityGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cityGridView.Size = new System.Drawing.Size(300, 400);
            this.cityGridView.TabIndex = 3;
            this.cityGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cityGridView_CellClick);
            this.cityGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cityGridView_CellContentClick);
            // 
            // citySearch
            // 
            this.citySearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.citySearch.Location = new System.Drawing.Point(65, 12);
            this.citySearch.Name = "citySearch";
            this.citySearch.Size = new System.Drawing.Size(247, 20);
            this.citySearch.TabIndex = 4;
            this.citySearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.citySearch_KeyUp);
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
            // CityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(366, 505);
            this.Controls.Add(this.btnManageRemovedItems);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.citySearch);
            this.Controls.Add(this.cityGridView);
            this.MaximizeBox = false;
            this.Name = "CityView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cidades";
            this.Load += new System.EventHandler(this.CityView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cityGridView;
        private System.Windows.Forms.TextBox citySearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnManageRemovedItems;
    }
}