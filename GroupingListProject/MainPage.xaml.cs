using GroupingListProject.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace GroupingListProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly PlayerViewModel _viewModel;

        public MainPage()
        {
            this.InitializeComponent();
            DataContext = _viewModel = new PlayerViewModel();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _viewModel.Initialize();
        }
    }
}
