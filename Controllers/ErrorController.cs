using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Telefon_Rehberi.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry page not found";
                    break;
            }
            return View("NotFound");
        }

        [Route("Error")]
        [AllowAnonymous]
        public IActionResult Error()
        {
            var exDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            ViewBag.expath = exDetails.Path;
            ViewBag.msg = exDetails.Error.Message;
            ViewBag.Trace = exDetails.Error.StackTrace;

            return View("Error");
        }

    }
}