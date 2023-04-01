import { useState } from 'react';
import { useNavigate } from 'react-router-dom';
// @mui
import { Link, Stack, IconButton, InputAdornment, TextField, Checkbox } from '@mui/material';
import { LoadingButton } from '@mui/lab';
// components
import Iconify from '../../../components/iconify';

// ----------------------------------------------------------------------

export default function RegisterForm() {
  const navigate = useNavigate();

  const [showPassword, setShowPassword] = useState(false);

  const handleClick = () => {
    navigate('/home', { replace: true });
  };

  return (
    <>
      <Stack spacing={3}>
        <TextField name="firstName" label="First name" />
        <TextField name="lastName" label="Last name" />
        <TextField name="email" label="Email address" />
        <TextField name="password" label="Password"/>
        <TextField name="repeatPassword" label="Repeat Password"/>
      </Stack>

      <LoadingButton fullWidth size="large" type="submit" variant="contained" onClick={handleClick} sx={{ my: 5 }}>
        Register
      </LoadingButton>
    </>
  );
}
