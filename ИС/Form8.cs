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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Technique". При необходимости она может быть перемещена или удалена.
            this.techniqueTableAdapter.Fill(this.иСDataSet.Technique);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Tip_oplati". При необходимости она может быть перемещена или удалена.
            this.tip_oplatiTableAdapter.Fill(this.иСDataSet.Tip_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Prodaga_technique". При необходимости она может быть перемещена или удалена.
            this.prodaga_techniqueTableAdapter.Fill(this.иСDataSet.Prodaga_technique);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.иСDataSet.Sotrudnik);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            if (main != null)
            {
                DataRow nRow = main.иСDataSet.Tables[2].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = comboBox1.SelectedValue;
                nRow[4] = comboBox2.SelectedValue;
                nRow[5] = comboBox3.SelectedValue;
                main.иСDataSet.Tables[2].Rows.Add(nRow);
                main.prodaga_techniqueTableAdapter.Update(main.иСDataSet.Prodaga_technique);
                main.иСDataSet.Tables[2].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
