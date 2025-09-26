using System;
using System.Windows.Forms;
using PersonalMathLib; // bắt buộc đã Add Reference đến DLL

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private MathTool mathTool;

        public Form1()
        {
            InitializeComponent();
            mathTool = new MathTool();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0;
                int.TryParse(txtA.Text.Trim(), out a);
                int.TryParse(txtB.Text.Trim(), out b);

                mathTool.InputA = a;
                mathTool.InputB = b;

                string ketQua = mathTool.ComputeSummary();
                // Hiển thị lên label (label có kích thước lớn)
                lblKetQua.Text = ketQua;
                // Hiển thị thêm hộp thoại chi tiết
                MessageBox.Show(ketQua, "Kết quả từ PersonalMathLib");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
