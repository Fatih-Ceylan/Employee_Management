using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            this.logger = logger;
        }

        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry page not found";
                    logger.LogWarning($"404 Error Occured. Path={statusCodeResult.OriginalPath} and QueryString ={statusCodeResult.OriginalQueryString}");
                    break;
                case 405:
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

            logger.LogError($"The path{exDetails.Path} threw and exception{exDetails.Error}");
            //ViewBag.expath = exDetails.Path;
            //ViewBag.msg = exDetails.Error.Message;
            //ViewBag.Trace = exDetails.Error.StackTrace;

            return View("Error");
        }

    }
}