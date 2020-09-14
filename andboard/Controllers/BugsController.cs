using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using andboard.Conductors;
using andboard.Entities;
using andboard.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace andboard.Controllers
{
    [Route("api/bugs")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        private IRepositoryCreateConductor<Bug> _repositoryCreateConductor;
        private IRepositoryReadConductor<Bug> _repositoryReadConductor;

        public BugsController(IRepositoryReadConductor<Bug> repositoryReadConductor, IRepositoryCreateConductor<Bug> repositoryCreateConductor)
        {
            _repositoryCreateConductor = repositoryCreateConductor;
            _repositoryReadConductor = repositoryReadConductor;
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            var result = _repositoryReadConductor.FindAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult FindById(long id)
        {
            var result = _repositoryReadConductor.FindById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(Bug bug)
        {
            var result = _repositoryCreateConductor.Create(bug);
            return Ok(result);
        }
    }
}
