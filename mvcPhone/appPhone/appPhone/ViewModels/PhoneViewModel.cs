namespace appPhone.ViewModels
{
    using apiPhoneBook.Models;
    using appPhone.Services;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    public class PhoneViewModel: BaseViewModel
    {
        #region Attributes
        ApiService apiService;
        private ObservableCollection<Phone> phones;
        #endregion

        #region Properties
        public ObservableCollection<Phone> Phones
        {
            get {return this.phones; }
            set {SetValue(ref this.phones, value); }
        }
        #endregion

        #region Constructor
        public PhoneViewModel()
        {
            this.apiService = new ApiService();
            this.LoadPhones();
        }
        #endregion

        #region Method
        private async void LoadPhones()
        {
            var connection = await apiService.CheckConnection();
            if(!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert
                (
                    "Internet Error",
                    connection.Message,
                    "Accept"
                );
                return;
            }
            var response = await apiService.GetList<Phone>
                (
                "http://localhost:49561/",
                "api/",
                "Phones"
                );
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert
                (
                    "Service Phone Error",
                    response.Message,
                    "Accept"
                );
                return;
        }
        #endregion
    }
}