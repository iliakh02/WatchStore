import './Products.scss';
import Product from "../../components/Product/Product";

const Products = () => {
    const products = [
        {
            id: 1,
            name: "Classic Silver Watch",
            img: "https://m.media-amazon.com/images/I/71VjM5LOeYL._AC_UY780_.jpg",
            price: 999.99,
        },
        {
            id: 1,
            name: "Elegant Gold Watch",
            img: "data:image/webp;base64,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",
            price: 1490.99,
        },
        {
            id: 1,
            name: "Sporty Black Watch",
            img: "https://www.boat-lifestyle.com/cdn/shop/products/main-image-3_e934902f-345b-4cc4-80b9-9ef3d77a1f34.png?v=1661272676",
            price: 790.99,
        },
        {
            id: 1,
            name: "Luxury Rose Gold Watch",
            img: "https://www.linjer.co/cdn/shop/products/linjer-classic-watch-38-gunmetal-tan-1-front_grande.jpg?v=1602577160",
            price: 1290.99,
        },
        {
            id: 1,
            name: "Modern Stainless Steel Watch",
            img: "https://www-konga-com-res.cloudinary.com/w_400,f_auto,fl_lossy,dpr_3.0,q_auto/media/catalog/product/U/O/92910_1666897463.jpg",
            price: 1690.99,
        }
    ];
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