import React from 'react';
import styled from 'styled-components/macro';
import logo from '../images/logo.png';

const HeaderStyle = styled.header`
  display: flex;
  justify-content: center;
  align-items: center;
  background: rgb(244, 72, 255);
  color: #fff;
  position: fixed;
  width: 100%;
`;
const Logo = styled.img`
  max-height: 50px;
  padding: 10px 0;
`;
export const Header = () => {
  return (
    <HeaderStyle>
      <Logo src={logo} />
      <h2>BagelGram</h2>
    </HeaderStyle>
  );
};
