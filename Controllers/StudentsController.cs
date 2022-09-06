using System;
using System.Collections.Generic;
using ABC.Core.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ABC.Core.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "Students.Read.All")]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Hassan Habib"
                },

                new Student
                {

                    Id = Guid.NewGuid(),
                    Name = "Andrew Mcleland"
                },

                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Michael Mendelsohn"
                },
            };
        }
    }
}
