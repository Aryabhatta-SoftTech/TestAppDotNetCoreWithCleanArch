using System;
using System.Collections.Generic;
using TestApp.Core;
using TestApp.Core.Models;
using TestApp.Infrastructure.Repository;

namespace TestApp.Domain.Students
{
    public class StudentDashboard : IStudentsDashboard
    {
        IStudentData _iStudentsDashboard;
        public StudentDashboard(IStudentData iStudentsDashboard)
        {
            _iStudentsDashboard = iStudentsDashboard;
        }

        public List<StudentDashboardModel> GetStudentData()
        {
            //here you can reference Infra-Repo and get data from database
            var studentData =  _iStudentsDashboard.GetStudentDashboard();
            List<StudentDashboardModel> studentDashboardData = new List<StudentDashboardModel>();

            foreach (var item in studentData)
            {
                studentDashboardData.Add(new StudentDashboardModel() {Name=item,Status=StudentTypeEnum.Active.ToString() });
            }

            return studentDashboardData;

            //studentData[0] = string.Format(studentData[0]+"-{0}" ,StudentTypeEnum.Active);
            //studentData[1] = string.Format(studentData[1]+"-{0}" ,StudentTypeEnum.Deleted);
            //studentData[2] = string.Format(studentData[2]+"-{0}" ,StudentTypeEnum.Inactive);
            //return studentData;
        }
    }
}
