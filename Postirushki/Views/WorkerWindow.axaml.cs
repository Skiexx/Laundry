using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Postirushki.Views;

public partial class WorkerWindow : Window
{
    public WorkerWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}