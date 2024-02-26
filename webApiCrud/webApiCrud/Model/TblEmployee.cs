using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace webApiCrud.Model
{
    public class TblEmployee
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public String LastName { get; set; }
        [StringLength(250)]
        public string Email { get; set; }
        public int Age { get; set; }

        public DateTime Doj { get; set; }
        [StringLength(20)]
        public String Gender { get; set; }
        public int IsMarried { get; set; }
        public int IsActive { get; set; }
        public int DesignationId { get; set; }
        [NotMapped]
        public string Designation {  get; set; }
    }
}
