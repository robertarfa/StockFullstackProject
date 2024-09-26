import { Button } from '@mui/material';
import SendIcon from '@mui/icons-material/Send';
import React, { useState } from 'react';
import FormWrapper from '../../../components/FormWrapper/index';
import { Customer } from '../../../entities/customer/Customer';
import ICustomerRepository from '../../../repositories/ICustomerRepository';
import { Address } from '../../../entities/address/Address';
import { ICreateCustomerRequestDto } from '../../../UseCase/Customer/Create/CreateCustomerDTO';
import { CreateCustomerController } from '../../../UseCase/Customer/Create/CreateCustomerController';
// import { CreateCustomerUseCase } from '../../../UseCase/Customer/Create/CreateCustomerUseCase';

// import './style.scss';

interface CreateProps {
  handleSubmit: (customer: Customer) => void;
}

const Create: React.FC<CreateProps> = ({ handleSubmit }) => {
  // Estado para armazenar os dados do formulário
  const initialCustomerState: ICreateCustomerRequestDto = {
    name: '',
    phoneNumber: '',
    active: true,
    address: {
      city: '',
      street: '',
      number: 0,
      complement: '',
      postalCode: '',
    },
  };
  const [customer, setCustomer] =
    useState<ICreateCustomerRequestDto>(initialCustomerState);

  // Função para lidar com a mudança nos campos de input
  const handleChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>
  ) => {
    const { name, value } = e.target;

    // Lógica para atualizar propriedades aninhadas
    setCustomer((prevCustomer) => {
      const [parentKey, ...childKeys] = name.split('.'); // Separa as chaves pai e filho

      if (childKeys.length > 0) {
        // Se houver chaves filho (propriedade aninhada)
        return {
          ...prevCustomer,
          [parentKey]: {
            ...prevCustomer[parentKey], // Mantém os outros valores do objeto pai
            [childKeys.join('.')]: value, // Atualiza a propriedade aninhada
          },
        };
      } else {
        // Se não for uma propriedade aninhada, atualiza normalmente
        return {
          ...prevCustomer,
          [name]: value,
        };
      }
    });
  };

  // Função para lidar com o submit do formulário
  const handleFormSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    console.log('logs customer', customer);

    try {
      //const user: User = new UserAccount('Murphy', 1);
      const customerData = new CreateCustomerController();
      await customerData.create(customer);

      console.log('Customer created successfully!');

      setCustomer(initialCustomerState);
    } catch (error) {
      // Handle errors (e.g., display an error message)
      console.error('Error creating customer:', error);
      // You can display an error message to the user here
    }
  };

  return (
    <FormWrapper>
      <form
        className='form'
        data-testid='customer-form'
        onSubmit={handleFormSubmit}
      >
        <h2 className='h2'>Cadastrar Usuário</h2>
        <div className='inputCheckbox'>
          <label htmlFor='active'>Ativo:</label>
          <input
            type='checkbox'
            id='active'
            name='active'
            checked={customer.active} // Corrigido: acessando customer.active
            onChange={handleChange}
          />
        </div>
        <div className='inputContainer'>
          <label htmlFor='name'>Nome:</label>
          <input
            type='text'
            id='name'
            name='name' // Corrigido: removido o "_"
            value={customer.name} // Corrigido: acessando customer.name
            onChange={handleChange}
            required
          />
        </div>

        <div className='inputContainer'>
          <label htmlFor='phoneNumber'>Celular:</label>
          <input
            type='text'
            id='phoneNumber'
            name='phoneNumber' // Corrigido: removido o "_"
            value={customer.phoneNumber} // Corrigido: acessando customer.phoneNumber
            onChange={handleChange}
            required
          />
        </div>

        <h3 className='h3'>Endereço</h3>

        <div className='inputContainer'>
          <label htmlFor='cep'>Cep:</label>
          <input
            type='text'
            id='postalCode'
            name='address.postalCode' // Ajustado para acessar a propriedade aninhada
            value={customer.address.postalCode} // Ajustado para acessar a propriedade aninhada
            onChange={handleChange}
            required
          />
        </div>

        <div className='inputContainer'>
          <label htmlFor='city'>Cidade:</label>
          <input
            type='text'
            id='city'
            name='address.city' // Ajustado para acessar a propriedade aninhada
            value={customer.address.city} // Ajustado para acessar a propriedade aninhada
            onChange={handleChange}
            required
          />
        </div>

        <div className='inputContainer'>
          <label htmlFor='street'>Rua:</label>
          <input
            type='text'
            id='street'
            name='address.street' // Ajustado para acessar a propriedade aninhada
            value={customer.address.street} // Ajustado para acessar a propriedade aninhada
            onChange={handleChange}
            required
          />
        </div>

        <div className='inputContainer'>
          <label htmlFor='number'>Número:</label>
          <input
            type='text'
            id='number'
            name='address.number' // Ajustado para acessar a propriedade aninhada
            value={customer.address.number} // Ajustado para acessar a propriedade aninhada
            onChange={handleChange}
            required
          />
        </div>

        <div className='inputContainer'>
          <label htmlFor='complement'>Complemento:</label>
          <input
            type='text'
            id='complement'
            name='address.complement' // Ajustado para acessar a propriedade aninhada
            value={customer.address.complement} // Ajustado para acessar a propriedade aninhada
            onChange={handleChange}
          />
        </div>

        <Button
          className='button'
          color='inherit'
          variant='contained'
          type='submit'
          endIcon={<SendIcon />}
        >
          Enviar
        </Button>
      </form>
    </FormWrapper>
  );
};

export default Create;
