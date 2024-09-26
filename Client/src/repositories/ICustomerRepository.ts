import { Customer } from '../entities/customer/Customer';
import { ICreateCustomerRequestDto } from '../UseCase/Customer/Create/CreateCustomerDTO';

export default interface ICustomerRepository {
  get(id: string): Promise<Customer>;
  getByPhone(phoneNumber: string): Promise<Customer>;
  create(data: ICreateCustomerRequestDto): Promise<void>;
  update(data: Customer): Promise<void>;
}
