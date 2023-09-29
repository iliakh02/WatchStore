import './Product.scss';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faCartPlus } from '@fortawesome/free-solid-svg-icons';

const Product = (props) => {
    return (
        <div className="product card" key={props.product.id}>
            <img src={props.product.img} alt={props.product.name} />
            <a href={"/products/" + props.product.id} className="title">{props.product.name}</a>
            <p className="price">{props.product.price} грн</p>
            <a href="" className="buy"><FontAwesomeIcon icon={faCartPlus} /></a>
        </div>
    );
}

export default Product;