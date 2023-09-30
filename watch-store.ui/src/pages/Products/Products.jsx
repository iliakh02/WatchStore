import './Products.scss';
import Product from "../../components/Product/Product";
import ProductService from "../../services/ProductService";
import { useEffect, useState } from 'react';

const Products = () => {
    const [products, setProducts] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            const productService = new ProductService();
            const productList = await productService.getProducts();
            setProducts(productList);
        };
        fetchData();
    }, []);

    return (
        <>
            <div className="carousel">
                <div className="container">
                </div>
            </div>
            <div className="recommended-products">
                <div className="container">
                    <h1 className="products-title">Recommended products:</h1>
                    <div className="products">
                        {products.map((product, index) => {
                            return (
                                <Product product={product} key={index} />
                            );
                        })}
                    </div>
                </div>
            </div>
        </>
    );
}

export default Products;