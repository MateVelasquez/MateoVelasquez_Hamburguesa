using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateoVelasquez_Hamburguesa.Models
{
    [Table("burger")]
    public class MV_Burger
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250), Unique]
        public string MV_Name { get; set; }
        public string MV_Description { get; set; }
        public bool MV_WithExtraCheese { get; set; }
    }
}
