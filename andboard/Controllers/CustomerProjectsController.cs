using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using andboard.Entities;
using andboard.Interfaces;
using andboard.Models;
using Microsoft.AspNetCore.Mvc;

namespace andboard.Controllers
{
    [Route("api/andboards")]
    [ApiController]
    public class CustomerProjectsController : Controller, ICustomerProjectsController
    {
        private IRepositoryReadConductor<CustomerProject> _repositoryReadConductor;

        public CustomerProjectsController(IRepositoryReadConductor<CustomerProject> repositoryReadConductor)
        {
            _repositoryReadConductor = repositoryReadConductor;
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            var allUsers = _repositoryReadConductor.FindAll();

            return Ok(allUsers);
        }

        [HttpGet("{id}")]
        public IActionResult FindById(long id)
        {
            var result = _repositoryReadConductor.FindById(id);

            return Ok(result);
        }

    }
}
