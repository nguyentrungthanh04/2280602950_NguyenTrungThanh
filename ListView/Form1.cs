using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class lv : Form
    {
        public lv()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                string MSNV = form2.MSNV;
                string TenNV = form2.TenNV;
                string LuongCB = form2.LuongCB;

                ListViewItem item = new ListViewItem(new[] { MSNV, TenNV, LuongCB });
                listView1.Items.Add(item);
            }
        }

        int vt;
        private void btnSua_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            ListViewItem selectedItem = listView1.SelectedItems[0];
            form2.MSNV = selectedItem.SubItems[0].Text;
            form2.TenNV = selectedItem.SubItems[1].Text;
            form2.LuongCB = selectedItem.SubItems[2].Text;

            if (form2.ShowDialog() == DialogResult.OK)
            {
                selectedItem.SubItems[0].Text = form2.MSNV;
                selectedItem.SubItems[1].Text = form2.TenNV;
                selectedItem.SubItems[2].Text = form2.LuongCB;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            ListViewItem selectedItem = listView1.SelectedItems[0];
            listView1.Items.Remove(selectedItem);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
