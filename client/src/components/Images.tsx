import React from 'react';
import { useGetImagesQuery } from '../generated/graphql';
import { ImageColumn, ImageItem, SquareImage, Like, Comment } from '../styles/ImageStyles';

export const Images = () => {
  const { data, error, loading } = useGetImagesQuery();
  const images = (data && data.getImages) || [];
  return (
    <ImageColumn>
      {images.map((image, idx) => (
        <ImageItem key={idx}>
          <SquareImage src={`http://localhost:5000${image!.source}`} />
          <Like />
          <Comment />
        </ImageItem>
      ))}
    </ImageColumn>
  );
};
