using GraphQL.Types;

namespace GraphCool.API.Query
{
    public class PersonInputType : InputObjectGraphType
    {
        public PersonInputType()
        {
            Name = "PersonInput";
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<NonNullGraphType<StringGraphType>>("birthDate");
        }
    }
}