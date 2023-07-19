using webtuyensinh.Models;

namespace webtuyensinh.ViewModels
{
    public class AdmissionViewModel
    {
        public AdmissionModel Admission { get; set; }
        public IEnumerable<AdmissionModel> Admissions { get; set; }
    }
}
