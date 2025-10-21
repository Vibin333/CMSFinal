using CMSFinalProject.Models;
using System.Data;
using System.Data.SqlClient;

namespace CMSFinalProject.Repositories
{
    public class AdminRepoImpl : IAdminRepo
    {
        private readonly string _connectionString;
        public AdminRepoImpl(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MVCConnectionString");
        }
        public void InsertStaff(User staff)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_AddStaff", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Fullname", staff.Fullname);
                cmd.Parameters.AddWithValue("@Gender", staff.Gender.HasValue ? staff.Gender.ToString() : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@JoiningDate", staff.JoiningDate ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MobileNum", staff.MobileNum ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MailId", staff.MailId);
                cmd.Parameters.AddWithValue("@RoleId", staff.RoleId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Password", staff.Password);
                cmd.Parameters.AddWithValue("@IsActive", staff.IsActive);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public List<User> ListAllStaff()
        {
            var staffList = new List<User>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetAllStaff", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var user = new User
                            {
                                UserId = Convert.ToInt32(reader["UserId"]),
                                Fullname = reader["Fullname"].ToString(),
                                Gender = reader["Gender"] != DBNull.Value ? Convert.ToChar(reader["Gender"]) : (char?)null,
                                JoiningDate = reader["JoiningDate"] != DBNull.Value ? (DateTime?)reader["JoiningDate"] : null,
                                MobileNum = reader["MobileNum"] != DBNull.Value ? Convert.ToInt64(reader["MobileNum"]) : (long?)null,
                                MailId = reader["MailId"].ToString(),
                                //RoleId = reader["RoleName"] != DBNull.Value ? (int?)reader["RoleId"] : null, // Optional, if you want RoleId
                                IsActive = true
                            };
                            staffList.Add(user);
                        }
                    }
                }
            }

            return staffList;
        }
    }
}
