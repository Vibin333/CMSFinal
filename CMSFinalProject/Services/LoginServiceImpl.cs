using CMSFinalProject.Models;
using CMSFinalProject.Repositories;

namespace CMSFinalProject.Services
{
    public class LoginServiceImpl : ILoginService
    {
        private readonly ILoginRepo _loginRepo;
        public LoginServiceImpl(ILoginRepo loginRepo)
        {
            _loginRepo = loginRepo;
        }
        public User Login(string username, string password)
        {
            return _loginRepo.Login(username, password);
        }
    }
}
