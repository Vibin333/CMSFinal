using CMSFinalProject.Models;

namespace CMSFinalProject.Repositories
{
    public interface IAdminRepo
    {
        void InsertStaff(User user);
        List<User> ListAllStaff();
    }
}
