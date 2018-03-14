<?php 
	/* 
		Template Name: Login Page
	*/
 
	the_post();
	get_header();
?>
	<!-- TITLE BAR -->
	<div class="row mainContentTitleBar">
        <div class="col-md-12 col-lg-12">
            <h3 class="page-title"><?php the_title(); ?></h3>
        </div> <!-- /.col-md-12 col-lg-12 -->
    </div> <!-- /.mainContentTitleBar -->
	
	<div class="row login-page-body">
        <div class="col-md-12 col-lg-12">
			<?php
				if ( ! is_user_logged_in() ) { // Display WordPress login form: 
			?>
					
			<?php echo '<h4 class="alreadyAccount">
			Already have an account? Please login.
			</h4><!-- /.alreadyAccount -->'; ?>
				
			<?php } //end if-statement 
					else { // If logged in:
							echo '<h4 class="alreadyAccount">Wanna logout?</h4>';
						} //end else-statement
			?>
					
			<?php 
					/* Array keys and values to pass to wp_login_form() */
					$args = array(
						'echo'           => true,
						'remember'       => true,
						'redirect' 		 => get_permalink
											( get_page( $page_id_of_member_area ) ),
						'form_id'        => 'loginform',
						'id_username'    => 'user_login',
						'id_password'    => 'user_pass',
						'id_remember'    => 'rememberme',
						'id_submit'      => 'wp-submit',
						'label_username' => __( 'Username' ),
						'label_password' => __( 'Password' ),
						'label_remember' => __( 'Remember Me' ),
						'label_log_in'   => __( 'Log In' ),
						'value_username' => '',
						'value_remember' => false
					  ); //end $args array
	
	?>

			<?php $login  = (isset($_GET['login']) ) ? $_GET['login'] : 0; ?>

			
			<?php 
				if ( $login === "failed" ) {
					echo 
					'<div id="login-error">
						<p class="login-msg bodyText">
							<strong>ERROR:</strong> 
							Invalid username and/or password.
						</p><!-- /.login-msg bodyText" -->
					</div> <!-- /#login-error -->';
				} elseif ( $login === "empty" ) {
					echo 
					'<div id="login-error">
						<p class="login-msg">
							<strong>ERROR:</strong> 
							Username and/or Password is empty.
						</p><!-- /$login-msg bodyText" -->
					</div> <!-- /#login-error -->';
				} elseif ( $login === "false" ) {
					echo 
					'<div id="login-error">
						<p class="login-msg">
							You are logged out.
						</p>
					</div> <!-- /#login-error -->';
				}
				
				 elseif ( $login === "register" ) {
					echo 
					'<div id="login-error">
						<p class="login-msg">
							You have registered your account. Check your email.
						</p>
					</div> <!-- /#login-error -->';
				}
				
				 elseif ( $login === "lostpassword" ) {
					echo 
					'<div id="login-error">
						<p class="login-msg">
							Lost password.
						</p>
					</div> <!-- /#login-error -->';
				}
			?>

			<div class="login-form-container">
				<?php
					if ( ! is_user_logged_in() ) { // Display WordPress login form: ?>
					<?php wp_login_form( $args ); ?>
				<?php } //end if-statement 
					else { // If logged in:
							wp_loginout( home_url() ); // Display "Log Out" link.
							echo " | ";
							wp_register('', ''); // Display "Site Admin" link.
						} //end else-statement
				?>
			</div> <!-- /.login-form-container -->
			
			<div class="login-links-container">
				<!--<div class ="home-link"> 
					<a href="<?php echo home_url(); ?> ">Go to Homepage</a>
				</div> <!-- /.home-link -->
				
				<div class ="reset-link"> 
					&bull;<a href="<?php echo wp_lostpassword_url(); ?>"> Reset Password</a>
				</div> <!-- /. reset-link --> 
				
				<div class ="register-link"> 
					&bull;<a href="<?php echo wp_registration_url(); ?>"> Register</a>
				</div> <!-- /. reset-link --> 
			</div> <!-- /. login-links-container -->
			
         </div> <!-- /.col-md-12 col-lg-12 -->	
	</div> <!-- /.row login-page-body -->	
<?php get_footer() ?>