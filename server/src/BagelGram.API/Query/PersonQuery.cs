using BagelGram.API.Interfaces;
using BagelGram.API.Models;
using BagelGram.API.Services;
using GraphQL.Types;

namespace BagelGram.API.Query
{
    public class PersonQuery : ObjectGraphType
    {

        public PersonQuery(ContextServiceLocator contextServiceLocator)
        {
            FieldAsync<PersonType>(
                name: "Person",
                description: "A person in the app",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "Id" }),
                resolve: async context => await contextServiceLocator.PersonService.GetAsync(context.GetArgument<int>("Id"))
            );

            FieldAsync<ListGraphType<PersonType>>(
                "People",
                resolve: async context => await contextServiceLocator.PersonService.GetAllAsync()
            );
        }
    }
}