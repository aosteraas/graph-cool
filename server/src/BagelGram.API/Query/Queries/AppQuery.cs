using GraphQL.Types;

namespace BagelGram.API.Query.Queries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery()
        {
            Name = "Query";

            Field<UserQuery>("users", resolve: context => new { });
            Field<ImageQuery>("images", resolve: context => new { });
            Field<CommentQuery>("comments", resolve: context => new { });
        }
    }
}