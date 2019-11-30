import styled from 'styled-components/macro';

export const ImageColumn = styled.section`
  display: flex;
  flex-direction: column;
  align-items: center;
  margin: 0 auto;
  padding: 72px 0;
`;

export const ImageItem = styled.article`
  border: 2px solid #dfdfdf;
  border-radius: 0.25rem;
  padding: 0.625rem;
  margin: 0.625rem 0;
  background-color: #f8f8ff;
`;

export const SquareImage = styled.img`
  width: 100%;
  height: 100%;
  max-width: 500px;
  max-height: 500px;
  object-fit: cover;
`;

export const ImageActions = styled.section`
  display: flex;
  flex-direction: row;
  font-size: 1.5rem;
`;
