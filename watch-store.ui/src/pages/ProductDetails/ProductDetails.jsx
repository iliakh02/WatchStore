import { useEffect, useState } from "react";
import "./ProductDetails.scss";
import { useParams } from "react-router-dom";
import ProductService from "../../services/ProductService";

const ProductDetails = () => {
    const [product, setProduct] = useState();
    const { id } = useParams();
    useEffect(() => {
        const fetchData = async () => {
            const productService = new ProductService();
            const product = await productService.getProductById(id);
            setProduct(product);
            console.log(product);
        };
        fetchData();
    });

    return (
        <div className="container">
            <div className="product-details">
                <h1 className="title">{product?.name}</h1>
                <img src={product?.imgUrl} alt="" />
                <div className="product-about">
                    <div className="stars">* * * * *</div>
                    <p className="price">{product?.price} грн</p>
                    <div className="product-buttons">
                        <a href="/" className="btn back-to-shopping">Back to shopping</a>
                        <a className="btn buy">Buy</a>
                    </div>
                </div>
                <p className="description">
                    {product?.description}
                </p>
            </div>
        </div>
    );
}

export default ProductDetails;