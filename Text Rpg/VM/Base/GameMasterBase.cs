using System.ComponentModel;
using System.Runtime.CompilerServices;
using Text_Rpg.Annotations;

namespace Text_Rpg
{
    public abstract class GameMasterBase<TDomainClass> : INotifyPropertyChanged
        where TDomainClass : Hero

    {
    private HeroVMBase<TDomainClass> _detailsViewModel;

    public GameMasterBase()
    {

    }

    public HeroVMBase<TDomainClass> DetailsViewModel
    {
        get { return _detailsViewModel; }
        set
        {
            _detailsViewModel = value;

            OnPropertyChanged();
        }

    }

    public event PropertyChangedEventHandler PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    }
}