using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HighlightSample;

public class ViewModel : INotifyPropertyChanged
{
    private string? filter;
    private string? fullText;

    public string? Filter
    {
        get => filter;
        set => SetProperty(ref filter, value);
    }

    public string? FullText
    {
        get => fullText;
        set => SetProperty(ref fullText, value);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(storage, value))
        {
            return false;
        }

        storage = value;
        OnPropertyChanged(propertyName!);
        return true;
    }
}
