import { Injectable } from '@angular/core';
import axios from 'axios';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  private apiUrl = 'http://localhost:5094/api/orders';

  constructor() { }

  getOrders() {
    return axios.get(this.apiUrl);
  }

  getOrderById(id: string) {
    return axios.get(`${this.apiUrl}/${id}`);
  }

  addOrder(order: any) {
    return axios.post(this.apiUrl, order);
  }
}
