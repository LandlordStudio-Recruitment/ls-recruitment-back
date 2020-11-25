using LandlordStudio.Recruitment.Core.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LandlordStudio.Recruitment.Backend.Controllers
{
    public class BaseController: ControllerBase { 
        public IActionResult HandleException(Exception exception)
        {
            // TODO: Logging

            if (!(exception is BaseException))
            {
                return StatusCode(500);
            }

            var baseException = (BaseException)exception;

            switch (baseException.StatusCode)
            {
                case Core.Enums.StatusCode.BadRequest:
                    return BadRequest(exception.Message);
                case Core.Enums.StatusCode.NotFound:
                    return NotFound(exception.Message);
                case Core.Enums.StatusCode.ImATeapot:
                    return BadRequest("No coffee here");
                // TODO: Handle more exceptions
                default:
                    return StatusCode(500);
            }

        }
    }
}
