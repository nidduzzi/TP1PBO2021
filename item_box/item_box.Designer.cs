﻿namespace item_box
{
    partial class item_box
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pb_item = new System.Windows.Forms.PictureBox();
            this.lb_nama = new System.Windows.Forms.Label();
            this.lb_harga = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_item)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pb_item, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_nama, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_harga, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.9359F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0641F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 403);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pb_item
            // 
            this.pb_item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_item.Location = new System.Drawing.Point(102, 3);
            this.pb_item.Name = "pb_item";
            this.pb_item.Size = new System.Drawing.Size(292, 259);
            this.pb_item.TabIndex = 0;
            this.pb_item.TabStop = false;
            // 
            // lb_nama
            // 
            this.lb_nama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_nama.AutoSize = true;
            this.lb_nama.Location = new System.Drawing.Point(230, 282);
            this.lb_nama.Name = "lb_nama";
            this.lb_nama.Size = new System.Drawing.Size(35, 13);
            this.lb_nama.TabIndex = 1;
            this.lb_nama.Text = "label1";
            // 
            // lb_harga
            // 
            this.lb_harga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_harga.AutoSize = true;
            this.lb_harga.Location = new System.Drawing.Point(230, 329);
            this.lb_harga.Name = "lb_harga";
            this.lb_harga.Size = new System.Drawing.Size(35, 13);
            this.lb_harga.TabIndex = 2;
            this.lb_harga.Text = "label2";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(210, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Beli";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // item_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "item_box";
            this.Size = new System.Drawing.Size(497, 403);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pb_item;
        private System.Windows.Forms.Label lb_nama;
        private System.Windows.Forms.Label lb_harga;
        private System.Windows.Forms.Button button1;
    }
}
