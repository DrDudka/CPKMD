using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPKMD.Models
{
    [Table("training_forms")]
    public class TrainingForm
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("name")]
        [Required]
        [StringLength(100)]
        public  string Name { get; set; }
        public List<EducationalProgram> EducationalPrograms { get; set; } = [];
    }

    [Table("program_names")]
    public class ProgramName
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("name")]
        [Required]
        [StringLength(200)]
        public  string Name { get; set; }
        public List<EducationalProgram> EducationalPrograms { get; set; } = [];
    }

    [Table("educational_programs")]
    public class EducationalProgram
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("program_number")]
        [Required]
        public int ProgramNumber { get; set; }
        [Column("program_name_id")]
        [Required]
        public int ProgramNameId { get; set; }
        public  ProgramName ProgramName { get; set; }
        [Column("training_form_id")]
        [Required]
        public int TrainingFormId { get; set; }
        public  TrainingForm TrainingForm { get; set; }
        [Column("hours")]
        [Required]
        public int Hours { get; set; }
        [Column("cost")]
        [Required]
        public int Cost { get; set; }
    }

    [Table("users")]
    public class User
    {
        [Column("user_id")]
        [Key]
        public int Id { get; set; }
        [Column("login")]
        [Required]
        [StringLength(50)]
        public string Login { get; set; }
        [Column("password")]
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
    }
}
