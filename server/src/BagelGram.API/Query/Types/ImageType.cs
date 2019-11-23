using BagelGram.Core.Models;
using GraphQL.Types;

namespace BagelGram.API.Query.Types
{
    public class ImageType : ObjectGraphType<Image>
    {
        public ImageType()
        {
            Name = "Image";

            Field(x => x.Id, type: typeof(IdGraphType))
                .Description("The Image ID");

            Field<NonNullGraphType<StringGraphType>>(nameof(Image.Source));

            Field(x => x.Uploaded)
                .Description("The date the image was uploaded");

            Field(x => x.Caption)
                .Description("The caption of the image");

            Field<UserType>(nameof(Image.User));
            Field<ListGraphType<CommentType>>(nameof(Image.Comments));
            // TODO add likes
        }
    }
}