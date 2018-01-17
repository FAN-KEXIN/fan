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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<T> list=new List<T>();  //可以用for吗？ 可以  可以用foreach? 当然可以  有索引
        Dictionary<string, T> list1 = new Dictionary<string, T>();  //可以用foreach? 当然可以，for呢 （i）没有索引
        private void Form1_Load(object sender, EventArgs e)
        {
            T con = new T();
            con.CompanyName = "dd";
            con.Country = "中国";
            con.Product = "232";
            T con1 = new T();
            con1.CompanyName = "dt";
            con1.Country = "美国";
            con1.Product = "25552";
            T con2 = new T();
            con2.CompanyName = "heht";
            con2.Country = "he 国";
            con2.Product = "23546552";
            list.Add(con);
            list.Add(con1);
            list.Add(con2);
            load();
            
        }
        public void load() {
         
            for (int i = 0; i < list.Count; i++)
            {
                
                ListViewItem item = new ListViewItem(list[i].CompanyName);
                item.SubItems.Add(list[i].Country);
                item.SubItems.Add(list[i].Product);
                listView1.Items.Add(item);
                Console.WriteLine();
            }          
         
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i1 = listView1.SelectedItems[0].Index;
            MessageBox.Show(i1.ToString());

            list.RemoveAt(i1);
          
          
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("一共有"+list.Count.ToString()+"个公司");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (listView1.Items!=null)
            {
                listView1.Items.Clear();
               
            }

             load();
        }
    }
}
