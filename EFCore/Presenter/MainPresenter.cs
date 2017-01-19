using EFCore.Services;
using EFCore.View;

namespace EFCore.Presenter
{
    /// <summary>
    /// Представитель главного окна
    /// </summary>
    public class MainPresenter : IPresenter
    {
        private IMainView _view;
        private ISelectDataService _selectDataService;
        private ICreatePlaceService _createPlaceService;

        public MainPresenter(IMainView view, ISelectDataService selectDataService,
            ICreatePlaceService createPlaceService)
        {
            _view = view;
            _selectDataService = selectDataService;
            _createPlaceService = createPlaceService;

            _view.FormLoaded += FormLoadedHandler;
            _view.AddRecord += AddRecordHandler;
        }

        /// <summary>
        /// Запускает главное окно
        /// </summary>
        public void Run()
        {
            _view.Show();
        }

        private void AddRecordHandler()
        {
            var placeDto = _view.GetNewRecord();
            _createPlaceService.Add(placeDto);
            _view.AddPlace(placeDto);
        }

        private void FormLoadedHandler()
        {
            _view.FillPlaces(_selectDataService.SelectPlaces());
            _view.FillEngines(_selectDataService.SelectEngines());
            _view.FillCities(_selectDataService.SelectCities());
        }
    }
}
