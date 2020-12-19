namespace BaoCao.Forms
{
    partial class Form_Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.panelleft = new System.Windows.Forms.Panel();
            this.btnbill = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnthongke = new System.Windows.Forms.Button();
            this.btnmuahang = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.btnsanpham = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnthugon = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbltime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timertime = new System.Windows.Forms.Timer(this.components);
            this.panelControls = new System.Windows.Forms.Panel();
            this.NHOM10 = new System.Windows.Forms.Label();
            this.panelleft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelleft.Controls.Add(this.NHOM10);
            this.panelleft.Controls.Add(this.btnbill);
            this.panelleft.Controls.Add(this.btnorder);
            this.panelleft.Controls.Add(this.panelSide);
            this.panelleft.Controls.Add(this.btnthongke);
            this.panelleft.Controls.Add(this.btnmuahang);
            this.panelleft.Controls.Add(this.btncustomer);
            this.panelleft.Controls.Add(this.btnnhanvien);
            this.panelleft.Controls.Add(this.btnsanpham);
            this.panelleft.Controls.Add(this.btnhome);
            this.panelleft.Controls.Add(this.panel2);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(215, 703);
            this.panelleft.TabIndex = 0;
            // 
            // btnbill
            // 
            this.btnbill.ForeColor = System.Drawing.Color.Purple;
            this.btnbill.Image = ((System.Drawing.Image)(resources.GetObject("btnbill.Image")));
            this.btnbill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbill.Location = new System.Drawing.Point(12, 466);
            this.btnbill.Name = "btnbill";
            this.btnbill.Size = new System.Drawing.Size(200, 56);
            this.btnbill.TabIndex = 10;
            this.btnbill.Text = "Bill";
            this.btnbill.UseVisualStyleBackColor = true;
            this.btnbill.Click += new System.EventHandler(this.btnbill_Click);
            // 
            // btnorder
            // 
            this.btnorder.ForeColor = System.Drawing.Color.Purple;
            this.btnorder.Image = ((System.Drawing.Image)(resources.GetObject("btnorder.Image")));
            this.btnorder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorder.Location = new System.Drawing.Point(12, 528);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(200, 56);
            this.btnorder.TabIndex = 9;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click_1);
            // 
            // panelSide
            // 
            this.panelSide.Location = new System.Drawing.Point(3, 159);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(10, 53);
            this.panelSide.TabIndex = 3;
            // 
            // btnthongke
            // 
            this.btnthongke.ForeColor = System.Drawing.Color.Purple;
            this.btnthongke.Image = ((System.Drawing.Image)(resources.GetObject("btnthongke.Image")));
            this.btnthongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthongke.Location = new System.Drawing.Point(12, 590);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(200, 56);
            this.btnthongke.TabIndex = 8;
            this.btnthongke.Text = "Statistical";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // btnmuahang
            // 
            this.btnmuahang.ForeColor = System.Drawing.Color.Purple;
            this.btnmuahang.Image = ((System.Drawing.Image)(resources.GetObject("btnmuahang.Image")));
            this.btnmuahang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmuahang.Location = new System.Drawing.Point(12, 404);
            this.btnmuahang.Name = "btnmuahang";
            this.btnmuahang.Size = new System.Drawing.Size(200, 56);
            this.btnmuahang.TabIndex = 6;
            this.btnmuahang.Text = "Purchase Item";
            this.btnmuahang.UseVisualStyleBackColor = true;
            this.btnmuahang.Click += new System.EventHandler(this.btnmuahang_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.ForeColor = System.Drawing.Color.Purple;
            this.btncustomer.Image = ((System.Drawing.Image)(resources.GetObject("btncustomer.Image")));
            this.btncustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomer.Location = new System.Drawing.Point(12, 342);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(200, 56);
            this.btncustomer.TabIndex = 5;
            this.btncustomer.Text = "Customer";
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.ForeColor = System.Drawing.Color.Purple;
            this.btnnhanvien.Image = ((System.Drawing.Image)(resources.GetObject("btnnhanvien.Image")));
            this.btnnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhanvien.Location = new System.Drawing.Point(12, 280);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(200, 56);
            this.btnnhanvien.TabIndex = 4;
            this.btnnhanvien.Text = "Employee";
            this.btnnhanvien.UseVisualStyleBackColor = true;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // btnsanpham
            // 
            this.btnsanpham.ForeColor = System.Drawing.Color.Purple;
            this.btnsanpham.Image = ((System.Drawing.Image)(resources.GetObject("btnsanpham.Image")));
            this.btnsanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsanpham.Location = new System.Drawing.Point(12, 218);
            this.btnsanpham.Name = "btnsanpham";
            this.btnsanpham.Size = new System.Drawing.Size(200, 56);
            this.btnsanpham.TabIndex = 3;
            this.btnsanpham.Text = "Product";
            this.btnsanpham.UseVisualStyleBackColor = true;
            this.btnsanpham.Click += new System.EventHandler(this.btnsanpham_Click);
            // 
            // btnhome
            // 
            this.btnhome.ForeColor = System.Drawing.Color.Purple;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(12, 156);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(200, 56);
            this.btnhome.TabIndex = 2;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 150);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnthugon);
            this.panel3.Controls.Add(this.btnout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(215, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 55);
            this.panel3.TabIndex = 1;
            // 
            // btnthugon
            // 
            this.btnthugon.Image = ((System.Drawing.Image)(resources.GetObject("btnthugon.Image")));
            this.btnthugon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthugon.Location = new System.Drawing.Point(6, 2);
            this.btnthugon.Name = "btnthugon";
            this.btnthugon.Size = new System.Drawing.Size(48, 47);
            this.btnthugon.TabIndex = 4;
            this.btnthugon.UseVisualStyleBackColor = true;
            this.btnthugon.Click += new System.EventHandler(this.btnthugon_Click);
            // 
            // btnout
            // 
            this.btnout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnout.Image = ((System.Drawing.Image)(resources.GetObject("btnout.Image")));
            this.btnout.Location = new System.Drawing.Point(928, 0);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(53, 51);
            this.btnout.TabIndex = 3;
            this.btnout.UseVisualStyleBackColor = true;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.lbltime);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(215, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(985, 95);
            this.panel4.TabIndex = 2;
            // 
            // lbltime
            // 
            this.lbltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(854, 32);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(112, 23);
            this.lbltime.TabIndex = 1;
            this.lbltime.Text = "HH::MM::SS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome back!!";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timertime
            // 
            this.timertime.Tick += new System.EventHandler(this.timertime_Tick);
            // 
            // panelControls
            // 
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(215, 150);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(985, 553);
            this.panelControls.TabIndex = 3;
            // 
            // NHOM10
            // 
            this.NHOM10.AutoSize = true;
            this.NHOM10.ForeColor = System.Drawing.Color.White;
            this.NHOM10.Location = new System.Drawing.Point(45, 671);
            this.NHOM10.Name = "NHOM10";
            this.NHOM10.Size = new System.Drawing.Size(95, 23);
            this.NHOM10.TabIndex = 11;
            this.NHOM10.Text = "NHOM10";
            // 
            // Form_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelleft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dashboard";
            this.Text = "Form_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Button btnmuahang;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Button btnsanpham;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnthugon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timertime;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnbill;
        private System.Windows.Forms.Label NHOM10;
    }
}