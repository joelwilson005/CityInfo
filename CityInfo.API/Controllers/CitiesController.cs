﻿using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCitities()
        {
            return new JsonResult(
                new List<object>
                {
                    new {id = 1, name = "New York City"},
                    new {id = 2, name = "Paris"}
                }
                );
        }
    }
}
