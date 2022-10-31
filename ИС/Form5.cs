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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uchet main = this.Owner as Uchet;
            if (main != null)
            {
                DataRow nRow = main.иСDataSet.Tables[3].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = comboBox1.SelectedValue;
                main.иСDataSet.Tables[3].Rows.Add(nRow);
                main.uchet_techniqueTableAdapter.Update(main.иСDataSet.Uchet_technique);
                main.иСDataSet.Tables[3].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Uchet_technique". При необходимости она может быть перемещена или удалена.
            this.uchet_techniqueTableAdapter.Fill(this.иСDataSet.Uchet_technique);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Technique". При необходимости она может быть перемещена или удалена.
            this.techniqueTableAdapter.Fill(this.иСDataSet.Technique);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
