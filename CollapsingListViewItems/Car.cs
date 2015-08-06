namespace CollapsingListViewItemContainers
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Simple model that implements INPC to raise property changed 
    /// on IsVisible
    /// </summary>
    public class Car : INotifyPropertyChanged
    {
        private bool _isVisible;

        public Car(string name, string title, int id)
        {
            Name = name;
            Title = title;
            Id = id;
            IsVisible = true;
        }

        public string Name
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }

        public int Id
        {
            get; set;
        }

        public bool IsVisible
        {
            get
            {
                return _isVisible;
            }
            set
            {
                _isVisible = value;
                NotifyPropertyChanged("IsVisible");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
