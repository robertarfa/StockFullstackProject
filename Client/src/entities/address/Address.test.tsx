import { describe, expect, it } from 'vitest';
import { Address } from './Address';

describe('Address', () => {
  it('should create an address object with valid input', () => {
    const address = new Address(
      'São Paulo',
      'Rua Vergueiro',
      1,
      'Apt. 101',
      '01513-000'
    );

    // expect(address.id).toBe('123');
    // expect(address.customerId).toBe(1);
    expect(address.city).toBe('São Paulo');
    expect(address.street).toBe('Rua Vergueiro');
    expect(address.number).toBe(1);
    expect(address.complement).toBe('Apt. 101');
    expect(address.cep).toBe('01513-000');
  });

  it('should validate a valid address', () => {
    const address = new Address(
      'São Paulo',
      'Rua Vergueiro',
      1,
      'Apt. 101',
      '01513-000'
    );

    expect(() => Address.validate(address)).not.toThrow();
  });

  // it('should throw an error when customerId is missing', () => {
  //   const address = new Address(
  //     '123',
  //     undefined,
  //     'São Paulo',
  //     'Rua Vergueiro',
  //     123,
  //     'Apt. 101',
  //     '01513-000'
  //   );

  //   expect(() => Address.validate(address)).toThrow('CustomerId is required');
  // });

  it('should throw an error when city is missing', () => {
    const address = new Address(
      '',
      'Rua Vergueiro',
      1,
      'Apt. 101',
      '01513-000'
    );

    expect(() => Address.validate(address)).toThrow('City is required');
  });

  it('should throw an error when street is missing', () => {
    const address = new Address('São Paulo', '', 1, 'Apt. 101', '01513-000');

    expect(() => Address.validate(address)).toThrow('Street is required');
  });

  it('should throw an error when number is missing', () => {
    const address = new Address(
      'São Paulo',
      'Rua Vergueiro',
      undefined,
      'Apt. 101',
      '01513-000'
    );

    expect(() => Address.validate(address)).toThrow('Number is required');
  });

  it('should throw an error when cep is missing', () => {
    const address = new Address(
      'São Paulo',
      'Rua Vergueiro',
      1,
      'Apt. 101',
      ''
    );

    expect(() => Address.validate(address)).toThrow('Cep is required');
  });
});
