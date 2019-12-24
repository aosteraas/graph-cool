using BagelGram.API.Query.Types;
using BagelGram.API.Services;
using GraphQL.Types;

namespace BagelGram.API.Query.Queries
{
    public class BagelQuery : ObjectGraphType<object>
    {
        public BagelQuery(ContextServiceLocator locator)
        {
            Name = "Query";

            FieldAsync<UserType>(
                name: "getUser",
                description: "A User of BagelGram",

                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "Id", Description = "The User's Id" }),
                resolve: async context =>
                {
                    var id = context.GetArgument<int>("id");
                    return await locator.UserRepository.GetUserAsync(id);
                }
            );

            FieldAsync<ListGraphType<UserType>>(
                name: "getUsers",
                description: "All Users of BagelGram",
                resolve: async context => await locator.UserRepository.GetUsersAsync()
            );

            FieldAsync<ListGraphType<ImageType>>(
                name: "getImages",
                description: "All Images",
                resolve: async context => await locator.ImageRepository.GetImagesAsync()
            );

            FieldAsync<ImageType>(
                name: "getImage",
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
                name: "getImagesForUser",
                description: "All Images for a User",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "userId", Description = "The User's Id" }),
                resolve: async context =>
                {
                    var userId = context.GetArgument<int>("userId");
                    var images = await locator.ImageRepository.GetUserImages(userId);
                    return images;
                }
            );
            FieldAsync<ListGraphType<CommentType>>(
                name: "commentsForImage",
                description: "All comments on a given image",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "imageId", Description = "The Image's Id" }),
                resolve: async context => await locator.CommentRepository.GetImageComments(context.GetArgument<int>("imageId"))
            );

            FieldAsync<ListGraphType<CommentType>>(
                name: "commentsForUser",
                description: "All comments from a given user",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "userId", Description = "The User's Id" }),
                resolve: async context => await locator.CommentRepository.GetImageComments(context.GetArgument<int>("userId"))
            );

            FieldAsync<ListGraphType<LikeType>>(
                name: "likes",
                description: "Images I have liked",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "userId" }
                ),
                resolve: async context =>
                {
                    var userId = context.GetArgument<int>("userId");
                    var likes = await locator.LikeRepository.GetUserLikes(userId);
                    return likes;
                }
            );
            // Field<UserQuery>("users", resolve: context => new { });
            // Field<ImageQuery>("images", resolve: context => new { });
            // Field<CommentQuery>("comments", resolve: context => new { });
        }
    }
}