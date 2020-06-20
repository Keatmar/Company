using SQLite;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Company.Model
{
    [Table("Employee")]
    public class Employee : INotifyPropertyChanged
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string _name;

        [MaxLength(50)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value)
                    return;
                OnPropertyChanged();
            }
        }

        public string _surname;
        [MaxLength(50)]
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (_surname == value)
                    return;
                OnPropertyChanged();
            }
        }

        public string _phone;
        [MaxLength(13)]
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (_phone == value)
                    return;
                OnPropertyChanged();
            }
        }

        public string _address;
        [MaxLength(255)]
        public string Address
        {
            get { return _address; }
            set
            {
                if (_address == value)
                    return;
                OnPropertyChanged();
            }
        }

        public string _specialty;
        [MaxLength(50)]
        public string Specialty
        {
            get { return _specialty; }
            set
            {
                if (_specialty == value)
                    return;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
