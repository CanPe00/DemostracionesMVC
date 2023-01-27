using OperaWebSite.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OperaWebSite.Models
{
    [Table("Opera")]
    public class Opera
    {
        [Key]
        public int OperaId { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]//view/wf
        //[Display(Name ="Title")]
        [Column(TypeName ="varchar(50)")]
        [StringLength(50)]//view
        public string Title { get; set;}

        [Required(ErrorMessage = "Campo obligatorio")]//view/wf
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]//view
        public string Composer { get; set;}

        [CheckValidYear]
        public int Year { get; set;}
    }
}
