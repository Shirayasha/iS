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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.иСDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Uchet_technique". При необходимости она может быть перемещена или удалена.
            this.uchet_techniqueTableAdapter.Fill(this.иСDataSet.Uchet_technique);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Doljnost". При необходимости она может быть перемещена или удалена.
            this.doljnostTableAdapter.Fill(this.иСDataSet.Doljnost);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uchet main = this.Owner as Uchet;
            if (main != null)
            {
                DataRow nRow = main.иСDataSet.Tables[4].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = textBox4.Text;
                nRow[5] = textBox5.Text;
                nRow[6] = comboBox2.SelectedValue;
                main.иСDataSet.Tables[4].Rows.Add(nRow);
                main.uchet_techniqueTableAdapter.Update(main.иСDataSet.Uchet_technique);
                main.иСDataSet.Tables[4].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
