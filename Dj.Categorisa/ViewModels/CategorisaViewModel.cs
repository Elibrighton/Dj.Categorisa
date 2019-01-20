using Dj.Categorisa.Base;
using Dj.Categorisa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dj.Categorisa.ViewModels
{
    public class CategorisaViewModel : ObservableObject, ICategorisaViewModel
    {
        private ICategorisaModel _categorisaModel;

        public CategorisaViewModel(ICategorisaModel categorisaModel)
        {
            _categorisaModel = categorisaModel;
        }

        public string SongPathTextBox
        {
            get { return _categorisaModel.SongPath; }
            set
            {
                _categorisaModel.SongPath = value;
                NotifyPropertyChanged("SongPathTextBox");
            }
        }
    }
}
