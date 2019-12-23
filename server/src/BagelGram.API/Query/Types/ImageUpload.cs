using BagelGram.Core.Models;
using GraphQL.Types;

namespace BagelGram.API.Query.Types
{
    public class ImageUpload : ObjectGraphType<object>
    {
        public ImageUpload()
        {
            Name = "ImageUpload";
            Field(type: typeof(NonNullGraphType<StringGraphType>), "ImageData");
            Field(type: typeof(StringGraphType), "Caption");
        }
    }
}