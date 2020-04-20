namespace BingoStore
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.adminName = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.reports = new System.Windows.Forms.Button();
            this.newProduct = new System.Windows.Forms.Button();
            this.manageProduct = new System.Windows.Forms.Button();
            this.dshboard = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.dashBrd1 = new BingoStore.DashBrd();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel10.SuspendLayout();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(177, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 67);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.adminName);
            this.panel2.Location = new System.Drawing.Point(1003, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 67);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(14, 15);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(41, 36);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox10.TabIndex = 13;
            this.pictureBox10.TabStop = false;
            // 
            // adminName
            // 
            this.adminName.AutoSize = true;
            this.adminName.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.adminName.Location = new System.Drawing.Point(64, 25);
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(96, 23);
            this.adminName.TabIndex = 2;
            this.adminName.Text = "Bingo Admin";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.panel10.Controls.Add(this.sidePanel);
            this.panel10.Controls.Add(this.reports);
            this.panel10.Controls.Add(this.newProduct);
            this.panel10.Controls.Add(this.manageProduct);
            this.panel10.Controls.Add(this.dshboard);
            this.panel10.Controls.Add(this.label16);
            this.panel10.Location = new System.Drawing.Point(-12, 1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(191, 798);
            this.panel10.TabIndex = 13;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.Location = new System.Drawing.Point(11, 77);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 58);
            this.sidePanel.TabIndex = 14;
            // 
            // reports
            // 
            this.reports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.reports.FlatAppearance.BorderSize = 0;
            this.reports.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.reports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.reports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reports.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports.ForeColor = System.Drawing.Color.White;
            this.reports.Image = ((System.Drawing.Image)(resources.GetObject("reports.Image")));
            this.reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reports.Location = new System.Drawing.Point(24, 269);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(164, 58);
            this.reports.TabIndex = 5;
            this.reports.Text = "         Reports";
            this.reports.UseVisualStyleBackColor = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // newProduct
            // 
            this.newProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.newProduct.FlatAppearance.BorderSize = 0;
            this.newProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.newProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.newProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.newProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProduct.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProduct.ForeColor = System.Drawing.Color.White;
            this.newProduct.Image = ((System.Drawing.Image)(resources.GetObject("newProduct.Image")));
            this.newProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newProduct.Location = new System.Drawing.Point(24, 205);
            this.newProduct.Name = "newProduct";
            this.newProduct.Size = new System.Drawing.Size(164, 58);
            this.newProduct.TabIndex = 5;
            this.newProduct.Text = "         New Product";
            this.newProduct.UseVisualStyleBackColor = true;
            this.newProduct.Click += new System.EventHandler(this.newProduct_Click);
            // 
            // manageProduct
            // 
            this.manageProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.manageProduct.FlatAppearance.BorderSize = 0;
            this.manageProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.manageProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.manageProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.manageProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageProduct.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageProduct.ForeColor = System.Drawing.Color.White;
            this.manageProduct.Image = ((System.Drawing.Image)(resources.GetObject("manageProduct.Image")));
            this.manageProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageProduct.Location = new System.Drawing.Point(24, 141);
            this.manageProduct.Name = "manageProduct";
            this.manageProduct.Size = new System.Drawing.Size(164, 58);
            this.manageProduct.TabIndex = 5;
            this.manageProduct.Text = "         Manage Pro";
            this.manageProduct.UseVisualStyleBackColor = true;
            this.manageProduct.Click += new System.EventHandler(this.manageProduct_Click);
            // 
            // dshboard
            // 
            this.dshboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.dshboard.FlatAppearance.BorderSize = 0;
            this.dshboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.dshboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.dshboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dshboard.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshboard.ForeColor = System.Drawing.Color.White;
            this.dshboard.Image = ((System.Drawing.Image)(resources.GetObject("dshboard.Image")));
            this.dshboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dshboard.Location = new System.Drawing.Point(27, 77);
            this.dshboard.Name = "dshboard";
            this.dshboard.Size = new System.Drawing.Size(164, 58);
            this.dshboard.TabIndex = 5;
            this.dshboard.Text = "         Dashboard";
            this.dshboard.UseVisualStyleBackColor = true;
            this.dshboard.Click += new System.EventHandler(this.dshboard_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(21, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 34);
            this.label16.TabIndex = 4;
            this.label16.Text = "BINGO SPORTS";
            // 
            // content
            // 
            this.content.Controls.Add(this.dashBrd1);
            this.content.Location = new System.Drawing.Point(185, 74);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1163, 711);
            this.content.TabIndex = 14;
            // 
            // dashBrd1
            // 
            this.dashBrd1.BackColor = System.Drawing.Color.White;
            this.dashBrd1.Location = new System.Drawing.Point(3, 3);
            this.dashBrd1.Name = "dashBrd1";
            this.dashBrd1.Size = new System.Drawing.Size(1158, 711);
            this.dashBrd1.TabIndex = 15;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 791);
            this.Controls.Add(this.content);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label adminName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button newProduct;
        private System.Windows.Forms.Button manageProduct;
        private System.Windows.Forms.Button dshboard;
        private System.Windows.Forms.Label label16;
        private DashBrd dashBrd1;
        private System.Windows.Forms.Panel content;
    }
}

