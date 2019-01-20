namespace Dj.Categorisa.Models
{
    public interface ICategorisaModel
    {
        string SongPath { get; set; }
        bool IsStatusUnprocessedChecked { get; set; }
        bool IsStatusProcessedChecked { get; set; }
        bool IsTypeRemixChecked { get; set; }
        bool IsTypeOriginalChecked { get; set; }
        bool IsGenreRnbSelected { get; set; }
        bool IsGenrePopSelected { get; set; }
        bool IsGenreHipHopSelected { get; set; }
        bool IsGenreUrbanSelected { get; set; }
        bool IsGenreSleeperSelected { get; set; }
        bool IsGenreChillSelected { get; set; }
        bool IsGenreDanceSelected { get; set; }
        bool IsGenreGirlPowerSelected { get; set; }
        bool IsGenreCountrySelected { get; set; }
        bool IsGenreFunkSelected { get; set; }
        bool IsPersonalFavouriteChecked { get; set; }
        string LibraryPath { get; set; }
        void UpdateLibraryPath();
        bool Copy();
        void Reset();
    }
}