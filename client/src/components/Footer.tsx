import React from 'react';
import { faCameraRetro } from '@fortawesome/free-solid-svg-icons';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { FooterStyle } from '../styles/LayoutStyles';

export const Footer = () => {
  return (
    <FooterStyle>
      <FontAwesomeIcon size="2x" icon={faCameraRetro} />
    </FooterStyle>
  );
};
