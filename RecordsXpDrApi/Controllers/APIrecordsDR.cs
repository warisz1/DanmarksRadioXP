using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using DanmarksRadioXP;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecordsXpDrApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIrecordsDR : ControllerBase
    {

        private List<Records> _records = new();
        private int nextId = 1;

        public APIrecordsDR()
        {
            _records.Add(new Records() { Id = nextId++, Title = "One Last Time", Artist = "Ariana Grande", Duration = 256, PublicationYear = 2014 });
            _records.Add(new Records() { Id = nextId++, Title = "Old Town", Artist = "Lil Nas", Duration = 346, PublicationYear = 2018 });
            _records.Add(new Records() { Id = nextId++, Title = "Wild Side", Artist = "Normai", Duration = 266, PublicationYear = 2021 });
            _records.Add(new Records() { Id = nextId++, Title = "Sorry", Artist = "Justin Biber", Duration = 306, PublicationYear = 2015 });
        }

        // GET: api/<APIrecordsDR>
        [HttpGet]
        public IEnumerable<Records> GetAll(string? titleInclude = null, string? artistInclude = null)
        {
            IEnumerable<Records> result = new List<Records>(_records);
            if (titleInclude != null)
            {
                result = result.Where(m => m.Title.Contains(titleInclude));
            }
            if (artistInclude != null)
            {
                result = result.Where(m => m.Title.Contains(artistInclude));
            }

            return result;
        }

        // GET api/<APIrecordsDR>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<APIrecordsDR>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<APIrecordsDR>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<APIrecordsDR>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
