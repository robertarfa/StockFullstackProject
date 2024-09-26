import { describe, expect, it } from 'vitest';
import { Customer } from './Customer';
import { Address } from '../address/Address';

describe('Customer unit tests', () => {
  it('should throw error when name is empty', () => {
    expect(() => {
      let customer = new Customer(
        '',
        '11999998888',
        true,
        new Address('São Paulo', 'Rua Vergueiro', 1, 'Apt. 101', '01513-000')
      );
      customer.validate();
    }).toThrowError('Name is required');
  });

  it('should throw error when phoneNumber is empty', () => {
    expect(() => {
      let customer = new Customer(
        'Nome',
        '',
        true,
        new Address('São Paulo', 'Rua Vergueiro', 1, 'Apt. 101', '01513-000')
      );
      customer.validate();
    }).toThrowError('PhoneNumber is required');
  });

  it('should throw error when address is undefined', () => {
    expect(() => {
      let customer = new Customer('Nome', '11999998888', true, undefined);
      customer.validate();
    }).toThrowError('Address is required');
  });

  it('should change name', () => {
    const customer = new Customer(
      'John',
      '11999998888',
      true,
      new Address('São Paulo', 'Rua Vergueiro', 1, 'Apt. 101', '01513-000')
    );
    customer.changeName('Jane Doe');
    expect(customer.name).toBe('Jane Doe');
  });

  it('should change address', () => {
    const customer = new Customer(
      'Name',
      '11999998888',
      true,
      new Address('São Paulo', 'Rua Vergueiro', 1, 'Apt. 101', '01513-000')
    );
    const newAddress = new Address(
      'New City',
      'New Street',
      2,
      'New State',
      'New Zip'
    );
    customer.changeAddress(newAddress);
    expect(customer.getAddress).toBe(newAddress);
  });

  it('should activate customer', () => {
    const customer = new Customer(
      'Nome',
      '11999998888',
      true,
      new Address('São Paulo', 'Rua Vergueiro', 1, 'Apt. 101', '01513-000')
    );
    customer.activate();
    expect(customer.isActive()).toBe(true);
  });

  it('should throw error when address is undefined when activating customer', () => {
    expect(() => {
      const customer = new Customer('Nome', '11999998888', true, undefined);
      customer.activate();
    }).toThrowError('Address is required');
  });

  it('should deactivate customer', () => {
    const customer = new Customer(
      'Nome',
      '11999998888',
      false,
      new Address('São Paulo', 'Rua Vergueiro', 1, 'Apt. 101', '01513-000')
    );
    customer.activate();
    customer.deactivate();
    expect(customer.isActive()).toBe(false);
  });
});
