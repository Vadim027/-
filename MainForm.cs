using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            MessageBox.Show("Добавить производителя — пока заглушка");
        }

        private void btnEditManufacturer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изменить производителя — пока заглушка");
        }

        private void btnDeleteManufacturer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удалить производителя — пока заглушка");
        }

        // === Самолёты ===

        private void btnAddAircraft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавить самолёт — пока заглушка");
        }

        private void btnEditAircraft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изменить самолёт — пока заглушка");
        }

        private void btnDeleteAircraft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удалить самолёт — пока заглушка");
        }

        private void btnPrintAircraft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Печать самолётов — пока заглушка");
        }

        // === Оперативная информация ===

        private void btnUpdateSpeed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изменить скорость — пока заглушка");
        }

        private void btnUpdateAltitude_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изменить высоту и скорость набора — пока заглушка");
        }

        private void btnUpdateTurn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изменить поворот/скорость поворота — пока заглушка");
        }

        private void btnUpdateGear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изменить выпуск шасси — пока заглушка");
        }
    }
}
