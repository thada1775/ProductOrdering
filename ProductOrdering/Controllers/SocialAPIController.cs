using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ProductOrdering.Data;
using ProductOrdering.Models.API;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductOrdering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;
        public SocialAPIController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _client = new HttpClient();
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetResponeAuthCode(string code, string state)
        {
            _client.BaseAddress = new Uri("https://api.line.me/oauth2/v2.1/token");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var channelId = _configuration.GetConnectionString("channelId");
            var channelSecret = _configuration.GetConnectionString("channelSecret");
            var redirect_uri = _configuration.GetConnectionString("redirect_uri");

            var postingAuthCode = new PostingAuthCode
            {
                code = code,
                redirect_uri = redirect_uri,
                client_id = channelId,
                client_secret = channelSecret,
            };

            var json = JsonConvert.SerializeObject(postingAuthCode);
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            //var content = new StringContent(json);
            var response = _client.PostAsync(_client.BaseAddress, new FormUrlEncodedContent(dictionary)).Result;
            var resultJson = JsonConvert.DeserializeObject<GettingAccessToken>(response.Content.ReadAsStringAsync().Result);
            return Ok();
        }

        //[HttpGet]
        //public void GetAccessToken(GettingAccessToken result)
        //{

        //}

        //// GET: api/<SocialAPIController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<SocialAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SocialAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SocialAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SocialAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
