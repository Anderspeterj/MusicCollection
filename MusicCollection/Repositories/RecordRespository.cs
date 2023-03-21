using MusicCollection.Models;
using MusicCollection.Controller;
using MusicCollection.Repositories;

namespace MusicCollection.Repositories
{
    public class RecordRespository
    {
        private static int _nextId = 1;
        private static readonly List<Record> _records = new List<Record>
        {
            new Record {Id = _nextId++, Title = "Hollywood's Bleeding", Artist = "Post Malone",
            Duration = 156, PublicationYear = 2019},
            new Record {Id = _nextId++, Title = "Lucid Dreams", Artist = "Juice WRLD",
            Duration = 239, PublicationYear = 2018},
            new Record {Id = _nextId++, Title = "Venator", Artist = "Be'lakor", Duration = 517,
                PublicationYear = 2009,
            },
            new Record {Id = _nextId++, Title = "Jeg er havren", Artist ="Stig Møller", Duration = 220, PublicationYear = 1994}
        };

        public List<Record> GetAll()
        {
            List<Record> result = new List<Record>(_records);
            return result;
        }


        public Record AddRecord(Record newRecord)
        {
            newRecord.Id = _nextId++;
            _records.Add(newRecord);
            return newRecord;
        }

        public Record DeleteRecord(int id)
        {
            Record record = GetById(id);
            _records.Remove(record);
            return record;
        }

        public Record GetById(int id)
        {
            return _records.Find(record => record.Id == id);
        }   
    }
}
