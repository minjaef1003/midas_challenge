namespace midas_challenge
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel_outline = new System.Windows.Forms.Panel();
            this.panel_workspace = new System.Windows.Forms.Panel();
            this.panel_furniture_menu = new System.Windows.Forms.Panel();
            this.button_fur_lamp = new System.Windows.Forms.Button();
            this.button_fur_washing = new System.Windows.Forms.Button();
            this.button_fur_toilet = new System.Windows.Forms.Button();
            this.button_fur_table = new System.Windows.Forms.Button();
            this.button_fur_bureau = new System.Windows.Forms.Button();
            this.button_fur_closet = new System.Windows.Forms.Button();
            this.panel_createroom_menu = new System.Windows.Forms.Panel();
            this.button_createroom_rect = new System.Windows.Forms.Button();
            this.button_createroom_line = new System.Windows.Forms.Button();
            this.panel_log = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_create_furniture = new System.Windows.Forms.Button();
            this.button_create_room = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button_new_document = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새문서ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_menu_slide = new System.Windows.Forms.Timer(this.components);
            this.panel_outline.SuspendLayout();
            this.panel_workspace.SuspendLayout();
            this.panel_furniture_menu.SuspendLayout();
            this.panel_createroom_menu.SuspendLayout();
            this.panel_log.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_outline
            // 
            this.panel_outline.BackColor = System.Drawing.SystemColors.Control;
            this.panel_outline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_outline.Controls.Add(this.panel_workspace);
            this.panel_outline.Controls.Add(this.panel_log);
            this.panel_outline.Controls.Add(this.panel_menu);
            this.panel_outline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_outline.Location = new System.Drawing.Point(0, 68);
            this.panel_outline.Name = "panel_outline";
            this.panel_outline.Size = new System.Drawing.Size(1271, 719);
            this.panel_outline.TabIndex = 0;
            // 
            // panel_workspace
            // 
            this.panel_workspace.Controls.Add(this.panel_furniture_menu);
            this.panel_workspace.Controls.Add(this.panel_createroom_menu);
            this.panel_workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_workspace.Location = new System.Drawing.Point(166, 0);
            this.panel_workspace.Name = "panel_workspace";
            this.panel_workspace.Size = new System.Drawing.Size(1103, 543);
            this.panel_workspace.TabIndex = 2;
            // 
            // panel_furniture_menu
            // 
            this.panel_furniture_menu.BackColor = System.Drawing.Color.White;
            this.panel_furniture_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_furniture_menu.Controls.Add(this.button_fur_lamp);
            this.panel_furniture_menu.Controls.Add(this.button_fur_washing);
            this.panel_furniture_menu.Controls.Add(this.button_fur_toilet);
            this.panel_furniture_menu.Controls.Add(this.button_fur_table);
            this.panel_furniture_menu.Controls.Add(this.button_fur_bureau);
            this.panel_furniture_menu.Controls.Add(this.button_fur_closet);
            this.panel_furniture_menu.Location = new System.Drawing.Point(1, 0);
            this.panel_furniture_menu.Name = "panel_furniture_menu";
            this.panel_furniture_menu.Size = new System.Drawing.Size(89, 543);
            this.panel_furniture_menu.TabIndex = 1;
            // 
            // button_fur_lamp
            // 
            this.button_fur_lamp.FlatAppearance.BorderSize = 0;
            this.button_fur_lamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fur_lamp.Image = ((System.Drawing.Image)(resources.GetObject("button_fur_lamp.Image")));
            this.button_fur_lamp.Location = new System.Drawing.Point(-3, 426);
            this.button_fur_lamp.Margin = new System.Windows.Forms.Padding(0);
            this.button_fur_lamp.Name = "button_fur_lamp";
            this.button_fur_lamp.Size = new System.Drawing.Size(89, 80);
            this.button_fur_lamp.TabIndex = 2;
            this.button_fur_lamp.UseVisualStyleBackColor = true;
            this.button_fur_lamp.Click += new System.EventHandler(this.button_fur_lamp_Click);
            // 
            // button_fur_washing
            // 
            this.button_fur_washing.FlatAppearance.BorderSize = 0;
            this.button_fur_washing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fur_washing.Image = ((System.Drawing.Image)(resources.GetObject("button_fur_washing.Image")));
            this.button_fur_washing.Location = new System.Drawing.Point(-3, 337);
            this.button_fur_washing.Margin = new System.Windows.Forms.Padding(0);
            this.button_fur_washing.Name = "button_fur_washing";
            this.button_fur_washing.Size = new System.Drawing.Size(89, 80);
            this.button_fur_washing.TabIndex = 2;
            this.button_fur_washing.UseVisualStyleBackColor = true;
            this.button_fur_washing.Click += new System.EventHandler(this.button_fur_washing_Click);
            // 
            // button_fur_toilet
            // 
            this.button_fur_toilet.FlatAppearance.BorderSize = 0;
            this.button_fur_toilet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fur_toilet.Image = ((System.Drawing.Image)(resources.GetObject("button_fur_toilet.Image")));
            this.button_fur_toilet.Location = new System.Drawing.Point(-3, 253);
            this.button_fur_toilet.Margin = new System.Windows.Forms.Padding(0);
            this.button_fur_toilet.Name = "button_fur_toilet";
            this.button_fur_toilet.Size = new System.Drawing.Size(89, 80);
            this.button_fur_toilet.TabIndex = 2;
            this.button_fur_toilet.UseVisualStyleBackColor = true;
            this.button_fur_toilet.Click += new System.EventHandler(this.button_fur_toilet_Click);
            // 
            // button_fur_table
            // 
            this.button_fur_table.FlatAppearance.BorderSize = 0;
            this.button_fur_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fur_table.Image = ((System.Drawing.Image)(resources.GetObject("button_fur_table.Image")));
            this.button_fur_table.Location = new System.Drawing.Point(-2, 168);
            this.button_fur_table.Margin = new System.Windows.Forms.Padding(0);
            this.button_fur_table.Name = "button_fur_table";
            this.button_fur_table.Size = new System.Drawing.Size(89, 80);
            this.button_fur_table.TabIndex = 2;
            this.button_fur_table.UseVisualStyleBackColor = true;
            this.button_fur_table.Click += new System.EventHandler(this.button_fur_table_Click);
            // 
            // button_fur_bureau
            // 
            this.button_fur_bureau.FlatAppearance.BorderSize = 0;
            this.button_fur_bureau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fur_bureau.Image = ((System.Drawing.Image)(resources.GetObject("button_fur_bureau.Image")));
            this.button_fur_bureau.Location = new System.Drawing.Point(-1, 84);
            this.button_fur_bureau.Margin = new System.Windows.Forms.Padding(0);
            this.button_fur_bureau.Name = "button_fur_bureau";
            this.button_fur_bureau.Size = new System.Drawing.Size(89, 80);
            this.button_fur_bureau.TabIndex = 2;
            this.button_fur_bureau.UseVisualStyleBackColor = true;
            this.button_fur_bureau.Click += new System.EventHandler(this.button_fur_bureau_Click);
            // 
            // button_fur_closet
            // 
            this.button_fur_closet.FlatAppearance.BorderSize = 0;
            this.button_fur_closet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fur_closet.Image = ((System.Drawing.Image)(resources.GetObject("button_fur_closet.Image")));
            this.button_fur_closet.Location = new System.Drawing.Point(-2, -2);
            this.button_fur_closet.Margin = new System.Windows.Forms.Padding(0);
            this.button_fur_closet.Name = "button_fur_closet";
            this.button_fur_closet.Size = new System.Drawing.Size(89, 80);
            this.button_fur_closet.TabIndex = 2;
            this.button_fur_closet.UseVisualStyleBackColor = true;
            this.button_fur_closet.Click += new System.EventHandler(this.button_fur_closet_Click);
            // 
            // panel_createroom_menu
            // 
            this.panel_createroom_menu.BackColor = System.Drawing.Color.White;
            this.panel_createroom_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_createroom_menu.Controls.Add(this.button_createroom_rect);
            this.panel_createroom_menu.Controls.Add(this.button_createroom_line);
            this.panel_createroom_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_createroom_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_createroom_menu.Name = "panel_createroom_menu";
            this.panel_createroom_menu.Size = new System.Drawing.Size(89, 543);
            this.panel_createroom_menu.TabIndex = 0;
            // 
            // button_createroom_rect
            // 
            this.button_createroom_rect.FlatAppearance.BorderSize = 0;
            this.button_createroom_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_createroom_rect.Image = ((System.Drawing.Image)(resources.GetObject("button_createroom_rect.Image")));
            this.button_createroom_rect.Location = new System.Drawing.Point(0, 81);
            this.button_createroom_rect.Margin = new System.Windows.Forms.Padding(0);
            this.button_createroom_rect.Name = "button_createroom_rect";
            this.button_createroom_rect.Size = new System.Drawing.Size(89, 80);
            this.button_createroom_rect.TabIndex = 0;
            this.button_createroom_rect.UseVisualStyleBackColor = true;
            this.button_createroom_rect.Click += new System.EventHandler(this.button_createroom_rect_Click);
            // 
            // button_createroom_line
            // 
            this.button_createroom_line.FlatAppearance.BorderSize = 0;
            this.button_createroom_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_createroom_line.Image = ((System.Drawing.Image)(resources.GetObject("button_createroom_line.Image")));
            this.button_createroom_line.Location = new System.Drawing.Point(-1, 1);
            this.button_createroom_line.Margin = new System.Windows.Forms.Padding(0);
            this.button_createroom_line.Name = "button_createroom_line";
            this.button_createroom_line.Size = new System.Drawing.Size(90, 80);
            this.button_createroom_line.TabIndex = 0;
            this.button_createroom_line.UseVisualStyleBackColor = true;
            this.button_createroom_line.Click += new System.EventHandler(this.button_createroom_line_Click);
            // 
            // panel_log
            // 
            this.panel_log.BackColor = System.Drawing.Color.White;
            this.panel_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_log.Controls.Add(this.label1);
            this.panel_log.Controls.Add(this.richTextBox1);
            this.panel_log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_log.Location = new System.Drawing.Point(166, 543);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(1103, 174);
            this.panel_log.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "log";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1101, 145);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.White;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.button_create_furniture);
            this.panel_menu.Controls.Add(this.button_create_room);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(166, 717);
            this.panel_menu.TabIndex = 0;
            // 
            // button_create_furniture
            // 
            this.button_create_furniture.FlatAppearance.BorderSize = 0;
            this.button_create_furniture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create_furniture.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create_furniture.Image = ((System.Drawing.Image)(resources.GetObject("button_create_furniture.Image")));
            this.button_create_furniture.Location = new System.Drawing.Point(0, 106);
            this.button_create_furniture.Margin = new System.Windows.Forms.Padding(0);
            this.button_create_furniture.Name = "button_create_furniture";
            this.button_create_furniture.Size = new System.Drawing.Size(164, 101);
            this.button_create_furniture.TabIndex = 0;
            this.button_create_furniture.Text = "Create Furniture";
            this.button_create_furniture.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_create_furniture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_create_furniture.UseVisualStyleBackColor = true;
            this.button_create_furniture.Click += new System.EventHandler(this.button_create_furniture_Click);
            // 
            // button_create_room
            // 
            this.button_create_room.FlatAppearance.BorderSize = 0;
            this.button_create_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create_room.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create_room.Image = ((System.Drawing.Image)(resources.GetObject("button_create_room.Image")));
            this.button_create_room.Location = new System.Drawing.Point(0, 0);
            this.button_create_room.Margin = new System.Windows.Forms.Padding(0);
            this.button_create_room.Name = "button_create_room";
            this.button_create_room.Size = new System.Drawing.Size(164, 101);
            this.button_create_room.TabIndex = 0;
            this.button_create_room.Text = "Create Room";
            this.button_create_room.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_create_room.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_create_room.UseVisualStyleBackColor = true;
            this.button_create_room.Click += new System.EventHandler(this.button_create_room_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_new_document,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1271, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // button_new_document
            // 
            this.button_new_document.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_new_document.Image = ((System.Drawing.Image)(resources.GetObject("button_new_document.Image")));
            this.button_new_document.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_new_document.Name = "button_new_document";
            this.button_new_document.Size = new System.Drawing.Size(24, 24);
            this.button_new_document.Text = "button_new_document";
            this.button_new_document.Click += new System.EventHandler(this.button_new_document_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새문서ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.불러오기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 새문서ToolStripMenuItem
            // 
            this.새문서ToolStripMenuItem.Name = "새문서ToolStripMenuItem";
            this.새문서ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.새문서ToolStripMenuItem.Text = "새문서";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            this.불러오기ToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // timer_menu_slide
            // 
            this.timer_menu_slide.Interval = 5;
            this.timer_menu_slide.Tick += new System.EventHandler(this.timer_menu_slide_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 787);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_outline);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "self interior";
            this.panel_outline.ResumeLayout(false);
            this.panel_workspace.ResumeLayout(false);
            this.panel_furniture_menu.ResumeLayout(false);
            this.panel_createroom_menu.ResumeLayout(false);
            this.panel_log.ResumeLayout(false);
            this.panel_log.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_outline;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton button_new_document;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새문서ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;        
        private System.Windows.Forms.Panel panel_log;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_create_room;
        private System.Windows.Forms.Panel panel_workspace;
        private System.Windows.Forms.Panel panel_createroom_menu;
        private System.Windows.Forms.Button button_createroom_rect;
        private System.Windows.Forms.Button button_createroom_line;
        private System.Windows.Forms.Timer timer_menu_slide;
        private System.Windows.Forms.Button button_create_furniture;
        private System.Windows.Forms.Panel panel_furniture_menu;
        private System.Windows.Forms.Button button_fur_lamp;
        private System.Windows.Forms.Button button_fur_washing;
        private System.Windows.Forms.Button button_fur_toilet;
        private System.Windows.Forms.Button button_fur_table;
        private System.Windows.Forms.Button button_fur_bureau;
        private System.Windows.Forms.Button button_fur_closet;
    }
}

