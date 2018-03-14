<?php
   /*
   Plugin Name: Login Logo Editor
   Plugin URI: https://surpriseazwebservices.com/wordpress-plugins/wordpress-login-logo-editor/
   Donate link: https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=VQMNHMR86QKNY
   Description: A plugin to change the logo displayed on the admin login screen.
   Version: 1.2.2
   Author: Scott DeLuzio
   Author URI: https://surpriseazwebservices.com
   License: GPL2
   */
   
	/*  Copyright 2013  Scott DeLuzio  (email : scott (at) surpriseazwebservices.com)

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License, version 2, as 
    published by the Free Software Foundation.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
	*/

/* Add language support */
function login_lang() {
	load_plugin_textdomain('login_translate', false, dirname(plugin_basename(__FILE__)) . '/lang/');
}
add_action('init', 'login_lang');
	
/* Settings Page */

// Hook for adding admin menus
add_action('admin_menu', 'oizuled_login_logo_add_pages');

// action function for above hook
function oizuled_login_logo_add_pages() {
    // Add a new submenu under Settings:
    add_options_page('Login Logo Options','Login Logo', 'manage_options', 'oizuledloginlogo', 'oizuled_login_logo_settings_page');
}

add_action('admin_init', 'register_oizuled_login_logo_settings');

function activate_login_logo() {
  $oizuled_wp_ver = get_bloginfo('version');
  if ($oizuled_wp_ver < 3.8) {
	add_option('oizuled-login-logo-img', plugins_url( 'wordpress-logo.png' , __FILE__));
  } else {
	add_option('oizuled-login-logo-img', plugins_url( 'w-logo-blue.png' , __FILE__));
  }
  add_option('oizuled-login-logo-link', 'http://wordpress.org');
  add_option('oizuled-login-logo-title', 'Powered by WordPress');
  add_option('oizuled-login-logo-css', '');
}

function deactive_login_logo() {
  delete_option('oizuled-login-logo-img');
  delete_option('oizuled-login-logo-link');
  delete_option('oizuled-login-logo-title');
  delete_option('oizuled-login-logo-css');
}

register_activation_hook(__FILE__, 'activate_login_logo');
register_deactivation_hook(__FILE__, 'deactive_login_logo');

function register_oizuled_login_logo_settings() {
	register_setting( 'oizuled-login-logo-option-group', 'oizuled-login-logo-img');
	register_setting( 'oizuled-login-logo-option-group', 'oizuled-login-logo-link');
	register_setting( 'oizuled-login-logo-option-group', 'oizuled-login-logo-title');
	register_setting( 'oizuled-login-logo-option-group', 'oizuled-login-logo-css');
}

// Display the page content for the login logo submenu
function oizuled_login_logo_settings_page() {
	include(WP_PLUGIN_DIR.'/login-logo-editor-by-oizuled/options.php');  
}
	
/* Reference CSS File */
function login_logo_by_oizuled() { 
	echo '<link rel="stylesheet" type="text/css" href="' . plugins_url( 'login-logo-by-oizuled.css' , __FILE__ ). '" />';
}
add_action('login_head', 'login_logo_by_oizuled');

/* Show Logo */
function oizuled_login_logo() {
if(!isset($oizuledlogo)) {
	$oizuledlogo = get_option('oizuled-login-logo-img');
}
if(!isset($oizuledcss)) {
	$oizuledcss = get_option('oizuled-login-logo-css');
}
	echo '<style type="text/css">
		h1 a { background-image:url(' . $oizuledlogo . ') !important;
		background-size: 274px 63px;}
		' . $oizuledcss . '
		</style>';
}
add_action('login_head', 'oizuled_login_logo');

add_filter('login_headerurl','oizuled_login_page_link');
function oizuled_login_page_link($url) {
if(!isset($oizuledlink)) {
	$oizuledlink = get_option('oizuled-login-logo-link');
}
	return $oizuledlink;
}

add_filter( 'login_headertitle', 'oizuled_login_logo_url_title' );
function oizuled_login_logo_url_title() {
if(!isset($oizuledtitle)) {
	$oizuledtitle = get_option('oizuled-login-logo-title');
}
    return $oizuledtitle;
}

add_action('admin_enqueue_scripts', 'oizuled_upload_script');
 
function oizuled_upload_script() {
    if (isset($_GET['page']) && $_GET['page'] == 'oizuledloginlogo') {
        wp_enqueue_media();
        wp_register_script('image-upload-js', WP_PLUGIN_URL.'/login-logo-editor-by-oizuled/image-upload.js', array('jquery'));
        wp_enqueue_script('image-upload-js');
    }
}

?>