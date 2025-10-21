using CMSFinalProject.Models;

namespace CMSFinalProject.Repositories
{
    public interface IPatientRepo
    {
        void InsertPatient(Patient patient);
        List<Patient> ListAllPatients();
    }
}
