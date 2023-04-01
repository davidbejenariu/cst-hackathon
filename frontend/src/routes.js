import { Navigate, useRoutes } from 'react-router-dom';
// layouts
import NavBar from './layouts/dashboard/NavBar';
import SimpleLayout from './layouts/simple';
//
import BlogPage from './pages/BlogPage';
import LeaderboardPage from './pages/LeaderboardPage';
import LoginPage from './pages/LoginPage';
import Page404 from './pages/Page404';
import ProductsPage from './pages/Offers';
import HomePage from './pages/HomePage';
import Profile from './pages/ProfilePage';
import RegisterPage from './pages/RegisterPage';
import TryHorizontal from './pages/TryHorizontal'

// ----------------------------------------------------------------------

export default function Router() {
  const routes = useRoutes([

    {
      path: '/',
      element: <NavBar/>,
      children: [
        { element: <Navigate to="/home" />, index: true },
        { path: 'home', element: <HomePage /> },
        { path: 'profile', element: <Profile /> },
        { path: 'my-offers', element: <ProductsPage /> },
        { path: 'blog-page', element: <BlogPage /> },
        { path: 'leaderboard', element: <LeaderboardPage /> }
      ],
    },
    {
      path: 'login',
      element: <LoginPage />,
    },{
      path: 'register',
      element: <RegisterPage />,
    },
    {
      path: 'hori',
      element: <TryHorizontal />,
    },
    {
      element: <SimpleLayout />,
      children: [
        { element: <Navigate to="/home" />, index: true },
        { path: '404', element: <Page404 /> },
        { path: '*', element: <Navigate to="/404" /> },
      ],
    },
    {
      path: '*',
      element: <Navigate to="/404" replace />,
    },
  ]);

  return routes;
}
