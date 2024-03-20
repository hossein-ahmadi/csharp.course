using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Demo119___WPFTemplates
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ((Window)((Border)sender).TemplatedParent).DragMove();
        }
    }

}
