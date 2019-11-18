using System;
using GraphQL.Types;
using GraphQL.Utilities;
using BagelGram.API.Query.Queries;
using BagelGram.API.Query.Mutations;

namespace BagelGram.API.Query.Schemas
{
    public class AppSchema : Schema
    {
        public AppSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<AppQuery>();
            Mutation = provider.GetRequiredService<AppMutation>();
        }
    }
}