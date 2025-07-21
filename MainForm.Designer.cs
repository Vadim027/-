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
            this.dgvManufacturers = new System.Windows.Forms.DataGridView();
            this.tabAircrafts = new System.Windows.Forms.TabPage();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.btnAddManufacturer = new System.Windows.Forms.Button();
            this.btnEditManufacturer = new System.Windows.Forms.Button();
            this.btnDeleteManufacturer = new System.Windows.Forms.Button();
            this.dgvAircrafts = new System.Windows.Forms.DataGridView();
            this.btnAddAircraft = new System.Windows.Forms.Button();
            this.btnEditAircraft = new System.Windows.Forms.Button();
            this.btnDeleteAircraft = new System.Windows.Forms.Button();
            this.btnPrintAircraft = new System.Windows.Forms.Button();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.btnUpdateSpeed = new System.Windows.Forms.Button();
            this.btnUpdateAltitude = new System.Windows.Forms.Button();
            this.btnUpdateTurn = new System.Windows.Forms.Button();
            this.btnUpdateGear = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabManufacturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).BeginInit();
            this.tabAircrafts.SuspendLayout();
            this.tabStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAircrafts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabManufacturers);
            this.tabControlMain.Controls.Add(this.tabAircrafts);
            this.tabControlMain.Controls.Add(this.tabStatus);
            this.tabControlMain.Location = new System.Drawing.Point(169, 34);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(536, 328);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.Tag = "";
            // 
            // tabManufacturers
            // 
            this.tabManufacturers.Controls.Add(this.btnDeleteManufacturer);
            this.tabManufacturers.Controls.Add(this.btnEditManufacturer);
            this.tabManufacturers.Controls.Add(this.btnAddManufacturer);
            this.tabManufacturers.Controls.Add(this.dgvManufacturers);
            this.tabManufacturers.Location = new System.Drawing.Point(4, 25);
            this.tabManufacturers.Name = "tabManufacturers";
            this.tabManufacturers.Padding = new System.Windows.Forms.Padding(3);
            this.tabManufacturers.Size = new System.Drawing.Size(528, 299);
            this.tabManufacturers.TabIndex = 0;
            this.tabManufacturers.Text = "Производители";
            this.tabManufacturers.UseVisualStyleBackColor = true;
            // 
            // dgvManufacturers
            // 
            this.dgvManufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManufacturers.Location = new System.Drawing.Point(6, 6);
            this.dgvManufacturers.Name = "dgvManufacturers";
            this.dgvManufacturers.RowHeadersWidth = 51;
            this.dgvManufacturers.RowTemplate.Height = 24;
            this.dgvManufacturers.Size = new System.Drawing.Size(516, 208);
            this.dgvManufacturers.TabIndex = 0;
            // 
            // tabAircrafts
            // 
            this.tabAircrafts.Controls.Add(this.btnPrintAircraft);
            this.tabAircrafts.Controls.Add(this.btnDeleteAircraft);
            this.tabAircrafts.Controls.Add(this.btnEditAircraft);
            this.tabAircrafts.Controls.Add(this.btnAddAircraft);
            this.tabAircrafts.Controls.Add(this.dgvAircrafts);
            this.tabAircrafts.Location = new System.Drawing.Point(4, 25);
            this.tabAircrafts.Name = "tabAircrafts";
            this.tabAircrafts.Padding = new System.Windows.Forms.Padding(3);
            this.tabAircrafts.Size = new System.Drawing.Size(528, 299);
            this.tabAircrafts.TabIndex = 1;
            this.tabAircrafts.Text = "Самолёты";
            this.tabAircrafts.UseVisualStyleBackColor = true;
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.btnUpdateGear);
            this.tabStatus.Controls.Add(this.btnUpdateTurn);
            this.tabStatus.Controls.Add(this.btnUpdateAltitude);
            this.tabStatus.Controls.Add(this.btnUpdateSpeed);
            this.tabStatus.Controls.Add(this.dgvStatus);
            this.tabStatus.Location = new System.Drawing.Point(4, 25);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(528, 299);
            this.tabStatus.TabIndex = 2;
            this.tabStatus.Text = "Оперативная информация";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // btnAddManufacturer
            // 
            this.btnAddManufacturer.Location = new System.Drawing.Point(6, 220);
            this.btnAddManufacturer.Name = "btnAddManufacturer";
            this.btnAddManufacturer.Size = new System.Drawing.Size(182, 73);
            this.btnAddManufacturer.TabIndex = 1;
            this.btnAddManufacturer.Text = "Добавить";
            this.btnAddManufacturer.UseVisualStyleBackColor = true;
            // 
            // btnEditManufacturer
            // 
            this.btnEditManufacturer.Location = new System.Drawing.Point(194, 220);
            this.btnEditManufacturer.Name = "btnEditManufacturer";
            this.btnEditManufacturer.Size = new System.Drawing.Size(153, 73);
            this.btnEditManufacturer.TabIndex = 2;
            this.btnEditManufacturer.Text = "Изменить";
            this.btnEditManufacturer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteManufacturer
            // 
            this.btnDeleteManufacturer.Location = new System.Drawing.Point(353, 220);
            this.btnDeleteManufacturer.Name = "btnDeleteManufacturer";
            this.btnDeleteManufacturer.Size = new System.Drawing.Size(169, 73);
            this.btnDeleteManufacturer.TabIndex = 3;
            this.btnDeleteManufacturer.Text = "Удалить";
            this.btnDeleteManufacturer.UseVisualStyleBackColor = true;
            // 
            // dgvAircrafts
            // 
            this.dgvAircrafts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAircrafts.Location = new System.Drawing.Point(6, 6);
            this.dgvAircrafts.Name = "dgvAircrafts";
            this.dgvAircrafts.RowHeadersWidth = 51;
            this.dgvAircrafts.RowTemplate.Height = 24;
            this.dgvAircrafts.Size = new System.Drawing.Size(516, 207);
            this.dgvAircrafts.TabIndex = 0;
            // 
            // btnAddAircraft
            // 
            this.btnAddAircraft.Location = new System.Drawing.Point(6, 219);
            this.btnAddAircraft.Name = "btnAddAircraft";
            this.btnAddAircraft.Size = new System.Drawing.Size(134, 74);
            this.btnAddAircraft.TabIndex = 1;
            this.btnAddAircraft.Text = "Добавить";
            this.btnAddAircraft.UseVisualStyleBackColor = true;
            // 
            // btnEditAircraft
            // 
            this.btnEditAircraft.Location = new System.Drawing.Point(146, 219);
            this.btnEditAircraft.Name = "btnEditAircraft";
            this.btnEditAircraft.Size = new System.Drawing.Size(133, 74);
            this.btnEditAircraft.TabIndex = 2;
            this.btnEditAircraft.Text = "Изменить";
            this.btnEditAircraft.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAircraft
            // 
            this.btnDeleteAircraft.Location = new System.Drawing.Point(285, 219);
            this.btnDeleteAircraft.Name = "btnDeleteAircraft";
            this.btnDeleteAircraft.Size = new System.Drawing.Size(131, 74);
            this.btnDeleteAircraft.TabIndex = 3;
            this.btnDeleteAircraft.Text = "Удалить";
            this.btnDeleteAircraft.UseVisualStyleBackColor = true;
            // 
            // btnPrintAircraft
            // 
            this.btnPrintAircraft.Location = new System.Drawing.Point(422, 219);
            this.btnPrintAircraft.Name = "btnPrintAircraft";
            this.btnPrintAircraft.Size = new System.Drawing.Size(100, 74);
            this.btnPrintAircraft.TabIndex = 4;
            this.btnPrintAircraft.Text = "Печать";
            this.btnPrintAircraft.UseVisualStyleBackColor = true;
            this.btnPrintAircraft.Click += new System.EventHandler(this.btnPrintAircraft_Click);
            // 
            // dgvStatus
            // 
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatus.Location = new System.Drawing.Point(6, 6);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.RowHeadersWidth = 51;
            this.dgvStatus.RowTemplate.Height = 24;
            this.dgvStatus.Size = new System.Drawing.Size(516, 194);
            this.dgvStatus.TabIndex = 0;
            // 
            // btnUpdateSpeed
            // 
            this.btnUpdateSpeed.Location = new System.Drawing.Point(6, 206);
            this.btnUpdateSpeed.Name = "btnUpdateSpeed";
            this.btnUpdateSpeed.Size = new System.Drawing.Size(120, 87);
            this.btnUpdateSpeed.TabIndex = 1;
            this.btnUpdateSpeed.Text = "Изменить скорость";
            this.btnUpdateSpeed.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAltitude
            // 
            this.btnUpdateAltitude.Location = new System.Drawing.Point(132, 206);
            this.btnUpdateAltitude.Name = "btnUpdateAltitude";
            this.btnUpdateAltitude.Size = new System.Drawing.Size(121, 87);
            this.btnUpdateAltitude.TabIndex = 2;
            this.btnUpdateAltitude.Text = "Изменить высоту и скорость набора";
            this.btnUpdateAltitude.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTurn
            // 
            this.btnUpdateTurn.Location = new System.Drawing.Point(259, 206);
            this.btnUpdateTurn.Name = "btnUpdateTurn";
            this.btnUpdateTurn.Size = new System.Drawing.Size(133, 87);
            this.btnUpdateTurn.TabIndex = 3;
            this.btnUpdateTurn.Text = "Изменить поворот/скорость поворота";
            this.btnUpdateTurn.UseVisualStyleBackColor = true;
            // 
            // btnUpdateGear
            // 
            this.btnUpdateGear.Location = new System.Drawing.Point(398, 206);
            this.btnUpdateGear.Name = "btnUpdateGear";
            this.btnUpdateGear.Size = new System.Drawing.Size(124, 87);
            this.btnUpdateGear.TabIndex = 4;
            this.btnUpdateGear.Text = "Изменить выпуск шасси";
            this.btnUpdateGear.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 540);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.tabManufacturers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).EndInit();
            this.tabAircrafts.ResumeLayout(false);
            this.tabStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAircrafts)).EndInit();
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
        private System.Windows.Forms.Button btnEditManufacturer;
        private System.Windows.Forms.Button btnAddManufacturer;
        private System.Windows.Forms.DataGridView dgvAircrafts;
        private System.Windows.Forms.Button btnPrintAircraft;
        private System.Windows.Forms.Button btnDeleteAircraft;
        private System.Windows.Forms.Button btnEditAircraft;
        private System.Windows.Forms.Button btnAddAircraft;
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.Button btnUpdateTurn;
        private System.Windows.Forms.Button btnUpdateAltitude;
        private System.Windows.Forms.Button btnUpdateSpeed;
        private System.Windows.Forms.Button btnUpdateGear;
    }
}

