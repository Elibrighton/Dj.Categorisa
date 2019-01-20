using System;
using System.Collections.Generic;
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

        public CategorisaModel()
        {
            IsStatusUnprocessedChecked = true;
            IsTypeRemixChecked = true;
            LibraryPath = BaseLibraryPath;
            _statusPath = string.Empty;
            _typePath = string.Empty;
            _genrePath = string.Empty;
            UpdateLibraryPath();
        }

        internal void UpdateGenrePath()
        {
            if(IsGenreRnbSelected)
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
        }

        internal void UpdateStatusPath()
        {
            _statusPath = IsStatusUnprocessedChecked ? "Unprocessed" : "Processed";
        }

        internal void UpdateTypePath()
        {
            _typePath = IsTypeRemixChecked ? "Remix" : "Original";
        }

        public void UpdateLibraryPath()
        {
            UpdateStatusPath();
            UpdateTypePath();
            UpdateGenrePath();

            if (!string.IsNullOrEmpty(_statusPath) && !string.IsNullOrEmpty(_typePath) && !string.IsNullOrEmpty(_genrePath))
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
        public bool IsPersonalFavouriteChecked { get; set; }
        public string LibraryPath { get; set; }
    }
}
