using CMSFinalProject.Models;

namespace CMSFinalProject.Services
{
    public interface IAdminService
    {
        void AddStaff(User user);
        List<User> GetAllStaff();
    }
}
