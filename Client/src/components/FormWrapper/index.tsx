import React from 'react';
import './style.scss';

interface FormularioProps<T> {
  children: React.ReactNode;
}

const FormWrapper = <T extends object>({ children }: FormularioProps<T>) => {
  return <div className='form'>{children}</div>;
};

export default FormWrapper;
