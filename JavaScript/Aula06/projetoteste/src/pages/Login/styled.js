import styled from "styled-components";

export const Title = styled.h1`
  color: ${(props) => props.isRed ? "red" : "blue"}; // Ao invés de passarmos um cor direto para o titulo agora podemos mudar ela direto no index.js
  small {
    font-size: 0.5em;
    margin-left: 15px;
    color: black;
  }
`;
