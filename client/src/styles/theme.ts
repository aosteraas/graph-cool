export interface Theme {
  colors: Colors;
  borders: Borders;
}
interface Colors {
  pink: string;
}
interface Borders {
  default: string;
  radius: string;
}
export const theme: Theme = {
  colors: {
    pink: `rgb(244, 72, 255)`
  },
  borders: {
    default: `2px solid rgb(244, 72, 255)`,
    radius: `border-radius: 2px;`
  }
};
