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
    [Route("api/andboards/projects")]
    [ApiController]
    public class CustomerProjectsController : Controller, ICustomerProjectsController
    {
        private IRepositoryReadConductor<CustomerProject> _repositoryReadConductor;
        private IRepositoryCreateConductor<CustomerProject> _repositoryCreateConductor;
        private IRepositoryUpdateConductor<CustomerProject> _repositoryUpdateConductor;

        public CustomerProjectsController(
            IRepositoryReadConductor<CustomerProject> repositoryReadConductor,
            IRepositoryCreateConductor<CustomerProject> repositoryCreateConductor,
            IRepositoryUpdateConductor<CustomerProject> repositoryUpdateConductor)
        {
            _repositoryReadConductor = repositoryReadConductor;
            _repositoryCreateConductor = repositoryCreateConductor;
            _repositoryUpdateConductor = repositoryUpdateConductor;
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
            var result = _repositoryCreateConductor.Create(customerProject);
            return Ok(result);
        }

        [HttpPatch]
        public IActionResult Update(CustomerProject customerProject)
        {
            throw new NotImplementedException();
        }

    }
}
