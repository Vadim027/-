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
using ClosedXML.Excel;
using System.Diagnostics;
using System.IO;


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

            LoadAircrafts();

            LoadStatus();
        }

        private void LoadManufacturers()
        {
            dgvManufacturers.DataSource = null;
            dgvManufacturers.DataSource = _db.GetManufacturers();
        }


        // === Самолёты ===

        private void LoadAircrafts()
        {
            dgvAircrafts.DataSource = null;
            dgvAircrafts.DataSource = _db.GetAircrafts();
            cbManufacturer.DataSource = _db.GetManufacturers();
            cbManufacturer.DisplayMember = "Name";
            cbManufacturer.ValueMember = "Id";
        }

        // === Оперативная информация ===



        // === Производители ===


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

        private void btnPrintManufacturers_Click(object sender, EventArgs e)
        {
            if (dgvManufacturers.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для печати!");
                return;
            }

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Manufacturers");

                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Название";
                worksheet.Cell(1, 3).Value = "Описание";

                int row = 2;

                foreach (DataGridViewRow dgRow in dgvManufacturers.Rows)
                {
                    if (dgRow.DataBoundItem is Manufacturer m)
                    {
                        worksheet.Cell(row, 1).Value = m.Id;
                        worksheet.Cell(row, 2).Value = m.Name;
                        worksheet.Cell(row, 3).Value = m.Description;
                        row++;
                    }
                }

                string fileName = Path.Combine(Application.StartupPath, "Manufacturers.xlsx");
                workbook.SaveAs(fileName);

                // Откроем папку и выделим файл
                Process.Start("explorer.exe", $"/select,\"{fileName}\"");
            }

            /// <summary>
            ///Функция кнопки Печать
        }


        // === Самолёты ===


        private void dgvAircrafts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAircrafts.CurrentRow == null)
            {
                txtSerialNumber.Clear();
                txtAircraftName.Clear();
                txtAircraftDescription.Clear();
                cbManufacturer.SelectedIndex = -1;
                return;
            }

            var row = dgvAircrafts.CurrentRow.DataBoundItem as Aircraft;
            if (row == null) return;

            txtSerialNumber.Text = row.SerialNumber;
            txtAircraftName.Text = row.Name;
            txtAircraftDescription.Text = row.Description;
            cbManufacturer.SelectedValue = row.ManufacturerId;
        }

        private void btnAddAircraft_Click_1(object sender, EventArgs e)
        {
            txtSerialNumber.Clear();
            txtAircraftName.Clear();
            txtAircraftDescription.Clear();
            cbManufacturer.SelectedIndex = -1;
            dgvAircrafts.ClearSelection();
        }

        private void btnSaveAircraft_Click_1(object sender, EventArgs e)
        {
            var sn = txtSerialNumber.Text.Trim();
            var name = txtAircraftName.Text.Trim();
            var desc = txtAircraftDescription.Text.Trim();

            if (cbManufacturer.SelectedValue == null)
            {
                MessageBox.Show("Выберите производителя!");
                return;
            }

            var mId = (int)cbManufacturer.SelectedValue;

            if (string.IsNullOrWhiteSpace(sn) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите серийный номер и имя самолёта!");
                return;
            }

            if (dgvAircrafts.SelectedRows.Count == 0)
            {
                _db.AddAircraft(sn, name, desc, mId);
                MessageBox.Show("Самолёт добавлен!");
            }
            else
            {
                var selected = dgvAircrafts.CurrentRow?.DataBoundItem as Aircraft;
                if (selected != null)
                {
                    _db.UpdateAircraft(selected.Id, sn, name, desc, mId);
                    MessageBox.Show("Самолёт обновлён!");
                }
            }

            LoadAircrafts();
            txtSerialNumber.Clear();
            txtAircraftName.Clear();
            txtAircraftDescription.Clear();
            cbManufacturer.SelectedIndex = -1;
            dgvAircrafts.ClearSelection();
        }

        private void btnDeleteAircraft_Click_1(object sender, EventArgs e)
        {
            if (dgvAircrafts.CurrentRow == null)
            {
                MessageBox.Show("Выберите самолёт для удаления!");
                return;
            }

            var row = dgvAircrafts.CurrentRow.DataBoundItem as Aircraft;
            if (row == null) return;

            var confirm = MessageBox.Show($"Удалить самолёт {row.Name}?", "Подтвердите", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _db.DeleteAircraft(row.Id);
                MessageBox.Show("Самолёт удалён!");
                LoadAircrafts();
                txtSerialNumber.Clear();
                txtAircraftName.Clear();
                txtAircraftDescription.Clear();
                cbManufacturer.SelectedIndex = -1;
                dgvAircrafts.ClearSelection();
            }
        }

        private void btnPrintAircrafts_Click(object sender, EventArgs e)
        {
            if (dgvAircrafts.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для печати!");
                return;
            }

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Aircrafts");

                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Серийный номер";
                worksheet.Cell(1, 3).Value = "Название";
                worksheet.Cell(1, 4).Value = "Описание";
                worksheet.Cell(1, 5).Value = "Производитель ID";

                int row = 2;

                foreach (DataGridViewRow dgRow in dgvAircrafts.Rows)
                {
                    if (dgRow.DataBoundItem is Aircraft ac)
                    {
                        worksheet.Cell(row, 1).Value = ac.Id;
                        worksheet.Cell(row, 2).Value = ac.SerialNumber;
                        worksheet.Cell(row, 3).Value = ac.Name;
                        worksheet.Cell(row, 4).Value = ac.Description;
                        worksheet.Cell(row, 5).Value = ac.ManufacturerId;
                        row++;
                    }
                }

                string fileName = Path.Combine(Application.StartupPath, "Aircrafts.xlsx");
                workbook.SaveAs(fileName);

                Process.Start("explorer.exe", $"/select,\"{fileName}\"");
            }
        }

        private void dgvAircrafts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        // === Оперативная информация ===


        private void LoadStatus()
        {
            dgvStatus.DataSource = null;
            dgvStatus.DataSource = _db.GetAircraftStatuses();
        }


        /// <summary>
        /// Кнопка обновления оперативной информации
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateSpeed_Click_1(object sender, EventArgs e)
        {
            if (dgvStatus.CurrentRow == null) return;
            var s = dgvStatus.CurrentRow.DataBoundItem as AircraftStatus;
            if (s == null) return;

            var input = Prompt.ShowDialog("Новая скорость:", "Обновить скорость");
            if (float.TryParse(input, out float newSpeed))
            {
                s.FlightSpeed = newSpeed;
                _db.UpdateAircraftStatus(s);
                LoadStatus();
            }
        }



        private void btnUpdateAltitude_Click(object sender, EventArgs e)
        {
            if (dgvStatus.CurrentRow == null) return;
            var s = dgvStatus.CurrentRow.DataBoundItem as AircraftStatus;
            if (s == null) return;

            var altInput = Prompt.ShowDialog("Новая высота:", "Обновить высоту");
            var crInput = Prompt.ShowDialog("Новая скорость набора:", "Обновить скорость набора");
            if (float.TryParse(altInput, out float newAlt) && float.TryParse(crInput, out float newClimb))
            {
                s.Altitude = newAlt;
                s.ClimbRate = newClimb;
                _db.UpdateAircraftStatus(s);
                LoadStatus();
            }
        }

        private void btnUpdateTurn_Click(object sender, EventArgs e)
        {
            if (dgvStatus.CurrentRow == null) return;
            var s = dgvStatus.CurrentRow.DataBoundItem as AircraftStatus;
            if (s == null) return;

            var dirInput = Prompt.ShowDialog("Направление (Straight, Left, Right):", "Обновить направление");
            var tsInput = Prompt.ShowDialog("Скорость поворота:", "Обновить скорость поворота");
            if (Enum.TryParse(dirInput, true, out TurnDirection newDir) && float.TryParse(tsInput, out float newTS))
            {
                s.TurnDirection = newDir;
                s.TurnSpeed = newTS;
                _db.UpdateAircraftStatus(s);
                LoadStatus();
            }
        }

        private void btnUpdateGear_Click(object sender, EventArgs e)
        {
            if (dgvStatus.CurrentRow == null) return;
            var s = dgvStatus.CurrentRow.DataBoundItem as AircraftStatus;
            if (s == null) return;

            s.Gear = !s.Gear; // Переключаем шасси
            _db.UpdateAircraftStatus(s);
            LoadStatus();
        }



        private void btnPrintStatus_Click(object sender, EventArgs e)
        {
            if (dgvStatus.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для печати!");
                return;
            }

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("AircraftStatus");

                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Aircraft ID";
                worksheet.Cell(1, 3).Value = "Скорость полёта";
                worksheet.Cell(1, 4).Value = "Высота";
                worksheet.Cell(1, 5).Value = "Скорость набора";
                worksheet.Cell(1, 6).Value = "Направление";
                worksheet.Cell(1, 7).Value = "Скорость поворота";
                worksheet.Cell(1, 8).Value = "Шасси";

                int row = 2;

                foreach (DataGridViewRow dgRow in dgvStatus.Rows)
                {
                    if (dgRow.DataBoundItem is AircraftStatus s)
                    {
                        worksheet.Cell(row, 1).Value = s.Id;
                        worksheet.Cell(row, 2).Value = s.AircraftId;
                        worksheet.Cell(row, 3).Value = s.FlightSpeed;
                        worksheet.Cell(row, 4).Value = s.Altitude;
                        worksheet.Cell(row, 5).Value = s.ClimbRate;
                        worksheet.Cell(row, 6).Value = s.TurnDirection.ToString();
                        worksheet.Cell(row, 7).Value = s.TurnSpeed;
                        worksheet.Cell(row, 8).Value = s.Gear ? "Выпущены" : "Убраны";
                        row++;
                    }
                }

                string fileName = Path.Combine(Application.StartupPath, "AircraftStatus.xlsx");
                workbook.SaveAs(fileName);

                Process.Start("explorer.exe", $"/select,\"{fileName}\"");
            }
        }
    }
}
