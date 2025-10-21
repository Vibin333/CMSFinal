using CMSFinalProject.Models;
using CMSFinalProject.Repositories;

namespace CMSFinalProject.Services
{
    public class AdminServiceImpl : IAdminService
    {
        private readonly IAdminRepo _adminRepo;
        public AdminServiceImpl(IAdminRepo adminRepo)
        {
            _adminRepo = adminRepo;
        }
        public void AddStaff(User user)
        {
            _adminRepo.InsertStaff(user);
        }

        public List<User> GetAllStaff()
        {
            return _adminRepo.ListAllStaff();
        }
    }
}
