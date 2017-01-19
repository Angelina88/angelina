namespace EFCore.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlaceGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contactInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributesJsonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalPlaceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EngineComboBox = new System.Windows.Forms.ComboBox();
            this.engineDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EndPointTextBox = new System.Windows.Forms.TextBox();
            this.EnableCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.cityDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AttributesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.OriginalPlaceIdTextBox = new System.Windows.Forms.TextBox();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.PlaceTypeIdTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDtoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlaceGridView
            // 
            this.PlaceGridView.AllowUserToAddRows = false;
            this.PlaceGridView.AllowUserToDeleteRows = false;
            this.PlaceGridView.AutoGenerateColumns = false;
            this.PlaceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlaceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlaceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.groupNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.enabledDataGridViewCheckBoxColumn,
            this.contactInfoDataGridViewTextBoxColumn,
            this.engineIdDataGridViewTextBoxColumn,
            this.engineNameDataGridViewTextBoxColumn,
            this.endPointDataGridViewTextBoxColumn,
            this.attributesJsonDataGridViewTextBoxColumn,
            this.cityIdDataGridViewTextBoxColumn,
            this.cityNameDataGridViewTextBoxColumn,
            this.originalPlaceIdDataGridViewTextBoxColumn,
            this.placeTypeIdDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.updatedDataGridViewTextBoxColumn});
            this.PlaceGridView.DataSource = this.placeDtoBindingSource;
            this.PlaceGridView.Location = new System.Drawing.Point(0, 454);
            this.PlaceGridView.Margin = new System.Windows.Forms.Padding(3, 23, 3, 3);
            this.PlaceGridView.MinimumSize = new System.Drawing.Size(900, 0);
            this.PlaceGridView.MultiSelect = false;
            this.PlaceGridView.Name = "PlaceGridView";
            this.PlaceGridView.ReadOnly = true;
            this.PlaceGridView.RowTemplate.Height = 40;
            this.PlaceGridView.Size = new System.Drawing.Size(2868, 614);
            this.PlaceGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            this.groupNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enabledDataGridViewCheckBoxColumn
            // 
            this.enabledDataGridViewCheckBoxColumn.DataPropertyName = "Enabled";
            this.enabledDataGridViewCheckBoxColumn.HeaderText = "Доступна";
            this.enabledDataGridViewCheckBoxColumn.Name = "enabledDataGridViewCheckBoxColumn";
            this.enabledDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // contactInfoDataGridViewTextBoxColumn
            // 
            this.contactInfoDataGridViewTextBoxColumn.DataPropertyName = "ContactInfo";
            this.contactInfoDataGridViewTextBoxColumn.HeaderText = "Контактная информация";
            this.contactInfoDataGridViewTextBoxColumn.Name = "contactInfoDataGridViewTextBoxColumn";
            this.contactInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engineIdDataGridViewTextBoxColumn
            // 
            this.engineIdDataGridViewTextBoxColumn.DataPropertyName = "EngineId";
            this.engineIdDataGridViewTextBoxColumn.HeaderText = "EngineId";
            this.engineIdDataGridViewTextBoxColumn.Name = "engineIdDataGridViewTextBoxColumn";
            this.engineIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.engineIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // engineNameDataGridViewTextBoxColumn
            // 
            this.engineNameDataGridViewTextBoxColumn.DataPropertyName = "EngineName";
            this.engineNameDataGridViewTextBoxColumn.HeaderText = "Очередь";
            this.engineNameDataGridViewTextBoxColumn.Name = "engineNameDataGridViewTextBoxColumn";
            this.engineNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.engineNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // endPointDataGridViewTextBoxColumn
            // 
            this.endPointDataGridViewTextBoxColumn.DataPropertyName = "EndPoint";
            this.endPointDataGridViewTextBoxColumn.HeaderText = "Базовый адрес";
            this.endPointDataGridViewTextBoxColumn.Name = "endPointDataGridViewTextBoxColumn";
            this.endPointDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attributesJsonDataGridViewTextBoxColumn
            // 
            this.attributesJsonDataGridViewTextBoxColumn.DataPropertyName = "AttributesJson";
            this.attributesJsonDataGridViewTextBoxColumn.HeaderText = "Параметры";
            this.attributesJsonDataGridViewTextBoxColumn.Name = "attributesJsonDataGridViewTextBoxColumn";
            this.attributesJsonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityIdDataGridViewTextBoxColumn
            // 
            this.cityIdDataGridViewTextBoxColumn.DataPropertyName = "CityId";
            this.cityIdDataGridViewTextBoxColumn.HeaderText = "CityId";
            this.cityIdDataGridViewTextBoxColumn.Name = "cityIdDataGridViewTextBoxColumn";
            this.cityIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            this.cityNameDataGridViewTextBoxColumn.DataPropertyName = "CityName";
            this.cityNameDataGridViewTextBoxColumn.HeaderText = "Город";
            this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            this.cityNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originalPlaceIdDataGridViewTextBoxColumn
            // 
            this.originalPlaceIdDataGridViewTextBoxColumn.DataPropertyName = "OriginalPlaceId";
            this.originalPlaceIdDataGridViewTextBoxColumn.HeaderText = "Внешний идентификатор места";
            this.originalPlaceIdDataGridViewTextBoxColumn.Name = "originalPlaceIdDataGridViewTextBoxColumn";
            this.originalPlaceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeTypeIdDataGridViewTextBoxColumn
            // 
            this.placeTypeIdDataGridViewTextBoxColumn.DataPropertyName = "PlaceTypeId";
            this.placeTypeIdDataGridViewTextBoxColumn.HeaderText = "Идентификатор типа места";
            this.placeTypeIdDataGridViewTextBoxColumn.Name = "placeTypeIdDataGridViewTextBoxColumn";
            this.placeTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Создана";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedDataGridViewTextBoxColumn
            // 
            this.updatedDataGridViewTextBoxColumn.DataPropertyName = "Updated";
            this.updatedDataGridViewTextBoxColumn.HeaderText = "Обновлена";
            this.updatedDataGridViewTextBoxColumn.Name = "updatedDataGridViewTextBoxColumn";
            this.updatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeDtoBindingSource
            // 
            this.placeDtoBindingSource.DataSource = typeof(EFCore.DTO.PlaceDto);
            // 
            // EngineComboBox
            // 
            this.EngineComboBox.DataSource = this.engineDtoBindingSource;
            this.EngineComboBox.DisplayMember = "Name";
            this.EngineComboBox.FormattingEnabled = true;
            this.EngineComboBox.Location = new System.Drawing.Point(1141, 14);
            this.EngineComboBox.Name = "EngineComboBox";
            this.EngineComboBox.Size = new System.Drawing.Size(317, 39);
            this.EngineComboBox.TabIndex = 12;
            this.EngineComboBox.ValueMember = "Id";
            // 
            // engineDtoBindingSource
            // 
            this.engineDtoBindingSource.DataSource = typeof(EFCore.DTO.EntityDto);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(793, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Очередь*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Контактная информация";
            // 
            // EndPointTextBox
            // 
            this.EndPointTextBox.Location = new System.Drawing.Point(1141, 64);
            this.EndPointTextBox.Name = "EndPointTextBox";
            this.EndPointTextBox.Size = new System.Drawing.Size(317, 38);
            this.EndPointTextBox.TabIndex = 14;
            // 
            // EnableCheckBox
            // 
            this.EnableCheckBox.AutoSize = true;
            this.EnableCheckBox.Location = new System.Drawing.Point(22, 154);
            this.EnableCheckBox.Name = "EnableCheckBox";
            this.EnableCheckBox.Size = new System.Drawing.Size(286, 36);
            this.EnableCheckBox.TabIndex = 9;
            this.EnableCheckBox.Text = "доступна клиенту";
            this.EnableCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(793, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Базовый адрес сервиса";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(272, 110);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(317, 38);
            this.AddressTextBox.TabIndex = 7;
            // 
            // CityComboBox
            // 
            this.CityComboBox.DataSource = this.cityDtoBindingSource;
            this.CityComboBox.DisplayMember = "Name";
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(1141, 110);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(317, 39);
            this.CityComboBox.TabIndex = 16;
            this.CityComboBox.ValueMember = "Id";
            // 
            // cityDtoBindingSource
            // 
            this.cityDtoBindingSource.DataSource = typeof(EFCore.DTO.EntityDto);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Адрес";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(793, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Город*";
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Location = new System.Drawing.Point(272, 61);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(317, 38);
            this.GroupTextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(793, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "Параметры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Группа";
            // 
            // AttributesTextBox
            // 
            this.AttributesTextBox.Location = new System.Drawing.Point(799, 245);
            this.AttributesTextBox.Multiline = true;
            this.AttributesTextBox.Name = "AttributesTextBox";
            this.AttributesTextBox.Size = new System.Drawing.Size(659, 110);
            this.AttributesTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1634, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(350, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "Внешний идентификатор";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(272, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(317, 38);
            this.NameTextBox.TabIndex = 2;
            // 
            // OriginalPlaceIdTextBox
            // 
            this.OriginalPlaceIdTextBox.Location = new System.Drawing.Point(2029, 14);
            this.OriginalPlaceIdTextBox.Name = "OriginalPlaceIdTextBox";
            this.OriginalPlaceIdTextBox.Size = new System.Drawing.Size(317, 38);
            this.OriginalPlaceIdTextBox.TabIndex = 21;
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(22, 255);
            this.ContactTextBox.Multiline = true;
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(567, 100);
            this.ContactTextBox.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1634, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(380, 32);
            this.label10.TabIndex = 22;
            this.label10.Text = "Идентификатор типа места";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(22, 370);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(174, 60);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PlaceTypeIdTextBox
            // 
            this.PlaceTypeIdTextBox.Location = new System.Drawing.Point(2029, 64);
            this.PlaceTypeIdTextBox.Name = "PlaceTypeIdTextBox";
            this.PlaceTypeIdTextBox.Size = new System.Drawing.Size(317, 38);
            this.PlaceTypeIdTextBox.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PlaceTypeIdTextBox);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ContactTextBox);
            this.panel1.Controls.Add(this.OriginalPlaceIdTextBox);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AttributesTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.GroupTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CityComboBox);
            this.panel1.Controls.Add(this.AddressTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EnableCheckBox);
            this.panel1.Controls.Add(this.EndPointTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EngineComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2868, 1058);
            this.panel1.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2868, 1058);
            this.Controls.Add(this.PlaceGridView);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Места";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlaceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDtoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PlaceGridView;
        private System.Windows.Forms.BindingSource placeDtoBindingSource;
        private System.Windows.Forms.ComboBox EngineComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EndPointTextBox;
        private System.Windows.Forms.CheckBox EnableCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GroupTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AttributesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox OriginalPlaceIdTextBox;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox PlaceTypeIdTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource engineDtoBindingSource;
        private System.Windows.Forms.BindingSource cityDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributesJsonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalPlaceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDataGridViewTextBoxColumn;
    }
}

