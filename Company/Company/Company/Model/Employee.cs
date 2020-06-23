using SQLite;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Company.Model
{
    [Table("Employee")]
    public class Employee
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }


        [MaxLength(50), Column("Name")]
        public string Name { get; set; }

        [MaxLength(50), Column("Surname")]
        public string Surname { get; set; }

        [MaxLength(13), Column("Phone")]
        public string Phone { get; set; }

        [MaxLength(100), Column("Address")]
        public string Address { get; set; }

        [MaxLength(50), Column("Specialty")]
        public string Specialty { get; set; }
    }
}
