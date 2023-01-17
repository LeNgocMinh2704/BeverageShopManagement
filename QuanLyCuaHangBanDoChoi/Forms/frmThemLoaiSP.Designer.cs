namespace QuanLyCuaHangBanDoChoi.Forms
{
    partial class frmThemLoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemLoaiSP));
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtTenLoaiSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(127)))), ((int)(((byte)(50)))));
            this.btnThemSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemSP.FlatAppearance.BorderSize = 0;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Image = global::QuanLyCuaHangBanDoChoi.Properties.Resources.icons8_add_32px_1;
            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSP.Location = new System.Drawing.Point(341, 99);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(104, 37);
            this.btnThemSP.TabIndex = 12;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtTenLoaiSP
            // 
            this.txtTenLoaiSP.BackColor = System.Drawing.Color.White;
            this.txtTenLoaiSP.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenLoaiSP.Location = new System.Drawing.Point(111, 60);
            this.txtTenLoaiSP.Name = "txtTenLoaiSP";
            this.txtTenLoaiSP.Size = new System.Drawing.Size(334, 33);
            this.txtTenLoaiSP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên loại";
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
            this.button9.Location = new System.Drawing.Point(445, 1);
            this.button9.Name = "button9";
            this.button9.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button9.Size = new System.Drawing.Size(34, 33);
            this.button9.TabIndex = 61;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // frmThemLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 159);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.txtTenLoaiSP);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemLoaiSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemLoaiSP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtTenLoaiSP;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton button9;
    }
}