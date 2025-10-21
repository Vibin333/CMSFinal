using CMSFinalProject.Models;
using System.Data.SqlClient;

namespace CMSFinalProject.Repositories
{
    public class PatientRepoImpl : IPatientRepo
    {
        private readonly string _connectionString;
        public PatientRepoImpl(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MVCConnectionString");
        }
        public void InsertPatient(Patient patient)
        {
            // Implementation for inserting a patient into the database
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_AddPatient", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PatientName", patient.PatientName);
                cmd.Parameters.AddWithValue("@DOB", patient.DOB);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@Address", patient.Address);
                cmd.Parameters.AddWithValue("@MobileNum", patient.MobileNum);
                cmd.Parameters.AddWithValue("@BloodGroup", patient.BloodGroup);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public List<Patient> ListAllPatients()
        {
            List<Patient> patients = new List<Patient>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetAllPatients", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient
                    {
                        //MMRNo = Convert.ToInt32(reader["PatientId"]),
                        PatientName = reader["PatientName"].ToString(),
                        //JoiningDate = reader["JoiningDate"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["JoiningDate"];
                        DOB = reader["DOB"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["DOB"]),
                        Gender = reader["Gender"] == DBNull.Value
                         ? '\0'
                         : Convert.ToChar(reader["Gender"].ToString().Trim()),
                        Address = reader["Address"].ToString(),
                        MobileNum = Convert.ToInt64(reader["MobileNum"]),
                        BloodGroup = reader["BloodGroup"].ToString()
                        };
                    patients.Add(patient);
                }
                con.Close();
            }
            return patients;
        }
        }
    }