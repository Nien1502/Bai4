namespace Baitap04
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MSNV = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_LuongCB = new System.Windows.Forms.TextBox();
            this.btn_DongY = new System.Windows.Forms.Button();
            this.btn_BoQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSNV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lương Cơ Bản:";
            // 
            // txt_MSNV
            // 
            this.txt_MSNV.Location = new System.Drawing.Point(203, 36);
            this.txt_MSNV.Name = "txt_MSNV";
            this.txt_MSNV.Size = new System.Drawing.Size(396, 22);
            this.txt_MSNV.TabIndex = 1;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(203, 72);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(396, 22);
            this.txt_TenNV.TabIndex = 1;
            // 
            // txt_LuongCB
            // 
            this.txt_LuongCB.Location = new System.Drawing.Point(203, 111);
            this.txt_LuongCB.Name = "txt_LuongCB";
            this.txt_LuongCB.Size = new System.Drawing.Size(396, 22);
            this.txt_LuongCB.TabIndex = 1;
            // 
            // btn_DongY
            // 
            this.btn_DongY.Location = new System.Drawing.Point(54, 153);
            this.btn_DongY.Name = "btn_DongY";
            this.btn_DongY.Size = new System.Drawing.Size(176, 30);
            this.btn_DongY.TabIndex = 2;
            this.btn_DongY.Text = "Đồng Ý";
            this.btn_DongY.UseVisualStyleBackColor = true;
            this.btn_DongY.Click += new System.EventHandler(this.btn_DongY_Click);
            // 
            // btn_BoQua
            // 
            this.btn_BoQua.Location = new System.Drawing.Point(396, 153);
            this.btn_BoQua.Name = "btn_BoQua";
            this.btn_BoQua.Size = new System.Drawing.Size(176, 30);
            this.btn_BoQua.TabIndex = 3;
            this.btn_BoQua.Text = "Bỏ Qua";
            this.btn_BoQua.UseVisualStyleBackColor = true;
            this.btn_BoQua.Click += new System.EventHandler(this.btn_BoQua_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 243);
            this.Controls.Add(this.btn_BoQua);
            this.Controls.Add(this.btn_DongY);
            this.Controls.Add(this.txt_LuongCB);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.txt_MSNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MSNV;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.TextBox txt_LuongCB;
        private System.Windows.Forms.Button btn_DongY;
        private System.Windows.Forms.Button btn_BoQua;
    }
}