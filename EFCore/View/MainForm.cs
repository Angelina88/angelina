using EFCore.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EFCore.View
{
    /// <summary>
    /// Главное окно
    /// </summary>
    public partial class MainForm : Form, IMainView
    {
        public event Action FormLoaded;
        public event Action AddRecord;

        public MainForm()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            Application.Run(this);
        }

        /// <summary>
        /// Заполнить места
        /// </summary>
        /// <param name="list">список мест</param>
        public void FillPlaces(IEnumerable<PlaceDto> list)
        {
            FillBindingSource(placeDtoBindingSource, list);
        }

        /// <summary>
        /// Заполнить города
        /// </summary>
        /// <param name="list">список городов</param>
        public void FillCities(IEnumerable<EntityDto> list)
        {
            FillBindingSource(cityDtoBindingSource, list);
        }

        /// <summary>
        /// Добавить новое место
        /// </summary>
        /// <param name="row">новое место</param>
        public void AddPlace(PlaceDto row)
        {
            placeDtoBindingSource.Insert(0, row);         
        }

        /// <summary>
        /// Заполнить движки очередей
        /// </summary>
        /// <param name="list">список движков очередей</param>
        public void FillEngines(IEnumerable<EntityDto> list)
        {
            FillBindingSource(engineDtoBindingSource, list);
        }   

        /// <summary>
        /// Получить новое место
        /// </summary>
        /// <returns>новое место</returns>
        public PlaceDto GetNewRecord()
        {
            var placeDto = new PlaceDto();
            placeDto.Name = NameTextBox.Text;
            placeDto.GroupName = GroupTextBox.Text;
            placeDto.OriginalPlaceId = OriginalPlaceIdTextBox.Text;
            Guid placeTypeId;
            if (Guid.TryParse(PlaceTypeIdTextBox.Text, out placeTypeId))
                placeDto.PlaceTypeId = placeTypeId;
            else
                placeDto.PlaceTypeId = Guid.Empty;
            placeDto.Address = AddressTextBox.Text;
            placeDto.AttributesJson = AttributesTextBox.Text;
            placeDto.CityId = (Guid)CityComboBox.SelectedValue;
            placeDto.CityName = ((EntityDto)CityComboBox.SelectedItem).Name;
            placeDto.ContactInfo = ContactTextBox.Text;
            placeDto.Enabled = EnableCheckBox.Checked;
            placeDto.EndPoint = EndPointTextBox.Text;
            placeDto.EngineId = (Guid)EngineComboBox.SelectedValue;
            placeDto.EngineName = ((EntityDto)EngineComboBox.SelectedItem).Name;
            placeDto.Created = DateTime.Now;
            placeDto.Updated = placeDto.Created;
            return placeDto;
        }

        private void FillBindingSource(BindingSource source, IEnumerable<object> list)
        {
            source.DataSource = list;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text)) return false;
            if (EngineComboBox.SelectedIndex < 0) return false;
            if (CityComboBox.SelectedIndex < 0) return false;
            return true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Необходимо заполнить все обязательные поля");
                return;
            }

            AddRecord.Invoke();

            ClearAddForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormLoaded.Invoke();
            PlaceTypeIdTextBox.Text = Guid.Empty.ToString();
        }

        private void ClearAddForm()
        {
            NameTextBox.Text = "";
            GroupTextBox.Text = "";
            OriginalPlaceIdTextBox.Text = "";
            PlaceTypeIdTextBox.Text = Guid.Empty.ToString();
            AddressTextBox.Text = "";
            AttributesTextBox.Text = "";
            CityComboBox.SelectedIndex = 0;
            ContactTextBox.Text = "";
            EnableCheckBox.Checked = false;
            EndPointTextBox.Text = "";
            EngineComboBox.SelectedIndex = 0;
        }

    }
}
