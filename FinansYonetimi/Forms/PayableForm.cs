using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinansYonetimi.Dal;
using FinansYonetimi.Model;

namespace FinansYonetimi.Forms
{
    public partial class PayableForm : Form
    {
        public PayableForm()
        {
            InitializeComponent();
        }

        PayableDal _payableDal = new PayableDal();

        private void PayableForm_Load(object sender, EventArgs e)
        {
            LoadPayable();
        }
        private void LoadPayable()
        {
            var result = _payableDal.GetAll();
            if (result.Count > 0)
            {
                dgwPayables.DataSource = result;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxName.Text) || string.IsNullOrWhiteSpace(tbxAmount.Text) || string.IsNullOrWhiteSpace(cbxCurrency.Text))
            {
                MessageBox.Show("* 'lı Alanları Doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(tbxAmount.Text, out decimal amount))
            {
                MessageBox.Show("Geçerli bir miktar girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime? dateValue = null;  // Nullable DateTime

            // Tarih girişini kontrol et
            if (DateTime.TryParse(tbxDate.Text, out DateTime parsedDate))
            {
                dateValue = parsedDate;
            }
            try
            {
                _payableDal.Add(new Payable
                {
                    Isim = tbxName.Text.Trim(),
                    Miktar = Convert.ToDecimal(tbxAmount.Text),
                    ParaBirimi = cbxCurrency.Text,
                    Tarih = dateValue,
                    Aciklama = tbxDescription.Text.Trim()
                });
                tbxName.Text = "";
                tbxAmount.Text = "";
                cbxCurrency.Text = "TL";
                tbxDate.Text = "";
                tbxDescription.Text = "";
                LoadPayable();
                MessageBox.Show("Başarıyla Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxName2.Text) || string.IsNullOrWhiteSpace(tbxAmount2.Text))
            {
                MessageBox.Show("* 'lı Alanları Doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(tbxAmount2.Text, out decimal amount))
            {
                MessageBox.Show("Geçerli bir miktar girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime? dateValue = null;
            if (DateTime.TryParse(tbxDate2.Text, out DateTime parsedDate))
            {
                dateValue = parsedDate;
            }

            try
            {
                _payableDal.Update(new Payable
                {
                    No = Convert.ToInt32(dgwPayables.CurrentRow.Cells[0].Value),
                    Isim = tbxName2.Text.Trim(),
                    Miktar = Convert.ToDecimal(tbxAmount2.Text),
                    ParaBirimi = cbxCurrency2.Text,
                    Tarih = dateValue,
                    Aciklama = tbxDescription2.Text.Trim()
                });
                LoadPayable();
                MessageBox.Show("Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void dgwPayables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwPayables.SelectedRows.Count > 0 && dgwPayables.DataSource != null)
            {
                tbxName2.Text = dgwPayables.CurrentRow.Cells[1].Value?.ToString() ?? "";
                tbxAmount2.Text = dgwPayables.CurrentRow.Cells[2].Value?.ToString() ?? "";
                cbxCurrency2.Text = dgwPayables.CurrentRow.Cells[3].Value?.ToString() ?? "";
                tbxDate2.Text = dgwPayables.CurrentRow.Cells[4].Value is DateTime date ? date.ToString("dd-MM-yyyy") : "";
                tbxDescription2.Text = dgwPayables.CurrentRow.Cells[5].Value?.ToString() ?? "";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _payableDal.Delete(new Payable
            {
                No = Convert.ToInt32(dgwPayables.CurrentRow.Cells[0].Value),
                Isim = dgwPayables.CurrentRow.Cells[1].Value.ToString(),
                Miktar = Convert.ToDecimal(dgwPayables.CurrentRow.Cells[2].Value),
                ParaBirimi = dgwPayables.CurrentRow.Cells[3].Value.ToString()
            });
            tbxName2.Text = "";
            tbxAmount2.Text = "";
            cbxCurrency2.Text = "";
            tbxDate2.Text = "";
            tbxDescription2.Text = "";
            LoadPayable();
            MessageBox.Show("Silindi!");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            var result = _payableDal.GetByName(tbxSearch.Text);
            if (result.Count > 0)
            {
                dgwPayables.DataSource = result;
            }
        }
    }
}
