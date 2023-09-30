import logo from './logo.svg';
import './App.scss';
import Header from './components/Header/Header';
import Footer from './components/Footer/Footer';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Products from './pages/Products/Products';
import About from './pages/About/About';
import Cart from './pages/Cart/Cart';
import ProductDetails from './pages/ProductDetails/ProductDetails';

function App() {
  return (
    <div className="App">
      <Header />
      <main id="main" style={{ paddingBottom: 2.5 + 'rem', flex: "1 0 auto" }}>
        <BrowserRouter>
          <Routes>
            <Route path="/" Component={Products}>
            </Route>
            <Route path="/products" Component={Products}>
            </Route>
            <Route path="/about" Component={About}>
            </Route>
            <Route path="/cart" Component={Cart}>
            </Route>
            <Route path="/products/:id" Component={ProductDetails} >
            </Route>
          </Routes>
        </BrowserRouter>
      </main>
      <Footer />
    </div>
  );
}

export default App;
