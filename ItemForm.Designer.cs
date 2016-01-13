﻿namespace Kakeibo1
{
    partial class ItemForm
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
            this.monCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comCategory = new System.Windows.Forms.ComboBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.mtxtMoney = new System.Windows.Forms.MaskedTextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.categoryDataSet = new Kakeibo1.CategoryDataSet();
            this.categoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monCalendar
            // 
            this.monCalendar.Location = new System.Drawing.Point(18, 18);
            this.monCalendar.Name = "monCalendar";
            this.monCalendar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "分類";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "品名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "金額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "備考";
            // 
            // comCategory
            // 
            this.comCategory.DataSource = this.categoryDataTableBindingSource;
            this.comCategory.DisplayMember = "分類";
            this.comCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCategory.FormattingEnabled = true;
            this.comCategory.Location = new System.Drawing.Point(299, 36);
            this.comCategory.Name = "comCategory";
            this.comCategory.Size = new System.Drawing.Size(121, 20);
            this.comCategory.TabIndex = 5;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(299, 71);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 19);
            this.txtItem.TabIndex = 6;
            // 
            // mtxtMoney
            // 
            this.mtxtMoney.Location = new System.Drawing.Point(299, 102);
            this.mtxtMoney.Mask = "999999";
            this.mtxtMoney.Name = "mtxtMoney";
            this.mtxtMoney.Size = new System.Drawing.Size(100, 19);
            this.mtxtMoney.TabIndex = 7;
            this.mtxtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(299, 135);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(100, 19);
            this.txtRemarks.TabIndex = 8;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(87, 192);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "登録";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(299, 191);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // categoryDataSet
            // 
            this.categoryDataSet.DataSetName = "CategoryDataSet";
            this.categoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryDataSetBindingSource
            // 
            this.categoryDataSetBindingSource.DataSource = this.categoryDataSet;
            this.categoryDataSetBindingSource.Position = 0;
            // 
            // categoryDataTableBindingSource
            // 
            this.categoryDataTableBindingSource.DataMember = "CategoryDataTable";
            this.categoryDataTableBindingSource.DataSource = this.categoryDataSetBindingSource;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 241);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.mtxtMoney);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.comCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monCalendar);
            this.Name = "ItemForm";
            this.Text = "登録";
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comCategory;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.MaskedTextBox mtxtMoney;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.BindingSource categoryDataTableBindingSource;
        private System.Windows.Forms.BindingSource categoryDataSetBindingSource;
        private CategoryDataSet categoryDataSet;
    }
}