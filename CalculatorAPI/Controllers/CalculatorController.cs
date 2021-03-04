using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost("add")]
        public dynamic Post([FromBody] dynamic jsonResponse)
        {
            try
            {
                float a = float.Parse(jsonResponse.GetProperty("a").ToString());
                float b = float.Parse(jsonResponse.GetProperty("b").ToString());
                string message = (a + b).ToString();
                return JsonConvert.SerializeObject(new JsonResponse(message));
            }
            catch (Exception e)
            {
                return JsonConvert.SerializeObject(new JsonResponse(e.Message));
            }
        }
        [HttpPost("subtract")]
        public dynamic PostOther([FromBody] dynamic jsonResponse)
        {
            try
            {
                float a = float.Parse(jsonResponse.GetProperty("a").ToString());
                float b = float.Parse(jsonResponse.GetProperty("b").ToString());
                string message = (a - b).ToString();
                return JsonConvert.SerializeObject(new JsonResponse(message));
            }
            catch (Exception e)
            {
                return JsonConvert.SerializeObject(new JsonResponse(e.Message));
            }
        }
        [HttpPost("multiply")]
        public dynamic PostOther2([FromBody] dynamic jsonResponse)
        {
            try
            {
                float a = float.Parse(jsonResponse.GetProperty("a").ToString());
                float b = float.Parse(jsonResponse.GetProperty("b").ToString());
                string message = (a * b).ToString();
                return JsonConvert.SerializeObject(new JsonResponse(message));
            }
            catch (Exception e)
            {
                return JsonConvert.SerializeObject(new JsonResponse(e.Message));
            }
        }
        [HttpPost("divide")]
        public dynamic PostOther3([FromBody] dynamic jsonResponse)
        {
            try
            {
                float a = float.Parse(jsonResponse.GetProperty("a").ToString());
                float b = float.Parse(jsonResponse.GetProperty("b").ToString());
                string message = (a / b).ToString();
                return JsonConvert.SerializeObject(new JsonResponse(message));
            }
            catch (Exception e)
            {
                return JsonConvert.SerializeObject(new JsonResponse(e.Message));
            }
        }
        [HttpPost("modulo")]
        public dynamic PostOther4([FromBody] dynamic jsonResponse)
        {
            try
            {
                float a = float.Parse(jsonResponse.GetProperty("a").ToString());
                float b = float.Parse(jsonResponse.GetProperty("b").ToString());
                string message = (a % b).ToString();
                return JsonConvert.SerializeObject(new JsonResponse(message));
            }
            catch (Exception e)
            {
                return JsonConvert.SerializeObject(new JsonResponse(e.Message));
            }
        }
    }
}