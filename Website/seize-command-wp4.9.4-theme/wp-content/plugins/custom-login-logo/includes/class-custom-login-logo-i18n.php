<?php

class Themeist_CustomLoginLogo_i18n {

	public function load_plugin_textdomain() {
		load_plugin_textdomain(
			'plugin-slug',
			false,
			dirname( dirname( plugin_basename( __FILE__ ) ) ) . '/languages/'
		);
	}
}