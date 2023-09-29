import "./ProductDetails.scss";

const ProductDetails = () => {
    const product = {
        id: 5,
        name: "Modern Stainless Steel Watch",
        img: "https://www-konga-com-res.cloudinary.com/w_400,f_auto,fl_lossy,dpr_3.0,q_auto/media/catalog/product/U/O/92910_1666897463.jpg",
        price: 1690.99,
        rate: 3,
        description: "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Alias quo, fugiat officiis voluptatum saepe ex! Dolorem quisquam labore quos reprehenderit iusto quidem ipsam repudiandae odio, molestias temporibus dignissimos voluptates quibusdam officia debitis necessitatibus sequi neque at eos explicabo modi ea obcaecati. Illo voluptates ut odio nihil similique aspernatur a culpa, dolorem adipisci, sapiente vel iusto temporibus mollitia doloremque tempore, quisquam veniam. Temporibus debitis cumque, nulla officia nam nisi velit odit. Quae nostrum harum exercitationem consequuntur! Laboriosam aliquam odio suscipit beatae velit autem reiciendis temporibus error dolorem. Rerum quod voluptatem deserunt quos nobis."
    };

    return (
        <div className="container">
            <div className="product-details">
                <h1 className="title">{product.name}</h1>
                <img src={product.img} alt="" />
                <div className="product-about">
                    <div className="stars">* * * * *</div>
                    <p className="price">{product.price} грн</p>
                    <div className="product-buttons">
                        <a href="/" className="btn back-to-shopping">Back to shopping</a>
                        <a className="btn buy">Buy</a>
                    </div>
                </div>
                <p className="description">
                    {product.description}
                </p>
            </div>
        </div>
    );
}

export default ProductDetails;