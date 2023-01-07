using Chess_Game.ViewModels;
using System.Windows.Controls;

using System.Windows.Input;

namespace Chess_Game.Views
{
    /// <summary>
    /// Interaction logic for hiddenSandoxView.xaml
    /// </summary>
    public partial class hiddenSandboxView : UserControl
    {
        public hiddenSandboxView()
        {
            InitializeComponent();
            //DataContext = new HiddenSandboxViewModel();
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
