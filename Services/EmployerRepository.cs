using rest_api.Helper;
using rest_api.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace rest_api.Services
{
    public class EmployerRepository
    {
        public Employer[] GetAllEmployers()
        {
            var employers = DAL.Select("select * from pastemployer");
            var emps = new List<Employer>();
            foreach (DataRow row in employers.Rows)
            {
                try
                {
                    emps.Add(new Employer
                    {
                        id = new Guid(row["id"].ToString()),
                        company = row["company"].ToString(),
                        startDate = DateTime.Parse(row["startDate"].ToString()),
                        endDate = DateTime.Parse(row["endDate"].ToString())
                    });
                }
                catch
                {
                }
            }
            return emps.ToArray();
        }
    }
}