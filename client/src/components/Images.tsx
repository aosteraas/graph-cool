import React from "react";
import { useGetImagesQuery } from "../generated/graphql";
import {
  ImageColumn,
  ImageItem,
  SquareImage,
  ImageMeta
} from "../styles/ImageStyles";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
  faHeart as fasHeart,
  faComment
} from "@fortawesome/free-solid-svg-icons";
import { faHeart } from "@fortawesome/free-regular-svg-icons";

export const Images = () => {
  const { data, error, loading } = useGetImagesQuery();
  const images = (data && data.getImages) || [];
  return (
    <ImageColumn>
      {images.map((image, idx) => (
        <ImageItem key={idx}>
          <SquareImage src={`http://localhost:5000${image!.source}`} />
          <ImageMeta>
            <FontAwesomeIcon icon={fasHeart} />
            <FontAwesomeIcon icon={faHeart} />
            <FontAwesomeIcon icon={faComment} />
          </ImageMeta>
        </ImageItem>
      ))}
    </ImageColumn>
  );
};
