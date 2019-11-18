using BagelGram.API.Query.Inputs;
using BagelGram.API.Query.Types;
using BagelGram.API.Services;
using BagelGram.Core.Interfaces;
using BagelGram.Core.Models;
using GraphQL.Types;

namespace BagelGram.API.Query.Mutations
{
    public class AppMutation : ObjectGraphType
    {
        public AppMutation(ContextServiceLocator locator)
        {
            FieldAsync<UserType>(
                "createUser",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<UserInputType>>() { Name = "user" }
                ),
                resolve: async context =>
                {
                    var user = context.GetArgument<User>("user");
                    var newUser = await locator.UserRepository.CreateUserAsync(user);
                    return user;
                }
            );
        }
    }
}
