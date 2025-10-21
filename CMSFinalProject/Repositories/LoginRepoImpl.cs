using CMSFinalProject.Models;
using System.Data.SqlClient;

namespace CMSFinalProject.Repositories
{
    public class LoginRepoImpl : ILoginRepo
    {
        private readonly string _connectionString;
        public LoginRepoImpl(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MVCConnectionString");
        }

        public User Login(string username, string password)
        {
            User user = null;

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_LoginUser", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                UserId = Convert.ToInt32(reader["UserId"]),
                                Password = reader["Password"].ToString(),
                                Fullname = reader["Fullname"].ToString(),
                                Gender = reader["Gender"] == DBNull.Value ? (char?)null : Convert.ToChar(reader["Gender"]),
                                JoiningDate = reader["JoiningDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["JoiningDate"]),
                                MobileNum = reader["MobileNum"] == DBNull.Value ? 0 : Convert.ToInt64(reader["MobileNum"]),
                                RoleId = Convert.ToInt32(reader["RoleId"]),
                                IsActive = Convert.ToBoolean(reader["IsActive"]),
                                MailId = reader["MailId"].ToString()
                            };

                        }
                    }
                }
            }

            return user;
        }
    }
}
