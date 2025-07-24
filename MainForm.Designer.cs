using System;

namespace Управление_самолетами
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabManufacturers = new System.Windows.Forms.TabPage();
            this.btnPrintManufacturers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddManufacturer = new System.Windows.Forms.Button();
            this.btnSaveManufacturer = new System.Windows.Forms.Button();
            this.txtManufacturerDescription = new System.Windows.Forms.TextBox();
            this.txtManufacturerName = new System.Windows.Forms.TextBox();
            this.btnDeleteManufacturer = new System.Windows.Forms.Button();
            this.dgvManufacturers = new System.Windows.Forms.DataGridView();
            this.tabAircrafts = new System.Windows.Forms.TabPage();
            this.cbManufacturer = new System.Windows.Forms.ComboBox();
            this.txtAircraftDescription = new System.Windows.Forms.TextBox();
            this.txtAircraftName = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.btnPrintAircrafts = new System.Windows.Forms.Button();
            this.btnDeleteAircraft = new System.Windows.Forms.Button();
            this.btnSaveAircraft = new System.Windows.Forms.Button();
            this.btnAddAircraft = new System.Windows.Forms.Button();
            this.dgvAircrafts = new System.Windows.Forms.DataGridView();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.btnPrintStatus = new System.Windows.Forms.Button();
            this.btnUpdateGear = new System.Windows.Forms.Button();
            this.btnUpdateTurn = new System.Windows.Forms.Button();
            this.btnUpdateAltitude = new System.Windows.Forms.Button();
            this.btnUpdateSpeed = new System.Windows.Forms.Button();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabManufacturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).BeginInit();
            this.tabAircrafts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAircrafts)).BeginInit();
            this.tabStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabManufacturers);
            this.tabControlMain.Controls.Add(this.tabAircrafts);
            this.tabControlMain.Controls.Add(this.tabStatus);
            this.tabControlMain.Location = new System.Drawing.Point(3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(866, 466);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.Tag = "";
            // 
            // tabManufacturers
            // 
            this.tabManufacturers.Controls.Add(this.btnPrintManufacturers);
            this.tabManufacturers.Controls.Add(this.label2);
            this.tabManufacturers.Controls.Add(this.label1);
            this.tabManufacturers.Controls.Add(this.btnAddManufacturer);
            this.tabManufacturers.Controls.Add(this.btnSaveManufacturer);
            this.tabManufacturers.Controls.Add(this.txtManufacturerDescription);
            this.tabManufacturers.Controls.Add(this.txtManufacturerName);
            this.tabManufacturers.Controls.Add(this.btnDeleteManufacturer);
            this.tabManufacturers.Controls.Add(this.dgvManufacturers);
            this.tabManufacturers.Location = new System.Drawing.Point(4, 25);
            this.tabManufacturers.Name = "tabManufacturers";
            this.tabManufacturers.Padding = new System.Windows.Forms.Padding(3);
            this.tabManufacturers.Size = new System.Drawing.Size(858, 437);
            this.tabManufacturers.TabIndex = 0;
            this.tabManufacturers.Text = "Производители";
            this.tabManufacturers.UseVisualStyleBackColor = true;
            this.tabManufacturers.Click += new System.EventHandler(this.tabManufacturers_Click);
            // 
            // btnPrintManufacturers
            // 
            this.btnPrintManufacturers.Location = new System.Drawing.Point(380, 356);
            this.btnPrintManufacturers.Name = "btnPrintManufacturers";
            this.btnPrintManufacturers.Size = new System.Drawing.Size(147, 60);
            this.btnPrintManufacturers.TabIndex = 10;
            this.btnPrintManufacturers.Text = "Печать";
            this.btnPrintManufacturers.UseVisualStyleBackColor = true;
            this.btnPrintManufacturers.Click += new System.EventHandler(this.btnPrintManufacturers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Новое название самолёта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Новое название производителя";
            // 
            // btnAddManufacturer
            // 
            this.btnAddManufacturer.Location = new System.Drawing.Point(19, 356);
            this.btnAddManufacturer.Name = "btnAddManufacturer";
            this.btnAddManufacturer.Size = new System.Drawing.Size(113, 60);
            this.btnAddManufacturer.TabIndex = 7;
            this.btnAddManufacturer.Text = "Добавить";
            this.btnAddManufacturer.UseVisualStyleBackColor = true;
            this.btnAddManufacturer.Click += new System.EventHandler(this.btnAddManufacturer_Click_1);
            // 
            // btnSaveManufacturer
            // 
            this.btnSaveManufacturer.Location = new System.Drawing.Point(133, 356);
            this.btnSaveManufacturer.Name = "btnSaveManufacturer";
            this.btnSaveManufacturer.Size = new System.Drawing.Size(117, 60);
            this.btnSaveManufacturer.TabIndex = 6;
            this.btnSaveManufacturer.Text = "Сохранить";
            this.btnSaveManufacturer.UseVisualStyleBackColor = true;
            this.btnSaveManufacturer.Click += new System.EventHandler(this.btnSaveManufacturer_Click);
            // 
            // txtManufacturerDescription
            // 
            this.txtManufacturerDescription.Location = new System.Drawing.Point(256, 291);
            this.txtManufacturerDescription.Name = "txtManufacturerDescription";
            this.txtManufacturerDescription.Size = new System.Drawing.Size(218, 22);
            this.txtManufacturerDescription.TabIndex = 5;
            // 
            // txtManufacturerName
            // 
            this.txtManufacturerName.Location = new System.Drawing.Point(19, 291);
            this.txtManufacturerName.Name = "txtManufacturerName";
            this.txtManufacturerName.Size = new System.Drawing.Size(179, 22);
            this.txtManufacturerName.TabIndex = 4;
            // 
            // btnDeleteManufacturer
            // 
            this.btnDeleteManufacturer.Location = new System.Drawing.Point(256, 356);
            this.btnDeleteManufacturer.Name = "btnDeleteManufacturer";
            this.btnDeleteManufacturer.Size = new System.Drawing.Size(118, 60);
            this.btnDeleteManufacturer.TabIndex = 3;
            this.btnDeleteManufacturer.Text = "Удалить";
            this.btnDeleteManufacturer.UseVisualStyleBackColor = true;
            this.btnDeleteManufacturer.Click += new System.EventHandler(this.btnDeleteManufacturer_Click_1);
            // 
            // dgvManufacturers
            // 
            this.dgvManufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManufacturers.Location = new System.Drawing.Point(6, 6);
            this.dgvManufacturers.Name = "dgvManufacturers";
            this.dgvManufacturers.RowHeadersWidth = 51;
            this.dgvManufacturers.RowTemplate.Height = 24;
            this.dgvManufacturers.Size = new System.Drawing.Size(676, 208);
            this.dgvManufacturers.TabIndex = 0;
            this.dgvManufacturers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManufacturers_CellContentClick);
            this.dgvManufacturers.SelectionChanged += new System.EventHandler(this.dgvManufacturers_SelectionChanged);
            // 
            // tabAircrafts
            // 
            this.tabAircrafts.Controls.Add(this.label6);
            this.tabAircrafts.Controls.Add(this.label5);
            this.tabAircrafts.Controls.Add(this.label4);
            this.tabAircrafts.Controls.Add(this.label3);
            this.tabAircrafts.Controls.Add(this.cbManufacturer);
            this.tabAircrafts.Controls.Add(this.txtAircraftDescription);
            this.tabAircrafts.Controls.Add(this.txtAircraftName);
            this.tabAircrafts.Controls.Add(this.txtSerialNumber);
            this.tabAircrafts.Controls.Add(this.btnPrintAircrafts);
            this.tabAircrafts.Controls.Add(this.btnDeleteAircraft);
            this.tabAircrafts.Controls.Add(this.btnSaveAircraft);
            this.tabAircrafts.Controls.Add(this.btnAddAircraft);
            this.tabAircrafts.Controls.Add(this.dgvAircrafts);
            this.tabAircrafts.Location = new System.Drawing.Point(4, 25);
            this.tabAircrafts.Name = "tabAircrafts";
            this.tabAircrafts.Padding = new System.Windows.Forms.Padding(3);
            this.tabAircrafts.Size = new System.Drawing.Size(858, 437);
            this.tabAircrafts.TabIndex = 1;
            this.tabAircrafts.Text = "Самолёты";
            this.tabAircrafts.UseVisualStyleBackColor = true;
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.Location = new System.Drawing.Point(561, 257);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(121, 24);
            this.cbManufacturer.TabIndex = 8;
            // 
            // txtAircraftDescription
            // 
            this.txtAircraftDescription.Location = new System.Drawing.Point(375, 259);
            this.txtAircraftDescription.Name = "txtAircraftDescription";
            this.txtAircraftDescription.Size = new System.Drawing.Size(100, 22);
            this.txtAircraftDescription.TabIndex = 7;
            // 
            // txtAircraftName
            // 
            this.txtAircraftName.Location = new System.Drawing.Point(189, 259);
            this.txtAircraftName.Name = "txtAircraftName";
            this.txtAircraftName.Size = new System.Drawing.Size(100, 22);
            this.txtAircraftName.TabIndex = 6;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(6, 259);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(100, 22);
            this.txtSerialNumber.TabIndex = 5;
            // 
            // btnPrintAircrafts
            // 
            this.btnPrintAircrafts.Location = new System.Drawing.Point(461, 374);
            this.btnPrintAircrafts.Name = "btnPrintAircrafts";
            this.btnPrintAircrafts.Size = new System.Drawing.Size(100, 74);
            this.btnPrintAircrafts.TabIndex = 4;
            this.btnPrintAircrafts.Text = "Печать";
            this.btnPrintAircrafts.UseVisualStyleBackColor = true;
            this.btnPrintAircrafts.Click += new System.EventHandler(this.btnPrintAircrafts_Click);
            // 
            // btnDeleteAircraft
            // 
            this.btnDeleteAircraft.Location = new System.Drawing.Point(309, 374);
            this.btnDeleteAircraft.Name = "btnDeleteAircraft";
            this.btnDeleteAircraft.Size = new System.Drawing.Size(131, 74);
            this.btnDeleteAircraft.TabIndex = 3;
            this.btnDeleteAircraft.Text = "Удалить";
            this.btnDeleteAircraft.UseVisualStyleBackColor = true;
            this.btnDeleteAircraft.Click += new System.EventHandler(this.btnDeleteAircraft_Click_1);
            // 
            // btnSaveAircraft
            // 
            this.btnSaveAircraft.Location = new System.Drawing.Point(156, 374);
            this.btnSaveAircraft.Name = "btnSaveAircraft";
            this.btnSaveAircraft.Size = new System.Drawing.Size(133, 74);
            this.btnSaveAircraft.TabIndex = 2;
            this.btnSaveAircraft.Text = "Сохранить";
            this.btnSaveAircraft.UseVisualStyleBackColor = true;
            this.btnSaveAircraft.Click += new System.EventHandler(this.btnSaveAircraft_Click_1);
            // 
            // btnAddAircraft
            // 
            this.btnAddAircraft.Location = new System.Drawing.Point(6, 374);
            this.btnAddAircraft.Name = "btnAddAircraft";
            this.btnAddAircraft.Size = new System.Drawing.Size(134, 74);
            this.btnAddAircraft.TabIndex = 1;
            this.btnAddAircraft.Text = "Добавить";
            this.btnAddAircraft.UseVisualStyleBackColor = true;
            this.btnAddAircraft.Click += new System.EventHandler(this.btnAddAircraft_Click_1);
            // 
            // dgvAircrafts
            // 
            this.dgvAircrafts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAircrafts.Location = new System.Drawing.Point(6, 6);
            this.dgvAircrafts.Name = "dgvAircrafts";
            this.dgvAircrafts.RowHeadersWidth = 51;
            this.dgvAircrafts.RowTemplate.Height = 24;
            this.dgvAircrafts.Size = new System.Drawing.Size(676, 207);
            this.dgvAircrafts.TabIndex = 0;
            this.dgvAircrafts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAircrafts_CellContentClick);
            this.dgvAircrafts.SelectionChanged += new System.EventHandler(this.dgvAircrafts_SelectionChanged);
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.btnPrintStatus);
            this.tabStatus.Controls.Add(this.btnUpdateGear);
            this.tabStatus.Controls.Add(this.btnUpdateTurn);
            this.tabStatus.Controls.Add(this.btnUpdateAltitude);
            this.tabStatus.Controls.Add(this.btnUpdateSpeed);
            this.tabStatus.Controls.Add(this.dgvStatus);
            this.tabStatus.Location = new System.Drawing.Point(4, 25);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(858, 437);
            this.tabStatus.TabIndex = 2;
            this.tabStatus.Text = "Оперативная информация";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // btnPrintStatus
            // 
            this.btnPrintStatus.Location = new System.Drawing.Point(546, 206);
            this.btnPrintStatus.Name = "btnPrintStatus";
            this.btnPrintStatus.Size = new System.Drawing.Size(136, 87);
            this.btnPrintStatus.TabIndex = 5;
            this.btnPrintStatus.Text = "Печать";
            this.btnPrintStatus.UseVisualStyleBackColor = true;
            this.btnPrintStatus.Click += new System.EventHandler(this.btnPrintStatus_Click);
            // 
            // btnUpdateGear
            // 
            this.btnUpdateGear.Location = new System.Drawing.Point(398, 206);
            this.btnUpdateGear.Name = "btnUpdateGear";
            this.btnUpdateGear.Size = new System.Drawing.Size(142, 87);
            this.btnUpdateGear.TabIndex = 4;
            this.btnUpdateGear.Text = "Изменить выпуск шасси";
            this.btnUpdateGear.UseVisualStyleBackColor = true;
            this.btnUpdateGear.Click += new System.EventHandler(this.btnUpdateGear_Click);
            // 
            // btnUpdateTurn
            // 
            this.btnUpdateTurn.Location = new System.Drawing.Point(259, 206);
            this.btnUpdateTurn.Name = "btnUpdateTurn";
            this.btnUpdateTurn.Size = new System.Drawing.Size(133, 87);
            this.btnUpdateTurn.TabIndex = 3;
            this.btnUpdateTurn.Text = "Изменить поворот/скорость поворота";
            this.btnUpdateTurn.UseVisualStyleBackColor = true;
            this.btnUpdateTurn.Click += new System.EventHandler(this.btnUpdateTurn_Click);
            // 
            // btnUpdateAltitude
            // 
            this.btnUpdateAltitude.Location = new System.Drawing.Point(132, 206);
            this.btnUpdateAltitude.Name = "btnUpdateAltitude";
            this.btnUpdateAltitude.Size = new System.Drawing.Size(121, 87);
            this.btnUpdateAltitude.TabIndex = 2;
            this.btnUpdateAltitude.Text = "Изменить высоту и скорость набора";
            this.btnUpdateAltitude.UseVisualStyleBackColor = true;
            this.btnUpdateAltitude.Click += new System.EventHandler(this.btnUpdateAltitude_Click);
            // 
            // btnUpdateSpeed
            // 
            this.btnUpdateSpeed.Location = new System.Drawing.Point(6, 206);
            this.btnUpdateSpeed.Name = "btnUpdateSpeed";
            this.btnUpdateSpeed.Size = new System.Drawing.Size(120, 87);
            this.btnUpdateSpeed.TabIndex = 1;
            this.btnUpdateSpeed.Text = "Изменить скорость";
            this.btnUpdateSpeed.UseVisualStyleBackColor = true;
            this.btnUpdateSpeed.Click += new System.EventHandler(this.btnUpdateSpeed_Click_1);
            // 
            // dgvStatus
            // 
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatus.Location = new System.Drawing.Point(6, 6);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.RowHeadersWidth = 51;
            this.dgvStatus.RowTemplate.Height = 24;
            this.dgvStatus.Size = new System.Drawing.Size(846, 194);
            this.dgvStatus.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Серийный номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Название";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Описание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Марка";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 500);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.tabManufacturers.ResumeLayout(false);
            this.tabManufacturers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).EndInit();
            this.tabAircrafts.ResumeLayout(false);
            this.tabAircrafts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAircrafts)).EndInit();
            this.tabStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabManufacturers;
        private System.Windows.Forms.TabPage tabAircrafts;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.DataGridView dgvManufacturers;
        private System.Windows.Forms.Button btnDeleteManufacturer;
        private System.Windows.Forms.DataGridView dgvAircrafts;
        private System.Windows.Forms.Button btnPrintAircrafts;
        private System.Windows.Forms.Button btnDeleteAircraft;
        private System.Windows.Forms.Button btnSaveAircraft;
        private System.Windows.Forms.Button btnAddAircraft;
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.Button btnUpdateTurn;
        private System.Windows.Forms.Button btnUpdateAltitude;
        private System.Windows.Forms.Button btnUpdateSpeed;
        private System.Windows.Forms.Button btnUpdateGear;
        private System.Windows.Forms.Button btnSaveManufacturer;
        private System.Windows.Forms.TextBox txtManufacturerDescription;
        private System.Windows.Forms.TextBox txtManufacturerName;
        private System.Windows.Forms.Button btnAddManufacturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintManufacturers;
        private System.Windows.Forms.ComboBox cbManufacturer;
        private System.Windows.Forms.TextBox txtAircraftDescription;
        private System.Windows.Forms.TextBox txtAircraftName;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Button btnPrintStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

