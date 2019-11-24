using BagelGram.Core.Models;
using GraphQL.Types;

namespace BagelGram.API.Query.Types
{
    public class ImageType : ObjectGraphType<Image>
    {
        public ImageType()
        {
            Name = "Image";

            Field(x => x.Id, type: typeof(NonNullGraphType<IdGraphType>))
                .Description("The Image ID");

            Field<NonNullGraphType<StringGraphType>>(nameof(Image.Source));

            Field(x => x.Uploaded)
                .Description("The date the image was uploaded");

            Field(x => x.Caption)
                .Description("The caption of the image");

            Field<NonNullGraphType<UserType>>(nameof(Image.User));
            Field<ListGraphType<CommentType>>(nameof(Image.Comments));

            Field(
                typeof(NonNullGraphType<IntGraphType>),
                "TotalLikes",
                "Number of likes an image has",
                null,
                context =>
                {
                    var likes = context.Source.Likes.Count;
                    return likes;
                }
            );
        }
    }
}