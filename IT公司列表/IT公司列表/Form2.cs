using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT公司列表
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Dictionary<string,T> list=new Dictionary<string,T>() ;

        private void Form2_Load(object sender, EventArgs e)
        {
            T con = new T();
            con.CompanyName = "aa11a";
            con.Country = "中国";
            con.Product = "aaa";
            T con1 = new T();
            con1.CompanyName = "bbbb";
            con1.Country = "美国";
            con1.Product = "bbbb";
            T con2 = new T();
            con2.CompanyName = "bb11bb";
            con2.Country = "美国";
            con2.Product = "bbbb";
            list.Add(con.CompanyName, con);
            list.Add(con1.CompanyName, con1);
            list.Add(con2.CompanyName, con2);
            update();
        }
        public void update()
        {
            
            foreach (string item1 in list.Keys)
            {
                ListViewItem item = new ListViewItem(item1);
               
                item.SubItems.Add(list[item1].Country);
                item.SubItems.Add(list[item1].Product);
                listView1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string num = listView1.SelectedItems[0].SubItems[0].Text;
            list.Remove(num);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("一共有" + list.Count.ToString() + "个公司");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items != null)
            {
                listView1.Items.Clear();

            }

            update();
        }
    }
}
