// import { Address } from '../../../entities/address/Address';
// import { Customer } from '../../../entities/customer/Customer';
// import ICustomerRepository from '../../../repositories/ICustomerRepository';
// import { ICreateCustomerRequestDto } from './CreateCustomerDTO';

// export class CreateCustomerUseCase {
//   constructor(private customerRepository: ICustomerRepository) {}

//   async execute(data: ICreateCustomerRequestDto) {
//     const customerAlreadyExists = await this.customerRepository.getByPhone(
//       data.phoneNumber
//     );

//     if (customerAlreadyExists) {
//       throw new Error('Customer already exists.');
//     }

//     const customer = new Customer(
//       data.name,
//       data.phoneNumber,
//       data.active,
//       (data.address = new Address(
//         data.address.city,
//         data.address.street,
//         data.address.number,
//         data.address.cep,
//         data.address.complement || ''
//       ))
//     );

//     await this.customerRepository.create(customer);
//   }
// }
