using System;
using System.Windows;
using MaterialDesignThemes.Wpf;

namespace Eol.UI.Wpf.ViewModels;

public class ViewItem
{
    public object Content { get; }

    public string Name { get; }
    public PackIconKind? IconKind { get; }

    public ViewItem(string name, object contentType, PackIconKind? iconKind = null)
    {
        Name = name;
        IconKind = iconKind;
        Content = contentType;
    }
}