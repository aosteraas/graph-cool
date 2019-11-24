import gql from 'graphql-tag';
import * as ApolloReactCommon from '@apollo/react-common';
import * as ApolloReactHooks from '@apollo/react-hooks';
export type Maybe<T> = T | null;
/** All built-in and custom scalars, mapped to their actual values */
export type Scalars = {
  ID: string,
  String: string,
  Boolean: boolean,
  Int: number,
  Float: number,
  /** 
 * The `Date` scalar type represents a year, month and day in accordance with the
   * [ISO-8601](https://en.wikipedia.org/wiki/ISO_8601) standard.
 **/
  Date: any,
  BigInt: any,
  Byte: any,
  /** 
 * The `DateTime` scalar type represents a date and time. `DateTime` expects
   * timestamps to be formatted in accordance with the
   * [ISO-8601](https://en.wikipedia.org/wiki/ISO_8601) standard.
 **/
  DateTime: any,
  /** 
 * The `DateTimeOffset` scalar type represents a date, time and offset from UTC.
   * `DateTimeOffset` expects timestamps to be formatted in accordance with the
   * [ISO-8601](https://en.wikipedia.org/wiki/ISO_8601) standard.
 **/
  DateTimeOffset: any,
  Decimal: any,
  Guid: any,
  Long: any,
  /** The `Milliseconds` scalar type represents a period of time represented as the total number of milliseconds. */
  Milliseconds: any,
  SByte: any,
  /** The `Seconds` scalar type represents a period of time represented as the total number of seconds. */
  Seconds: any,
  Short: any,
  UInt: any,
  ULong: any,
  Uri: any,
  UShort: any,
};

export type AppMutation = {
   __typename?: 'AppMutation',
  createUser?: Maybe<User>,
};


export type AppMutationCreateUserArgs = {
  user: UserInput
};



export type Comment = {
   __typename?: 'Comment',
  /** The Comment ID */
  id?: Maybe<Scalars['ID']>,
  /** The image the comment belongs to */
  image?: Maybe<Image>,
  /** The text of the comment */
  text: Scalars['String'],
  /** The User who wrote the comment */
  user?: Maybe<User>,
};






export type Image = {
   __typename?: 'Image',
  /** The caption of the image */
  caption: Scalars['String'],
  comments?: Maybe<Array<Maybe<Comment>>>,
  /** The Image ID */
  id: Scalars['ID'],
  source: Scalars['String'],
  /** Number of likes an image has */
  totalLikes: Scalars['Int'],
  /** The date the image was uploaded */
  uploaded: Scalars['Date'],
  user: User,
};



export type Query = {
   __typename?: 'Query',
  /** All comments on a given image */
  commentsForImage?: Maybe<Array<Maybe<Comment>>>,
  /** All comments from a given user */
  commentsForUser?: Maybe<Array<Maybe<Comment>>>,
  /** A single image */
  getImage?: Maybe<Image>,
  /** All Images */
  getImages?: Maybe<Array<Maybe<Image>>>,
  /** All Images for a User */
  getImagesForUser?: Maybe<Array<Maybe<Image>>>,
  /** A User of BagelGram */
  getUser?: Maybe<User>,
  /** All Users of BagelGram */
  getUsers?: Maybe<Array<Maybe<User>>>,
};


export type QueryCommentsForImageArgs = {
  imageId: Scalars['ID']
};


export type QueryCommentsForUserArgs = {
  userId: Scalars['ID']
};


export type QueryGetImageArgs = {
  imageId: Scalars['ID']
};


export type QueryGetImagesForUserArgs = {
  userId: Scalars['ID']
};


export type QueryGetUserArgs = {
  id: Scalars['ID']
};







export type User = {
   __typename?: 'User',
  /** Comments the user has made */
  comments?: Maybe<Array<Maybe<Comment>>>,
  /** The User ID */
  id?: Maybe<Scalars['ID']>,
  /** The User's images */
  images?: Maybe<Array<Maybe<Image>>>,
  /** The User's display name */
  userName: Scalars['String'],
};

export type UserInput = {
  userName: Scalars['String'],
  birthDate: Scalars['String'],
};


export type GetImagesQueryVariables = {};


export type GetImagesQuery = (
  { __typename?: 'Query' }
  & { getImages: Maybe<Array<Maybe<(
    { __typename?: 'Image' }
    & Pick<Image, 'id' | 'source' | 'caption' | 'uploaded' | 'totalLikes'>
  )>>> }
);


export const GetImagesDocument = gql`
    query GetImages {
  getImages {
    id
    source
    caption
    uploaded
    totalLikes
  }
}
    `;

/**
 * __useGetImagesQuery__
 *
 * To run a query within a React component, call `useGetImagesQuery` and pass it any options that fit your needs.
 * When your component renders, `useGetImagesQuery` returns an object from Apollo Client that contains loading, error, and data properties 
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useGetImagesQuery({
 *   variables: {
 *   },
 * });
 */
export function useGetImagesQuery(baseOptions?: ApolloReactHooks.QueryHookOptions<GetImagesQuery, GetImagesQueryVariables>) {
        return ApolloReactHooks.useQuery<GetImagesQuery, GetImagesQueryVariables>(GetImagesDocument, baseOptions);
      }
export function useGetImagesLazyQuery(baseOptions?: ApolloReactHooks.LazyQueryHookOptions<GetImagesQuery, GetImagesQueryVariables>) {
          return ApolloReactHooks.useLazyQuery<GetImagesQuery, GetImagesQueryVariables>(GetImagesDocument, baseOptions);
        }
export type GetImagesQueryHookResult = ReturnType<typeof useGetImagesQuery>;
export type GetImagesLazyQueryHookResult = ReturnType<typeof useGetImagesLazyQuery>;
export type GetImagesQueryResult = ApolloReactCommon.QueryResult<GetImagesQuery, GetImagesQueryVariables>;

      export interface IntrospectionResultData {
        __schema: {
          types: {
            kind: string;
            name: string;
            possibleTypes: {
              name: string;
            }[];
          }[];
        };
      }
      const result: IntrospectionResultData = {
  "__schema": {
    "types": []
  }
};
      export default result;
    