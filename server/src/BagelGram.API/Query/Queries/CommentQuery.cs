using BagelGram.API.Query.Types;
using BagelGram.API.Services;
using GraphQL.Types;

namespace BagelGram.API.Query.Queries
{
    public class CommentQuery : ObjectGraphType
    {
        public CommentQuery(ContextServiceLocator locator)
        {
            Name = "Comments";

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
        }
    }
}