using System;
using PeopleManagement.Constants;

namespace PeopleManagement.Models
{
    public class ImportantDate
    {
        public DateTime Date { get; set; }
        public ImportantDateType Type { get; set; }
    }
}