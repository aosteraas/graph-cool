import { gql } from 'apollo-boost';

export const QUERY_GET_IMAGES = gql`
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
