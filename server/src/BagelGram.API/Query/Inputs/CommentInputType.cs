using BagelGram.Core.Models;
using GraphQL.Types;

namespace BagelGram.API.Query.Inputs
{
    public class CommentInputType : InputObjectGraphType
    {
        public CommentInputType()
        {
            Name = "CommentInput";

            Field(type: typeof(NonNullGraphType<IdGraphType>), "ImageId");
            Field(type: typeof(NonNullGraphType<StringGraphType>), "Text");
        }
    }
}