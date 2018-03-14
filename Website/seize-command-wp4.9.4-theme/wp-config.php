<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the
 * installation. You don't have to use the web site, you can
 * copy this file to "wp-config.php" and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * MySQL settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://codex.wordpress.org/Editing_wp-config.php
 *
 * @package WordPress
 */

// ** MySQL settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define('DB_NAME', 'wordpress');

/** MySQL database username */
define('DB_USER', 'Nerux95');

/** MySQL database password */
define('DB_PASSWORD', 'RraogqrKxDVcwtOM');

/** MySQL hostname */
define('DB_HOST', 'localhost');

/** Database Charset to use in creating database tables. */
define('DB_CHARSET', 'utf8');

/** The Database Collate type. Don't change this if in doubt. */
define('DB_COLLATE', '');

/**#@+
 * Authentication Unique Keys and Salts.
 *
 * Change these to different unique phrases!
 * You can generate these using the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}
 * You can change these at any point in time to invalidate all existing cookies. This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define('AUTH_KEY',         '-U+M@B.)2+=qIyzO%Tz[x0I+z4^mCQ]jA::*WSnh<,h<jJKVHjP)Xa|&F_@6Q;+k');
define('SECURE_AUTH_KEY',  'ww`n||b7-MJJI_F<pF}:mR>{|Q.p87bV<&de$?)tC1fm|^{8HgSw~s^Nl#+-*!:P');
define('LOGGED_IN_KEY',    'H|.9Zgv]EtmlXJPc7)]7flgtde7ThjPI4K}YlSe3Igb|kA^H#vQPIYby%dd3eBOw');
define('NONCE_KEY',        '==niWa7KqJ)-7=i+i(<Y(#|<oh??5fK2$/]1/Zj+6bQhj:2? O5>uq?G)k.r[wr;');
define('AUTH_SALT',        ')vHpxShUY4A}*j.sAay@flsU%+Xw>$Y|OdIp++7T]|<=FQFw^jm:U1by+U5(bXRh');
define('SECURE_AUTH_SALT', 'Kok&zWxZTF9|SJGxt|~s+BiABU`4y;8.Z&ZdfbC&F7``+z@K-<Wl8!Y:y!l,LrEv');
define('LOGGED_IN_SALT',   'M%ggg9:6#&?260#u7?p#&*BDl`pkt^Fs|?W8-uX#s-++49A>)!K3o|!l|>S6CV;o');
define('NONCE_SALT',       '7;PQ+fqbwV9)p)]DD[>|W@s {`D<k<L^|9UJ`E;_p$/x2p<+d9bA{,#B|8^BuEv_');


/**#@-*/

/**
 * WordPress Database Table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix  = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the Codex.
 *
 * @link https://codex.wordpress.org/Debugging_in_WordPress
 */
define('WP_DEBUG', false);

/* That's all, stop editing! Happy blogging. */

/** Absolute path to the WordPress directory. */
if ( !defined('ABSPATH') )
	define('ABSPATH', dirname(__FILE__) . '/');

/** Sets up WordPress vars and included files. */
require_once(ABSPATH . 'wp-settings.php');
