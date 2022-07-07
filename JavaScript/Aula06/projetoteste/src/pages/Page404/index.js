import React from "react";

import { Container } from '../../styles/GlobalStyles';
import { Title } from './styled';

export default function Page404(){
    return(
        <>
            <Container>
                <Title isRed>
                ERROR 404
                    <small>Page route not found</small>
                </Title>
            </Container>
        </>
    );
}