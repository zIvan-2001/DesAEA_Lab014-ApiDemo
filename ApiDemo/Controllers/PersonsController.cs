using ApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiDemo.Controllers
{
    public class PersonsController : ApiController
    {
        public List<PersonResponse> Get()
        {
            var result = new List<PersonResponse>();
            result.Add(new PersonResponse { FirstName = "Ivan", LastName = "Antonio" });
            result.Add(new PersonResponse { FirstName = "Anthony", LastName = "Quito" });
            result.Add(new PersonResponse { FirstName = "Elsin", LastName = "Vila" });
            return result;
        }

        public PersonResponse Insert(PersonRequest request)
        {
            var result = new PersonResponse();

            result.FirstName = request.FirstName;
            result.LastName = request.LastName;

            return result;

        }

    }
}