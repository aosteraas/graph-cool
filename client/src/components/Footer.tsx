import React from 'react';
import { Link } from 'react-router-dom';
import { faCameraRetro } from '@fortawesome/free-solid-svg-icons';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { FooterStyle } from '../styles/LayoutStyles';

export const Footer = () => {
  return (
    <FooterStyle>
      <Link to="/upload">
        <FontAwesomeIcon size="2x" icon={faCameraRetro} />
      </Link>
    </FooterStyle>
  );
};
