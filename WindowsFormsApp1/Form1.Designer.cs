namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BanCo_pnl = new System.Windows.Forms.Panel();
            this.KhungHinh_pnl = new System.Windows.Forms.Panel();
            this.PicBoxAva = new System.Windows.Forms.PictureBox();
            this.KhungNgChoi_pnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLAN = new System.Windows.Forms.Button();
            this.IP_PlayerIP_txtb = new System.Windows.Forms.TextBox();
            this.pic_mark_box = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.PlayerName_txtb = new System.Windows.Forms.TextBox();
            this.KhungHinh_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxAva)).BeginInit();
            this.KhungNgChoi_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mark_box)).BeginInit();
            this.SuspendLayout();
            // 
            // BanCo_pnl
            // 
            this.BanCo_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.BanCo_pnl.Location = new System.Drawing.Point(12, 12);
            this.BanCo_pnl.Name = "BanCo_pnl";
            this.BanCo_pnl.Size = new System.Drawing.Size(935, 710);
            this.BanCo_pnl.TabIndex = 0;
            // 
            // KhungHinh_pnl
            // 
            this.KhungHinh_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KhungHinh_pnl.Controls.Add(this.PicBoxAva);
            this.KhungHinh_pnl.Location = new System.Drawing.Point(968, 12);
            this.KhungHinh_pnl.Name = "KhungHinh_pnl";
            this.KhungHinh_pnl.Size = new System.Drawing.Size(364, 364);
            this.KhungHinh_pnl.TabIndex = 1;
            // 
            // PicBoxAva
            // 
            this.PicBoxAva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBoxAva.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PicBoxAva.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.caroimage;
            this.PicBoxAva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxAva.Location = new System.Drawing.Point(0, 0);
            this.PicBoxAva.Name = "PicBoxAva";
            this.PicBoxAva.Size = new System.Drawing.Size(364, 364);
            this.PicBoxAva.TabIndex = 0;
            this.PicBoxAva.TabStop = false;
            // 
            // KhungNgChoi_pnl
            // 
            this.KhungNgChoi_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KhungNgChoi_pnl.Controls.Add(this.label1);
            this.KhungNgChoi_pnl.Controls.Add(this.buttonLAN);
            this.KhungNgChoi_pnl.Controls.Add(this.IP_PlayerIP_txtb);
            this.KhungNgChoi_pnl.Controls.Add(this.pic_mark_box);
            this.KhungNgChoi_pnl.Controls.Add(this.progressBar);
            this.KhungNgChoi_pnl.Controls.Add(this.PlayerName_txtb);
            this.KhungNgChoi_pnl.Location = new System.Drawing.Point(968, 382);
            this.KhungNgChoi_pnl.Name = "KhungNgChoi_pnl";
            this.KhungNgChoi_pnl.Size = new System.Drawing.Size(364, 305);
            this.KhungNgChoi_pnl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 140);
            this.label1.TabIndex = 5;
            this.label1.Text = "Luật chơi:\r\n- 2 người chơi lần lượt đánh các nước cờ \r\n\"X\" và \"O\"\r\n- Người chơi c" +
    "ó 5 hàng (dọc, ngang hoặc \r\nchéo) đầu tiên sẽ dành chiến thắng.\r\nCHÚC BẠN MAY MẮ" +
    "N!! <3\r\n\r\n";
            // 
            // buttonLAN
            // 
            this.buttonLAN.Location = new System.Drawing.Point(3, 105);
            this.buttonLAN.Name = "buttonLAN";
            this.buttonLAN.Size = new System.Drawing.Size(163, 26);
            this.buttonLAN.TabIndex = 4;
            this.buttonLAN.Text = "LAN";
            this.buttonLAN.UseVisualStyleBackColor = true;
            // 
            // IP_PlayerIP_txtb
            // 
            this.IP_PlayerIP_txtb.Location = new System.Drawing.Point(3, 77);
            this.IP_PlayerIP_txtb.Name = "IP_PlayerIP_txtb";
            this.IP_PlayerIP_txtb.Size = new System.Drawing.Size(163, 22);
            this.IP_PlayerIP_txtb.TabIndex = 3;
            this.IP_PlayerIP_txtb.Text = "127.0.0.1";
            // 
            // pic_mark_box
            // 
            this.pic_mark_box.BackColor = System.Drawing.SystemColors.Control;
            this.pic_mark_box.Location = new System.Drawing.Point(172, 3);
            this.pic_mark_box.Name = "pic_mark_box";
            this.pic_mark_box.Size = new System.Drawing.Size(189, 128);
            this.pic_mark_box.TabIndex = 2;
            this.pic_mark_box.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 31);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(163, 40);
            this.progressBar.TabIndex = 1;
            // 
            // PlayerName_txtb
            // 
            this.PlayerName_txtb.Location = new System.Drawing.Point(3, 3);
            this.PlayerName_txtb.Name = "PlayerName_txtb";
            this.PlayerName_txtb.ReadOnly = true;
            this.PlayerName_txtb.Size = new System.Drawing.Size(163, 22);
            this.PlayerName_txtb.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 728);
            this.Controls.Add(this.KhungNgChoi_pnl);
            this.Controls.Add(this.KhungHinh_pnl);
            this.Controls.Add(this.BanCo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.KhungHinh_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxAva)).EndInit();
            this.KhungNgChoi_pnl.ResumeLayout(false);
            this.KhungNgChoi_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mark_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BanCo_pnl;
        private System.Windows.Forms.Panel KhungHinh_pnl;
        private System.Windows.Forms.PictureBox PicBoxAva;
        private System.Windows.Forms.Panel KhungNgChoi_pnl;
        private System.Windows.Forms.Button buttonLAN;
        private System.Windows.Forms.TextBox IP_PlayerIP_txtb;
        private System.Windows.Forms.PictureBox pic_mark_box;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox PlayerName_txtb;
        private System.Windows.Forms.Label label1;
    }
}

