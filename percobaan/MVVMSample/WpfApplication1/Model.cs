using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1
{
    public class Model : INotifyPropertyChanged
    {
        public Model()
        {
            AddCommand = new AddNameCommand(this);
        }

        class AddNameCommand : ICommand
        {
            Model parent;

            public AddNameCommand(Model parent)
            {
                this.parent = parent;
                parent.PropertyChanged += delegate { CanExecuteChanged?.Invoke(this, EventArgs.Empty); };
            }

            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter) { return !string.IsNullOrEmpty(parent.CurrentName); }

            public void Execute(object parameter)
            {
                parent.AddedNames.Add(parent.CurrentName); ;
                parent.CurrentName = null;
            }
        }

        public ICommand AddCommand { get; private set; }

        #region CurrentName

        public string CurrentName
        {
            get { return mCurrentName; }
            set
            {
                if (value == mCurrentName)
                    return;

                mCurrentName = value;
                OnPropertyChanged(nameof(CurrentName));
            }
        }
        string mCurrentName;

        #endregion

        public ObservableCollection<string> AddedNames { get; } = new ObservableCollection<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
