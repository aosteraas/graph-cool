using GraphQL.Types;
using GraphQL;
using System;
using GraphQL.Utilities;

namespace BagelGram.API.Query
{
    public class PersonSchema : Schema
    {
        public PersonSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<PersonQuery>();
            Mutation = provider.GetRequiredService<PersonMutation>();
        }
    }
}