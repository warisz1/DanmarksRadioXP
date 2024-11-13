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

        public Records? GetById(int id)
        {
            return _records.Find(record => record.Id == id);
        }

        public Records Add(Records records)
        {
            records.Validate();
            records.Id = nextId++;
            _records.Add(records);
            return records;
        }


        public Records? Remove(int id)
        {
           Records? records = GetById(id);
            if (records == null) 
            {
                return null;
            }
            _records.Remove(records);
            return records; 
        }




    }
}
