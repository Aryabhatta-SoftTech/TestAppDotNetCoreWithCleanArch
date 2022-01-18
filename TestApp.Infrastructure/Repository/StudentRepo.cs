using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Infrastructure.Repository
{
    public class StudentRepo : IStudentData
    {
        IConfiguration _iconfiguration;
        public StudentRepo(IConfiguration configuration)
        {
            _iconfiguration = configuration;
        }

        public List<string> GetStudentDashboard()
        {
            var getList = new List<string>();
            getList.Add("Raghav");
            getList.Add("Anuradha");
            getList.Add("Shreya");
            return getList;

            var conString = _iconfiguration["ConnectionStrings:sqlReadOnly"];
            using (SqlConnection sCon = new SqlConnection("your connection string read from appseting.json"))
            {
                SqlCommand sqlCommand = new SqlCommand();
                //all our traditional code
            }
        }
    }
}
