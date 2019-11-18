using BagelGram.API.Query.Types;
using BagelGram.API.Services;
using GraphQL.Types;

namespace BagelGram.API.Query.Queries
{
    public class UserQuery : ObjectGraphType
    {
        public UserQuery(ContextServiceLocator locator)
        {
            Name = "Users";

            FieldAsync<UserType>(
                name: "User",
                description: "A User of BagelGram",

                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "Id", Description = "The User's Id" }),
                resolve: async context =>
                {
                    var id = context.GetArgument<int>("id");
                    return await locator.UserRepository.GetUserAsync(id);
                }
            );

            FieldAsync<ListGraphType<UserType>>(
                name: "Users",
                description: "All Users of BagelGram",
                resolve: async context => await locator.UserRepository.GetUsersAsync()
            );
        }
    }
}
