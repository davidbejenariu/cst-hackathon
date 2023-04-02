import PropTypes from 'prop-types';
import { forwardRef } from 'react';
import { Link as RouterLink } from 'react-router-dom';
// @mui
import { useTheme } from '@mui/material/styles';
import { Box, Link, Typography } from '@mui/material';
import { fontSize } from '@mui/system';
import LogoEarth from '../../images/logo.png'


// ----------------------------------------------------------------------

const Logo = forwardRef(({ disabledLink = false, sx, ...other }, ref) => {
  const theme = useTheme();


  // OR using local (public folder)
  // -------------------------------------------------------
  const logo = (
    <Box
      component="img"
      src={LogoEarth}
      sx={{ width: 50, height: 50, cursor: 'pointer', ...sx }}
    />
  );

  

  if (disabledLink) {
    return <>{logo}</>;
  }

  return (
    <>
    <Link to="/" component={RouterLink} sx={{ display: 'contents' }}>
      {logo}
    </Link>
      <Typography style = {{
        marginLeft: '1rem',
        marginTop: '0.4rem',
        fontSize: '1.8rem'
      }}>
        Catchy
      </Typography>
    </>
  );
});

Logo.propTypes = {
  sx: PropTypes.object,
  disabledLink: PropTypes.bool,
};

export default Logo;
