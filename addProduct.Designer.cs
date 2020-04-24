namespace BingoStore
{
    partial class addProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.title = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.brand = new Bunifu.Framework.UI.BunifuDropdown();
            this.gender = new Bunifu.Framework.UI.BunifuDropdown();
            this.category = new Bunifu.Framework.UI.BunifuDropdown();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tags = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.firstImage = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.costPerItem = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.compareToPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.price = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.next = new Bunifu.Framework.UI.BunifuFlatButton();
            this.discard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.firstPanel = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstImage)).BeginInit();
            this.panel5.SuspendLayout();
            this.firstPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Products";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.description);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.title);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(13, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 294);
            this.panel4.TabIndex = 25;
            // 
            // description
            // 
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description.Location = new System.Drawing.Point(14, 112);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(546, 172);
            this.description.TabIndex = 24;
            this.description.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Description";
            // 
            // title
            // 
            this.title.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(108)))), ((int)(((byte)(197)))));
            this.title.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.title.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.title.BorderThickness = 1;
            this.title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.title.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.isPassword = false;
            this.title.Location = new System.Drawing.Point(14, 31);
            this.title.Margin = new System.Windows.Forms.Padding(4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(546, 44);
            this.title.TabIndex = 22;
            this.title.Text = "Short sleeve t-shirt";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.title.Enter += new System.EventHandler(this.title_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Title";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.brand);
            this.panel2.Controls.Add(this.gender);
            this.panel2.Controls.Add(this.category);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tags);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(612, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 294);
            this.panel2.TabIndex = 26;
            // 
            // brand
            // 
            this.brand.BackColor = System.Drawing.Color.Transparent;
            this.brand.BorderRadius = 3;
            this.brand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brand.ForeColor = System.Drawing.Color.Black;
            this.brand.Items = new string[] {
        "Nike",
        "Addidas",
        "Puma",
        "Reebok",
        "NewBalance",
        "Rip Curl"};
            this.brand.Location = new System.Drawing.Point(20, 139);
            this.brand.Name = "brand";
            this.brand.NomalColor = System.Drawing.Color.White;
            this.brand.onHoverColor = System.Drawing.Color.White;
            this.brand.selectedIndex = 0;
            this.brand.Size = new System.Drawing.Size(471, 44);
            this.brand.TabIndex = 40;
            this.brand.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.BorderRadius = 3;
            this.gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gender.ForeColor = System.Drawing.Color.Black;
            this.gender.Items = new string[] {
        "Man ",
        "Woman ",
        "Child"};
            this.gender.Location = new System.Drawing.Point(274, 65);
            this.gender.Name = "gender";
            this.gender.NomalColor = System.Drawing.Color.White;
            this.gender.onHoverColor = System.Drawing.Color.White;
            this.gender.selectedIndex = 0;
            this.gender.Size = new System.Drawing.Size(217, 44);
            this.gender.TabIndex = 39;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.Transparent;
            this.category.BorderRadius = 3;
            this.category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category.ForeColor = System.Drawing.Color.Black;
            this.category.Items = new string[] {
        "Running",
        "Hicking",
        "Football ",
        "Tennis",
        "Fishing",
        "Cardio",
        "Swimming",
        "Surfing",
        "menSweater",
        "menFootwar",
        "menPants",
        "menT-Shirts",
        "menSneakers",
        "womenSweater",
        "womenFootwar",
        "womenPants",
        "womenT-Shirts",
        "womenSneakers",
        "childSweater",
        "childFootwar",
        "childPants",
        "childT-Shirts",
        "childSneakers",
        "Adidas",
        "Nike",
        "Puma",
        "Reebook",
        "SHIRTS",
        "SNEAKERS",
        "HOODIES",
        "PANTS",
        "ACCESORIES",
        ""};
            this.category.Location = new System.Drawing.Point(20, 65);
            this.category.Name = "category";
            this.category.NomalColor = System.Drawing.Color.White;
            this.category.onHoverColor = System.Drawing.Color.White;
            this.category.selectedIndex = 0;
            this.category.Size = new System.Drawing.Size(217, 44);
            this.category.TabIndex = 28;
            this.category.onItemSelected += new System.EventHandler(this.category_onItemSelected);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(246, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Product Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Organization";
            // 
            // tags
            // 
            this.tags.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(108)))), ((int)(((byte)(197)))));
            this.tags.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tags.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tags.BorderThickness = 1;
            this.tags.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tags.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tags.ForeColor = System.Drawing.Color.Black;
            this.tags.isPassword = false;
            this.tags.Location = new System.Drawing.Point(17, 226);
            this.tags.Margin = new System.Windows.Forms.Padding(4);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(482, 44);
            this.tags.TabIndex = 24;
            this.tags.Text = "summer, footbal, men";
            this.tags.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tags.Enter += new System.EventHandler(this.tags_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tags";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Product Category";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.firstImage);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(13, 323);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 245);
            this.panel3.TabIndex = 27;
            // 
            // firstImage
            // 
            this.firstImage.Image = ((System.Drawing.Image)(resources.GetObject("firstImage.Image")));
            this.firstImage.Location = new System.Drawing.Point(14, 45);
            this.firstImage.Name = "firstImage";
            this.firstImage.Size = new System.Drawing.Size(546, 189);
            this.firstImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstImage.TabIndex = 27;
            this.firstImage.TabStop = false;
            this.firstImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Images";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.costPerItem);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.compareToPrice);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.price);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(612, 323);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(517, 245);
            this.panel5.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Cost per item";
            // 
            // costPerItem
            // 
            this.costPerItem.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(108)))), ((int)(((byte)(197)))));
            this.costPerItem.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.costPerItem.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.costPerItem.BorderThickness = 1;
            this.costPerItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.costPerItem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.costPerItem.ForeColor = System.Drawing.Color.Black;
            this.costPerItem.isPassword = false;
            this.costPerItem.Location = new System.Drawing.Point(15, 154);
            this.costPerItem.Margin = new System.Windows.Forms.Padding(4);
            this.costPerItem.Name = "costPerItem";
            this.costPerItem.Size = new System.Drawing.Size(494, 44);
            this.costPerItem.TabIndex = 31;
            this.costPerItem.Text = "MAD 0.00";
            this.costPerItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.costPerItem.Enter += new System.EventHandler(this.costPerItem_Enter);
            this.costPerItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costPerItem_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(271, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Compare to price";
            // 
            // compareToPrice
            // 
            this.compareToPrice.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(108)))), ((int)(((byte)(197)))));
            this.compareToPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.compareToPrice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.compareToPrice.BorderThickness = 1;
            this.compareToPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.compareToPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.compareToPrice.ForeColor = System.Drawing.Color.Black;
            this.compareToPrice.isPassword = false;
            this.compareToPrice.Location = new System.Drawing.Point(269, 69);
            this.compareToPrice.Margin = new System.Windows.Forms.Padding(4);
            this.compareToPrice.Name = "compareToPrice";
            this.compareToPrice.Size = new System.Drawing.Size(240, 44);
            this.compareToPrice.TabIndex = 29;
            this.compareToPrice.Text = "MAD 0.00";
            this.compareToPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.compareToPrice.Enter += new System.EventHandler(this.compareToPrice_Enter);
            this.compareToPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compareToPrice_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Price";
            // 
            // price
            // 
            this.price.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(108)))), ((int)(((byte)(197)))));
            this.price.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.price.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.price.BorderThickness = 1;
            this.price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.isPassword = false;
            this.price.Location = new System.Drawing.Point(15, 69);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(240, 44);
            this.price.TabIndex = 27;
            this.price.Text = "MAD 0.00";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.price.OnValueChanged += new System.EventHandler(this.price_OnValueChanged);
            this.price.Enter += new System.EventHandler(this.price_Enter);
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Pricing";
            // 
            // next
            // 
            this.next.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(192)))));
            this.next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(192)))));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.BorderRadius = 0;
            this.next.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.next.ButtonText = "Next";
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.DisabledColor = System.Drawing.Color.Gray;
            this.next.Iconcolor = System.Drawing.Color.Transparent;
            this.next.Iconimage = null;
            this.next.Iconimage_right = null;
            this.next.Iconimage_right_Selected = null;
            this.next.Iconimage_Selected = null;
            this.next.IconMarginLeft = 0;
            this.next.IconMarginRight = 0;
            this.next.IconRightVisible = true;
            this.next.IconRightZoom = 0D;
            this.next.IconVisible = true;
            this.next.IconZoom = 90D;
            this.next.IsTab = false;
            this.next.Location = new System.Drawing.Point(627, 595);
            this.next.Name = "next";
            this.next.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(192)))));
            this.next.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(192)))));
            this.next.OnHoverTextColor = System.Drawing.Color.White;
            this.next.selected = false;
            this.next.Size = new System.Drawing.Size(139, 48);
            this.next.TabIndex = 29;
            this.next.Text = "Next";
            this.next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.next.Textcolor = System.Drawing.Color.White;
            this.next.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // discard
            // 
            this.discard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(171)))));
            this.discard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(171)))));
            this.discard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.discard.BorderRadius = 0;
            this.discard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discard.ButtonText = "Discard";
            this.discard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discard.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(171)))));
            this.discard.Iconcolor = System.Drawing.Color.Transparent;
            this.discard.Iconimage = null;
            this.discard.Iconimage_right = null;
            this.discard.Iconimage_right_Selected = null;
            this.discard.Iconimage_Selected = null;
            this.discard.IconMarginLeft = 0;
            this.discard.IconMarginRight = 0;
            this.discard.IconRightVisible = true;
            this.discard.IconRightZoom = 0D;
            this.discard.IconVisible = true;
            this.discard.IconZoom = 90D;
            this.discard.IsTab = false;
            this.discard.Location = new System.Drawing.Point(467, 595);
            this.discard.Name = "discard";
            this.discard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(171)))));
            this.discard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(158)))), ((int)(((byte)(171)))));
            this.discard.OnHoverTextColor = System.Drawing.Color.Black;
            this.discard.selected = false;
            this.discard.Size = new System.Drawing.Size(139, 48);
            this.discard.TabIndex = 30;
            this.discard.Text = "Discard";
            this.discard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.discard.Textcolor = System.Drawing.Color.Black;
            this.discard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discard.Click += new System.EventHandler(this.discard_Click);
            // 
            // firstPanel
            // 
            this.firstPanel.Controls.Add(this.discard);
            this.firstPanel.Controls.Add(this.next);
            this.firstPanel.Controls.Add(this.panel5);
            this.firstPanel.Controls.Add(this.panel3);
            this.firstPanel.Controls.Add(this.panel2);
            this.firstPanel.Controls.Add(this.panel4);
            this.firstPanel.Location = new System.Drawing.Point(24, 51);
            this.firstPanel.Name = "firstPanel";
            this.firstPanel.Size = new System.Drawing.Size(1131, 657);
            this.firstPanel.TabIndex = 18;
            this.firstPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.firstPanel_Paint);
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.firstPanel);
            this.Controls.Add(this.label1);
            this.Name = "addProduct";
            this.Size = new System.Drawing.Size(1169, 711);
            this.Load += new System.EventHandler(this.addProduct_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstImage)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.firstPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox tags;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMetroTextbox costPerItem;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMetroTextbox compareToPrice;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMetroTextbox price;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuFlatButton next;
        private Bunifu.Framework.UI.BunifuFlatButton discard;
        private System.Windows.Forms.Panel firstPanel;
        private System.Windows.Forms.PictureBox firstImage;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuDropdown category;
        private Bunifu.Framework.UI.BunifuDropdown gender;
        private Bunifu.Framework.UI.BunifuDropdown brand;
    }
}
