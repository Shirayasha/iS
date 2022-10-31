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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm2 sf = new SearchForm2();
            sf.Owner = this;
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Tip_oplati". При необходимости она может быть перемещена или удалена.
            this.tip_oplatiTableAdapter.Fill(this.иСDataSet.Tip_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.иСDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Technique". При необходимости она может быть перемещена или удалена.
            this.techniqueTableAdapter.Fill(this.иСDataSet.Technique);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Prodaga_technique". При необходимости она может быть перемещена или удалена.
            this.prodaga_techniqueTableAdapter.Fill(this.иСDataSet.Prodaga_technique);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 sf = new Form8();
            sf.Owner = this;
            sf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchForm5 sf = new searchForm5();
            sf.Owner = this;
            sf.Show();
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 sf = new Form9();
            sf.Owner = this;
            sf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prodagatechniqueBindingSource.EndEdit();
            prodaga_techniqueTableAdapter.Update(иСDataSet);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            techniqueBindingSource.EndEdit();
            techniqueTableAdapter.Update(иСDataSet);
        }
    }
}
