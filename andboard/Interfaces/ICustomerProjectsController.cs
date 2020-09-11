using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace andboard.Interfaces
{
    public interface ICustomerProjectsController
    {
        IActionResult FindById(long id);
        IActionResult FindAll();
    }
}
