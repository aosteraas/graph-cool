using System;
using GraphQL.Types;
using GraphQL.Utilities;
using BagelGram.API.Query.Queries;
using BagelGram.API.Query.Mutations;

namespace BagelGram.API.Query.Schemas
{
    public class BagelSchema : Schema
    {
        public BagelSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<BagelQuery>();
            Mutation = provider.GetRequiredService<BagelMutation>();
        }
    }
}