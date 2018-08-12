using System;
using PeopleManagement.Constants;

namespace PeopleManagement.Models.Builders
{
    public class ImportantDateBuilder
    {
        private DateTime date;
        private ImportantDateType type;
        private string notes;

        public static ImportantDateBuilder Default()
        {
            return new ImportantDateBuilder();
        }

        public ImportantDateBuilder UseDate(DateTime date)
        {
            this.date = date;
            return this;
        }

        public ImportantDateBuilder UseType(ImportantDateType type)
        {
            this.type = type;
            return this;
        }

        public ImportantDateBuilder UseNotes(string notes)
        {
            this.notes = notes;
            return this;
        }

        public ImportantDate Build()
        {
            return new ImportantDate(date, type, notes);
        }
    }
}