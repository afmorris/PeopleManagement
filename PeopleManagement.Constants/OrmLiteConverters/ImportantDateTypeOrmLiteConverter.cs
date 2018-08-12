using System;
using System.Data;
using ServiceStack.OrmLite;

namespace PeopleManagement.Constants.OrmLiteConverters
{
    public class ImportantDateTypeOrmLiteConverter : OrmLiteConverter
    {
        public override string ColumnDefinition => "NVARCHAR(20)";
        
        public override DbType DbType => DbType.String;
        
        public override object FromDbValue(Type fieldType, object value) => new ImportantDateType((string)value);

        public override object ToDbValue(Type fieldType, object value) => ((ImportantDateType)value).ToString();
    }
}