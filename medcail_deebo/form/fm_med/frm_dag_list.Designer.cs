﻿namespace medcail_deebo.form.fm_med
{
    partial class frm_dag_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dag_list));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_coust_name = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.grb_dag = new System.Windows.Forms.GroupBox();
            this.dgv_dagino = new DevExpress.XtraGrid.GridControl();
            this.grid_all_dagno = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_new_dagno = new DevExpress.XtraEditors.SimpleButton();
            this.btn_mor_using = new DevExpress.XtraEditors.SimpleButton();
            this.grb_vist = new System.Windows.Forms.GroupBox();
            this.dgv_vist_dagno = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.grb_dag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dagino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_all_dagno)).BeginInit();
            this.grb_vist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vist_dagno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lbl_coust_name);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1198, 41);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl_coust_name
            // 
            this.lbl_coust_name.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coust_name.Appearance.Options.UseFont = true;
            this.lbl_coust_name.LineVisible = true;
            this.lbl_coust_name.Location = new System.Drawing.Point(520, 13);
            this.lbl_coust_name.Name = "lbl_coust_name";
            this.lbl_coust_name.Size = new System.Drawing.Size(52, 22);
            this.lbl_coust_name.TabIndex = 41;
            this.lbl_coust_name.Text = "المريض";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.LineVisible = true;
            this.labelControl7.Location = new System.Drawing.Point(713, 13);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(139, 22);
            this.labelControl7.TabIndex = 40;
            this.labelControl7.Text = "التشخيص الخاص ب ";
            // 
            // grb_dag
            // 
            this.grb_dag.Controls.Add(this.dgv_dagino);
            this.grb_dag.Location = new System.Drawing.Point(12, 102);
            this.grb_dag.Name = "grb_dag";
            this.grb_dag.Size = new System.Drawing.Size(594, 304);
            this.grb_dag.TabIndex = 1;
            this.grb_dag.TabStop = false;
            this.grb_dag.Text = "قائمه التشخيص";
            // 
            // dgv_dagino
            // 
            this.dgv_dagino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dagino.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_dagino.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.dgv_dagino.Location = new System.Drawing.Point(3, 17);
            this.dgv_dagino.MainView = this.grid_all_dagno;
            this.dgv_dagino.Name = "dgv_dagino";
            this.dgv_dagino.Size = new System.Drawing.Size(588, 284);
            this.dgv_dagino.TabIndex = 5;
            this.dgv_dagino.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid_all_dagno});
            // 
            // grid_all_dagno
            // 
            this.grid_all_dagno.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grid_all_dagno.Appearance.OddRow.Options.UseBackColor = true;
            this.grid_all_dagno.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.grid_all_dagno.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grid_all_dagno.Appearance.TopNewRow.BackColor = System.Drawing.Color.Lime;
            this.grid_all_dagno.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grid_all_dagno.Appearance.ViewCaption.BackColor = System.Drawing.Color.Blue;
            this.grid_all_dagno.Appearance.ViewCaption.Options.UseBackColor = true;
            this.grid_all_dagno.GridControl = this.dgv_dagino;
            this.grid_all_dagno.Name = "grid_all_dagno";
            this.grid_all_dagno.OptionsView.EnableAppearanceOddRow = true;
            this.grid_all_dagno.DoubleClick += new System.EventHandler(this.grid_all_dagno_DoubleClick);
            // 
            // btn_new_dagno
            // 
            this.btn_new_dagno.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_new_dagno.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_new_dagno.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_dagno.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_new_dagno.Appearance.Options.UseBackColor = true;
            this.btn_new_dagno.Appearance.Options.UseFont = true;
            this.btn_new_dagno.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_new_dagno.ImageOptions.Image")));
            this.btn_new_dagno.Location = new System.Drawing.Point(454, 14);
            this.btn_new_dagno.Name = "btn_new_dagno";
            this.btn_new_dagno.Size = new System.Drawing.Size(130, 37);
            this.btn_new_dagno.TabIndex = 4;
            this.btn_new_dagno.Text = "تشخيص جديد ";
            this.btn_new_dagno.Click += new System.EventHandler(this.btn_new_dagno_Click);
            // 
            // btn_mor_using
            // 
            this.btn_mor_using.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_mor_using.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_mor_using.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mor_using.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_mor_using.Appearance.Options.UseBackColor = true;
            this.btn_mor_using.Appearance.Options.UseFont = true;
            this.btn_mor_using.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_mor_using.ImageOptions.Image")));
            this.btn_mor_using.Location = new System.Drawing.Point(110, 14);
            this.btn_mor_using.Name = "btn_mor_using";
            this.btn_mor_using.Size = new System.Drawing.Size(130, 37);
            this.btn_mor_using.TabIndex = 6;
            this.btn_mor_using.Text = "الاكثر استخداما ";
            this.btn_mor_using.Click += new System.EventHandler(this.btn_mor_using_Click);
            // 
            // grb_vist
            // 
            this.grb_vist.Controls.Add(this.dgv_vist_dagno);
            this.grb_vist.Location = new System.Drawing.Point(632, 99);
            this.grb_vist.Name = "grb_vist";
            this.grb_vist.Size = new System.Drawing.Size(554, 327);
            this.grb_vist.TabIndex = 7;
            this.grb_vist.TabStop = false;
            this.grb_vist.Text = "التشخيص السابق ";
            // 
            // dgv_vist_dagno
            // 
            this.dgv_vist_dagno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vist_dagno.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_vist_dagno.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.dgv_vist_dagno.Location = new System.Drawing.Point(3, 17);
            this.dgv_vist_dagno.MainView = this.gridView1;
            this.dgv_vist_dagno.Name = "dgv_vist_dagno";
            this.dgv_vist_dagno.Size = new System.Drawing.Size(548, 307);
            this.dgv_vist_dagno.TabIndex = 5;
            this.dgv_vist_dagno.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.Lime;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Appearance.ViewCaption.BackColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgv_vist_dagno;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(6, 8);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(130, 37);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "حذف الكل ";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton4.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(409, 12);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(130, 37);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "تشخيص سابق";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton5.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(152, 10);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(87, 37);
            this.simpleButton5.TabIndex = 7;
            this.simpleButton5.Text = "حذف";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(279, 14);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(147, 37);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "قائمه التشاخيص";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton2);
            this.groupBox2.Controls.Add(this.simpleButton4);
            this.groupBox2.Controls.Add(this.simpleButton3);
            this.groupBox2.Controls.Add(this.simpleButton5);
            this.groupBox2.Location = new System.Drawing.Point(635, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 55);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simpleButton1);
            this.groupBox3.Controls.Add(this.btn_mor_using);
            this.groupBox3.Controls.Add(this.btn_new_dagno);
            this.groupBox3.Location = new System.Drawing.Point(15, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 55);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(256, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(130, 37);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "الاجراء الحالي ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frm_dag_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 438);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grb_vist);
            this.Controls.Add(this.grb_dag);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_dag_list";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_dag_list";
            this.Load += new System.EventHandler(this.frm_dag_list_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_dag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dagino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_all_dagno)).EndInit();
            this.grb_vist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vist_dagno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.GroupBox grb_dag;
        private DevExpress.XtraEditors.SimpleButton btn_mor_using;
        private DevExpress.XtraEditors.SimpleButton btn_new_dagno;
        private DevExpress.XtraGrid.GridControl dgv_dagino;
        private DevExpress.XtraGrid.Views.Grid.GridView grid_all_dagno;
        private System.Windows.Forms.GroupBox grb_vist;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.GridControl dgv_vist_dagno;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lbl_coust_name;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}