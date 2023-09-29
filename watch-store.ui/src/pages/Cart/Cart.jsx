import CartItem from "../../components/CartItem/CartItem";
import "./Cart.scss";

const Cart = () => {
    const items = [
        {
            id: 1,
            name: "Modern Stainless Steel Watch",
            img: "https://www-konga-com-res.cloudinary.com/w_400,f_auto,fl_lossy,dpr_3.0,q_auto/media/catalog/product/U/O/92910_1666897463.jpg",
            price: 1690.99,
            amount: 2
        },
        {
            id: 1,
            name: "Luxury Rose Gold Watch",
            img: "https://www.linjer.co/cdn/shop/products/linjer-classic-watch-38-gunmetal-tan-1-front_grande.jpg?v=1602577160",
            price: 1290.99,
            amount: 2
        }
    ];
    return (
        <div className="container">
            <h1>Cart</h1>
            <div className="products-list">
                {items.map((item, index) => {
                    return (<CartItem item={item} key={index} />);
                })}
            </div>
            <div className="cart-control">
                <a className="btn" href="/products">Continue shopping</a>

                <a className="btn">Buy</a>
            </div>
        </div>
    );
}

export default Cart;