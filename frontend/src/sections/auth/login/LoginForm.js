import axios from "axios";
import { useState } from "react";
import { useNavigate } from "react-router-dom";
// @mui
import {
  Link,
  Stack,
  IconButton,
  InputAdornment,
  TextField,
  Checkbox,
} from "@mui/material";
import { LoadingButton } from "@mui/lab";
// components
import Iconify from "../../../components/iconify";
import useForm from "../../../hooks/useForm";

// ----------------------------------------------------------------------
const getFreshModelObject = () => ({ 
  email: "",
  password: "",
});


export default function LoginForm() {
  const navigate = useNavigate();

  const [showPassword, setShowPassword] = useState(false);
  const{
    values,
    setValues,
    errors,
    setErrors,
    handleInputChange} = useForm(getFreshModelObject);
    
  const handleClick = () => {
    navigate("/home", { replace: true });
  };

  const login = async (e) => {
    e.preventDefault();
    if(validate()){
      console.log("login");
      await axios.post('https://localhost:7068/api/auth/login', values)
      .then(res => {console.log(res)}, handleClick())
      .catch(err => console.error( "error while logging in",err));
    }
    console.log(values);
  }

  const validate = () => {
    const temp = {};
    temp.email = values.email ? "" : "This field is required.";
    temp.password = values.password ? "" : "This field is required.";
    setErrors({
      ...temp,
    });
    return Object.values(temp).every((x) => x === "");
  };


  return (
    <>
        <form noValidate autoComplete="off" onSubmit={login}>
      <Stack spacing={3}>
          <TextField name="email" label="Email address" 
          variant="outlined"
          value={values.email}
          onChange = {handleInputChange}
          {...(errors.email && { error: true, helperText: errors.email })}
          />

          <TextField
            name="password"
            label="Password"
            type={showPassword ? "text" : "password"}
            variant="outlined"
            value={values.password}
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
            }}
          />
          </Stack>

      <Stack
        direction="row"
        alignItems="center"
        justifyContent="space-between"
        sx={{ my: 2 }}
      >
        {/* <Checkbox name="remember" label="Remember me">
          Remeber me
        </Checkbox> */}
        <Link variant="subtitle2" underline="hover" style={{ allign: "right" }}>
          Forgot password?
        </Link>
      </Stack>

      <LoadingButton
        fullWidth
        size="large"
        type="submit"
        variant="contained"
        
      >
        Login
      </LoadingButton>
      
      </form>
    </>
  );
}
