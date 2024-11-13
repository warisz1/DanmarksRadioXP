using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanmarksRadioXP
{
    public class RecordsRepo
    {
        private List<Records> _records = new();
        private int nextId = 1;

        public RecordsRepo()
        {
            _records.Add(new Records() { Id = nextId++, Title = "One Last Time", Artist = "Ariana Grande", Duration = 256, PublicationYear = 2014 });
            _records.Add(new Records() { Id = nextId++, Title = "Old Town", Artist = "Lil Nas", Duration = 346, PublicationYear = 2018 });
            _records.Add(new Records() { Id = nextId++, Title = "Wild Side", Artist = "Normai", Duration = 266, PublicationYear = 2021 });
            _records.Add(new Records() { Id = nextId++, Title = "Sorry", Artist = "Justin Biber", Duration = 306, PublicationYear = 2015 });
        }

        public IEnumerable<Records> GetAll()
        {
            IEnumerable<Records> result = new List<Records>(_records);
            return result;
        }




    }
}
