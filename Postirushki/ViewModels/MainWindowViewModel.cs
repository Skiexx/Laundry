using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;
using Postirushki.Views;

namespace Postirushki.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        public object? Password { get; set; }

        public object? Login { get; set; }

        public void OnClickCommand()
        {
            string login = "admin", password = "123";
            if ((string)Login! == login && (string)Password! == password)
                Console.WriteLine( Login + " " + Password);
        }
    }
}