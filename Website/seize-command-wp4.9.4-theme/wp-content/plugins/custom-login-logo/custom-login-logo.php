<?php
/*
 * Plugin Name:       Custom Login Logo
 * Plugin URI:        https://themeist.com/#utm_source=wp-plugin&utm_medium=mailchimp-for-wp&utm_campaign=plugins-page
 * Description:       Add a custom logo to the WordPress login page.
 * Version:           1.1.1
 * Author:            Themeist, Harish Chouhan
 * Author URI:        https://themeist.com/
 * Author Email:      hello@dreamsmedia.in
 * Text Domain:       custom-login-logo-locale
 * License:           GPL-3.0
 * License URI:       http://www.gnu.org/licenses/gpl-3.0.txt
 * Domain Path:       /languages
 */

if ( ! defined( 'WPINC' ) ) {
	die;
}

define( 'THEMEIST_CLL_VERSION', '1.1.1' );

require_once plugin_dir_path( __FILE__ ) . 'includes/class-custom-login-logo.php';

function run_themeist_custom_login_logo() {

	$spmm = new Themeist_CustomLoginLogo();
	$spmm->run();

}

run_themeist_custom_login_logo();