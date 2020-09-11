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
        private IRepositoryCreateConductor<CustomerProject> _repositoryCreateConductor;

        public CustomerProjectsController(
            IRepositoryReadConductor<CustomerProject> repositoryReadConductor,
            IRepositoryCreateConductor<CustomerProject> repositoryCreateConductor)
        {
            _repositoryReadConductor = repositoryReadConductor;
            _repositoryCreateConductor = repositoryCreateConductor;
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

        [HttpPost]
        public IActionResult Create(CustomerProject customerProject)
        {
            var result = _repositoryCreateConductor.Create(customerProject as CustomerProject);
            return Ok(result);
        }

    }
}
