export interface ICreateCustomerRequestDto {
  name: string;
  phoneNumber: string;
  active: boolean;
  address: {
    city: string;
    street: string;
    number: number;
    complement?: string;
    postalCode: string;
  };
  [key: string]: any;
}
