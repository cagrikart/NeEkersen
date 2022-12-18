using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using RestSharp;
using System.Net;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private IActivityService _service;

        public ActivityController(IActivityService activityService)
        {
            this._service = activityService;
        }
        [HttpPost]
        public Activity CreateActivity([FromBody] Activity activity)
        {
            return _service.CreateActivity(activity);
        }

        [HttpDelete("{id}")]
        public void DeleteActivity(Guid id)
        {
            _service.DeleteActivity(id);
        }

        [HttpGet("{id}")]
        public Activity GetActivityById(Guid id)
        {
            return _service.GetActivityById(id);
        }
        [HttpGet]
        public List<Activity> GetAllActivity()
        {
            return _service.GetAllActivity();
        }

        [HttpPut("{id}")]
        public Activity UpdateActivity([FromBody] Activity activity)
        {
            return _service.UpdateActivity(activity);
        }


        [HttpGet(template:"collect")]
        public ActionResult<string> GetWeather()
        {
            var client = new RestClient("https://api.collectapi.com/weather/getWeather?data.lang=tr&data.city=ankara");
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "apikey 32j9cWNjp8LvgdHuJHCqEA:26Q3GYJNV8MH0S0BKU2yT8");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

    }
}
