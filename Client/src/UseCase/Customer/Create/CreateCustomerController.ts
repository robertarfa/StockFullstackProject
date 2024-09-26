import { Customer } from '../../../entities/customer/Customer';
import ICustomerRepository from '../../../repositories/ICustomerRepository';
import { ICreateCustomerRequestDto } from './CreateCustomerDTO';

export class CreateCustomerController implements ICustomerRepository {
  async get(id: string): Promise<Customer> {
    const response = await fetch(`/api/customers/${id}`);
    const data = await response.json();
    return data;
  }

  async getByPhone(phoneNumber: string): Promise<Customer> {
    const response = await fetch(
      `https://localhost:7200/api/customer/${phoneNumber}`
    );
    const data = await response.json();
    return data;
  }

  async create(data: ICreateCustomerRequestDto): Promise<void> {
    const response = await fetch('https://localhost:7200/api/Customer', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(data),
    });
    console.log('logs createCustomer', response);
    // ... lidar com a resposta
  }

  async update(data: Customer): Promise<void> {
    const response = await fetch('/api/customer/update', {
      method: 'PUT',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(data),
    });
    console.log('logs createCustomer', response);
    // ... lidar com a resposta
  }
}
