using BagelGram.Core.Models;
using GraphQL.Types;

namespace BagelGram.API.Query.Types
{
    public class LikeType : ObjectGraphType<Like>
    {
        public LikeType()
        {
            Name = "Like";

            Field(x => x.ImageId, type: typeof(NonNullGraphType<IdGraphType>))
                .Description("The Image ID");
        }
    }
}