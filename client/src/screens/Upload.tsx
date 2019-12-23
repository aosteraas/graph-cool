import React, { useState, useRef } from 'react';
import { Theme } from '../styles/theme';
import styled from 'styled-components/macro';
import { ImageColumn } from '../styles/ImageStyles';
import { ImagePicker } from '../components/ImagePicker';
import { ImageEditor, AvatarEditor } from '../components/ImageEditor';

export const Upload: React.FC = () => {
  const [image, setImage] = useState<File | undefined>(undefined);
  const [caption, setCaption] = useState('things');
  const [rotate, setRotate] = useState(0);
  const [scale, setScale] = useState(1);
  const editor = useRef<AvatarEditor | undefined>();
  const setRef = (editorRef: AvatarEditor) => (editor.current = editorRef);

  const onImageSelect = (e: React.ChangeEvent<HTMLInputElement>) => {
    if (!e.target.files) return;
    const file = e.target.files[0];
    setImage(file);
  };

  const onSave = () => {
    if (!editor.current) return;
    const canvas = editor.current.getImage();
    const img = editor.current.getImageScaledToCanvas().toDataURL();
    const formData = new FormData();
    formData.append('file', img);
  };

  return (
    <ImageColumn>
      <ImagePicker onImageSelect={onImageSelect} />
      <ImageEditor image={image} scale={scale} rotate={rotate} setRef={setRef} />
      <div>
        <div onClick={() => setScale(scale + 0.1)}>+</div>
        <div onClick={() => setScale(scale - 0.1)}>-</div>
      </div>
      <Comment onChange={e => setCaption(e.target.value)} type="text" value={caption} />
    </ImageColumn>
  );
};

const Comment = styled.input`
  font-family: 'Chalkboard', 'Comic Sans MS';
  width: 100%;
  max-width: 500px;
  border: ${({ theme }) => theme.borders.default};
  border-radius: ${({ theme }) => theme.borders.radius};
  font-size: 1rem;
`;
