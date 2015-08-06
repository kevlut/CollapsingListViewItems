namespace CollapsingListViewItemContainers
{
    using System.Collections.ObjectModel;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Set up collection of test data.
        /// </summary>
        private ObservableCollection<Car> _cars = new ObservableCollection<Car>
                        {
                            new Car("Not yours", "Mine", 1),
                            new Car("Not mine", "Yours", 2),
                            new Car("Not ours", "His", 3),
                            new Car("Not ours", "Hers", 4),
                        };

        /// <summary>
        /// Create view and set up binding (Cars)
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        /// <summary>
        /// Collection of Cars (bound to view)
        /// </summary>
        public ObservableCollection<Car> Cars
        {
            get
            {
                return _cars;
            }
        }

        /// <summary>
        /// Quick visibility toggle switch for the Car in index 2.
        /// </summary>
        /// <param name="sender">Button raising event</param>
        /// <param name="e">Button click arguments</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cars[2].IsVisible = !Cars[2].IsVisible;
            DisButt.Content = Cars[2].IsVisible ? "Hide Car 3!" : "Show Car 3!";
        }
    }
}
