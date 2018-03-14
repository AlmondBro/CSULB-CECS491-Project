<?php

class Themeist_CustomLoginLogo {

	protected $loader;

	protected $plugin_slug;

	protected $version;

	public function __construct() {


		if ( defined( 'THEMEIST_CLL_VERSION' ) ) {
			$this->version = THEMEIST_CLL_VERSION;
		} else {
			$this->version = '1.0.0';
		}
		$this->plugin_slug = 'custom-login-logo';

		$this->load_dependencies();
		$this->set_locale();
		$this->define_admin_hooks();
		$this->define_public_hooks();

	}

	private function load_dependencies() {

		require_once plugin_dir_path( dirname( __FILE__ ) ) . 'includes/class-custom-login-logo-loader.php';
		require_once plugin_dir_path( dirname( __FILE__ ) ) . 'includes/class-custom-login-logo-i18n.php';
		require_once plugin_dir_path( dirname( __FILE__ ) ) . 'admin/class-custom-login-logo-admin.php';
		require_once plugin_dir_path( dirname( __FILE__ ) ) . 'public/class-custom-login-logo-public.php';

		$this->loader = new Themeist_CustomLoginLogo_Loader();

	}

	private function set_locale() {
		$plugin_i18n = new Themeist_CustomLoginLogo_i18n();
		$this->loader->add_action( 'plugins_loaded', $plugin_i18n, 'load_plugin_textdomain' );
	}

	private function define_admin_hooks() {

		$admin = new Themeist_CustomLoginLogo_Admin( $this->get_version() );
		$this->loader->add_action( 'admin_menu', $admin, 'admin_menu' );
		$this->loader->add_action( 'admin_init', $admin, 'themeist_cll_settings' );
		$this->loader->add_action( 'admin_enqueue_scripts', $admin, 'enqueue_scripts' );
		$this->loader->add_action( 'admin_enqueue_scripts', $admin, 'enqueue_styles' );

	}

	private function define_public_hooks() {

		$public = new Themeist_CustomLoginLogo_Public( $this->get_version() );
		$this->loader->add_action( 'login_head', $public, 'display_login_logo' );
		$this->loader->add_filter( 'login_headertitle', $public, 'login_logo_title' );
		$this->loader->add_filter( 'login_headerurl', $public, 'login_logo_url' );

	}

	public function run() {
		$this->loader->run();
	}

	public function get_version() {
		return $this->version;
	}

}