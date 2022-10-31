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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Zakupka main = this.Owner as Zakupka;
            if (main != null)
            {
                DataRow nRow = main.иСDataSet.Tables[5].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = textBox4.Text;
                main.иСDataSet.Tables[5].Rows.Add(nRow);
                main.zakupka_techiqueTableAdapter.Update(main.иСDataSet.Zakupka_techique);
                main.иСDataSet.Tables[5].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 sf = new Form2();
            sf.Owner = this;
            sf.Show();
        }
    }
}
