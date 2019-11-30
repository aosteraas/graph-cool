import styled from 'styled-components/macro';

export const HeaderStyle = styled.header`
  display: flex;
  justify-content: center;
  align-items: center;
  background: rgb(244, 72, 255);
  color: #fff;
  position: fixed;
  width: 100%;
`;

export const FooterStyle = styled.footer`
  position: fixed;
  bottom: 0;
  width: 100%;
  display: flex;
  background: rgb(244, 72, 255);
  color: #fff;
  justify-content: center;
  padding: 0.425rem 0;
  svg {
    background: rgba(0, 0, 0, 0.25);
    padding: 0.25rem;
    border: 1px solid #fff;
    border-radius: 4px;
  }
`;
