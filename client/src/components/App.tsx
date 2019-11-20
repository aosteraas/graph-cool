import React from 'react';
import { gql } from 'apollo-boost';
import { Header } from './Header';
import { Images } from './Images';

const QUERY_GET_IMAGES = gql`
  query GetImages {
    getImages {
      id
      source
    }
  }
`;

const App: React.FC = () => {
  return (
    <div className="App">
      <Header />
      <Images />
    </div>
  );
};

export default App;
