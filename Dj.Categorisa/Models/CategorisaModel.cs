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
        private bool _isStatusProcessedChecked;
        private bool _isTypeRemixChecked;
        private bool _isTypeOriginalChecked;
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
        private ISongHandler _songHandler;

        public CategorisaModel(ISongHandler songHandler)
        {
            _songHandler = songHandler;
            IsStatusUnprocessedChecked = true;
            IsTypeRemixChecked = true;
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
        }

        internal void UpdateStatusPath()
        {
            _statusPath = IsStatusUnprocessedChecked ? "Unprocessed" : "Processed";

            if (IsPersonalFavouriteChecked)
            {
                _statusPath += string.Concat(@"\", "Personal favourite");
            }
        }

        internal void UpdateTypePath()
        {
            _typePath = IsTypeRemixChecked ? "Remix" : "Original";
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

            if (IsPersonalFavouriteChecked && !string.IsNullOrEmpty(_statusPath))
            {
                LibraryPath = string.Concat(BaseLibraryPath, @"\", _statusPath, @"\");
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
        public bool IsStatusProcessedChecked
        {
            get { return _isStatusProcessedChecked; }
            set
            {
                _isStatusProcessedChecked = value;
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
        public bool IsPersonalFavouriteChecked { get; set; }
        public string LibraryPath { get; set; }
    }
}
