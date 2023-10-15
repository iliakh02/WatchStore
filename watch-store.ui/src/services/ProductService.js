import axios from "axios";

class ProductService {
    constructor() {
        const domainUrl = "http://localhost:8080";
        this.baseUrl = `${domainUrl}/products`;
    }

    async getProducts() {
        const response = await axios.get(`${this.baseUrl}/`);
        const products = response.data;
        return products;
    }

    async getProductById(id) {
        const response = await axios.get(`${this.baseUrl}/${id}`);
        const product = response.data;
        return product;
    }
}

export default ProductService;