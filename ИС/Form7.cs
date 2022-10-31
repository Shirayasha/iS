using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИС
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zakupka main = this.Owner as Zakupka;
            if (main != null)
            {
                DataRow nRow = main.иСDataSet.Tables[1].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                main.иСDataSet.Tables[1].Rows.Add(nRow);
                main.postavchikTableAdapter.Update(main.иСDataSet.Postavchik);
                main.иСDataSet.Tables[1].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
