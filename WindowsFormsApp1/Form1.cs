using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float s, t, p;
            s = float.Parse(textBox1.Text);
            t = float.Parse(textBox2.Text);
            p = float.Parse(textBox3.Text);
            
            Lib_TinhTK.TinhSoNam thang;         
            thang = new Lib_TinhTK.TinhSoNam();  
            thang.s = s;
            thang.t = t;
            thang.p = p;

            thang.TinhThang();           

            lbl_KQ.Text = $"So thang can gui là {thang.n}";
        }
    }
}
