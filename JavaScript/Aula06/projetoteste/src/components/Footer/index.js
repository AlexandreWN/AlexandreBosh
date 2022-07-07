import React from "react";
import { FaHome, FaUserAlt, FaSignOutAlt } from "react-icons/fa";
import { Nav } from "./styled";
export default function Footer() {
  return (
    <Nav>
        <a href="#">telefone</a>
        <a href="#">e-mail</a>
        <a href="#">redes sociais</a>
        <a href="#"><img src="https://www.svgrepo.com/show/85740/instagram.svg"></img></a>
        <a href="#"><img src="https://www.svgrepo.com/show/110852/facebook.svg"></img></a>
        <a href="#"><img src="https://www.svgrepo.com/show/130096/twitter.svg"></img></a>
    </Nav>
  );
}
