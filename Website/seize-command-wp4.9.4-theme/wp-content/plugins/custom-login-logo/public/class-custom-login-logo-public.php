<?php

class Themeist_CustomLoginLogo_Public {

	private $version;

	public function __construct( $version ) {
		$this->version = $version;
	}

	public function display_login_logo() {

		$options = get_option( 'themeist_cll_settings' );

		if( $options['login_logo_url'] != "" ) {
			echo '<style type="text/css">
        	h1 a { background-image:url('.esc_url( $options["login_logo_url"] ).') !important; 	height:'.esc_attr( $options["login_logo_height"] ).'px !important; background-size: auto auto !important; width: auto !important;}
        		</style>';
    	}
    }

	public function login_logo_title( $title ) {
		return get_bloginfo( 'name' );
	}

	public function login_logo_url( $url ) {
		return home_url();
	}

}