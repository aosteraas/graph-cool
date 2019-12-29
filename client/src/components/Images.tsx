import React from 'react';
import { useGetImagesQuery } from '../generated/graphql';
import { ImageColumn, ImageItem, SquareImage, ImageActions } from '../styles/ImageStyles';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';

export const Images = () => {
  const { data, error, loading } = useGetImagesQuery();
  const images = (data && data.getImages) || [];
  return (
    <ImageColumn>
      {images.map((image, idx) => (
        <ImageItem key={idx}>
          <SquareImage src={`${image!.source}`} />
          <ImageActions>
            {/* <FontAwesomeIcon icon={fasHeart} /> */}
            <FontAwesomeIcon icon={['fas', 'heart']} />
            <FontAwesomeIcon icon={['fas', 'comment']} />
          </ImageActions>
          <div className="imageauthor">
            <strong>Bagel </strong>
            {image!.caption}
          </div>
          <div className="posted">{image!.uploaded}</div>
        </ImageItem>
      ))}
    </ImageColumn>
  );
};
