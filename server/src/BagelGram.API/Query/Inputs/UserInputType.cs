using GraphQL.Types;

namespace BagelGram.API.Query.Inputs
{
    public class UserInputType : InputObjectGraphType
    {
        public UserInputType()
        {
            Name = "UserInput";

            Field<NonNullGraphType<StringGraphType>>("userName");
            Field<NonNullGraphType<StringGraphType>>("birthDate");
        }
    }
}