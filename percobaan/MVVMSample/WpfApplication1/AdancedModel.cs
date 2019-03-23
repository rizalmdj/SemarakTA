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
    public class Person : INotifyPropertyChanged
    {
        #region FirstName

        public string FirstName
        {
            get { return mFirstName; }
            set
            {
                if (value == mFirstName)
                    return;

                mFirstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }
        string mFirstName;

        #endregion

        #region LastName

        public string LastName
        {
            get { return mLastName; }
            set
            {
                if (value == mLastName)
                    return;

                mLastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }
        string mLastName;

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class AdvancedModel : INotifyPropertyChanged
    {
        public AdvancedModel()
        {
            AddCommand = new AddPersonCommand(this);
            CurrentPerson = new Person();
        }

        public class AddPersonCommand : ICommand
        {
            AdvancedModel parent;

            public AddPersonCommand(AdvancedModel parent)
            {
                this.parent = parent;
                parent.PropertyChanged += delegate { CanExecuteChanged?.Invoke(this, EventArgs.Empty); };
            }

            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return CurrentPerson != null
                    && !string.IsNullOrWhiteSpace(CurrentPerson.FirstName)
                    && !string.IsNullOrWhiteSpace(CurrentPerson.LastName)
                    ;
            }

            public void Execute(object parameter)
            {
                parent.AddedPersons.Add(parent.CurrentPerson);
                parent.CurrentPerson = new Person();
            }

            #region CurrentPerson

            public Person CurrentPerson
            {
                get { return mCurrentPerson; }
                set
                {
                    if (value == mCurrentPerson)
                        return;

                    PropertyChangedEventHandler handler = delegate { CanExecuteChanged?.Invoke(this, EventArgs.Empty); };
                    if (CurrentPerson != null)
                        CurrentPerson.PropertyChanged -= handler;
                    mCurrentPerson = value;
                    if (CurrentPerson != null)
                        CurrentPerson.PropertyChanged += handler;
                    handler(null, null);
                }
            }
            Person mCurrentPerson;

            #endregion
        }

        public AddPersonCommand AddCommand { get; private set; }

        #region CurrentPerson

        public Person CurrentPerson
        {
            get { return mCurrentPerson; }
            set
            {
                if (value == mCurrentPerson)
                    return;

                mCurrentPerson = value;
                OnPropertyChanged(nameof(CurrentPerson));
                AddCommand.CurrentPerson = value;
            }
        }
        Person mCurrentPerson = new Person();

        #endregion

        public ObservableCollection<Person> AddedPersons { get; } = new ObservableCollection<Person>();

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
