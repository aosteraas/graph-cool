using BagelGram.Core.Models;
using GraphQL.Types;

namespace BagelGram.API.Query.Types
{
    public class CommentType : ObjectGraphType<Comment>
    {
        public CommentType()
        {
            Name = "Comment";

            Field(x => x.Id, type: typeof(IdGraphType))
                .Description("The Comment ID");

            Field(x => x.Text)
                .Description("The text of the comment");

            Field(x => x.Image, type: typeof(ImageType))
                .Description("The image the comment belongs to");

            Field(x => x.User, type: typeof(UserType))
                .Description("The User who wrote the comment");
        }
    }
}