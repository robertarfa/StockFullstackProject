export class Address {
  constructor(
    private _city: string,
    private _street: string,
    private _number: number,
    private _complement: string,
    private _postalCode: string,
    private readonly _id?: string
  ) {}

  // get id(): string {
  //   return this._id;
  // }

  // get customerId(): number {
  //   return this._customerId;
  // }
  get city(): string {
    return this._city;
  }
  get street(): string {
    return this._street;
  }
  get number(): number {
    return this._number;
  }

  get complement(): string {
    return this._complement;
  }

  get cep(): string {
    return this._postalCode;
  }

  static validate(address: Address) {
    // if (
    //   address._customerId === null ||
    //   address._customerId === undefined ||
    //   address._customerId === 0
    // ) {
    //   throw new Error('CustomerId is required');
    // }
    if (address._city.length === 0) {
      throw new Error('City is required');
    }
    if (
      address._number === null ||
      address._number === undefined ||
      address._number === 0
    ) {
      throw new Error('Number is required');
    }
    if (address._street.length === 0) {
      throw new Error('Street is required');
    }
    if (
      address._postalCode?.length === 0 ||
      address._postalCode === null ||
      address._postalCode === undefined
    ) {
      throw new Error('Cep is required');
    }
  }
}
