using SongHandlerInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dj.Categorisa.Models
{
    public class CategorisaModel : ICategorisaModel
    {
        public const string BaseLibraryPath = @"C:\DJ Eli B";

        private string _statusPath;
        private string _typePath;
        private string _genrePath;
        private bool _isStatusUnprocessedChecked;
        private bool _isStatusSelectionsChecked;
        private bool _isTypeRemixChecked;
        private bool _isTypeOriginalChecked;
        private bool _isTypePersonalFavouriteChecked;
        private bool _isGenreRnbSelected;
        private bool _isGenrePopSelected;
        private bool _isGenreHipHopSelected;
        private bool _isGenreUrbanSelected;
        private bool _isGenreSleeperSelected;
        private bool _isGenreChillSelected;
        private bool _isGenreDanceSelected;
        private bool _isGenreGirlPowerSelected;
        private bool _isGenreCountrySelected;
        private bool _isGenreFunkSelected;
        private bool _isGenreRockSelected;
        private bool _isGenreMoombahtonSelected;
        private ISongHandler _songHandler;

        public CategorisaModel(ISongHandler songHandler)
        {
            _songHandler = songHandler;
            IsStatusUnprocessedChecked = true;
            IsTypeRemixChecked = true;
            IsCopyEnabled = false;
            Reset();
            UpdateLibraryPath();
        }

        internal void UpdateGenrePath()
        {
            if (IsGenreRnbSelected)
            {
                _genrePath = "RnB";
            }
            else if (IsGenrePopSelected)
            {
                _genrePath = "Pop";
            }
            else if (IsGenreHipHopSelected)
            {
                _genrePath = "HipHop";
            }
            else if (IsGenreUrbanSelected)
            {
                _genrePath = "Urban";
            }
            else if (IsGenreSleeperSelected)
            {
                _genrePath = "Sleeper";
            }
            else if (IsGenreChillSelected)
            {
                _genrePath = "Chill";
            }
            else if (IsGenreDanceSelected)
            {
                _genrePath = "Dance";
            }
            else if (IsGenreGirlPowerSelected)
            {
                _genrePath = "GirlPower";
            }
            else if (IsGenreCountrySelected)
            {
                _genrePath = "Country";
            }
            else if (IsGenreFunkSelected)
            {
                _genrePath = "Funk";
            }
            else if (IsGenreRockSelected)
            {
                _genrePath = "Rock";
            }
            else if (IsGenreMoombahtonSelected)
            {
                _genrePath = "Moombahton";
            }
        }

        internal void UpdateStatusPath()
        {
            _statusPath = IsStatusUnprocessedChecked ? "Unprocessed" : "Selections";
        }

        internal void UpdateTypePath()
        {
            if (IsTypeRemixChecked)
            {
                _typePath = "Remix";
            }
            else if (IsTypeOriginalChecked)
            {
                _typePath = "Original";
            }
            else
            {
                _typePath = "Personal favourite";
            }
        }

        public void Reset()
        {
            LibraryPath = BaseLibraryPath;
            _statusPath = string.Empty;
            _typePath = string.Empty;
            _genrePath = string.Empty;
        }

        public bool Copy()
        {
            return _songHandler.Copy(SongPath, LibraryPath);
        }

        public void UpdateLibraryPath()
        {
            UpdateStatusPath();
            UpdateTypePath();
            UpdateGenrePath();

            if (!string.IsNullOrEmpty(_statusPath) && !string.IsNullOrEmpty(_typePath) && IsTypePersonalFavouriteChecked)
            {
                LibraryPath = string.Concat(BaseLibraryPath, @"\", _statusPath, @"\", _typePath, @"\");
            }
               else if (!string.IsNullOrEmpty(_statusPath) && !string.IsNullOrEmpty(_typePath) && !string.IsNullOrEmpty(_genrePath))
            {
                LibraryPath = string.Concat(BaseLibraryPath, @"\", _statusPath, @"\", _typePath, @"\", _genrePath, @"\");
            }
        }

        public string SongPath { get; set; }
        public bool IsStatusUnprocessedChecked
        {
            get { return _isStatusUnprocessedChecked; }
            set
            {
                _isStatusUnprocessedChecked = value;
                UpdateLibraryPath();
            }
        }
        public bool IsStatusSelectionsChecked
        {
            get { return _isStatusSelectionsChecked; }
            set
            {
                _isStatusSelectionsChecked = value;
                UpdateLibraryPath();
            }
        }
        public bool IsTypeRemixChecked
        {
            get { return _isTypeRemixChecked; }
            set
            {
                _isTypeRemixChecked = value;
                UpdateLibraryPath();
            }
        }
        public bool IsTypeOriginalChecked
        {
            get { return _isTypeOriginalChecked; }
            set
            {
                _isTypeOriginalChecked = value;
                UpdateLibraryPath();
            }
        }
        public bool IsTypePersonalFavouriteChecked
        {
            get { return _isTypePersonalFavouriteChecked; }
            set
            {
                _isTypePersonalFavouriteChecked = value;
                UpdateLibraryPath();
            }
        }
        public bool IsGenreRnbSelected
        {
            get { return _isGenreRnbSelected; }
            set
            {
                _isGenreRnbSelected = value;
                UpdateLibraryPath();
            }
        }
        public bool IsGenrePopSelected
        {
            get { return _isGenrePopSelected; }
            set
            {
                _isGenrePopSelected = value;
                UpdateLibraryPath();
            }
        }
        public bool IsGenreHipHopSelected
        {
            get { return _isGenreHipHopSelected; }
            set
            {
                _isGenreHipHopSelected = value;
                UpdateLibraryPath();
            }
        }
        public bool IsGenreUrbanSelected
        {
            get { return _isGenreUrbanSelected; }
            set
            {
                _isGenreUrbanSelected = value;
                UpdateLibraryPath();
            }
        }
        public bool IsGenreSleeperSelected
        {
            get { return _isGenreSleeperSelected; }
            set
            {
                _isGenreSleeperSelected = value;
                UpdateLibraryPath();
            }
        }
        public bool IsGenreChillSelected
        {
            get { return _isGenreChillSelected; }
            set
            {
                _isGenreChillSelected = value;
                UpdateLibraryPath();
            }
        }
        public bool IsGenreDanceSelected
        {
            get { return _isGenreDanceSelected; }
            set
            {
                _isGenreDanceSelected = value;
                UpdateLibraryPath();
            }
        }
        public bool IsGenreGirlPowerSelected
        {
            get { return _isGenreGirlPowerSelected; }
            set
            {
                _isGenreGirlPowerSelected = value;
                UpdateLibraryPath();
            }
        }
        public bool IsGenreCountrySelected
        {
            get { return _isGenreCountrySelected; }
            set
            {
                _isGenreCountrySelected = value;
                UpdateLibraryPath();
            }
        }
        public bool IsGenreFunkSelected
        {
            get { return _isGenreFunkSelected; }
            set
            {
                _isGenreFunkSelected = value;
                UpdateLibraryPath();
            }
        }
        public bool IsGenreRockSelected
        {
            get { return _isGenreRockSelected; }
            set
            {
                _isGenreRockSelected = value;
                UpdateLibraryPath();
            }
        }
        public bool IsGenreMoombahtonSelected
        {
            get { return _isGenreMoombahtonSelected; }
            set
            {
                _isGenreMoombahtonSelected = value;
                UpdateLibraryPath();
            }
        }
        public string LibraryPath { get; set; }
        public bool IsCopyEnabled { get; set; }
    }
}
