namespace QLPhongTro.ChildForm
{
    partial class frmThanhToan
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
            this.pblBottom = new System.Windows.Forms.Panel();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThanhToanGiaHan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbContent = new System.Windows.Forms.GroupBox();
            this.btnThanhToanTraPhong = new System.Windows.Forms.Button();
            this.lblConLai = new System.Windows.Forms.Label();
            this.lblTienDien = new System.Windows.Forms.Label();
            this.lblTongTienCanThanhToan = new System.Windows.Forms.Label();
            this.lblSoDuNo = new System.Windows.Forms.Label();
            this.lblTongTienThang = new System.Windows.Forms.Label();
            this.lblTienMang = new System.Windows.Forms.Label();
            this.lblTienVeSinh = new System.Windows.Forms.Label();
            this.lblTienNuoc = new System.Windows.Forms.Label();
            this.lblTienPhong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            this.grbContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pblBottom
            // 
            this.pblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblBottom.Location = new System.Drawing.Point(13, 464);
            this.pblBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pblBottom.Name = "pblBottom";
            this.pblBottom.Size = new System.Drawing.Size(933, 12);
            this.pblBottom.TabIndex = 15;
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhToan.Location = new System.Drawing.Point(197, 279);
            this.txtThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(167, 23);
            this.txtThanhToan.TabIndex = 2;
            this.txtThanhToan.Text = "0";
            this.txtThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtThanhToan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThanhToan_KeyPress);
            this.txtThanhToan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtThanhToan_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thanh toán";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(63, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Khách thuê phòng";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 37);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(13, 439);
            this.pnlLeft.TabIndex = 13;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.ptbExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(946, 37);
            this.pnlTop.TabIndex = 14;
            // 
            // ptbExit
            // 
            this.ptbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExit.Image = global::QLPhongTro.Properties.Resources.close;
            this.ptbExit.Location = new System.Drawing.Point(904, 9);
            this.ptbExit.Margin = new System.Windows.Forms.Padding(4);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(27, 25);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExit.TabIndex = 0;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(580, 346);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(288, 28);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnThanhToanGiaHan
            // 
            this.btnThanhToanGiaHan.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnThanhToanGiaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToanGiaHan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToanGiaHan.Location = new System.Drawing.Point(56, 346);
            this.btnThanhToanGiaHan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToanGiaHan.Name = "btnThanhToanGiaHan";
            this.btnThanhToanGiaHan.Size = new System.Drawing.Size(251, 28);
            this.btnThanhToanGiaHan.TabIndex = 5;
            this.btnThanhToanGiaHan.Text = "Thanh toán và gia hạn";
            this.btnThanhToanGiaHan.UseVisualStyleBackColor = false;
            this.btnThanhToanGiaHan.Click += new System.EventHandler(this.btnThanhToanGiaHan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiền phòng:";
            // 
            // grbContent
            // 
            this.grbContent.Controls.Add(this.btnThanhToanTraPhong);
            this.grbContent.Controls.Add(this.txtThanhToan);
            this.grbContent.Controls.Add(this.label2);
            this.grbContent.Controls.Add(this.btnHuy);
            this.grbContent.Controls.Add(this.btnThanhToanGiaHan);
            this.grbContent.Controls.Add(this.lblConLai);
            this.grbContent.Controls.Add(this.lblTienDien);
            this.grbContent.Controls.Add(this.lblTongTienCanThanhToan);
            this.grbContent.Controls.Add(this.lblSoDuNo);
            this.grbContent.Controls.Add(this.lblTongTienThang);
            this.grbContent.Controls.Add(this.lblTienMang);
            this.grbContent.Controls.Add(this.lblTienVeSinh);
            this.grbContent.Controls.Add(this.lblTienNuoc);
            this.grbContent.Controls.Add(this.lblTienPhong);
            this.grbContent.Controls.Add(this.label4);
            this.grbContent.Controls.Add(this.lblPhong);
            this.grbContent.Controls.Add(this.label17);
            this.grbContent.Controls.Add(this.label7);
            this.grbContent.Controls.Add(this.label15);
            this.grbContent.Controls.Add(this.label13);
            this.grbContent.Controls.Add(this.label11);
            this.grbContent.Controls.Add(this.label9);
            this.grbContent.Controls.Add(this.label5);
            this.grbContent.Controls.Add(this.label3);
            this.grbContent.Controls.Add(this.label1);
            this.grbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbContent.Location = new System.Drawing.Point(13, 37);
            this.grbContent.Margin = new System.Windows.Forms.Padding(4);
            this.grbContent.Name = "grbContent";
            this.grbContent.Padding = new System.Windows.Forms.Padding(4);
            this.grbContent.Size = new System.Drawing.Size(933, 427);
            this.grbContent.TabIndex = 16;
            this.grbContent.TabStop = false;
            this.grbContent.Enter += new System.EventHandler(this.grbContent_Enter);
            // 
            // btnThanhToanTraPhong
            // 
            this.btnThanhToanTraPhong.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnThanhToanTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToanTraPhong.ForeColor = System.Drawing.Color.White;
            this.btnThanhToanTraPhong.Location = new System.Drawing.Point(315, 346);
            this.btnThanhToanTraPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToanTraPhong.Name = "btnThanhToanTraPhong";
            this.btnThanhToanTraPhong.Size = new System.Drawing.Size(257, 28);
            this.btnThanhToanTraPhong.TabIndex = 8;
            this.btnThanhToanTraPhong.Text = "Thanh toán và trả phòng";
            this.btnThanhToanTraPhong.UseVisualStyleBackColor = false;
            this.btnThanhToanTraPhong.Click += new System.EventHandler(this.btnThanhToanTraPhong_Click);
            // 
            // lblConLai
            // 
            this.lblConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConLai.ForeColor = System.Drawing.Color.White;
            this.lblConLai.Location = new System.Drawing.Point(696, 279);
            this.lblConLai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConLai.Name = "lblConLai";
            this.lblConLai.Size = new System.Drawing.Size(172, 16);
            this.lblConLai.TabIndex = 1;
            this.lblConLai.Text = "0";
            this.lblConLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTienDien
            // 
            this.lblTienDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDien.ForeColor = System.Drawing.Color.White;
            this.lblTienDien.Location = new System.Drawing.Point(696, 92);
            this.lblTienDien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienDien.Name = "lblTienDien";
            this.lblTienDien.Size = new System.Drawing.Size(172, 16);
            this.lblTienDien.TabIndex = 1;
            this.lblTienDien.Text = "0";
            this.lblTienDien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongTienCanThanhToan
            // 
            this.lblTongTienCanThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienCanThanhToan.ForeColor = System.Drawing.Color.White;
            this.lblTongTienCanThanhToan.Location = new System.Drawing.Point(696, 207);
            this.lblTongTienCanThanhToan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTienCanThanhToan.Name = "lblTongTienCanThanhToan";
            this.lblTongTienCanThanhToan.Size = new System.Drawing.Size(172, 16);
            this.lblTongTienCanThanhToan.TabIndex = 1;
            this.lblTongTienCanThanhToan.Text = "0";
            this.lblTongTienCanThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSoDuNo
            // 
            this.lblSoDuNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDuNo.ForeColor = System.Drawing.Color.White;
            this.lblSoDuNo.Location = new System.Drawing.Point(197, 207);
            this.lblSoDuNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoDuNo.Name = "lblSoDuNo";
            this.lblSoDuNo.Size = new System.Drawing.Size(157, 16);
            this.lblSoDuNo.TabIndex = 1;
            this.lblSoDuNo.Text = "0";
            this.lblSoDuNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongTienThang
            // 
            this.lblTongTienThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienThang.ForeColor = System.Drawing.Color.White;
            this.lblTongTienThang.Location = new System.Drawing.Point(696, 169);
            this.lblTongTienThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTienThang.Name = "lblTongTienThang";
            this.lblTongTienThang.Size = new System.Drawing.Size(172, 16);
            this.lblTongTienThang.TabIndex = 1;
            this.lblTongTienThang.Text = "0";
            this.lblTongTienThang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTienMang
            // 
            this.lblTienMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienMang.ForeColor = System.Drawing.Color.White;
            this.lblTienMang.Location = new System.Drawing.Point(197, 169);
            this.lblTienMang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienMang.Name = "lblTienMang";
            this.lblTienMang.Size = new System.Drawing.Size(157, 16);
            this.lblTienMang.TabIndex = 1;
            this.lblTienMang.Text = "0";
            this.lblTienMang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTienVeSinh
            // 
            this.lblTienVeSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienVeSinh.ForeColor = System.Drawing.Color.White;
            this.lblTienVeSinh.Location = new System.Drawing.Point(696, 130);
            this.lblTienVeSinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienVeSinh.Name = "lblTienVeSinh";
            this.lblTienVeSinh.Size = new System.Drawing.Size(172, 16);
            this.lblTienVeSinh.TabIndex = 1;
            this.lblTienVeSinh.Text = "0";
            this.lblTienVeSinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTienNuoc
            // 
            this.lblTienNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienNuoc.ForeColor = System.Drawing.Color.White;
            this.lblTienNuoc.Location = new System.Drawing.Point(197, 130);
            this.lblTienNuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienNuoc.Name = "lblTienNuoc";
            this.lblTienNuoc.Size = new System.Drawing.Size(157, 16);
            this.lblTienNuoc.TabIndex = 1;
            this.lblTienNuoc.Text = "0";
            this.lblTienNuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTienPhong
            // 
            this.lblTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienPhong.ForeColor = System.Drawing.Color.White;
            this.lblTienPhong.Location = new System.Drawing.Point(197, 92);
            this.lblTienPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienPhong.Name = "lblTienPhong";
            this.lblTienPhong.Size = new System.Drawing.Size(157, 16);
            this.lblTienPhong.TabIndex = 1;
            this.lblTienPhong.Text = "0";
            this.lblTienPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(424, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Còn lại";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.ForeColor = System.Drawing.Color.White;
            this.lblPhong.Location = new System.Drawing.Point(183, 58);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(83, 17);
            this.lblPhong.TabIndex = 1;
            this.lblPhong.Text = "Phòng VIP";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(424, 207);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(196, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Tổng tiền cần thanh toán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(424, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tiền điện:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(52, 207);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Số nợ còn thiếu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(424, 169);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tổng tiền của tháng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(52, 169);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tiền mạng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(424, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tiền vệ sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tiền nước:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phòng:";
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(946, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(13, 476);
            this.pnlRight.TabIndex = 12;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(959, 476);
            this.Controls.Add(this.grbContent);
            this.Controls.Add(this.pblBottom);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThanhToan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThanhToan";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            this.grbContent.ResumeLayout(false);
            this.grbContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pblBottom;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThanhToanGiaHan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbContent;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblTienPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConLai;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTienDien;
        private System.Windows.Forms.Label lblTongTienCanThanhToan;
        private System.Windows.Forms.Label lblSoDuNo;
        private System.Windows.Forms.Label lblTongTienThang;
        private System.Windows.Forms.Label lblTienMang;
        private System.Windows.Forms.Label lblTienVeSinh;
        private System.Windows.Forms.Label lblTienNuoc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThanhToanTraPhong;
    }
}