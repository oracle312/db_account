namespace testDB
{
    partial class Main
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
            this.label_userinfo = new System.Windows.Forms.Label();
            this.lable_lastlogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_userinfo
            // 
            this.label_userinfo.AutoSize = true;
            this.label_userinfo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_userinfo.Location = new System.Drawing.Point(10, 13);
            this.label_userinfo.Name = "label_userinfo";
            this.label_userinfo.Size = new System.Drawing.Size(39, 15);
            this.label_userinfo.TabIndex = 0;
            this.label_userinfo.Text = "label1";
            // 
            // lable_lastlogin
            // 
            this.lable_lastlogin.AutoSize = true;
            this.lable_lastlogin.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lable_lastlogin.Location = new System.Drawing.Point(10, 37);
            this.lable_lastlogin.Name = "lable_lastlogin";
            this.lable_lastlogin.Size = new System.Drawing.Size(39, 15);
            this.lable_lastlogin.TabIndex = 1;
            this.lable_lastlogin.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 276);
            this.Controls.Add(this.lable_lastlogin);
            this.Controls.Add(this.label_userinfo);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_userinfo;
        public System.Windows.Forms.Label lable_lastlogin;
    }
}