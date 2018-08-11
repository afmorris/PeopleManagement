using System;
using System.Data;
using ServiceStack.OrmLite;

namespace PeopleManagement.Constants.OrmLiteConverters
{
    public class RelationshipTypeOrmLiteConverter : OrmLiteConverter
    {
        public override string ColumnDefinition => "NVARCHAR(20)";
        
        public override DbType DbType => DbType.String;
        
        public override object FromDbValue(Type fieldType, object value) => new RelationshipType((string)value);

        public override object ToDbValue(Type fieldType, object value) => ((RelationshipType)value).ToString();
    }
}