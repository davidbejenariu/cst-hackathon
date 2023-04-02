import { useState } from 'react';
// @mui
import { alpha } from '@mui/material/styles';
import {  Grid, Button, CardActionArea, CardActions, Card, Container, Box, Divider, Typography, Stack, MenuItem, Avatar, IconButton, Popover } from '@mui/material';
import { ProgressBar } from 'react-bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Tooltip from '@mui/material/Tooltip';

// mocks_
import account from '../../../_mock/account';
import SurveyLogo from '../../../images/Icons/580745-200.png'
import QuizLogo from '../../../images/Icons/3524335.png'
import StreakLogo from '../../../images/Icons/fire_10.png'


// ----------------------------------------------------------------------

const MENU_OPTIONS = [
  {
    label: 'Home',
    icon: 'eva:home-fill',
  },
  {
    label: 'Profile',
    icon: 'eva:person-fill',
  },
  {
    label: 'Settings',
    icon: 'eva:settings-2-fill',
  },
];

// ----------------------------------------------------------------------

export default function AccountPopover() {
  const [open, setOpen] = useState(null);
  const percentage = 77;
  const handleOpen = (event) => {
    setOpen(event.currentTarget);
  };

  const handleClose = () => {
    setOpen(null);
  };

  return (
    <>
    <Tooltip title="User Info">
      <IconButton
        onClick={handleOpen}
        sx={{
          p: 0,
          ...(open && {
            '&:before': {
              zIndex: 1,
              content: "''",
              width: '100%',
              height: '100%',
              borderRadius: '50%',
              position: 'absolute',
              bgcolor: (theme) => alpha(theme.palette.grey[900], 0.8),
            },
          }),
        }}
      >
        <Avatar src={account.photoURL} alt="photoURL" />
      </IconButton>
      </Tooltip>
      <Popover

        

        open={Boolean(open)}
        anchorEl={open}
        onClose={handleClose}
        anchorOrigin={{ vertical: 'bottom', horizontal: 'right' }}
        transformOrigin={{ vertical: 'top', horizontal: 'right' }}
        PaperProps={{
          sx: {
            p: 0,
            mt: 1.5,
            ml: 0.75,
            width: 180,
            '& .MuiMenuItem-root': {
              typography: 'body2',
              borderRadius: 0.75,
            },
          },
        }}
      >

        <Box sx={{ my: 1.5, px: 2.5 , marginBottom:-1}}>
          <Typography variant="subtitle2" noWrap style={{textAlign: 'center'}}>
            {account.displayName}
          </Typography>
          <Typography variant="body2" sx={{ color: 'text.secondary' }} noWrap style={{textAlign: 'center', fontSize: '0.6rem'}}>
            {account.email}
          </Typography>
        </Box>

        <Grid container style={{display: 'flex', flexDirection: 'row' }}>
          <Grid item >
            <div style={{width: '1.25rem', height: '1.25rem', paddingTop:'1.0rem', marginLeft: '0.5rem'}}>
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
          <Grid item>
            <div className="progressBar" style={{marginBottom:'2rem', marginLeft:'2.0rem', marginRight: '0.5rem'}}>
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
                
                <Typography style={{alignContent:'center', fontSize: '0.6rem'}}>
                  Congrats, you did {percentage}% of your monthly streak!
                </Typography>
            </div>
          </Grid>
        </Grid>

        <Divider sx={{ borderStyle: 'dashed' }} />
        <div style={{display: 'flex', flexDirection: 'row', alignContent:'center', marginLeft:'2rem', marginTop:'-1.8rem'}}>
          <img src = {SurveyLogo} alt='img' style = {{width:'2.0rem', height:'2.0rem'}}/>
          <p style={{marginTop:'0.2rem'}}>2 surveys</p>
        </div>
        <Divider sx={{ borderStyle: 'dashed' }} />
        <div style={{display: 'flex', flexDirection: 'row', alignContent:'center', marginLeft:'2rem'}}>
          <img src = {QuizLogo} alt='img' style = {{width:'2.0rem', height:'2.0rem'}}/>
          <p style={{marginTop:'0.2rem'}}>4 quizzes</p>
        </div>
        <Divider sx={{ borderStyle: 'dashed' }} />
        <div style={{display: 'flex', flexDirection: 'row', alignContent:'center', marginLeft:'2rem'}}>
          <img src = {StreakLogo} alt='img' style = {{width:'2.0rem', height:'2.0rem'}}/>
          <p style={{marginTop:'0.2rem'}}>5 days streak</p>
        </div>
        <Divider sx={{ borderStyle: 'dashed' }} />

      </Popover>
    </>
  );
}
