using rest_api.Models;
using rest_api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace rest_api.Controllers
{
    public class EmployerController : ApiController
    {
        private EmployerRepository employerRepository;
        public EmployerController()
        {
            this.employerRepository = new EmployerRepository();
        }
        public Employer[] Get()
        {
            return employerRepository.GetAllEmployers();
        }
    }
}
