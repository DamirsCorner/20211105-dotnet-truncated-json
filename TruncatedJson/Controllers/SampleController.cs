using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TruncatedJson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return this.GetStrings();
        }

        [HttpGet]
        [Route("materialized")]
        public IEnumerable<string> GetMaterialized()
        {
            return this.GetStrings().ToList();
        }

        private IEnumerable<string> GetStrings()
        {
            foreach (var i in Enumerable.Range(1, 1500))
            {
                yield return $"Item {i}";
            }

            throw new Exception();
        }
    }
}
