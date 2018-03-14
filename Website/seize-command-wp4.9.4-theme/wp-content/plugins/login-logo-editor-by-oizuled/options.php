<div class="wrap">
	<div class="postbox">
		<h2><?php _e('Login Logo Options', 'login_translate'); ?></h2>
		<form method='post' action='options.php'>
			<?php wp_nonce_field( 'update-options' ); ?>
			<?php settings_fields( 'oizuled-login-logo-option-group' ); ?>
			<table class="form-table">
				<tr valign="top">
					<th scope="row"><strong><?php _e('Enter a URL or upload an image to use for your login logo', 'login_translate'); ?></strong>.</th>
					<td>
						<label for="upload_image">
							<input id="upload_image" type="text" size="36" name="oizuled-login-logo-img" value="<?php echo get_option('oizuled-login-logo-img'); ?>" /> 
							<input id="upload_image_button" class="button" type="button" value="<?php _e('Upload Image', 'login_translate'); ?>" />
						</label>
					</td>
				</tr>
				<tr valign="top">
					<th scope="row"><strong><?php _e('Enter the URL of you would like the login logo to point to.', 'login_translate'); ?></strong><br /><?php _e('By default it points to', 'login_translate'); ?> <a href="http://wordpress.org" target="_blank">WordPress.org</a></th>
					<td><input type="text" size="36" name="oizuled-login-logo-link" value="<?php echo get_option('oizuled-login-logo-link'); ?>" />
				</tr>
				<tr valign="top">
					<th scope="row"><strong><?php _e('Enter the text to display when you hover your mouse over the login logo.', 'login_translate'); ?></strong><br /><?php _e('By default it says "Powered by WordPress".', 'login_translate'); ?></th>
					<td><input type="text" size="36" name="oizuled-login-logo-title" value="<?php echo get_option('oizuled-login-logo-title'); ?>" />
				</tr>
				<tr valign="top">
					<th scope="row"><strong><?php _e('Enter custom CSS for the login screen.', 'login_translate'); ?></strong><br /><?php _e('If you are not familiar with CSS, you can leave this blank.', 'login_translate'); ?>
					<ul>
						<li><a href="http://codex.wordpress.org/Customizing_the_Login_Form#Styling_Your_Login" target="_blank"><?php _e('CSS options can be found by clicking here.', 'login_translate'); ?></a></li>
					</ul>
					</th>
					<td><textarea rows="10" cols="36" name="oizuled-login-logo-css"><?php echo get_option('oizuled-login-logo-css'); ?></textarea>
				</tr>
				<tr valign="top">
					<td colspan="2"><input type="hidden" name="action" value="update" /><?php submit_button(); ?></td>
				</tr>
			</table>
		</form>
		<?php
		$oizuledlogo = get_option('oizuled-login-logo-img');
		$oizuledlink = get_option('oizuled-login-logo-link');
		$oizuledtitle = get_option('oizuled-login-logo-title');
		$oizuledcss = get_option('oizuled-login-logo-css');
		if(!empty($oizuledlogo)) { ?>
			<p><?php _e('How your login logo image looks:', 'login_translate'); ?></p>
			<a href="<?php if (!empty($oizuledlink)) { echo $oizuledlink; } else { echo "#"; } ?>">
				<img src="<?php echo $oizuledlogo; ?>" title="<?php if (!empty($oizuledtitle)) { echo $oizuledtitle; } else { echo ""; } ?>" />
			</a>	
		<?php } ?>
	</div>
	<div class="postbox">
		<p><?php _e('If this plugin has helped you out at all, please consider making a donation to encourage future updates.', 'login_translate'); ?><br /><?php _e('Your generosity is appreciated!', 'login_translate'); ?></p>
			<a href="#" onclick="window.open('https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=VQMNHMR86QKNY');">
				<img alt="" border="0" src="https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif" width="147" height="47">
			</a>
		<p><?php _e('To report any issues with ', 'login_translate'); ?><strong><?php _e('this plugin', 'login_translate'); ?></strong><?php _e(', please visit the', 'login_translate'); ?> <a href="http://wordpress.org/support/plugin/login-logo-editor-by-oizuled"><?php _e('support page on WordPress.org', 'login_translate'); ?></a>.</p>
		<p><?php _e('For all other WordPress support, please check out the following', 'login_translate'); ?> <a href="https://surpriseazwebservices.com/services/wordpress-site-install/"><?php _e('site set-up', 'login_translate'); ?></a>, <a href="https://surpriseazwebservices.com/services/wordpress-maintenance-support/"><?php _e('24x7 support', 'login_translate'); ?></a><?php _e(', and other', 'login_translate'); ?> <a href="https://surpriseazwebservices.com/services/"><?php _e('WordPress training', 'login_translate'); ?></a> <?php _e('services', 'login_translate'); ?>.</p>
		<p><a href="https://twitter.com/SurpriseWebSvc" class="twitter-follow-button" data-show-count="false" data-lang="en">Follow @SurpriseWebSvc</a>
<script>!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0];if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src="//platform.twitter.com/widgets.js";fjs.parentNode.insertBefore(js,fjs);}}(document,"script","twitter-wjs");</script></p>
	</div>
</div>