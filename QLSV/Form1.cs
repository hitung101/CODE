using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CbbLop.Items.Add("Lớp A");
            CbbLop.Items.Add("Lớp B");
            CbbLop.Items.Add("Lớp R");

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ListViewItem item = new ListViewItem(txtHoten.Text);

            //item.SubItems.Add(txtMaSV.Text);
            //item.SubItems.Add(dtpNgaysinh.Text);
            //item.SubItems.Add(txtDiachi.Text);
            //item.SubItems.Add(CbbLop.Text);

            //listView1.Items.Add(item);
            if ((string.IsNullOrEmpty(txtMaSV.Text))|| (string.IsNullOrEmpty(txtHoten.Text))){
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = txtMaSV.Text;
                listView1.Items.Add(item);

                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, (txtHoten.Text));
                item.SubItems.Add(subItem);
                ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem(item, (txtDiachi.Text));
                item.SubItems.Add(subItem1);
                ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem(item, (dtpNgaysinh.Text));
                item.SubItems.Add(subItem2);
                ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem(item, (CbbLop.Text));
                item.SubItems.Add(subItem3);
            }
        }
        
        private void EnabledTrue()
        {
            txtDiachi.Enabled = true;
            txtMaSV.Enabled = true;
            txtHoten.Enabled = true;
            dtpNgaysinh.Enabled = true;
            CbbLop.Enabled = true;
            
        }
        private void EnabledFalse()
        {
            txtDiachi.Enabled = false;
            txtMaSV.Enabled = false;
            txtHoten.Enabled = false;
            dtpNgaysinh.Enabled = false;
            CbbLop.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = string.Empty;
            txtHoten.Text = string.Empty;
            txtMaSV.Text = string.Empty;
            EnabledTrue();

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa mục đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        listView1.Items.Remove(item);
                    }
                }
            }
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
