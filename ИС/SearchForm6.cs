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
    public partial class SearchForm6 : Form
    {
        public SearchForm6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uchet main = this.Owner as Uchet;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView1.RowCount; i++)
                {
                    main.dataGridView3.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView3.ColumnCount; j++)
                        if (main.dataGridView3.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                main.dataGridView3.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
