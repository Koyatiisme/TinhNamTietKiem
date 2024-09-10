using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int ok = 0;
            try
            {
                float s, t, p;
                                
                s = float.Parse(TextBox1.Text);
                ok = 1;
                t = float.Parse(TextBox2.Text);
                ok = 2;
                p = float.Parse(TextBox3.Text) / 100;
                ok = 3;

                Lib_TinhTK.TinhSoNam thang;         
                thang = new Lib_TinhTK.TinhSoNam();  
                thang.s = s;      
                thang.t = t;
                thang.p = p;
                thang.TinhThang();           

                ketqua.InnerHtml = $"Tháng cần gửi tiết kiệm, áp <span title = \"lãi xuất {thang.p * 100}%\">lãi xuất {thang.p * 100}%</span> là <b class='maudo'>{thang.n}</b>";
            }
            catch (Exception ex)
            {
                if (ok == 0)
                {
                    ketqua.InnerHtml = $"Có lỗi khi nhập số thứ nhất";
                    TextBox1.Focus();
                }
                else if (ok == 1)
                {
                    ketqua.InnerHtml = $"Có lỗi khi nhập số thứ hai";
                    TextBox2.Focus();
                }
                else if (ok == 2)
                {
                    ketqua.InnerHtml = $"Có lỗi khi nhập lãi xuất";
                    TextBox3.Focus();
                }
                else
                    ketqua.InnerHtml = $"Có lỗi gì đó: " + ex.Message;
            }
        }
    }
}