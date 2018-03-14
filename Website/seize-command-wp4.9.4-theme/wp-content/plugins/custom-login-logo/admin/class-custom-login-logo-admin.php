<?php

class Themeist_CustomLoginLogo_Admin {

	private $version;

	public function __construct( $version ) {
		$this->version = $version;
	}

	public function admin_menu() {
		$page_title = __('Custom Login Logo', 'plugin-slug');
		$menu_title = __('Custom Login Logo', 'plugin-slug');
		$capability = 'manage_options';
		$menu_slug = 'themeist_cll';
		$function =  array( $this, 'render_options_page');
		add_options_page( $page_title, $menu_title, $capability, $menu_slug, $function );
	}

	public function enqueue_styles() {

		if (isset($_GET['page']) && $_GET['page'] == 'themeist_cll') {
			wp_enqueue_style( 'thickbox' );
		}

	}

	public function enqueue_scripts() {

		if (isset($_GET['page']) && $_GET['page'] == 'themeist_cll') {

			wp_enqueue_script( 'thickbox' );
			wp_enqueue_script( 'media-upload' );

			wp_enqueue_script(
				'custom-login-logo-admin',
				plugin_dir_url( __FILE__ ) . 'js/custom-login-logo-admin.js',
				array( 'thickbox', 'media-upload' ),
				$this->version,
				FALSE
			);
		}

	}

	public function themeist_cll_settings() {

		register_setting(
			'themeist_cll_settings',
			'themeist_cll_settings',
			array( $this, 'settings_validate' )
		);

		add_settings_section(
			'login_logo',
			__( 'Logo Settings', 'plugin-slug' ),
			array( $this, 'section_login_logo' ),
			'themeist_cll_settings'
		);

		add_settings_field(
			'login_logo_url',
			__( 'Upload Login Logo', 'plugin-slug' ),
			array( $this, 'section_login_logo_url' ),
			'themeist_cll_settings',
			'login_logo'
		);

		add_settings_field(
			'login_logo_height',
			__( 'Set Logo Height', 'plugin-slug' ),
			array( $this, 'section_login_logo_height' ),
			'themeist_cll_settings',
			'login_logo'
		);
	}

	public function section_login_logo() {

	}

	public function section_login_logo_url() {
		printf(
			'<span class="upload">
				<input type="text" id="themeist_cll_settings[login_logo_url]" class="regular-text text-upload" name="themeist_cll_settings[login_logo_url]" value="%s"/>
				<input type="button" class="button button-upload" value="' . __( 'Upload an image', 'plugin-slug' ) . '"/></br>
				<img style="max-width: 300px; display: block;" src="" class="preview-upload" />
			</span>',
			isset( $this->options['login_logo_url'] ) ? esc_url( $this->options['login_logo_url']) : ''

		);
	}

	public function section_login_logo_height() {

		printf(
			'<input type="text" id="login_logo_height" name="themeist_cll_settings[login_logo_height]" value="%s" /> px',
			isset( $this->options['login_logo_height'] ) ? esc_attr( $this->options['login_logo_height']) : ''
		);

	}

	public function settings_validate($input) {
		$new_input = array();
		if( isset( $input['login_logo_height'] ) )
			$new_input['login_logo_height'] = absint( $input['login_logo_height'] );

		if( isset( $input['login_logo_url'] ) )
			$new_input['login_logo_url'] = sanitize_text_field( $input['login_logo_url'] );

		return $new_input;
	}

	public function render_options_page() {
		$this->options = get_option( 'themeist_cll_settings' );
		require_once plugin_dir_path( __FILE__ ) . 'partials/custom-login-logo-admin-display.php';
	}

}