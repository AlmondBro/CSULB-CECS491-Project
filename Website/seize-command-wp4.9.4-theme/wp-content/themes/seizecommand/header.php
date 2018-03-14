<?php
/**
 * The header for our theme
 *
 * This is the template that displays all of the <head> section and everything up until <div id="content">
 *
 * @link https://developer.wordpress.org/themes/basics/template-files/#template-partials
 *
 * @package seizecommand
 */

?>
<!doctype html>
<html <?php language_attributes(); ?>>
<head>
	<meta charset="<?php bloginfo( 'charset' ); ?>">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="profile" href="http://gmpg.org/xfn/11">


    <meta name="viewport" content="width='device-width', initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Seize Command</title>
    <link rel="stylesheet" href="<?php echo get_template_directory_uri(); ?>/css/bootstrap-grid.css"/>
    <link href="https://fonts.googleapis.com/css?family=Aldrich" rel="stylesheet"> 
    <link rel="stylesheet" href="<?php echo get_template_directory_uri(); ?>/css/style.css" />
	
	<?php wp_head(); ?>
</head>

<body <?php body_class(); ?>>
<div id="page" class="site">
	<a class="skip-link screen-reader-text" href="#content"><?php esc_html_e( 'Skip to content', 'seizecommand' ); ?></a>

	<div class="container-fluid">
        <nav id="nav" class="blue-to-black-gradient">
            <ul>
                <input type="checkbox" class="checkbox-hack" id="menu-toggle">
                <label id="nav-menu-icon-label" for="menu-toggle">
                <div class="nav-menu-icon">
                    <div class="bar1"></div>
                    <div class="bar2"></div>
                    <div class="bar3"></div>
                </div>    
                </label>
                <a class="mobile-menu-title" href="index.html">
                    <p>Seize Command</p>
                    <img src="<?php echo get_template_directory_uri(); ?>/media/img/Seize CommandLogo-only.svg" class="img-responsive" alt="Seize Command Logo" />
                </a>
                
                <li><a href="#"><p class="nav-item-textOnly">Leaderboard</p>&nbsp;<span class="nav-li-icon"><i class="fas fa-list-ol"></i></span></a></li>
                <li><a href="download.html"><p class="nav-item-textOnly">Download</p>&nbsp;<span class="nav-li-icon"><i class="fas fa-arrow-alt-circle-down"></i></span></a></li>
                <li><a href="manual.html"><p class="nav-item-textOnly">Manual</p>&nbsp;<span class="nav-li-icon"><i class="fas fa-book"></i></span></a></li>
                <li id="navLogo-li">
                    <a href="index.html">
                        <img src="<?php echo get_template_directory_uri(); ?>/media/img/SeizeCommandLogo4.svg" title="Seize Command Logo" alt="Seize Command Logo" id="nav-logo"/>
                    </a>
                </li>
                <li><a href="development.html"><p class="nav-item-textOnly">Development</p>&nbsp;<span class="nav-li-icon"><i class="fas fa-code-branch"></i></span></a></li>
                <li><a href="#"><p class="nav-item-textOnly">Gallery</p>&nbsp;<span class="nav-li-icon"><i class="fas fa-image"></i></span></a></li>
                <li><a href="#"><p class="nav-item-textOnly">Account</p>&nbsp;<span class="nav-li-icon"><i class="fas fa-user-circle"></i>&nbsp;<i class="fas fa-caret-down"></i></span></a></li>
            </ul>
        </nav>
    </div> <!-- /.container-fluid  -->

	<div id="content" class="site-content">
