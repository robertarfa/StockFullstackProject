import React from 'react';
import { render, screen, fireEvent, waitFor } from '@testing-library/react';
import { describe, expect, it, vi } from 'vitest'; // Importe recursos do Vitest
import Create from '.';

describe('Create Component', () => {
  it('renders form', async () => {
    render(<Create handleSubmit={vi.fn()} />);

    // Verifica se os elementos do formulário são renderizados
    expect(screen.getByText('Cadastrar Usuário')).toBeTruthy();
    expect(screen.getByLabelText('Nome:')).toBeTruthy();
    expect(screen.getByLabelText('Celular:')).toBeTruthy();
    expect(screen.getByLabelText('Ativo:')).toBeTruthy();
    expect(screen.getByLabelText('Cidade:')).toBeTruthy();
    expect(screen.getByLabelText('Rua:')).toBeTruthy();
    expect(screen.getByLabelText('Número:')).toBeTruthy();
    expect(screen.getByLabelText('Complemento:')).toBeTruthy();
    // expect(screen.getByText('Enviar')).toBeTruthy();
  });

  // it('handles form submission', async () => {
  //   const mockSubmit = vi.fn();

  //   render(<Create handleSubmit={mockSubmit} />);

  //   const nameInput = screen.getByLabelText('Nome:') as HTMLInputElement;
  //   const phoneNumberInput = screen.getByLabelText(
  //     'Celular:'
  //   ) as HTMLInputElement;
  //   const activeCheckbox = screen.getByLabelText('Ativo:') as HTMLInputElement;
  //   const cepInput = screen.getByLabelText('Cep:') as HTMLInputElement;
  //   const cityInput = screen.getByLabelText('Cidade:') as HTMLInputElement;
  //   const streetInput = screen.getByLabelText('Rua:') as HTMLInputElement;
  //   const numberInput = screen.getByLabelText('Número:') as HTMLInputElement;
  //   const complementInput = screen.getByLabelText(
  //     'Complemento:'
  //   ) as HTMLInputElement;

  //   fireEvent.change(nameInput, { target: { value: 'John Doe' } });
  //   fireEvent.change(phoneNumberInput, { target: { value: '1234567890' } });
  //   fireEvent.click(activeCheckbox);
  //   fireEvent.change(cepInput, { target: { value: '00000000' } });
  //   fireEvent.change(cityInput, { target: { value: 'São Paulo' } });
  //   fireEvent.change(streetInput, { target: { value: 'Rua Teste' } });
  //   fireEvent.change(numberInput, { target: { value: '123' } });
  //   fireEvent.change(complementInput, { target: { value: 'Apto 45' } });

  //   // const form = screen.getByTestId('customer-form'); // Encontra o formulário pelo data-testid
  //   // Simula o envio do formulário
  //   const submitButton = screen.getByText('Enviar') as HTMLButtonElement;
  //   fireEvent.click(submitButton);

  //   await waitFor(() => expect(mockSubmit).toHaveBeenCalledTimes(1));

  //   expect(mockSubmit).toHaveBeenCalledWith({
  //     id: '',
  //     name: 'John Doe',
  // phoneNumber: '1234567890',
  // active: true,
  // address: {
  //   id: '',
  //   customerId: 0,
  //   city: 'São Paulo',
  //   street: 'Rua Teste',
  //   number: 123,
  //   complement: 'Apto 45',
  //   cep: '00000000',
  // },
  // });

  // // screen.debug();
  // });
});
