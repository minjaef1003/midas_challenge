﻿namespace midas_challenge
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_redo = new System.Windows.Forms.Button();
            this.button_undo = new System.Windows.Forms.Button();
            this.button_create_window = new System.Windows.Forms.Button();
            this.button_create_door = new System.Windows.Forms.Button();
            this.button_create_furniture = new System.Windows.Forms.Button();
            this.button_editmode = new System.Windows.Forms.Button();
            this.button_create_room = new System.Windows.Forms.Button();
            this.panel_createroom_menu = new System.Windows.Forms.Panel();
            this.button_createroom_rect = new System.Windows.Forms.Button();
            this.button_createroom_line = new System.Windows.Forms.Button();
            this.panel_furniture_menu = new System.Windows.Forms.Panel();
            this.button_fur_lamp = new System.Windows.Forms.Button();
            this.button_fur_washing = new System.Windows.Forms.Button();
            this.button_fur_toilet = new System.Windows.Forms.Button();
            this.button_fur_table = new System.Windows.Forms.Button();
            this.button_fur_bureau = new System.Windows.Forms.Button();
            this.button_fur_closet = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button_new_document = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.button_save_image = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새문서ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_menu_slide = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.기본바닥ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.타일바닥ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.정점편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.방삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.방이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.속성ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_openplan = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_outline.SuspendLayout();
            this.panel_workspace.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel_createroom_menu.SuspendLayout();
            this.panel_furniture_menu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_outline
            // 
            this.panel_outline.BackColor = System.Drawing.SystemColors.Control;
            this.panel_outline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_outline.Controls.Add(this.panel_workspace);
            this.panel_outline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_outline.Location = new System.Drawing.Point(0, 68);
            this.panel_outline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_outline.Name = "panel_outline";
            this.panel_outline.Size = new System.Drawing.Size(1271, 720);
            this.panel_outline.TabIndex = 0;
            // 
            // panel_workspace
            // 
            this.panel_workspace.Controls.Add(this.statusStrip1);
            this.panel_workspace.Controls.Add(this.panel_menu);
            this.panel_workspace.Controls.Add(this.panel_createroom_menu);
            this.panel_workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_workspace.Location = new System.Drawing.Point(0, 0);
            this.panel_workspace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_workspace.Name = "panel_workspace";
            this.panel_workspace.Size = new System.Drawing.Size(1269, 718);
            this.panel_workspace.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 693);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1269, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label_status
            // 
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(104, 20);
            this.label_status.Text = "프로그램 시작";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.button_redo);
            this.panel_menu.Controls.Add(this.button_undo);
            this.panel_menu.Controls.Add(this.button_create_window);
            this.panel_menu.Controls.Add(this.button_create_door);
            this.panel_menu.Controls.Add(this.button_create_furniture);
            this.panel_menu.Controls.Add(this.button_editmode);
            this.panel_menu.Controls.Add(this.button_create_room);
            this.panel_menu.Location = new System.Drawing.Point(0, 1);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(167, 688);
            this.panel_menu.TabIndex = 0;
            // 
            // button_redo
            // 
            this.button_redo.FlatAppearance.BorderSize = 0;
            this.button_redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_redo.Image = ((System.Drawing.Image)(resources.GetObject("button_redo.Image")));
            this.button_redo.Location = new System.Drawing.Point(86, 542);
            this.button_redo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_redo.Name = "button_redo";
            this.button_redo.Size = new System.Drawing.Size(75, 79);
            this.button_redo.TabIndex = 1;
            this.button_redo.Text = "Redo";
            this.button_redo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_redo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_redo.UseVisualStyleBackColor = true;
            this.button_redo.Click += new System.EventHandler(this.button_redo_Click);
            // 
            // button_undo
            // 
            this.button_undo.FlatAppearance.BorderSize = 0;
            this.button_undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_undo.Image = ((System.Drawing.Image)(resources.GetObject("button_undo.Image")));
            this.button_undo.Location = new System.Drawing.Point(10, 542);
            this.button_undo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_undo.Name = "button_undo";
            this.button_undo.Size = new System.Drawing.Size(75, 79);
            this.button_undo.TabIndex = 1;
            this.button_undo.Text = "Undo";
            this.button_undo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_undo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_undo.UseVisualStyleBackColor = true;
            this.button_undo.Click += new System.EventHandler(this.button_undo_Click);
            // 
            // button_create_window
            // 
            this.button_create_window.FlatAppearance.BorderSize = 0;
            this.button_create_window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create_window.Image = ((System.Drawing.Image)(resources.GetObject("button_create_window.Image")));
            this.button_create_window.Location = new System.Drawing.Point(1, 415);
            this.button_create_window.Margin = new System.Windows.Forms.Padding(0);
            this.button_create_window.Name = "button_create_window";
            this.button_create_window.Size = new System.Drawing.Size(165, 101);
            this.button_create_window.TabIndex = 0;
            this.button_create_window.Text = "Create Window";
            this.button_create_window.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_create_window.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_create_window.UseVisualStyleBackColor = true;
            this.button_create_window.Click += new System.EventHandler(this.button_create_window_Click);
            // 
            // button_create_door
            // 
            this.button_create_door.FlatAppearance.BorderSize = 0;
            this.button_create_door.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create_door.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create_door.Image = ((System.Drawing.Image)(resources.GetObject("button_create_door.Image")));
            this.button_create_door.Location = new System.Drawing.Point(1, 314);
            this.button_create_door.Margin = new System.Windows.Forms.Padding(0);
            this.button_create_door.Name = "button_create_door";
            this.button_create_door.Size = new System.Drawing.Size(165, 101);
            this.button_create_door.TabIndex = 0;
            this.button_create_door.Text = "Create Door";
            this.button_create_door.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_create_door.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_create_door.UseVisualStyleBackColor = true;
            this.button_create_door.Click += new System.EventHandler(this.button_create_door_Click);
            // 
            // button_create_furniture
            // 
            this.button_create_furniture.FlatAppearance.BorderSize = 0;
            this.button_create_furniture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create_furniture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create_furniture.Image = ((System.Drawing.Image)(resources.GetObject("button_create_furniture.Image")));
            this.button_create_furniture.Location = new System.Drawing.Point(0, 212);
            this.button_create_furniture.Margin = new System.Windows.Forms.Padding(0);
            this.button_create_furniture.Name = "button_create_furniture";
            this.button_create_furniture.Size = new System.Drawing.Size(165, 101);
            this.button_create_furniture.TabIndex = 0;
            this.button_create_furniture.Text = "Create Furniture";
            this.button_create_furniture.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_create_furniture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_create_furniture.UseVisualStyleBackColor = true;
            this.button_create_furniture.Click += new System.EventHandler(this.button_create_furniture_Click);
            // 
            // button_editmode
            // 
            this.button_editmode.FlatAppearance.BorderSize = 0;
            this.button_editmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editmode.Image = ((System.Drawing.Image)(resources.GetObject("button_editmode.Image")));
            this.button_editmode.Location = new System.Drawing.Point(1, 4);
            this.button_editmode.Margin = new System.Windows.Forms.Padding(0);
            this.button_editmode.Name = "button_editmode";
            this.button_editmode.Size = new System.Drawing.Size(165, 101);
            this.button_editmode.TabIndex = 0;
            this.button_editmode.Text = "Edit_Mode";
            this.button_editmode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_editmode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_editmode.UseVisualStyleBackColor = true;
            this.button_editmode.Click += new System.EventHandler(this.button_editmode_Click);
            // 
            // button_create_room
            // 
            this.button_create_room.FlatAppearance.BorderSize = 0;
            this.button_create_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create_room.Image = ((System.Drawing.Image)(resources.GetObject("button_create_room.Image")));
            this.button_create_room.Location = new System.Drawing.Point(0, 105);
            this.button_create_room.Margin = new System.Windows.Forms.Padding(0);
            this.button_create_room.Name = "button_create_room";
            this.button_create_room.Size = new System.Drawing.Size(165, 101);
            this.button_create_room.TabIndex = 0;
            this.button_create_room.Text = "Create Room";
            this.button_create_room.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_create_room.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_create_room.UseVisualStyleBackColor = true;
            this.button_create_room.Click += new System.EventHandler(this.button_create_room_Click);
            // 
            // panel_createroom_menu
            // 
            this.panel_createroom_menu.BackColor = System.Drawing.Color.White;
            this.panel_createroom_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_createroom_menu.Controls.Add(this.button_createroom_rect);
            this.panel_createroom_menu.Controls.Add(this.button_createroom_line);
            this.panel_createroom_menu.Location = new System.Drawing.Point(171, 4);
            this.panel_createroom_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_createroom_menu.Name = "panel_createroom_menu";
            this.panel_createroom_menu.Size = new System.Drawing.Size(89, 168);
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
            this.button_createroom_rect.Text = "Rectangle";
            this.button_createroom_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_createroom_rect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.button_createroom_line.Text = "Polygon";
            this.button_createroom_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_createroom_line.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_createroom_line.UseVisualStyleBackColor = true;
            this.button_createroom_line.Click += new System.EventHandler(this.button_createroom_line_Click);
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
            this.panel_furniture_menu.Location = new System.Drawing.Point(170, 72);
            this.panel_furniture_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button_fur_washing.Location = new System.Drawing.Point(-3, 338);
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
            this.button_fur_toilet.Location = new System.Drawing.Point(-3, 252);
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
            this.button_fur_bureau.Location = new System.Drawing.Point(-1, 81);
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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_new_document,
            this.toolStripButton2,
            this.toolStripButton3,
            this.button_save_image});
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
            this.toolStripButton2.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // button_save_image
            // 
            this.button_save_image.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_save_image.Image = ((System.Drawing.Image)(resources.GetObject("button_save_image.Image")));
            this.button_save_image.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_save_image.Name = "button_save_image";
            this.button_save_image.Size = new System.Drawing.Size(24, 24);
            this.button_save_image.Text = "toolStripButton1";
            this.button_save_image.Click += new System.EventHandler(this.button_save_image_Click);
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
            this.불러오기ToolStripMenuItem,
            this.button_openplan});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 새문서ToolStripMenuItem
            // 
            this.새문서ToolStripMenuItem.Name = "새문서ToolStripMenuItem";
            this.새문서ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.새문서ToolStripMenuItem.Text = "새문서";
            this.새문서ToolStripMenuItem.Click += new System.EventHandler(this.button_new_document_Click);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기본바닥ToolStripMenuItem,
            this.타일바닥ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 52);
            // 
            // 기본바닥ToolStripMenuItem
            // 
            this.기본바닥ToolStripMenuItem.Name = "기본바닥ToolStripMenuItem";
            this.기본바닥ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.기본바닥ToolStripMenuItem.Text = "기본 바닥";
            // 
            // 타일바닥ToolStripMenuItem
            // 
            this.타일바닥ToolStripMenuItem.Name = "타일바닥ToolStripMenuItem";
            this.타일바닥ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.타일바닥ToolStripMenuItem.Text = "타일바닥";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정점편집ToolStripMenuItem,
            this.방삭제ToolStripMenuItem,
            this.방이동ToolStripMenuItem,
            this.속성ToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(144, 100);
            // 
            // 정점편집ToolStripMenuItem
            // 
            this.정점편집ToolStripMenuItem.Name = "정점편집ToolStripMenuItem";
            this.정점편집ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.정점편집ToolStripMenuItem.Text = "정점 편집";
            // 
            // 방삭제ToolStripMenuItem
            // 
            this.방삭제ToolStripMenuItem.Name = "방삭제ToolStripMenuItem";
            this.방삭제ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.방삭제ToolStripMenuItem.Text = "방 삭제";
            this.방삭제ToolStripMenuItem.Click += new System.EventHandler(this.EditModeRemoveRoomToolStripMenuItem_Click);
            // 
            // 방이동ToolStripMenuItem
            // 
            this.방이동ToolStripMenuItem.Name = "방이동ToolStripMenuItem";
            this.방이동ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.방이동ToolStripMenuItem.Text = "방 이동";
            this.방이동ToolStripMenuItem.Click += new System.EventHandler(this.EditModeMovingRoomToolStripMenuItem_Click);
            // 
            // 속성ToolStripMenuItem
            // 
            this.속성ToolStripMenuItem.Name = "속성ToolStripMenuItem";
            this.속성ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.속성ToolStripMenuItem.Text = "속성";
            // 
            // button_openplan
            // 
            this.button_openplan.Name = "button_openplan";
            this.button_openplan.Size = new System.Drawing.Size(216, 26);
            this.button_openplan.Text = "도면 불러오기";
            this.button_openplan.Click += new System.EventHandler(this.button_openplan_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 788);
            this.Controls.Add(this.panel_furniture_menu);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_outline);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "self interior";
            this.panel_outline.ResumeLayout(false);
            this.panel_workspace.ResumeLayout(false);
            this.panel_workspace.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_createroom_menu.ResumeLayout(false);
            this.panel_furniture_menu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel_menu;
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
        private System.Windows.Forms.Button button_create_window;
        private System.Windows.Forms.Button button_create_door;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 기본바닥ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 타일바닥ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button button_undo;
        private System.Windows.Forms.Button button_redo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label_status;
        private System.Windows.Forms.ToolStripButton button_save_image;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_editmode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem 정점편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 방삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 방이동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 속성ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem button_openplan;
    }
}

