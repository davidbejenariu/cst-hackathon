import { Helmet } from 'react-helmet-async';
import { faker } from '@faker-js/faker';
// @mui
import { useTheme } from '@mui/material/styles';
import { Grid, Container, Typography } from '@mui/material';
import { ProgressBar } from 'react-bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';

import SurveyLogo from '../images/Icons/580745-200.png'
import QuizLogo from '../images/Icons/3524335.png'
import StreakLogo from '../images/Icons/fire_10.png'
// components
import Iconify from '../components/iconify';
// sections
import {
  AppWidgetSummary,
} from '../sections/@dashboard/app';
// ----------------------------------------------------------------------

export default function HomePage() {
  const theme = useTheme();
  const percentage = 77;
  return (
    <>
    
      <Helmet>
        <title> Home | Catchy </title>
      </Helmet>
    
      <Container maxWidth="xl">
        <Typography variant="h4" sx={{ mb: 5 }}>
          Hi, welcome back!
        </Typography>
        <Grid container style={{display: 'flex', flexDirection: 'row', width:'80vw' }}>
          <Grid item >
            <div style={{width: '1.9rem', height: '1.9rem'}}>
              {
                percentage <= 25 &&  <img src="/assets/badges/badge1.png" className="App-logo" alt="logo" />
              }
              {
                percentage >= 25 && percentage < 50 && <img src="/assets/badges/badge2.png" className="App-logo" alt="logo" />
              }
              {
                percentage >= 50 && percentage < 75 &&  <img src="/assets/badges/badge3.png" className="App-logo" alt="logo" />
              }
              {
                percentage >= 75 &&  <img src="/assets/badges/badge4.png" className="App-logo" alt="logo" />
              }
            </div>
          </Grid>
          <Grid item sm={7} md={6}>
            <div className="progressBar" style={{marginBottom:'2rem', marginLeft:'0.5rem'}}>
              {
                percentage <= 25 &&   <ProgressBar animated now={percentage} label={`${percentage}%`} min = {0} max = {100} visuallyHidden = 'false' />
              }
              {
                percentage >= 25 && percentage < 50 &&  <ProgressBar animated variant="warning" now={percentage} label={`${percentage}%`} min = {0} max = {100} visuallyHidden = 'false' />
              }
              {
                percentage >= 50 && percentage < 75 &&   <ProgressBar animated variant="danger" now={percentage} label={`${percentage}%`} min = {0} max = {100} visuallyHidden = 'false' />
              }
              {
                percentage >= 75 &&   <ProgressBar animated variant="success" now={percentage} label={`${percentage}%`} min = {0} max = {100} visuallyHidden = 'false' />
              }
                
                <Typography style={{alignContent:'center'}}>
                  Congrats, you did {percentage}% of your monthly streak!
                </Typography>
            </div>
          </Grid>
        </Grid>
       
        <Grid container spacing={3}>
          <Grid item xs={12} sm={6} md={3}>
            <AppWidgetSummary title="Surveys Completed" total={2} iconpath={SurveyLogo}  />
          </Grid>

          <Grid item xs={12} sm={6} md={3}>
            <AppWidgetSummary title="Quizez Completed" total={4} color="info" iconpath={QuizLogo} />
          </Grid>

          <Grid item xs={12} sm={6} md={3}>
            <AppWidgetSummary title="Week Streak" total={5} color="warning" iconpath={StreakLogo} />
          </Grid>
        </Grid>
      </Container>
    </>
  );
}
