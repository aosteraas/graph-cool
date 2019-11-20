import styled from 'styled-components/macro';

export const ImageColumn = styled.section`
  display: flex;
  flex-direction: column;
  align-items: center;
  width: 500px;
  margin: 0 auto;
`;
export const SquareImage = styled.img`
  width: 100%;
  height: 100%;
  max-width: 500px;
  max-height: 500px;
  object-fit: cover;
`;
export const ImageItem = styled.article``;

const Icon = styled.span`
  margin: 12px;
  background-color: #fed;
  border: 2px solid #fc6;
  display: inline-block;
  position: relative;
  vertical-align: top;
  &:after,
  &:before {
    background: #fed;
    border: 2px solid #fc6;
    content: '';
    position: absolute;
  }
`;
export const Comment = styled(Icon)`
  border-radius: 4px;
  height: 18px;
  width: 26px;
  &:before {
    border-top-color: #fed;
    bottom: -11px;
    z-index: 1;
    background: none;
    border-bottom: 6px solid transparent;
    border-left: 6px solid transparent;
    border-right: 6px solid transparent;
    border-top: 6px solid #fc6;
    border-top-color: rgb(255, 204, 102);
    bottom: -14px;
    height: 0;
    left: 7px;
    width: 0;
  }
  &:after {
    background: none;
    border-bottom: 6px solid transparent;
    border-left: 6px solid transparent;
    border-right: 6px solid transparent;
    border-top: 6px solid #fc6;
    bottom: -14px;
    height: 0;
    left: 7px;
    width: 0;
  }
`;
export const Like = styled(Icon)`
  border-radius: 100%;
  height: 15px;
  margin-right: 24px;
  width: 15px;
  &:after {
    border-radius: 100%;
    height: 15px;
    left: 11px;
    top: -2px;
    width: 15px;
    z-index: -1;
  }
  &:before {
    border-left: none;
    border-top: none;
    height: 16px;
    left: 5px;
    top: 6px;
    width: 16px;
    -webkit-transform: rotate(45deg);
    -moz-transform: rotate(45deg);
    -ms-transform: rotate(45deg);
    -o-transform: rotate(45deg);
    transform: rotate(45deg);
  }
`;
