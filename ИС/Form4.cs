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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zakupka main = this.Owner as Zakupka;
            if (main != null)
            {
                DataRow nRow = main.иСDataSet.Tables[8].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = textBox2.Text;
                nRow[2] = textBox1.Text;
                nRow[3] = comboBox1.SelectedValue;
                nRow[4] = comboBox2.SelectedValue;
                nRow[5] = comboBox3.SelectedValue;
                nRow[6] = comboBox4.SelectedValue;
                main.иСDataSet.Tables[8].Rows.Add(nRow);
                main.zakupka_techiqueTableAdapter.Update(main.иСDataSet.Zakupka_techique);
                main.иСDataSet.Tables[8].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox2.Text = "";
                textBox1.Text = "";
              

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Tip_oplati". При необходимости она может быть перемещена или удалена.
            this.tip_oplatiTableAdapter.Fill(this.иСDataSet.Tip_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Technique". При необходимости она может быть перемещена или удалена.
            this.techniqueTableAdapter.Fill(this.иСDataSet.Technique);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Postavchik". При необходимости она может быть перемещена или удалена.
            this.postavchikTableAdapter.Fill(this.иСDataSet.Postavchik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Zakupka_techique". При необходимости она может быть перемещена или удалена.
            this.zakupka_techiqueTableAdapter.Fill(this.иСDataSet.Zakupka_techique);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.иСDataSet.Sotrudnik);

        }
    }
}
