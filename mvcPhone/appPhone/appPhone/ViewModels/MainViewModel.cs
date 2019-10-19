using apiPhoneBook.Models;
using System.Collections.Generic;

namespace appPhone.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public List<Phone> ListPhone { get; set; }
        #endregion

        #region
        public PhoneViewModel phoneViewModel { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            instance = this;
            this.phoneViewModel = new PhoneViewModel();
        } 
        #endregion

        #region singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();
            }
            return (instance);
        }
        #endregion
    }
}
