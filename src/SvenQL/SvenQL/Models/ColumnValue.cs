namespace SvenQL.Models
{
    public class ColumnValue
    {
        public readonly object Value;
        public readonly Column Column;

        public ColumnValue(Column column, object value)
        {
            Column = column;
            Value = value;
        }
    }
}