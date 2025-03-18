using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinansYonetimi.Forms
{
    public partial class ReceivableForm : Form
    {
        public ReceivableForm()
        {
            InitializeComponent();
        }

        ReceivableDal _receivableDal = new ReceivableDal();
        private void ReceivableForm_Load_1(object sender, EventArgs e)
        {
            LoadReceivable();
        }
        private void LoadReceivable()
        {
            var result = _receivableDal.GetAll();
            if (result.Count > 0)
            {
                dgwReceivables.DataSource = result;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime? dateValue = null;  // Nullable DateTime

            // Tarih girişini kontrol et
            if (DateTime.TryParse(tbxDate.Text, out DateTime parsedDate))
            {
                dateValue = parsedDate;
            }
            _receivableDal.Add(new Receivable
            {
                Name = tbxName.Text,
                Amount = Convert.ToDecimal(tbxAmount.Text),
                Date = dateValue,
                Description = tbxDescription.Text
            });
            LoadReceivable();
            MessageBox.Show("Eklendi!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime? dateValue = null;
            if (DateTime.TryParse(tbxDate2.Text, out DateTime parsedDate))
            {
                dateValue = parsedDate;
            }

            _receivableDal.Update(new Receivable
            {
                RID = Convert.ToInt32(dgwReceivables.CurrentRow.Cells[0].Value),
                Name = tbxName2.Text,
                Amount = Convert.ToDecimal(tbxAmount2.Text),
                Date = dateValue,
                Description = tbxDescription2.Text

            });

            LoadReceivable();
            MessageBox.Show("Güncellendi!");
        }

        private void dgwReceivables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwReceivables.SelectedRows.Count > 0 && dgwReceivables.DataSource != null)
            {
                tbxName2.Text = dgwReceivables.CurrentRow.Cells[1].Value.ToString();
                tbxAmount2.Text = dgwReceivables.CurrentRow.Cells[2].Value.ToString();
                tbxDate2.Text = dgwReceivables.CurrentRow.Cells[3].Value.ToString();
                tbxDescription2.Text = dgwReceivables.CurrentRow.Cells[4].Value.ToString();
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _receivableDal.Delete(new Receivable { RID = Convert.ToInt32(dgwReceivables.CurrentRow.Cells[0].Value) });
            LoadReceivable();
            MessageBox.Show("Silindi!");
        }
    }
}
