import * as React from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem } from 'reactstrap';
import { NavLink } from 'react-router-dom';
import classess from './Sidebar.module.css'

export default class Sidebar extends React.PureComponent<{}, { isOpen: boolean }> {
    public state = {
        isOpen: false
    };

    public render() {
        return (
            <div className={classess.sidebar}>
                <NavLink className={classess.navItem} activeClassName={classess.activeLink} to="/inbox">Vhodyashie</NavLink>
                <NavLink className={classess.navItem} activeClassName={classess.activeLink} to="/today">Segodnya</NavLink>
                <NavLink className={classess.navItem} activeClassName={classess.activeLink} to="/calendar">Predstoyashie</NavLink>
                <NavLink className={classess.navItem} activeClassName={classess.activeLink} to="/project">Proekti</NavLink>
                <NavLink className={classess.navItem} activeClassName={classess.activeLink} to="/mark">Metki</NavLink>
                <NavLink className={classess.navItem} activeClassName={classess.activeLink} to="/filter">Filtri</NavLink>
        </div>
        );
    }

    private toggle = () => {
        this.setState({
            isOpen: !this.state.isOpen
        });
    }
}
