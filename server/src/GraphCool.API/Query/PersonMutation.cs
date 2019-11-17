using GraphCool.API.Models;
using GraphCool.API.Services;
using GraphQL.Types;

namespace GraphCool.API.Query
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