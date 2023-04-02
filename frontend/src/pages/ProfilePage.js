import { Helmet } from "react-helmet-async";
import { useTheme } from "@mui/material/styles";
import { useNavigate } from 'react-router-dom';
import {
  Container,
  Grid,
  Card,
  CardHeader,
  CardContent,
  Stack,
  TextField,
  Typography,
} from "@mui/material";
import { LoadingButton } from "@mui/lab";
// components
import Iconify from "../components/iconify";
// sections
import { AppWidgetSummary } from "../sections/@dashboard/app";

export default function ProfilePage() {
  const theme = useTheme();
  const navigate = useNavigate();
  const handleClick = () => {
    navigate('/my-offers', { replace: true });
  };
  return (
    <>
      <Helmet>
        <title> Profile | Catchy </title>
      </Helmet>

      <Container maxWidth="xl">
        <Typography variant="h4" sx={{ mb: 5 }}>
          Profile
        </Typography>

        <Grid container spacing={3}>
          <Grid item xs={12} md={6} lg={8}>
            <Card>
              <CardHeader title="Your Information" />
              <CardContent>
                <Stack spacing={3}>
                  <TextField
                    fullWidth
                    label="First Name"
                    name="firstname"
                    value="Katarina"
                    // variant="outlined"
                  />
                  <TextField
                    fullWidth
                    label="Last Name"
                    name="lastname"
                    value="Smith"
                    // variant="outlined"
                  />
                  <TextField
                    fullWidth
                    label="Email Address"
                    name="email"
                    value="katrinasmith@gmail.com"
                  />
                  <TextField
                    fullWidth
                    label="Phone Number"
                    name="email"
                    value="555-0129"
                  />
                </Stack>
              </CardContent>
            </Card>
            <LoadingButton
              style = {{marginTop: "20px"}}
              fullWidth
              size="large"
              type="submit"
              variant="contained"
              onClick={handleClick}
            >
              My offers
            </LoadingButton>
          </Grid>
        </Grid>
      </Container>
    </>
  );
}
