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
    public partial class SearchForm4cs : Form
    {
        public SearchForm4cs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uchet main = this.Owner as Uchet;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView2.RowCount; i++)
                {
                    main.dataGridView2.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView2.ColumnCount; j++)
                        if (main.dataGridView2.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                main.dataGridView2.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbStr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
