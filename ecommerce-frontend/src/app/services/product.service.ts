import { Injectable } from '@angular/core';
import axios from 'axios';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private apiUrl = 'http://localhost:5146/api/products';

  constructor() { }

  getProducts() {
    return axios.get(this.apiUrl);
  }

  getProductById(id: string) {
    return axios.get(`${this.apiUrl}/${id}`);
  }

  addProduct(product: any) {
    return axios.post(this.apiUrl, product);
  }

  updateProduct(id: string, product: any) {
    return axios.put(`${this.apiUrl}/${id}`, product);
  }

  deleteProduct(id: string) {
    return axios.put(`${this.apiUrl}/${id}`);
  }
}
