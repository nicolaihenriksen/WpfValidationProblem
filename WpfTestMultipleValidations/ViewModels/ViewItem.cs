using System;
using System.Windows;
using MaterialDesignThemes.Wpf;

namespace Eol.UI.Wpf.ViewModels;

public class ViewItem
{
    public FrameworkElement Content { get; }

    public string Name { get; }
    public PackIconKind? IconKind { get; }

    public ViewItem(string name, FrameworkElement contentType, PackIconKind? iconKind = null)
    {
        Name = name;
        IconKind = iconKind;
        Content = contentType;
    }
}