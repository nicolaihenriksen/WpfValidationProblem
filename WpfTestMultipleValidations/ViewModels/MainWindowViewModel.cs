using System;
using System.Collections.ObjectModel;
using Eol.UI.Wpf.ViewModels;
using MaterialDesignThemes.Wpf;
using WpfTestMultipleValidations.Views;

namespace WpfTestMultipleValidations.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<ViewItem> MenuItems { get; set; }
    private ViewItem? _selectedView;
    private int _selectedIndex;

    public MainWindowViewModel()
    {
        MenuItems = new ObservableCollection<ViewItem>(new[]
        {
            new ViewItem("Child 1", new ChildView1(), PackIconKind.TestTube),
            new ViewItem("texts", new TextBoxesView("from navigation pane"), PackIconKind.Cogs),
        });
    }

    public ViewItem? SelectedView
    {
        get => _selectedView;
        set => SetProperty(ref _selectedView, value);
    }

    public int SelectedIndex
    {
        get => _selectedIndex;
        set => SetProperty(ref _selectedIndex, value);
    }
}