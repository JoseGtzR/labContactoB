using AppContacto.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppContacto.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public List<Contact> ContactList { get; set; }
        #endregion

        #region ViewModel
        public ContactViewModel contactViewModel { get; set; }
        #endregion
        #region Constructor
        public MainViewModel()
        {
            instance = this;
            this.contactViewModel = new ContactViewModel();
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
