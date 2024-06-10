namespace csharp_bancuuchuong
{
    partial class Form1
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
            this.lblbangcuchuong = new System.Windows.Forms.Label();
            this.txtso = new System.Windows.Forms.TextBox();
            this.btnxem = new System.Windows.Forms.Button();
            this.lsbketqua = new System.Windows.Forms.ListBox();
            this.lblchuongmay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblbangcuchuong
            // 
            this.lblbangcuchuong.AutoSize = true;
            this.lblbangcuchuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbangcuchuong.Location = new System.Drawing.Point(162, 9);
            this.lblbangcuchuong.Name = "lblbangcuchuong";
            this.lblbangcuchuong.Size = new System.Drawing.Size(299, 39);
            this.lblbangcuchuong.TabIndex = 0;
            this.lblbangcuchuong.Text = "Bảng cửu chương";
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(84, 135);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(166, 20);
            this.txtso.TabIndex = 1;
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(370, 132);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(75, 23);
            this.btnxem.TabIndex = 2;
            this.btnxem.Text = "xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // lsbketqua
            // 
            this.lsbketqua.FormattingEnabled = true;
            this.lsbketqua.Location = new System.Drawing.Point(84, 219);
            this.lsbketqua.Name = "lsbketqua";
            this.lsbketqua.Size = new System.Drawing.Size(330, 147);
            this.lsbketqua.TabIndex = 3;
            // 
            // lblchuongmay
            // 
            this.lblchuongmay.AutoSize = true;
            this.lblchuongmay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchuongmay.Location = new System.Drawing.Point(110, 69);
            this.lblchuongmay.Name = "lblchuongmay";
            this.lblchuongmay.Size = new System.Drawing.Size(416, 25);
            this.lblchuongmay.TabIndex = 4;
            this.lblchuongmay.Text = "bạn muốn xem bảng cửu chương mấy?\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblchuongmay);
            this.Controls.Add(this.lsbketqua);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.lblbangcuchuong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbangcuchuong;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.ListBox lsbketqua;
        private System.Windows.Forms.Label lblchuongmay;
    }
}

