import { gql } from 'apollo-boost';

export const ADD_IMAGE = gql`
  mutation createImage($image: ImageInput!) {
    createImage(image: $image) {
      caption
      id
      source
    }
  }
`;
