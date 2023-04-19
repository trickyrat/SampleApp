using CommunityToolkit.Mvvm.ComponentModel;

namespace SampleApp.ViewModel;

public partial class MainViewModel : ObservableObject
{
    //[ObservableProperty]
    private string _fullName;

    public string FullName
    {
        get { return _fullName; }
        set
        {
            _fullName = value;
            OnPropertyChanged();
        }
    }

    private string _favoriteFlower;

    public string FavoriteFlower
    {
        get { return _favoriteFlower; }
        set
        {
            _favoriteFlower = value;
            OnPropertyChanged();
        }
    }
}
