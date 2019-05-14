using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meters.Data;

namespace Meters.API.Controllers
{
    [Route("api/index")]
    public class IndexController : Controller
    {
        private IMetersRepository _repository;

        public IndexController(IMetersRepository repository)
        {
            _repository = repository;
        }
    }
}
