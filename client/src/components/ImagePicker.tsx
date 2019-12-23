import React from 'react';
import { FileInputStyle } from '../styles/FileInputStyle';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faCameraRetro } from '@fortawesome/free-solid-svg-icons';

interface Props {
  onImageSelect(e: React.ChangeEvent<HTMLInputElement>): void;
}

export const ImagePicker: React.FC<Props> = ({ onImageSelect }) => {
  return (
    <FileInputStyle>
      <input
        id="image-upload"
        accept="image/*"
        multiple={false}
        type="file"
        onChange={onImageSelect}
      />
      <label htmlFor="image-upload">
        <FontAwesomeIcon icon={faCameraRetro} /> Select an Image
      </label>
    </FileInputStyle>
  );
};
