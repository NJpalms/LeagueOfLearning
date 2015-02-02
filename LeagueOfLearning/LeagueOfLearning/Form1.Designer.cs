namespace LeagueOfLearning
{
    partial class frmLOL
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
            this.txtAPI_Key = new System.Windows.Forms.TextBox();
            this.lblAPI_Key = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAPI_Key
            // 
            this.txtAPI_Key.Location = new System.Drawing.Point(95, 6);
            this.txtAPI_Key.Name = "txtAPI_Key";
            this.txtAPI_Key.Size = new System.Drawing.Size(337, 20);
            this.txtAPI_Key.TabIndex = 0;
            // 
            // lblAPI_Key
            // 
            this.lblAPI_Key.AutoSize = true;
            this.lblAPI_Key.Location = new System.Drawing.Point(44, 9);
            this.lblAPI_Key.Name = "lblAPI_Key";
            this.lblAPI_Key.Size = new System.Drawing.Size(45, 13);
            this.lblAPI_Key.TabIndex = 1;
            this.lblAPI_Key.Text = "API Key";
            // 
            // frmLOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 471);
            this.Controls.Add(this.lblAPI_Key);
            this.Controls.Add(this.txtAPI_Key);
            this.Name = "frmLOL";
            this.Text = "League of Learning";
            this.Load += new System.EventHandler(this.frmLOL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAPI_Key;
        private System.Windows.Forms.Label lblAPI_Key;
    }
}

