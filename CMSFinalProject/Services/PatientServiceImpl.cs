using CMSFinalProject.Models;
using CMSFinalProject.Repositories;

namespace CMSFinalProject.Services
{
    public class PatientServiceImpl : IPatient
    {
        private readonly IPatientRepo _patientRepo;

        public PatientServiceImpl(IPatientRepo patientRepo)
        {
            _patientRepo = patientRepo;
        }

        public void AddPatient(Patient patient)
        {
            _patientRepo.InsertPatient(patient);
        }

        public List<Patient> GetAllPatients()
        {
            return _patientRepo.ListAllPatients();
        }
    }
}
