using System;
using GraphQL.Types;
using GraphQL.Utilities;
using BagelGram.API.Query.Queries;
using BagelGram.API.Query.Mutations;

namespace BagelGram.API.Query.Schemas
{
    public class UserSchema : Schema
    {
        public UserSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<UserQuery>();
            Mutation = provider.GetRequiredService<UserMutation>();
        }
    }
}