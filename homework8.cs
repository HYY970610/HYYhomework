using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHelloWorld
{
    public partial class Form1:
    Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBoxNo_Enter(object sender,EventArgs e)
        {
            MessageBox.Show("订单号");
        }
        private void textBoxName_Enter(object sender,EventArgs e)
        {
            MessageBox.Show("商品名称");
        }
        private void button1_Click(object sender,EventArgs e)
        {
            MessageBox.Show("查询");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2
            frm2 = new Form2();
            frm2.MdiParent = this;
            frm2.Show();
            private void textBoxCustomer_Enter(object sender,EventArgs e)
        {
            MessageBox.Show("客户");
        }
        }
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        Form3
        frm3 = new Form3();
        frm3.MdiParent = this;
        frm3.Show();
        private
        void button2_Click(object
        sender, EventArgs
        e
    )
        {
            MessageBox.Show("新建");
        }
        private
        void textBoxNo2_Enter(object
        sender, EventArgs
        e
    )
        {
            MessageBox.Show("订单号");
        }
        private
        void textBoxName2_Enter(object
        sender, EventArgs
        e
    )
        {
            MessageBox.Show("商品名称");
        }
        private
        void textBoxCustomer2_Enter(object
        sender, EventArgs
        e
    )
        {
            MessageBox.Show("客户");
        }
        private
        void button3_Click(object
        sender, EventArgs
        e
    )
        {
            MessageBox.Show("确认新建");
        }
    }
        {
            Form3
            frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show();
            private void button2_Click(object sender,EventArgs e)
        {
            MessageBox.Show("新建");
        }

}