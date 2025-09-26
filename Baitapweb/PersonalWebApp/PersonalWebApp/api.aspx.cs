using System;
using System.Web;
using PersonalMathLib;

namespace PersonalWebApp   // phải khớp với Inherits trong api.aspx
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "application/json";

            try
            {
                int a = int.Parse(Request.Form["a"]);
                int b = int.Parse(Request.Form["b"]);

                MathTool tool = new MathTool();
                tool.InputA = a;
                tool.InputB = b;

                string ketQua = tool.ComputeSummary();

                // Escape ký tự đặc biệt để tránh lỗi JSON
                string safeKetQua = ketQua
                    .Replace("\\", "\\\\")
                    .Replace("\"", "\\\"")
                    .Replace("\r", "")
                    .Replace("\n", " ");

                Response.Write("{\"KetQua\":\"" + safeKetQua + "\"}");
            }
            catch (Exception ex)
            {
                // Escape lỗi để trả về JSON hợp lệ
                string safeErr = ex.Message
                    .Replace("\\", "\\\\")
                    .Replace("\"", "\\\"")
                    .Replace("\r", "")
                    .Replace("\n", " ");

                Response.Write("{\"KetQua\":\"Lỗi: " + safeErr + "\"}");
            }

            Response.End();
        }
    }
}
