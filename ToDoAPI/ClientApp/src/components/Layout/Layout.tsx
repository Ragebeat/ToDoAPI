import * as React from 'react';
import { Container } from 'reactstrap';
import Header from './Header/Header';
import classess from './Layout.module.css'

export default (props: { children?: React.ReactNode }) => (
    <React.Fragment>
        <Header/>
        <Container className={classess.container}>
            {props.children}
        </Container>
    </React.Fragment>
);
