namespace QuanLyCuaHangBanDoChoi.Forms
{
    partial class frmChonNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonNCC));
            this.btnChon = new System.Windows.Forms.Button();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.button1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.button9 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(127)))), ((int)(((byte)(50)))));
            this.btnChon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChon.FlatAppearance.BorderSize = 0;
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.Color.White;
            this.btnChon.Image = global::QuanLyCuaHangBanDoChoi.Properties.Resources.icons8_ok_32px;
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChon.Location = new System.Drawing.Point(372, 110);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(96, 37);
            this.btnChon.TabIndex = 17;
            this.btnChon.Text = "Chọn";
            this.btnChon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // cboNCC
            // 
            this.cboNCC.BackColor = System.Drawing.Color.White;
            this.cboNCC.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNCC.ForeColor = System.Drawing.Color.Black;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.ItemHeight = 25;
            this.cboNCC.Location = new System.Drawing.Point(169, 43);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(148, 33);
            this.cboNCC.TabIndex = 56;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(60, 46);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 21);
            this.label24.TabIndex = 58;
            this.label24.Text = "Nhà cung cấp";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageOffset = new System.Drawing.Point(0, 0);
            this.button1.ImageRotate = 0F;
            this.button1.ImageSize = new System.Drawing.Size(35, 35);
            this.button1.IndicateFocus = true;
            this.button1.Location = new System.Drawing.Point(323, 43);
            this.button1.Name = "button1";
            this.button1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button1.Size = new System.Drawing.Size(38, 33);
            this.button1.TabIndex = 59;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button9.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageOffset = new System.Drawing.Point(0, 0);
            this.button9.ImageRotate = 0F;
            this.button9.ImageSize = new System.Drawing.Size(40, 40);
            this.button9.IndicateFocus = true;
            this.button9.Location = new System.Drawing.Point(443, 3);
            this.button9.Name = "button9";
            this.button9.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button9.Size = new System.Drawing.Size(34, 33);
            this.button9.TabIndex = 60;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // frmChonNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 159);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboNCC);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.btnChon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChonNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChonNCC";
            this.Load += new System.EventHandler(this.frmChonNCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label label24;
        private Guna.UI2.WinForms.Guna2ImageButton button1;
        private Guna.UI2.WinForms.Guna2ImageButton button9;
    }
}