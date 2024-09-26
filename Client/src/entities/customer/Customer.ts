import { Address } from '../address/Address';

export class Customer {
  constructor(
    private _name: string,
    private _phoneNumber: string,
    private _active: boolean,
    private _address: Address,
    private readonly _id?: string
  ) {
    this.validate();
  }

  get name(): string {
    return this._name;
  }

  get phoneNumber(): string {
    return this._phoneNumber;
  }

  get getAddress(): Address {
    return this._address;
  }

  validate() {
    // if (this._id.length === 0) {
    //   throw new Error("Id is required");
    // }
    if (this._name.length === 0) {
      throw new Error('Name is required');
    }

    if (this._phoneNumber.length === 0) {
      throw new Error('PhoneNumber is required');
    }
    if (this._address === undefined) {
      throw new Error('Address is required');
    }
  }

  changeName(name: string) {
    this._name = name;
    this.validate();
  }

  changeAddress(address: Address) {
    this._address = address;
  }

  isActive(): boolean {
    return this._active;
  }

  activate() {
    if (this._address === undefined) {
      throw new Error('Address is mandatory to activate a customer');
    }
    this._active = true;
  }

  deactivate() {
    this._active = false;
  }

  set Address(address: Address) {
    this._address = address;
  }
}
