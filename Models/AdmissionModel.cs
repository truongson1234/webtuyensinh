using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webtuyensinh.Models
{
    [Table("Admission")]
    public class AdmissionModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public LevelOptions EducationLevel { get; set; }
        public TypeOptions TypeOfTraining { get; set; }
        public string Desire { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public enum LevelOptions
    {
        [Display(Name = "Sau đại học")]
        AfterUniversity,
        [Display(Name = "Đại học")]
        University,
        [Display(Name = "Cao đẳng")]
        College,
        [Display(Name = "Trung cấp")]
        Intermediate,
        [Display(Name = "Sơ cấp nghề")] 
        ElementaryOccupations,
        [Display(Name = "Tiếng Đức")]
        German,
        [Display(Name = "Tiếng Hàn")]
        Korean,
        [Display(Name = "Tiếng Nhật")]
        Japanese,
        [Display(Name = "Tiếng Anh")]
        English,
        [Display(Name = "Du học nghề")]
        StudyAbroad,
        [Display(Name = "XKLĐ")]
        LaborExport,
        [Display(Name = "Chuyển đổi bằng")]
        DegreeConversion
    }

    public enum TypeOptions
    {
        [Display(Name = "Liên thông")]
        UniversityTransfer,
        [Display(Name = "Văn bằng 2")]
        SecondDegree,
        [Display(Name = "Chính quy")]
        Formal,
        [Display(Name = "Học từ xa")]
        DistanceLearning,
        [Display(Name = "Du học nghề kép")]
        VocationalAbroad,
        [Display(Name = "Chuyển đổi bằng")]
        DegreeConversion,
        [Display(Name = "Tiếng Hàn")]
        Worker,
    }

}
