import styled from "styled-components";
import { secondaryColor, footerColor } from "../../config/colors";
export const Nav = styled.nav`
  background: ${footerColor};
  padding: 20px;
  display: flex;
  align-content: center;
  justify-content: right;
  align-items: end;
  position:fixed;
  width: 100%;
  bottom: 0;

  a {
    color: black;
    margin: 0 10px 0 0;
    font-weight: bold;
    text-decoration: none;
  }

  img{
    margin-bottom: -3px;
    width: 20px;
    height: 20px;
  }

  img:hover{
    margin-bottom: -4px;
    margin-right: -1px;
    width: 21px;
    height: 21px;
    cursor: pointer;
  }
`;
