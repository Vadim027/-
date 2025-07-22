using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Управление_самолетами.Models;
using Управление_самолетами.Services;

namespace Управление_самолетами
{
    public partial class MainForm : Form
    {
        private AppConfig _cfg;
        private DbService _db;
        private NetworkService _net;

        public MainForm(AppConfig cfg, DbService db, NetworkService net)
        {
            InitializeComponent();
            _cfg = cfg;
            _db = db;
            _net = net;

            LoadManufacturers();
        }

        private void LoadManufacturers()
        {
            dgvManufacturers.DataSource = null;
            dgvManufacturers.DataSource = _db.GetManufacturers();
        }

        // === Производители ===

        private void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditManufacturer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteManufacturer_Click(object sender, EventArgs e)
        {
            
        }

        // === Самолёты ===

        private void btnAddAircraft_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditAircraft_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteAircraft_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrintAircraft_Click(object sender, EventArgs e)
        {
            
        }

        // === Оперативная информация ===

        private void btnUpdateSpeed_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateAltitude_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateTurn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateGear_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvManufacturers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvManufacturers.CurrentRow == null)
            {
                txtManufacturerName.Clear();
                txtManufacturerDescription.Clear();
                return;
            }

            var row = dgvManufacturers.CurrentRow.DataBoundItem as Manufacturer;
            if (row == null) return;

            txtManufacturerName.Text = row.Name;
            txtManufacturerDescription.Text = row.Description;
        }

        private void btnSaveManufacturer_Click(object sender, EventArgs e)
        {
            var name = txtManufacturerName.Text.Trim();
            var desc = txtManufacturerDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название!");
                return;
            }

            if (dgvManufacturers.SelectedRows.Count == 0)
            {
                _db.AddManufacturer(name, desc);
                MessageBox.Show("Производитель добавлен!");
            }
            else
            {
                // Если выбрана строка — то обновление
                var selected = dgvManufacturers.CurrentRow?.DataBoundItem as Manufacturer;
                if (selected != null)
                {
                    _db.UpdateManufacturer(selected.Id, name, desc);
                    MessageBox.Show("Производитель обновлён!");
                }
            }

            LoadManufacturers();
            txtManufacturerName.Clear();
            txtManufacturerDescription.Clear();
            dgvManufacturers.ClearSelection();
        }

        private void btnDeleteManufacturer_Click_1(object sender, EventArgs e)
        {
            if (dgvManufacturers.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите производителя для удаления!");
                return;
            }

            var row = dgvManufacturers.CurrentRow.DataBoundItem as Manufacturer;
            if (row == null) return;

            if (!_db.CanDeleteManufacturer(row.Id))
            {
                MessageBox.Show("Нельзя удалить производителя, к которому привязаны самолёты!", "Ошибка");
                return;
            }

            var confirm = MessageBox.Show($"Удалить {row.Name}?", "Подтвердите", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _db.DeleteManufacturer(row.Id);
                MessageBox.Show("Производитель удалён!");
                LoadManufacturers();
                txtManufacturerName.Clear();
                txtManufacturerDescription.Clear();
                dgvManufacturers.ClearSelection();
            }
        }

        private void btnAddManufacturer_Click_1(object sender, EventArgs e)
        {
            txtManufacturerName.Clear();
            txtManufacturerDescription.Clear();
            dgvManufacturers.ClearSelection();
        }

        private void dgvManufacturers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
