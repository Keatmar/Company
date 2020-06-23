using SQLite;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Company.Model
{
    [Table("Employee")]
    public class Employee /*: INotifyPropertyChanged*/
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }


        [MaxLength(50), Column("Name")]
        public string Name { get; set; }
        //{
        //    get => Name;
        //    set
        //    {
        //        if (Name == value)
        //            return;
        //        Name = value;
        //        OnPropertyChanged();
        //    }
        //}

        [MaxLength(50), Column("Surname")]
        public string Surname { get; set; }
        //{
        //    get => Surname;
        //    set {
        //        if (Surname == value)
        //            return;
        //        Surname = value;
        //        OnPropertyChanged();
        //    } }

        [MaxLength(13), Column("Phone")]
        public string Phone { get; set; }
        //{
        //    get=>Phone;
        //    set {
        //        if (Phone == value)
        //            return;
        //        Phone = value;
        //        OnPropertyChanged();
        //    } }

        [MaxLength(100), Column("Address")]
        public string Address { get; set; }
        //{
        //    get => Address;
        //    set {
        //        if (Address == value)
        //            return;
        //        Address = value;
        //        OnopertyChanged();
        //    } }

        [MaxLength(50), Column("Specialty")]
        public string Specialty { get; set; }
        //{
        //    get => Specialty;
        //    set {
        //        if (Specialty == value)
        //            return;
        //        Specialty = value;
        //        OnPropertyChanged();
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
