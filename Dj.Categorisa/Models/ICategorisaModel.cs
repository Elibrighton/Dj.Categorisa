namespace Dj.Categorisa.Models
{
    public interface ICategorisaModel
    {
        string SongPath { get; set; }
        bool IsStatusUnprocessedChecked { get; set; }
        bool IsStatusSelectionsChecked { get; set; }
        bool IsTypeRemixChecked { get; set; }
        bool IsTypeOriginalChecked { get; set; }
        bool IsTypePersonalFavouriteChecked { get; set; }
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
        bool IsGenreRockSelected { get; set; }
        bool IsGenreMoombahtonSelected { get; set; }
        string LibraryPath { get; set; }
        void UpdateLibraryPath();
        bool Copy();
        void Reset();
        bool IsCopyEnabled { get; set; }
    }
}