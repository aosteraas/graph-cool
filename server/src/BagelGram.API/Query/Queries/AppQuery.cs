using BagelGram.API.Query.Types;
using BagelGram.API.Services;
using BagelGram.Core.Interfaces;
using GraphQL.Types;

namespace BagelGram.API.Query.Queries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(ContextServiceLocator locator)
        {
            FieldAsync<UserType>(
                name: "User",
                description: "A User of BagelGram",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "Id", Description = "The User's Id" }),
                resolve: async context =>
                {
                    var id = context.GetArgument<int>("id");
                    return await locator.UserRepository.GetUserAsync(id);
                }
            );

            FieldAsync<UserType>(
                name: "Users",
                description: "All Users of BagelGram",
                resolve: async context => await locator.UserRepository.GetUsersAsync()
            );
        }

    }

}