import { stringArg, idArg } from 'nexus';
import { prismaObjectType } from 'nexus-prisma';

export const Mutation = prismaObjectType({
  name: 'Mutation',
  definition(t) {
    t.prismaFields(['createUser', 'deletePost']);
    t.field('createDraft', {
      type: 'Post',
      args: {
        title: stringArg(),
        authorId: idArg({ nullable: true })
      },
      resolve: (_, { title, authorId }, ctx) =>
        ctx.prisma.createPost({
          title,
          author: { connect: { id: authorId } }
        })
    });
    t.field('publish', {
      type: 'Post',
      nullable: true,
      args: { id: idArg() },
      resolve: (_, { id }, ctx) =>
        ctx.prisma.updatePost({
          where: { id },
          data: { published: true }
        })
    });
  }
});
