import React, {useState} from "react";
import { display } from '@mui/system';
import { MdChevronLeft, MdChevronRight } from 'react-icons/md';

import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import { Button, CardActionArea, CardActions } from '@mui/material';
import { data } from '../../_mock/offers-mock';



export default function HorizontalScroll() {

  const [opacity, setOpacity] = useState("0.5")

  const sliderStyle = {
    cursor: "pointer",
    opacity: `${opacity}`
  }
  
  const offerStyle = {
    display: "inline-block",
    margin: '1rem',
    padding: "1.5rem",
    cursor: "pointer",
    width: "25rem",
    height: "30rem"
  }

  const slideLeft = () => {
    const slider = document.getElementById('sliderQuizzes');
    slider.scrollLeft -= 400;
  };

  const slideRight = () => {
    const slider = document.getElementById('sliderQuizzes');
    slider.scrollLeft += 400;
  };

  return (
    <>
      <div style = {{
        display: "flex",
        position: "relative",
        alignItems: "center",
      }} >
        <MdChevronLeft
            style = {sliderStyle}
            onClick={slideLeft} 
            onMouseEnter={() => setOpacity("1.0")}
            onMouseLeave={() => setOpacity("0.5")}
            size={40} />
        <div
          id='sliderQuizzes'
          style = {{
            width: '100%',
            height: '100%',
            overflowX: "hidden",
            whiteSpace: "nowrap",
            scrollBehavior: "smooth"
          }}
        >
          {data.map((item) => (
            <Card style = {offerStyle}>
                <CardActionArea>
                <CardMedia
                    component="img"
                    height = "220rem"
                    width = "15rem"
                    image={item.img}
                    alt="img"
                />
                <CardContent>
                    <Typography gutterBottom variant="h5" component="div">
                    Lizard
                    </Typography>
                    <Typography variant="body2" color="text.secondary">
                    Lizards are a widespread group of squamate reptiles, with over 6,000
                    species, ranging across all continents except Antarctica
                    </Typography>
                </CardContent>
                </CardActionArea>
                <CardActions>
                <Button size="small" color="primary">
                    Take the survey
                </Button>
                </CardActions>
            </Card>
          ))}
        </div>
        <MdChevronRight 
            style = {sliderStyle}
            onClick={slideRight} 
            onMouseEnter={() => setOpacity("1.0")}
            onMouseLeave={() => setOpacity("0.5")}
            size={40} />
      </div>
    </>
  );
}
