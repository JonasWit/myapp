using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;

namespace DotnetService.Components;

public partial class NavBar : UserControl
{
    public static readonly StyledProperty<int> SelectedIndexProperty =
        AvaloniaProperty.Register<NavBar, int>(nameof(SelectedIndex));

    public NavBar()
    {
        InitializeComponent();
        Loaded += NavBar_Loaded;
    }

    public int SelectedIndex
    {
        get => GetValue(SelectedIndexProperty);
        set => SetValue(SelectedIndexProperty, value);
    }

    private void NavBar_Loaded(object? sender, RoutedEventArgs e)
    {
        var homeBtn = (ToggleButton)navList.Children[0];
        var pointerPos = homeBtn.Bounds.Left + homeBtn.Bounds.Width / 2 - 3;
        navPointer.Margin = new Thickness(pointerPos, 0, 0, 0);
    }

    private void ToggleButton_Checked(object? sender, RoutedEventArgs e)
    {
        foreach (ToggleButton btn in navList.Children)
            if (btn == sender)
            {
                SelectedIndex = navList.Children.IndexOf(btn);
            }
            else
            {
                btn.IsEnabled = true;
                btn.IsChecked = false;
            }

        var checkedBtn = (ToggleButton)sender;

        var pointerPos = checkedBtn.Bounds.Left + checkedBtn.Bounds.Width / 2 - 3;
        navPointer.Margin = new Thickness(pointerPos, 0, 0, 0);
    }
}