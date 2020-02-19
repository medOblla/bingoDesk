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
            this.panel3 = new System.Windows.Forms.Panel();
            this.notification = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminName = new System.Windows.Forms.Label();
            this.metric = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.dshboard = new System.Windows.Forms.Button();
            this.manageProduct = new System.Windows.Forms.Button();
            this.newProduct = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.dashBrd1 = new BingoStore.DashBrd();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(177, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 67);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.notification);
            this.panel3.Location = new System.Drawing.Point(926, -11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 78);
            this.panel3.TabIndex = 0;
            // 
            // notification
            // 
            this.notification.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.notification.FlatAppearance.BorderSize = 0;
            this.notification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.notification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notification.Image = ((System.Drawing.Image)(resources.GetObject("notification.Image")));
            this.notification.Location = new System.Drawing.Point(15, 19);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(41, 36);
            this.notification.TabIndex = 2;
            this.notification.UseVisualStyleBackColor = true;
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
            // adminName
            // 
            this.adminName.AutoSize = true;
            this.adminName.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.adminName.Location = new System.Drawing.Point(64, 25);
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(103, 23);
            this.adminName.TabIndex = 2;
            this.adminName.Text = "Hamid Oublla";
            // 
            // metric
            // 
            this.metric.BackColor = System.Drawing.Color.Transparent;
            this.metric.BorderRadius = 5;
            this.metric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metric.ForeColor = System.Drawing.Color.Black;
            this.metric.Items = new string[] {
        "Year",
        "Month",
        "Day"};
            this.metric.Location = new System.Drawing.Point(1434, 92);
            this.metric.Name = "metric";
            this.metric.NomalColor = System.Drawing.Color.White;
            this.metric.onHoverColor = System.Drawing.Color.White;
            this.metric.selectedIndex = 0;
            this.metric.Size = new System.Drawing.Size(126, 35);
            this.metric.TabIndex = 7;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(1431, 91);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(128, 35);
            this.bunifuDropdown1.TabIndex = 8;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
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
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.Location = new System.Drawing.Point(11, 77);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 58);
            this.sidePanel.TabIndex = 14;
            // 
            // dashBrd1
            // 
            this.dashBrd1.BackColor = System.Drawing.Color.White;
            this.dashBrd1.Location = new System.Drawing.Point(192, 74);
            this.dashBrd1.Name = "dashBrd1";
            this.dashBrd1.Size = new System.Drawing.Size(1158, 711);
            this.dashBrd1.TabIndex = 14;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1351, 791);
            this.Controls.Add(this.dashBrd1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.metric);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button notification;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label adminName;
        private Bunifu.Framework.UI.BunifuDropdown metric;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
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
    }
}

