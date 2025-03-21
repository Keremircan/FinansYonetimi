﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FinansYonetimi.Dal;
using FinansYonetimi.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

            var dateValue = ConvertToDateTime(tbxDate.Text);

            try
            {
                _receivableDal.Add(new Receivable
                {
                    Isim = tbxName.Text.Trim(),
                    Miktar = Convert.ToDecimal(tbxAmount.Text),
                    ParaBirimi = cbxCurrency.Text,
                    Tarih = dateValue,
                    Aciklama = tbxDescription.Text.Trim()
                });
                tbxName.Text = "";
                tbxAmount.Text = "";
                cbxCurrency.Text="TL";
                tbxDate.Text = "";
                tbxDescription.Text = "";
                LoadReceivable();
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
                _receivableDal.Update(new Receivable
                {
                    No = Convert.ToInt32(dgwReceivables.CurrentRow.Cells[0].Value),
                    Isim = tbxName2.Text.Trim(),
                    Miktar = Convert.ToDecimal(tbxAmount2.Text),
                    ParaBirimi = cbxCurrency2.Text,
                    Tarih = dateValue,
                    Aciklama = tbxDescription2.Text.Trim()
                });
                LoadReceivable();
                MessageBox.Show("Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

        }

        private void dgwReceivables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwReceivables.SelectedRows.Count > 0 && dgwReceivables.DataSource != null)
            {
                tbxName2.Text = dgwReceivables.CurrentRow.Cells[1].Value?.ToString() ?? "";
                tbxAmount2.Text = dgwReceivables.CurrentRow.Cells[2].Value?.ToString() ?? "";
                cbxCurrency2.Text = dgwReceivables.CurrentRow.Cells[3].Value?.ToString() ?? "";
                tbxDate2.Text = dgwReceivables.CurrentRow.Cells[4].Value is DateTime date ? date.ToString("dd-MM-yyyy") : "";
                tbxDescription2.Text = dgwReceivables.CurrentRow.Cells[5].Value?.ToString() ?? "";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Emin misiniz? Bu işlem geri alınamaz.", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                _receivableDal.Delete(new Receivable
                {
                    No = Convert.ToInt32(dgwReceivables.CurrentRow.Cells[0].Value),
                    Isim = dgwReceivables.CurrentRow.Cells[1].Value.ToString(),
                    Miktar = Convert.ToDecimal(dgwReceivables.CurrentRow.Cells[2].Value),
                    ParaBirimi = dgwReceivables.CurrentRow.Cells[3].Value.ToString()
                });
                tbxName2.Text = "";
                tbxAmount2.Text = "";
                cbxCurrency2.Text = "";
                tbxDate2.Text = "";
                tbxDescription2.Text = "";
                LoadReceivable();
                MessageBox.Show("Başarıyla Silindi!");
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            var result = _receivableDal.GetByName(tbxSearch.Text);
            if (result.Count > 0)
            {
                dgwReceivables.DataSource = result;
            }
        }
    }
}
