using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApiForCountries.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly countryContext _countryContext;

        public CountriesController(countryContext countryContextvar)
        {
            _countryContext = countryContextvar;
        }
            [HttpGet("getcountries")]

            public IActionResult Get()
            {
                  var countries_list = _countryContext.countries.ToList();
                  if(countries_list.Count == 0)
                        return NotFound();
                  return Ok(countries_list);
            //    var countries_list = new List<Countries>
            //{
            //    new Countries
            //    {
            //        Short_form_name = "Afghanistan",
            //        Long_form_name = "Islamic Republic of Afghanistan",
            //        GENC2A_code="AF",
            //        GENC3A_code= "AFG",
            //        Capital= "Kabul",
            //        Continent= "Asia"
            //    }
            //};
                return Ok(countries_list);
            }


        [HttpPost("entercountry")]

        public IActionResult Create([FromBody] UserRequest request)
        {
            Countries country = new Countries();
            country.Short_form_name = request.Short_form_name;
            country.Long_form_name = request.Long_form_name;
            country.GENC2A_code = request.GENC2A_code;
            country.GENC3A_code = request.GENC3A_code;
            country.Capital = request.Capital;
            country.Continent = request.Continent;

            try
            {
                _countryContext.countries.Add(country);
                _countryContext.SaveChanges();

            }
            catch(Exception ex)
            {
                return StatusCode(500, "An error has occured");
            }
            
            return Ok();

        }
    }
         
}


