using Dj.Categorisa.Base;
using Dj.Categorisa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Dj.Categorisa.ViewModels
{
    public class CategorisaViewModel : ObservableObject, ICategorisaViewModel
    {
        private ICategorisaModel _categorisaModel;

        public CategorisaViewModel(ICategorisaModel categorisaModel)
        {
            _categorisaModel = categorisaModel;
            CopyButtonCommand = new RelayCommand(OnCopyButtonCommand);
        }

        internal void EnableCopyButton()
        {
            IsCopyButtonEnabled = !string.IsNullOrEmpty(SongPathTextBox) && AnyGenreSelected();
        }

        internal bool AnyGenreSelected()
        {
            return (IsGenreRnbComboBoxItemSelected
                    || IsGenrePopComboBoxItemSelected
                    || IsGenreHipHopComboBoxItemSelected
                    || IsGenreUrbanComboBoxItemSelected
                    || IsGenreSleeperComboBoxItemSelected
                    || IsGenreChillComboBoxItemSelected
                    || IsGenreDanceComboBoxItemSelected
                    || IsGenreGirlPowerComboBoxItemSelected
                    || IsGenreCountryComboBoxItemSelected
                    || IsGenreFunkComboBoxItemSelected
                    || IsGenreRockComboBoxItemSelected
                    || IsGenreMoombahtonComboBoxItemSelected);
        }

        internal void Reset()
        {
            SongPathTextBox = "";
            IsStatusUnprocessedRadioButtonChecked = true;
            IsTypeRemixRadioButtonChecked = true;
            ResetGenreComboBox();
            _categorisaModel.Reset();
        }

        internal void Copy()
        {
            var isCopied = _categorisaModel.Copy();
            MessageBox.Show(string.Concat("Song ", isCopied ? "copied" : "did not copy", " successfully."));

            if (isCopied)
            {
                Reset();
            }
        }

        internal void ResetGenreComboBox()
        {
            IsGenreRnbComboBoxItemSelected = false;
            IsGenrePopComboBoxItemSelected = false;
            IsGenreHipHopComboBoxItemSelected = false;
            IsGenreUrbanComboBoxItemSelected = false;
            IsGenreSleeperComboBoxItemSelected = false;
            IsGenreChillComboBoxItemSelected = false;
            IsGenreDanceComboBoxItemSelected = false;
            IsGenreGirlPowerComboBoxItemSelected = false;
            IsGenreCountryComboBoxItemSelected = false;
            IsGenreFunkComboBoxItemSelected = false;
            IsGenreRockComboBoxItemSelected = false;
            IsGenreMoombahtonComboBoxItemSelected = false;
        }

        internal void UpdateLibraryPath()
        {
            _categorisaModel.UpdateLibraryPath();
            LibraryPathTextBlock = _categorisaModel.LibraryPath;
        }

        public ICommand CopyButtonCommand { get; set; }

        private async void OnCopyButtonCommand(object param)
        {
            await Task.Run(() => Copy());
        }

        public string SongPathTextBox
        {
            get { return _categorisaModel.SongPath; }
            set
            {
                _categorisaModel.SongPath = value;
                EnableCopyButton();
                NotifyPropertyChanged("SongPathTextBox");
            }
        }

        public bool IsStatusUnprocessedRadioButtonChecked
        {
            get { return _categorisaModel.IsStatusUnprocessedChecked; }
            set
            {
                _categorisaModel.IsStatusUnprocessedChecked = value;
                UpdateLibraryPath();
                NotifyPropertyChanged("IsStatusUnprocessedRadioButtonChecked");
            }
        }

        public bool IsStatusSelectionsRadioButtonChecked
        {
            get { return _categorisaModel.IsStatusSelectionsChecked; }
            set
            {
                _categorisaModel.IsStatusSelectionsChecked = value;
                UpdateLibraryPath();
                NotifyPropertyChanged("IsStatusSelectionsRadioButtonChecked");
            }
        }

        public bool IsTypeRemixRadioButtonChecked
        {
            get { return _categorisaModel.IsTypeRemixChecked; }
            set
            {
                _categorisaModel.IsTypeRemixChecked = value;
                UpdateLibraryPath();
                NotifyPropertyChanged("IsTypeRemixRadioButtonChecked");
            }
        }

        public bool IsTypeOriginalRadioButtonChecked
        {
            get { return _categorisaModel.IsTypeOriginalChecked; }
            set
            {
                _categorisaModel.IsTypeOriginalChecked = value;
                UpdateLibraryPath();
                NotifyPropertyChanged("IsTypeOriginalRadioButtonChecked");
            }
        }

        public bool IsTypePersonalFavouriteRadioButtonChecked
        {
            get { return _categorisaModel.IsTypePersonalFavouriteChecked; }
            set
            {
                _categorisaModel.IsTypePersonalFavouriteChecked = value;
                UpdateLibraryPath();
                NotifyPropertyChanged("IsTypePersonalFavouriteRadioButtonChecked");
            }
        }

        public bool IsGenreRnbComboBoxItemSelected
        {
            get { return _categorisaModel.IsGenreRnbSelected; }
            set
            {
                _categorisaModel.IsGenreRnbSelected = value;
                UpdateLibraryPath();
                EnableCopyButton();
                NotifyPropertyChanged("IsGenreRnbComboBoxItemSelected");
            }
        }

        public bool IsGenrePopComboBoxItemSelected
        {
            get { return _categorisaModel.IsGenrePopSelected; }
            set
            {
                _categorisaModel.IsGenrePopSelected = value;
                UpdateLibraryPath();
                EnableCopyButton();
                NotifyPropertyChanged("IsGenrePopComboBoxItemSelected");
            }
        }

        public bool IsGenreHipHopComboBoxItemSelected
        {
            get { return _categorisaModel.IsGenreHipHopSelected; }
            set
            {
                _categorisaModel.IsGenreHipHopSelected = value;
                UpdateLibraryPath();
                EnableCopyButton();
                NotifyPropertyChanged("IsGenreHipHopComboBoxItemSelected");
            }
        }

        public bool IsGenreUrbanComboBoxItemSelected
        {
            get { return _categorisaModel.IsGenreUrbanSelected; }
            set
            {
                _categorisaModel.IsGenreUrbanSelected = value;
                UpdateLibraryPath();
                EnableCopyButton();
                NotifyPropertyChanged("IsGenreUrbanComboBoxItemSelected");
            }
        }

        public bool IsGenreSleeperComboBoxItemSelected
        {
            get { return _categorisaModel.IsGenreSleeperSelected; }
            set
            {
                _categorisaModel.IsGenreSleeperSelected = value;
                UpdateLibraryPath();
                EnableCopyButton();
                NotifyPropertyChanged("IsGenreSleeperComboBoxItemSelected");
            }
        }

        public bool IsGenreChillComboBoxItemSelected
        {
            get { return _categorisaModel.IsGenreChillSelected; }
            set
            {
                _categorisaModel.IsGenreChillSelected = value;
                UpdateLibraryPath();
                EnableCopyButton();
                NotifyPropertyChanged("IsGenreChillComboBoxItemSelected");
            }
        }

        public bool IsGenreDanceComboBoxItemSelected
        {
            get { return _categorisaModel.IsGenreDanceSelected; }
            set
            {
                _categorisaModel.IsGenreDanceSelected = value;
                UpdateLibraryPath();
                EnableCopyButton();
                NotifyPropertyChanged("IsGenreDanceComboBoxItemSelected");
            }
        }

        public bool IsGenreGirlPowerComboBoxItemSelected
        {
            get { return _categorisaModel.IsGenreGirlPowerSelected; }
            set
            {
                _categorisaModel.IsGenreGirlPowerSelected = value;
                UpdateLibraryPath();
                EnableCopyButton();
                NotifyPropertyChanged("IsGenreGirlPowerComboBoxItemSelected");
            }
        }

        public bool IsGenreCountryComboBoxItemSelected
        {
            get { return _categorisaModel.IsGenreCountrySelected; }
            set
            {
                _categorisaModel.IsGenreCountrySelected = value;
                UpdateLibraryPath();
                EnableCopyButton();
                NotifyPropertyChanged("IsGenreCountryComboBoxItemSelected");
            }
        }

        public bool IsGenreFunkComboBoxItemSelected
        {
            get { return _categorisaModel.IsGenreFunkSelected; }
            set
            {
                _categorisaModel.IsGenreFunkSelected = value;
                UpdateLibraryPath();
                EnableCopyButton();
                NotifyPropertyChanged("IsGenreFunkComboBoxItemSelected");
            }
        }

        public bool IsGenreRockComboBoxItemSelected
        {
            get { return _categorisaModel.IsGenreRockSelected; }
            set
            {
                _categorisaModel.IsGenreRockSelected = value;
                UpdateLibraryPath();
                EnableCopyButton();
                NotifyPropertyChanged("IsGenreRockComboBoxItemSelected");
            }
        }

        public bool IsGenreMoombahtonComboBoxItemSelected
        {
            get { return _categorisaModel.IsGenreMoombahtonSelected; }
            set
            {
                _categorisaModel.IsGenreMoombahtonSelected = value;
                UpdateLibraryPath();
                EnableCopyButton();
                NotifyPropertyChanged("IsGenreMoombahtonComboBoxItemSelected");
            }
        }

        public string LibraryPathTextBlock
        {
            get { return _categorisaModel.LibraryPath; }
            set
            {
                _categorisaModel.LibraryPath = value;
                NotifyPropertyChanged("LibraryPathTextBlock");
            }
        }

        public bool IsCopyButtonEnabled
        {
            get { return _categorisaModel.IsCopyEnabled; }
            set
            {
                _categorisaModel.IsCopyEnabled = value;
                NotifyPropertyChanged("IsCopyButtonEnabled");
            }
        }
    }
}
