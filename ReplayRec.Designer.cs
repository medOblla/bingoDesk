namespace BingoStore
{
    partial class ReplayRec
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
            this.send = new Bunifu.Framework.UI.BunifuFlatButton();
            this.firstPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subject = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailmessage = new System.Windows.Forms.RichTextBox();
            this.msgLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.title = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.firstPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(192)))));
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(192)))));
            this.send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.send.BorderRadius = 0;
            this.send.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.send.ButtonText = "Send";
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.DisabledColor = System.Drawing.Color.Gray;
            this.send.Iconcolor = System.Drawing.Color.Transparent;
            this.send.Iconimage = null;
            this.send.Iconimage_right = null;
            this.send.Iconimage_right_Selected = null;
            this.send.Iconimage_Selected = null;
            this.send.IconMarginLeft = 0;
            this.send.IconMarginRight = 0;
            this.send.IconRightVisible = true;
            this.send.IconRightZoom = 0D;
            this.send.IconVisible = true;
            this.send.IconZoom = 90D;
            this.send.IsTab = false;
            this.send.Location = new System.Drawing.Point(593, 592);
            this.send.Name = "send";
            this.send.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(192)))));
            this.send.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(192)))));
            this.send.OnHoverTextColor = System.Drawing.Color.White;
            this.send.selected = false;
            this.send.Size = new System.Drawing.Size(139, 48);
            this.send.TabIndex = 29;
            this.send.Text = "Send";
            this.send.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.send.Textcolor = System.Drawing.Color.White;
            this.send.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // firstPanel
            // 
            this.firstPanel.Controls.Add(this.panel1);
            this.firstPanel.Controls.Add(this.back);
            this.firstPanel.Controls.Add(this.send);
            this.firstPanel.Controls.Add(this.panel4);
            this.firstPanel.Location = new System.Drawing.Point(22, 49);
            this.firstPanel.Name = "firstPanel";
            this.firstPanel.Size = new System.Drawing.Size(1131, 657);
            this.firstPanel.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.subject);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.emailmessage);
            this.panel1.Controls.Add(this.msgLbl);
            this.panel1.Location = new System.Drawing.Point(593, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 555);
            this.panel1.TabIndex = 31;
            // 
            // subject
            // 
            this.subject.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(108)))), ((int)(((byte)(197)))));
            this.subject.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subject.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subject.BorderThickness = 1;
            this.subject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subject.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.subject.ForeColor = System.Drawing.Color.Black;
            this.subject.isPassword = false;
            this.subject.Location = new System.Drawing.Point(18, 35);
            this.subject.Margin = new System.Windows.Forms.Padding(4);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(491, 44);
            this.subject.TabIndex = 26;
            this.subject.Text = "Subject";
            this.subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Subject";
            // 
            // emailmessage
            // 
            this.emailmessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailmessage.Location = new System.Drawing.Point(14, 112);
            this.emailmessage.Name = "emailmessage";
            this.emailmessage.Size = new System.Drawing.Size(491, 431);
            this.emailmessage.TabIndex = 24;
            this.emailmessage.Text = "";
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.msgLbl.Location = new System.Drawing.Point(14, 90);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(65, 16);
            this.msgLbl.TabIndex = 23;
            this.msgLbl.Text = "Message";
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
            this.panel4.Size = new System.Drawing.Size(574, 555);
            this.panel4.TabIndex = 25;
            // 
            // description
            // 
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description.Location = new System.Drawing.Point(14, 112);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(546, 431);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Replay";
            // 
            // back
            // 
            this.back.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(192)))));
            this.back.BackColor = System.Drawing.Color.Gray;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.BorderRadius = 0;
            this.back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.back.ButtonText = "Back";
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.DisabledColor = System.Drawing.Color.Gray;
            this.back.Iconcolor = System.Drawing.Color.Transparent;
            this.back.Iconimage = null;
            this.back.Iconimage_right = null;
            this.back.Iconimage_right_Selected = null;
            this.back.Iconimage_Selected = null;
            this.back.IconMarginLeft = 0;
            this.back.IconMarginRight = 0;
            this.back.IconRightVisible = true;
            this.back.IconRightZoom = 0D;
            this.back.IconVisible = true;
            this.back.IconZoom = 90D;
            this.back.IsTab = false;
            this.back.Location = new System.Drawing.Point(448, 592);
            this.back.Name = "back";
            this.back.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(192)))));
            this.back.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(192)))));
            this.back.OnHoverTextColor = System.Drawing.Color.White;
            this.back.selected = false;
            this.back.Size = new System.Drawing.Size(139, 48);
            this.back.TabIndex = 29;
            this.back.Text = "Back";
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back.Textcolor = System.Drawing.Color.White;
            this.back.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ReplayRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.firstPanel);
            this.Controls.Add(this.label1);
            this.Name = "ReplayRec";
            this.Size = new System.Drawing.Size(1169, 711);
            this.firstPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton send;
        private System.Windows.Forms.Panel firstPanel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox subject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox emailmessage;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton back;
    }
}
