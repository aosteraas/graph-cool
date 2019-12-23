import React from 'react';
import AvatarEditor from 'react-avatar-editor';

interface Props {
  image?: File;
  rotate: number;
  scale: number;
  setRef(editorRef: AvatarEditor): void;
}

export const ImageEditor = React.memo<Props>(({ image, rotate, scale, setRef }) => {
  return (
    <AvatarEditor
      ref={setRef}
      image={image}
      rotate={rotate}
      scale={scale}
      width={500}
      height={500}
      border={1}
    />
  );
});

export { AvatarEditor };
