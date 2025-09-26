namespace WindowsFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lblKetQua;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(20, 20);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(35, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Số A:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(90, 17);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(200, 20);
            this.txtA.TabIndex = 1;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(20, 55);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(35, 13);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Số B:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(90, 52);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(200, 20);
            this.txtB.TabIndex = 3;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(90, 90);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(100, 28);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính toán";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = false;
            this.lblKetQua.Location = new System.Drawing.Point(20, 135);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(350, 120);
            this.lblKetQua.TabIndex = 5;
            this.lblKetQua.Text = "";
            this.lblKetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Personal Math Tool - Windows Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
