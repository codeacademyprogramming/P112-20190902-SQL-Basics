using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskWarehouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GetNumber();
            int a, b, c;
            Test(out a, out b, out c);


            string num = "asd";
            int r;
            int.TryParse(num, out r);

            MessageBox.Show("a = {0}, b = {1}, c = {2}", a.ToString(), b.ToString(), c.ToString());
            MessageBox.Show($"{r}");

        }

        public int GetNumber()
        {
            return 55;
        }

        public void Test(out int birinci, out int ikinci, out int ucuncu)
        {
            birinci = 10;
            ikinci = 20;
            ucuncu = 30;
        }
    }
}
