using BagelGram.API.Models;
using BagelGram.API.Services;
using GraphQL.Types;

namespace BagelGram.API.Query
{
    public class PersonMutation : ObjectGraphType
    {
        public PersonMutation(ContextServiceLocator contextServiceLocator)
        {
            FieldAsync<PersonType>(
                "createPerson",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PersonInputType>> { Name = "person" }
                ),
                resolve: async context =>
                {
                    var person = context.GetArgument<Person>("person");
                    return await contextServiceLocator.PersonService.CreateAsync(person);
                }
            );
        }
    }
}