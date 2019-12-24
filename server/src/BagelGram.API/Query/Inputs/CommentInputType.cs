using BagelGram.Core.Models;
using GraphQL.Types;

namespace BagelGram.API.Query.Inputs
{
    public class CommentInputType : InputObjectGraphType
    {
        public CommentInputType()
        {
            Name = "Comment";

            Field(type: typeof(NonNullGraphType<IdGraphType>), "ImageId");
            Field(type: typeof(StringGraphType), "Text");
        }
    }
}