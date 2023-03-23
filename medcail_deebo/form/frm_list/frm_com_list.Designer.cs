﻿namespace medcail_deebo.form.frm_list
{
    partial class frm_com_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_com_list));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lbl_form_name = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgv_com = new DevExpress.XtraGrid.GridControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.txt_search = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_com)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_search.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_form_name
            // 
            this.lbl_form_name.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form_name.Appearance.Options.UseFont = true;
            this.lbl_form_name.Location = new System.Drawing.Point(266, 7);
            this.lbl_form_name.Name = "lbl_form_name";
            this.lbl_form_name.Size = new System.Drawing.Size(109, 24);
            this.lbl_form_name.TabIndex = 43;
            this.lbl_form_name.Text = "قائمه الشركات ";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgv_com;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // dgv_com
            // 
            this.dgv_com.Location = new System.Drawing.Point(12, 85);
            this.dgv_com.MainView = this.gridView1;
            this.dgv_com.Name = "dgv_com";
            this.dgv_com.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_com.ShowOnlyPredefinedDetails = true;
            this.dgv_com.Size = new System.Drawing.Size(644, 341);
            this.dgv_com.TabIndex = 42;
            this.dgv_com.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(597, 36);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tajawal Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureEdit1.Properties.Appearance.Options.UseFont = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(59, 43);
            this.pictureEdit1.TabIndex = 40;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(425, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(166, 24);
            this.labelControl1.TabIndex = 44;
            this.labelControl1.Text = "اسم الشركه او  الموقع ";
            // 
            // btn_clear
            // 
            this.btn_clear.Appearance.Font = new System.Drawing.Font("Tajawal Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Appearance.Options.UseFont = true;
            this.btn_clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.ImageOptions.Image")));
            this.btn_clear.Location = new System.Drawing.Point(12, 36);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(76, 35);
            this.btn_clear.TabIndex = 41;
            this.btn_clear.Text = "مسح";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(94, 37);
            this.txt_search.Name = "txt_search";
            this.txt_search.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txt_search.Properties.AdvancedModeOptions.Label = "ابحث بالاسم او التخصص";
            this.txt_search.Properties.Appearance.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Properties.Appearance.Options.UseFont = true;
            this.txt_search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton("", -1, true, true, editorButtonImageOptions1, false, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "ابحث بالاسم او التخصص", null, null, true)});
            this.txt_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_search.Size = new System.Drawing.Size(323, 34);
            this.txt_search.TabIndex = 39;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // frm_com_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 448);
            this.Controls.Add(this.lbl_form_name);
            this.Controls.Add(this.dgv_com);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_search);
            this.Name = "frm_com_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_com_list";
            this.Activated += new System.EventHandler(this.frm_com_list_Activated);
            this.Load += new System.EventHandler(this.frm_com_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_com)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_search.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_form_name;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl dgv_com;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_clear;
        private DevExpress.XtraEditors.SearchControl txt_search;
    }
}