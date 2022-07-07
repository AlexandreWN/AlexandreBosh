import React from "react";

import { Container } from '../../styles/GlobalStyles';
import { Title } from './styled';

export default function Login() {
    return (
        <>
            <Container>
                <Title isRed>
                    Login
                    <small>Lorem ipsum dolor sit amet, consectetur adipiscing
                    elit. Ut ultricies leo et urna fringilla, tempus dictum est gravida.</small>
                </Title>
                <p>Pellentesque facilisis tempus lobortis.</p>
            </Container>
        </>
    );
 };