import './Header.scss';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faMagnifyingGlass, faCartShopping } from '@fortawesome/free-solid-svg-icons';

const Header = () => {
    return (
        <header id="header">
            <div className="container">
                <div className="header-content-wrapper">
                    <div className="site-logo">
                        <a href="/" className="logo-text">WatchStore</a>
                    </div>
                    <div className="navigation">
                        <ul className="nav">
                            <li className="nav-item">
                                <a href="/" className="nav-link">Головна</a>
                            </li>
                            <li className="nav-item">
                                <a href="/products" className="nav-link">Продукти</a>
                            </li>
                            <li className="nav-item">
                                <a href="/about" className="nav-link">Про сайт</a>
                            </li>
                        </ul>
                    </div>

                    <div className="site-links">
                        <div className="search">
                            <a href="">
                                <FontAwesomeIcon icon={faMagnifyingGlass} />
                            </a>
                        </div>
                        <a href="/cart" className="cart">
                            <FontAwesomeIcon icon={faCartShopping} />
                        </a>
                    </div>
                </div>
            </div>
        </header>
    );
}

export default Header;