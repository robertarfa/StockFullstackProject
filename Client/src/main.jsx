import { StrictMode } from 'react';
import { createRoot } from 'react-dom/client';

import { ThemeProvider, createTheme } from '@mui/material/styles';
import CssBaseline from '@mui/material/CssBaseline';
const theme = createTheme();

import Create from './pages/Customer/Create';
import './index.css';

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <Create />
    </ThemeProvider>
  </StrictMode>
);
