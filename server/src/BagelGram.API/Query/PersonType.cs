using BagelGram.API.Models;
using GraphQL.Types;

namespace BagelGram.API.Query
{
    public class PersonType : ObjectGraphType<Person>
    {
        public PersonType()
        {
            Field(x => x.Id);
            Field(x => x.Name, true);
            Field<StringGraphType>(
                "birthDate",
                resolve: context => context.Source.BirthDate.ToShortDateString()
            );
        }
    }
}