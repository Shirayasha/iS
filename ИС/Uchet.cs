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
    public partial class Uchet : Form
    {
        public Uchet()
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

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.иСDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Technique". При необходимости она может быть перемещена или удалена.
            this.techniqueTableAdapter.Fill(this.иСDataSet.Technique);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Proizvoditely". При необходимости она может быть перемещена или удалена.
            this.proizvoditelyTableAdapter.Fill(this.иСDataSet.Proizvoditely);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Uchet_technique". При необходимости она может быть перемещена или удалена.
            this.uchet_techniqueTableAdapter.Fill(this.иСDataSet.Uchet_technique);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 sf = new Form6();
            sf.Owner = this;
            sf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 sf = new Form5();
            sf.Owner = this;
            sf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchForm4cs sf = new SearchForm4cs();
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

        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form11 sf = new Form11();
            sf.Owner = this;
            sf.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            proizvoditelyBindingSource.EndEdit();
            proizvoditelyTableAdapter.Update(иСDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchForm6 sf = new SearchForm6();
            sf.Owner = this;
            sf.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sotrudnikBindingSource.EndEdit();
            sotrudnikTableAdapter.Update(иСDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
