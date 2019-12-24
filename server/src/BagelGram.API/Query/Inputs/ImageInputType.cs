using BagelGram.Core.Models;
using GraphQL.Types;

namespace BagelGram.API.Query.Inputs
{
    public class ImageInputType : InputObjectGraphType
    {
        public ImageInputType()
        {
            Name = "ImageInput";
            // Image in Base64 format.
            Field(type: typeof(NonNullGraphType<StringGraphType>), "ImageData");
            Field(type: typeof(StringGraphType), "Caption");
        }
    }
}