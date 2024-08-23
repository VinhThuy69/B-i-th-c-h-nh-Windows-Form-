namespace BaiTapThietKeFrom
{
    partial class frmBai3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTuMoi = new System.Windows.Forms.TextBox();
            this.txtNghiaCuaTu = new System.Windows.Forms.TextBox();
            this.btnThemTu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTuMoi = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNghia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tu moi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nghia cua tu:";
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Location = new System.Drawing.Point(146, 30);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(173, 20);
            this.txtTuMoi.TabIndex = 2;
            // 
            // txtNghiaCuaTu
            // 
            this.txtNghiaCuaTu.Location = new System.Drawing.Point(146, 60);
            this.txtNghiaCuaTu.Name = "txtNghiaCuaTu";
            this.txtNghiaCuaTu.Size = new System.Drawing.Size(173, 20);
            this.txtNghiaCuaTu.TabIndex = 3;
            // 
            // btnThemTu
            // 
            this.btnThemTu.Location = new System.Drawing.Point(146, 104);
            this.btnThemTu.Name = "btnThemTu";
            this.btnThemTu.Size = new System.Drawing.Size(75, 23);
            this.btnThemTu.TabIndex = 4;
            this.btnThemTu.Text = "Them tu moi";
            this.btnThemTu.UseVisualStyleBackColor = true;
            this.btnThemTu.Click += new System.EventHandler(this.btnThemTu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Danh sach tu moi";
            // 
            // lbTuMoi
            // 
            this.lbTuMoi.FormattingEnabled = true;
            this.lbTuMoi.Location = new System.Drawing.Point(146, 201);
            this.lbTuMoi.Name = "lbTuMoi";
            this.lbTuMoi.Size = new System.Drawing.Size(161, 173);
            this.lbTuMoi.TabIndex = 6;
            this.lbTuMoi.SelectedIndexChanged += new System.EventHandler(this.lbTuMoi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nghia cua tu";
            // 
            // txtNghia
            // 
            this.txtNghia.Location = new System.Drawing.Point(459, 201);
            this.txtNghia.Multiline = true;
            this.txtNghia.Name = "txtNghia";
            this.txtNghia.ReadOnly = true;
            this.txtNghia.Size = new System.Drawing.Size(215, 173);
            this.txtNghia.TabIndex = 8;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNghia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTuMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThemTu);
            this.Controls.Add(this.txtNghiaCuaTu);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Bai 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuMoi;
        private System.Windows.Forms.TextBox txtNghiaCuaTu;
        private System.Windows.Forms.Button btnThemTu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbTuMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNghia;
    }
}