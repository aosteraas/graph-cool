import React, { Fragment } from 'react';
import { Images } from '../components/Images';
import { Footer } from '../components/Footer';

export const Home: React.FC = () => {
  return (
    <Fragment>
      <Images />
      <Footer />
    </Fragment>
  );
};
