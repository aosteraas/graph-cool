import { gql } from 'apollo-boost';

export const ADD_IMAGE = gql`
  mutation createImageMutation($image: ImageUpload!) {
    createImage(image: $image) {
      caption
      id
      source
    }
  }
`;
