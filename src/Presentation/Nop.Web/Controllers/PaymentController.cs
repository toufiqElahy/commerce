using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;

namespace Nop.Web.Controllers
{
    public class PaymentController : Controller
    {
        public async Task<IActionResult> Index( [FromServices] INodeServices nodeServices)
        {
            try
            {
                string s = "FE344FEAEA4D8E5169A6D8F25C86681773B8CF69BB920BCC7DF44892F129091C";
                var result = await nodeServices.InvokeAsync<dynamic>("wwwroot/Scripts/test.js", s);
                ViewBag.result = result.data;
                //return Content(result);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
            return View();
        }
    }
}