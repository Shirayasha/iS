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
    public partial class Zakupka : Form
    {
        public Zakupka()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Zakupka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Tip_oplati". При необходимости она может быть перемещена или удалена.
            this.tip_oplatiTableAdapter.Fill(this.иСDataSet.Tip_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Technique". При необходимости она может быть перемещена или удалена.
            this.techniqueTableAdapter.Fill(this.иСDataSet.Technique);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Postavchik". При необходимости она может быть перемещена или удалена.
            this.postavchikTableAdapter.Fill(this.иСDataSet.Postavchik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.иСDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Zakupka_techique". При необходимости она может быть перемещена или удалена.
            this.zakupka_techiqueTableAdapter.Fill(this.иСDataSet.Zakupka_techique);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm1 sf = new SearchForm1();
            sf.Owner = this;
            sf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 sf = new Form4();
            sf.Owner = this;
            sf.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchForm3 sf = new SearchForm3();
            sf.Owner = this;
            sf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 sf = new Form7();
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

        private void button6_Click(object sender, EventArgs e)
        {
            zakupkatechiqueBindingSource.EndEdit();
            zakupka_techiqueTableAdapter.Update(иСDataSet);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sotrudnikBindingSource.EndEdit();
            sotrudnikTableAdapter.Update(иСDataSet);
        }
    }
}
