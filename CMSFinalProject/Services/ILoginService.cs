using CMSFinalProject.Models;
using CMSFinalProject.ViewModels;

namespace CMSFinalProject.Services
{
    public interface ILoginService
    {
        User Login(string username, string password);
    }
}
