using System;
using PeopleManagement.Constants;

namespace PeopleManagement.Models
{
    public class ImportantDate : BaseModel
    {
        public DateTime Date { get; }
        public ImportantDateType Type { get; }
        public string Notes { get; }

        public ImportantDate(DateTime date, ImportantDateType type, string notes)
        {
            Date = date;
            Type = type;
            Notes = notes;
        }
    }
}