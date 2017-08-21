using System.ComponentModel;
using System.Runtime.CompilerServices;
using Text_Rpg.Annotations;

namespace Text_Rpg
{
    public abstract class HeroVMBase<TDomainClass> : INotifyPropertyChanged
        where TDomainClass : Hero
    {

    public TDomainClass DomainObject;

    protected HeroVMBase(TDomainClass obj)
    {
        DomainObject = obj;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    }


}