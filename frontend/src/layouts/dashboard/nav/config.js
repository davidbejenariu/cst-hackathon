// component
import SvgColor from '../../../components/svg-color';

// ----------------------------------------------------------------------

const icon = (name) => <SvgColor src={`/assets/icons/navbar/${name}.svg`} sx={{ width: 1, height: 1 }} />;

const navConfig = [
  {
    title: 'home',
    path: '/home',
    icon: icon('ic_home'),
  },
  {
    title: 'profile',
    path: '/profile',
    icon: icon('ic_user'),
  },
  {
    title: 'my offers',
    path: '/my-offers',
    icon: icon('ic_cart'),
  },
  {
    title: 'leaderboard',
    path: '/leaderboard',
    icon: icon('ic_analytics'),
  },
  {
    title: 'log out',
    path: '/login',
    icon: icon('ic_lock'),
  },
  // {
  //   title: 'Not found',
  //   path: '/404',
  //   icon: icon('ic_disabled'),
  // },
];

export default navConfig;
