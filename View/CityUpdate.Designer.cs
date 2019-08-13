namespace gtlc.View
{
    partial class CityUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityUpdate));
            this.inputCity = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputCity
            // 
            resources.ApplyResources(this.inputCity, "inputCity");
            this.inputCity.Name = "inputCity";
            this.inputCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputCity_KeyPress);
            // 
            // labelRole
            // 
            resources.ApplyResources(this.labelRole, "labelRole");
            this.labelRole.Name = "labelRole";
            // 
            // buttonEdit
            // 
            resources.ApplyResources(this.buttonEdit, "buttonEdit");
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // CityUpdate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.inputCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CityUpdate";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.CityUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputCity;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Button buttonEdit;
    }
}