import React from 'react';
import styled from 'styled-components/macro';
import logo from '../images/logo.png';
import { HeaderStyle } from '../styles/LayoutStyles';

const Logo = styled.img`
  max-height: 50px;
  padding: 10px 0;
  transition: all 0.25s ease;
  &:hover {
    transform: rotate(30deg);
  }
`;
export const Header = () => {
  return (
    <HeaderStyle>
      <Logo src={logo} />
      <h2>BagelGram</h2>
    </HeaderStyle>
  );
};
