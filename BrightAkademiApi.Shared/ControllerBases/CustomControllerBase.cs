using BrightAkademiApi.Shared.ResponseDTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BrightAkademiApi.Shared.ControllerBases
{
    public class CustomControllerBase : ControllerBase
    {
        public IActionResult CreateActionResult<T>(Response<T> response)
        {
            var jsonResult = JsonSerializer.Serialize(response);
            var result = new ObjectResult(jsonResult)
            {
                StatusCode = response.StatusCode
            };

            return result;
        }
    }
}
