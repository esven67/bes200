using LibraryApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LibraryApi.Controllers
{
    public class OnCallDeveloper : Controller
    {

        ILookupOnCallDevelopers OnCallLookup;

        public OnCallDeveloper(ILookupOnCallDevelopers onCallLookup)
        {
            OnCallLookup = onCallLookup;
        }


        [HttpGet("oncalldeveloper")]
        public async Task<ActionResult> GetOnCallDeveloper()
        {            
            //write the code you wish you had (WTCYWYH)
            OnCallDeveloperResponse response = await OnCallLookup.GetOnCallDeveloper();

            return Ok(response);
        }
    }

    //public class OnCallDeveloper : Controller
    //{
    //    [HttpGet("oncalldeveloper")]
    //    public async Task<ActionResult> GetOnCallDeveloper()
    //    {
    //        var response = new OnCallDeveloperResponse
    //        {
    //            Email = "esvendse@prog.com"
    //        };

    //        return Ok(response);
    //    }
    //}
}