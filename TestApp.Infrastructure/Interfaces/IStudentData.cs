using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Infrastructure.Repository
{
    public interface IStudentData
    {
        public List<string> GetStudentDashboard();

    }
}
