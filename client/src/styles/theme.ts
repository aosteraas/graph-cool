export interface Theme {
  colors: Colors;
  borders: Borders;
  width: string;
  maxWidth: string;
}
interface Colors {
  pink: string;
}
interface Borders {
  default: string;
  radius: string;
}
export const theme: Theme = {
  width: `100%`,
  maxWidth: `500px`,
  colors: {
    pink: `rgb(244, 72, 255)`
  },
  borders: {
    default: `2px solid rgb(244, 72, 255)`,
    radius: `border-radius: 2px;`
  }
};
