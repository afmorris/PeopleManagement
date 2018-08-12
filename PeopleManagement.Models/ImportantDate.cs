using System;
using PeopleManagement.Constants;

namespace PeopleManagement.Models
{
    public class ImportantDate : BaseModel
    {
        public DateTime Date { get; set; }
        public ImportantDateType Type { get; set; }
        public string Notes { get; set; }
    }
}