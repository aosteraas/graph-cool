import React, { useState, useRef } from 'react';
import { ImageColumn } from '../styles/ImageStyles';
import { ImagePicker } from '../components/ImagePicker';
import { Comment, Controls } from '../styles/UploadStyles';
import { ImageEditor, AvatarEditor } from '../components/ImageEditor';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { useMutation } from '@apollo/react-hooks';
import { ADD_IMAGE } from '../mutations/ImageMutations';
import { ImageInput, Image, useCreateImageMutation } from '../generated/graphql';

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
    const img = editor.current.getImageScaledToCanvas().toDataURL();
    return img;
  };

  const [addImage, { data, error }] = useCreateImageMutation();

  const handleUpload = () => {
    const imageData = onSave()!;
    const image = { imageData, caption };
    addImage({ variables: { image } });
  };

  return (
    <ImageColumn>
      <ImagePicker onImageSelect={onImageSelect} />
      <ImageEditor image={image} scale={scale} rotate={rotate} setRef={setRef} />
      <Controls>
        <div onClick={() => setScale(scale + 0.1)}>
          <FontAwesomeIcon size="2x" icon="search-plus" />
        </div>
        <div onClick={() => setScale(scale - 0.1)}>
          <FontAwesomeIcon size="2x" icon="search-minus" />
        </div>
        <div>
          <FontAwesomeIcon size="2x" icon="undo" onClick={() => setRotate(rotate - 90)} />
        </div>
        <div>
          <FontAwesomeIcon
            size="2x"
            icon="undo"
            flip="horizontal"
            onClick={() => setRotate(rotate + 90)}
          />
        </div>
      </Controls>
      <Comment onChange={e => setCaption(e.target.value)} type="text" value={caption} />
      <button onClick={() => handleUpload()}> Save </button>
    </ImageColumn>
  );
};
