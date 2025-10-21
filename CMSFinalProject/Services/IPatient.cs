using CMSFinalProject.Models;

namespace CMSFinalProject.Services
{
    public interface IPatient
    {
        void AddPatient(Patient patient);
        List<Patient> GetAllPatients();
    }
}
