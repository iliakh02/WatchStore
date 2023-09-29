import { useState } from "react";
import "./CartItem.scss";


const CartItem = (props) => {
    const cartItem = props.item;
    const [amount, setAmount] = useState(cartItem.amount);
    return (
        <div className="cart-item-card">
            <a className="btn delete">х</a>
            <img src={cartItem.img} alt="" />
            <a href={"/products/" + cartItem.id}><h2 className="name">{cartItem.name}</h2></a>
            <p className="price">{cartItem.price} грн</p>
            <div className="amount">
                <a className="btn decrease" onClick={() => { if (amount > 1) setAmount(amount - 1); }}>-</a>
                <input type="text" min={1} max={99} value={amount} onChange={(e) => { if (e.target.value > 0 && e.target.value < 100) setAmount(e.target.value); }} />
                <a className="btn increase" onClick={() => { if (amount < 100) setAmount(amount + 1) }}>+</a>
            </div>
            <div className="bth total-price">{cartItem.price * amount} грн</div>
        </div>
    );
}

export default CartItem;