
import axios from 'axios';
import { useState } from 'react';
import { useNavigate } from 'react-router-dom';

// @mui
import { Link, Stack, IconButton, InputAdornment, TextField, Checkbox } from '@mui/material';
import { LoadingButton } from '@mui/lab';

import { ENDPOINTS, createAPIEndpoint } from '../../../api/index';
// components
import Iconify from '../../../components/iconify';
import useForm from "../../../hooks/useForm";


// ----------------------------------------------------------------------
const getFreshModelObject = () => ({
  firstName: "",
  lastName: "",
  email: "",
  password: "",
});

export default function RegisterForm() {
  const navigate = useNavigate();
  const {
    values, 
    setValues, 
    errors, 
    setErrors, 
    handleInputChange} = useForm(getFreshModelObject);
  const [showPassword, setShowPassword] = useState(false);
  
  
  const handleClick = () => {
    navigate('/login', { replace: true });
  };
  
  const register = async (e) => {
    e.preventDefault();
    const tempvalue = {};
    if (validate()) {
      console.log("register");
      tempvalue.firstName = values.firstName
      tempvalue.lastName = values.lastName 
      tempvalue.email = values.email 
      tempvalue.password = values.password
    
      // createAPIEndpoint(ENDPOINTS.Auth.Register).post(tempvalue)
      await axios.post('https://localhost:7068/api/auth/register', tempvalue)
      .then(res => {console.log(res)})
      .catch(err => console.error( "error while registering",err));
      handleClick();
    }
    console.log(tempvalue);
  };

  const validate = () => {
    const temp = {};
    temp.firstName = values.firstName ? "" : "This field is required.";
    temp.lastName = values.lastName ? "" : "This field is required.";
    temp.email = values.email ? "" : "This field is required.";
    temp.password = values.password ? "" : "This field is required.";
    // temp.repeatPassword = values.repeatPassword ? "" : "This field is required.";
    setErrors({
      ...temp,
    });
    return Object.values(temp).every((x) => x === "");
  };

  return (
    <>
    <form noValidate autoComplete="off" onSubmit={register}>
      <Stack spacing={3}>
        <TextField name="firstName" label="First name" variant='outlined' 
        value ={values.firstName} 
        onChange = {handleInputChange} 
        {...(errors.firstName && { error: true, helperText: errors.firstName })}
        />
        <TextField name="lastName" label="Last name"
        value ={values.lastName}
        onChange = {handleInputChange}
        {...(errors.lastName && { error: true, helperText: errors.lastName })}

        />
        <TextField name="email" label="Email address" 
        value={values.email}
        onChange = {handleInputChange}
        {...(errors.email && { error: true, helperText: errors.email })}

        />
        <TextField name="password" label="Password"
        type={showPassword ? "text" : "password"}
        value ={values.password} 
        onChange = {handleInputChange}
        {...(errors.password && { error: true, helperText: errors.password })}
        InputProps={{
          endAdornment: (
            <InputAdornment position="end">
              <IconButton
                onClick={() => setShowPassword(!showPassword)}
                edge="end"
              >
                <Iconify
                  icon={showPassword ? "eva:eye-fill" : "eva:eye-off-fill"}
                />
              </IconButton>
            </InputAdornment>
          ),
        }}/>
        <TextField name="repeatPassword" label="Repeat Password"
        value={values.repeatPassword}
        onChange = {handleInputChange}
        {...(errors.repeatPassword && { error: true, helperText: errors.repeatPassword })}

        />
      </Stack>

      <LoadingButton fullWidth size="large" type="submit" variant="contained" 
      // onClick={handleClick}    
      sx={{ my: 5 }}>
        Register
      </LoadingButton>
      </form>
    </>
  );
}

