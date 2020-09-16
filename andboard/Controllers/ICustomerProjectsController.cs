using andboard.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace andboard.Presentation.Controllers
{
    public interface ICustomerProjectsController
    {
        IActionResult FindById(long id);
        IActionResult FindAll();
        IActionResult Update(CustomerProject obj);
        IActionResult Create(CustomerProject obj);
    }
}
