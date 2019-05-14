using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meters.Data;

namespace Meters.API.Controllers
{
    [Route("api/meter")]
    public class MeterController : Controller
    {
        private IMetersRepository _repository;

        public MeterController(IMetersRepository repository)
        {
            _repository = repository;
        }

        [HttpGet()]
        public IActionResult GetMeters()
        {
            // an empty list of meters is a valid response: there are no meters yet,
            // so user should be redirected to add meter page
            var meters = _repository.GetMeters();

            // should return view models instead of entities
            return Ok(meters);
        }
    }
}
