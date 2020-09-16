using andboard.Core.Entities;
using andboard.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace andboard.Controllers
{
    [Route("api/featureitems")]
    [ApiController]
    public class FeatureItemsController : ControllerBase
    {
        private IRepositoryCreateConductor<FeatureItem> _repositoryCreateConductor;
        private IRepositoryReadConductor<FeatureItem> _repositoryReadConductor;

        public FeatureItemsController(IRepositoryReadConductor<FeatureItem> repositoryReadConductor, IRepositoryCreateConductor<FeatureItem> repositoryCreateConductor)
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
        public IActionResult Create(FeatureItem featureItem)
        {
            var result = _repositoryCreateConductor.Create(featureItem);
            return Ok(result);
        }
    }
}
