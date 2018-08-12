using System;
using System.Data;
using ServiceStack.OrmLite;

namespace PeopleManagement.Constants.OrmLiteConverters
{
    public class GenderOrmLiteConverter : OrmLiteConverter
    {
        public override string ColumnDefinition => "NVARCHAR(15)";
        
        public override DbType DbType => DbType.String;
        
        public override object FromDbValue(Type fieldType, object value) => new Gender((string)value);

        public override object ToDbValue(Type fieldType, object value) => ((Gender)value).ToString();
    }
}