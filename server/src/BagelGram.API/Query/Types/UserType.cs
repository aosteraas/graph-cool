using BagelGram.Core.Models;
using GraphQL.Types;

namespace BagelGram.API.Query.Types
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Name = "User";

            Field(x => x.Id, type: typeof(IdGraphType))
                .Description("The User ID");

            Field(x => x.UserName)
                .Description("The User's display name");

            Field(x => x.Images, type: typeof(ListGraphType<ImageType>))
                .Description("The User's images");

            Field(x => x.Comments, type: typeof(ListGraphType<CommentType>))
                .Description("Comments the user has made");
        }
    }
}