import { prisma } from './generated/prisma-client';
import * as path from 'path';
import { makePrismaSchema } from 'nexus-prisma';
import datamodelInfo from './generated/nexus-prisma';
import { Query } from './Query';
import { Mutation } from './Mutation';

export const schema = makePrismaSchema({
  types: [Query, Mutation],

  prisma: {
    datamodelInfo,
    client: prisma
  },

  outputs: {
    schema: path.join(__dirname, './generated/schema.graphql'),
    typegen: path.join(__dirname, './generated/nexus.ts')
  }
});
