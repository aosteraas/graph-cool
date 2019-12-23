import styled from 'styled-components/macro';

export const FileInputStyle = styled.div`
  border: 2px solid rgb(244, 72, 255);
  border-radius: 4px;
  background: rgba(244, 72, 255, 0.25);
  padding: 1rem;
  input {
    display: none;
  }
`;

export const Comment = styled.input`
  font-family: 'Chalkboard', 'Comic Sans MS';
  width: 100%;
  max-width: 500px;
  border: ${({ theme }) => theme.borders.default};
  border-radius: ${({ theme }) => theme.borders.radius};
  font-size: 1rem;
`;
export const Controls = styled.section`
  display: flex;
  flex-direction: row;
  padding: 0.5rem 0;
  justify-content: space-around;
  width: 100%;
  max-width: 500px;
`;
