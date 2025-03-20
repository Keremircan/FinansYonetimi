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
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
        }
        BillingDal _billingDal = new BillingDal();

        private void BillingForm_Load(object sender, EventArgs e)
        {
            LoadBilling();
        }
        private void LoadBilling()
        {
            var result = _billingDal.GetAll();
            if (result.Count > 0)
            {
                dgwBillings.DataSource = result;
            }
        }
        public DateTime? ConvertToDateTime(string dateString)
        {
            DateTime? dateValue = null;

            if (DateTime.TryParse(dateString, out DateTime parsedDate))
            {
                dateValue = parsedDate;
            }

            return dateValue;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxName.Text) || string.IsNullOrWhiteSpace(tbxAmount.Text) || string.IsNullOrWhiteSpace(cbxCurrency.Text) || string.IsNullOrWhiteSpace(tbxDate.Text))
            {
                MessageBox.Show("* 'lı Alanları Doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(tbxAmount.Text, out decimal amount))
            {
                MessageBox.Show("Geçerli bir miktar girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dateValue = ConvertToDateTime(tbxDate.Text);

            try
            {
                _billingDal.Add(new Billing
                {
                    Banka = tbxName.Text.Trim(),
                    Miktar = Convert.ToDecimal(tbxAmount.Text),
                    ParaBirimi = cbxCurrency.Text,
                    KesimTarihi = dateValue,
                    Aciklama = tbxDescription.Text.Trim()
                });
                tbxName.Text = "";
                tbxAmount.Text = "";
                cbxCurrency.Text = "TL";
                tbxDate.Text = "";
                tbxDescription.Text = "";
                LoadBilling();
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

            var dateValue = ConvertToDateTime(tbxDate2.Text);
            try
            {
                _billingDal.Update(new Billing
                {
                    No = Convert.ToInt32(dgwBillings.CurrentRow.Cells[0].Value),
                    Banka = tbxName2.Text.Trim(),
                    Miktar = Convert.ToDecimal(tbxAmount2.Text),
                    ParaBirimi = cbxCurrency2.Text,
                    KesimTarihi = dateValue,
                    Aciklama = tbxDescription2.Text.Trim()
                });
                LoadBilling();
                MessageBox.Show("Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void dgwBillings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwBillings.SelectedRows.Count > 0 && dgwBillings.DataSource != null)
            {
                tbxName2.Text = dgwBillings.CurrentRow.Cells[1].Value?.ToString() ?? "";
                tbxAmount2.Text = dgwBillings.CurrentRow.Cells[2].Value?.ToString() ?? "";
                cbxCurrency2.Text = dgwBillings.CurrentRow.Cells[3].Value?.ToString() ?? "";
                tbxDate2.Text = dgwBillings.CurrentRow.Cells[4].Value is DateTime date ? date.ToString("dd-MM-yyyy") : "";
                tbxDescription2.Text = dgwBillings.CurrentRow.Cells[5].Value?.ToString() ?? "";
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Silme işlemi için kullanıcıdan onay alınır
            var dialogResult = MessageBox.Show("Emin misiniz? Bu işlem geri alınamaz.", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                _billingDal.Delete(new Billing
                {
                    No = Convert.ToInt32(dgwBillings.CurrentRow.Cells[0].Value),
                    Banka = dgwBillings.CurrentRow.Cells[1].Value.ToString(),
                    Miktar = Convert.ToDecimal(dgwBillings.CurrentRow.Cells[2].Value),
                    ParaBirimi = dgwBillings.CurrentRow.Cells[3].Value.ToString(),
                    KesimTarihi = ConvertToDateTime(dgwBillings.CurrentRow.Cells[4].Value.ToString())
                });

                // Textbox'ları temizle
                tbxName2.Text = "";
                tbxAmount2.Text = "";
                cbxCurrency2.Text = "";
                tbxDate2.Text = "";
                tbxDescription2.Text = "";

                // Güncel verileri yükle
                LoadBilling();

                // Başarı mesajı
                MessageBox.Show("Başarıyla Silindi!");
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            var result = _billingDal.GetByName(tbxSearch.Text);
            if (result.Count > 0)
            {
                dgwBillings.DataSource = result;
            }
        }
    }
}
