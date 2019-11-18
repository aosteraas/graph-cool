using BagelGram.API.Query.Types;
using BagelGram.API.Services;
using GraphQL.Types;

namespace BagelGram.API.Query.Queries
{
    public class ImageQuery : ObjectGraphType
    {
        public ImageQuery(ContextServiceLocator locator)
        {
            Name = "Images";
            FieldAsync<ListGraphType<ImageType>>(
                name: "Images",
                description: "All Images",
                resolve: async context => await locator.ImageRepository.GetImagesAsync()
            );

            FieldAsync<ImageType>(
                name: "Image",
                description: "A single image",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "imageId", Description = "The Image's Id" }),
                resolve: async context =>
                {
                    var id = context.GetArgument<int>("imageId");
                    var image = await locator.ImageRepository.GetImageAsync(id);
                    return image;
                }
            );

            FieldAsync<ListGraphType<ImageType>>(
                name: "imagesForUser",
                description: "All Images for a User",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "userId", Description = "The User's Id" }),
                resolve: async context =>
                {
                    var userId = context.GetArgument<int>("userId");
                    var images = await locator.ImageRepository.GetUserImages(userId);
                    return images;
                }
            );
        }
    }
}
