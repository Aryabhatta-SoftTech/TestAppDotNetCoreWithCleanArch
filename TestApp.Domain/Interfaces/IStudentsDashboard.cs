using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Core.Models;

namespace TestApp.Domain.Students
{
    public interface IStudentsDashboard
    {
        public List<StudentDashboardModel> GetStudentData();
    }
}
