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

            Field(x => x.Source)
                .Description("The source url of the image");

            Field(x => x.User, type: typeof(UserType))
                .Description("The user who uploaded the image");
        }
    }
}