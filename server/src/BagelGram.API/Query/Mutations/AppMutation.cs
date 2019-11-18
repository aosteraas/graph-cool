using BagelGram.API.Query.Inputs;
using BagelGram.API.Query.Types;
using BagelGram.Core.Interfaces;
using BagelGram.Core.Models;
using GraphQL.Types;

namespace BagelGram.API.Query.Mutations
{
    public class UserMutation : ObjectGraphType
    {
        public UserMutation(IUserRepository userRepository)
        {
            FieldAsync<UserType>(
                "createUser",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<UserInputType>>() { Name = "user" }
                ),
                resolve: async context =>
                {
                    var user = context.GetArgument<User>("user");
                    var newUser = await userRepository.CreateUserAsync(user);
                    return user;
                }
            );
        }
    }
}
