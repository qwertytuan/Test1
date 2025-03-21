using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test1.Models
{
    [Table("tblClassRoom")]
    public class tblClassRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("tblStudents")]
        public int StudentId { get; set; }
        public tblStudents Student { get; set; }

        [ForeignKey("tblTeachers")]
        public int TeacherId { get; set; }
        public tblTeachers Teacher { get; set; }

        [ForeignKey("tblClasses")]
        public int ClassId { get; set; }
        public tblClasses Classes { get; set; }
    }
}

