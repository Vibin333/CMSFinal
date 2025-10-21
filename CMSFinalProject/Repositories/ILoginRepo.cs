using CMSFinalProject.Models;

namespace CMSFinalProject.Repositories
{
    public interface ILoginRepo
    {
        User Login(string username, string password);
    }
}
