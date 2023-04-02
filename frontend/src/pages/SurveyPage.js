import { Helmet } from 'react-helmet-async';
// @mui
import { Grid, Button, Container, Stack, Typography, Card, TextField, InputLabel } from '@mui/material';
// components
import Iconify from '../components/iconify';
import {Quiz} from '../components/surveys/Quiz';
// ----------------------------------------------------------------------



export default function SurveyPage() {

    
  return (
    <>
      <Helmet>
        <title> Survey| Catchy </title>
      </Helmet>
        <Card>
            <Container>
                <Stack direction="row" alignItems="center" justifyContent="space-between" mb={5}>
                    
                    <Quiz/>
                    

                </Stack>
            </Container>
        </Card>
      {/* <Container>
        <Stack direction="row" alignItems="center" justifyContent="space-between" mb={5}>
          <Typography variant="h4" gutterBottom>
            Blog
          </Typography>
          <Button variant="contained" startIcon={<Iconify icon="eva:plus-fill" />}>
            New Post
          </Button>
        </Stack>

        <Stack mb={5} direction="row" alignItems="center" justifyContent="space-between">
          <BlogPostsSearch posts={POSTS} />
          <BlogPostsSort options={SORT_OPTIONS} />
        </Stack>

        <Grid container spacing={3}>
          {POSTS.map((post, index) => (
            <BlogPostCard key={post.id} post={post} index={index} />
          ))}
        </Grid>
      </Container> */}
    </>
  );
}
