using Npgsql;

namespace DataAccessLayer.Translators
{
    public class CamelCaseTranslator : INpgsqlNameTranslator
    {
        public string TranslateMemberName(string clrName)
        {
            return clrName;
        }

        public string TranslateTypeName(string clrName)
        {
            return clrName;
        }
    }
}
