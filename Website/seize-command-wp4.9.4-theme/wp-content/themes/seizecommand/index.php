<?php
/**
 * The main template file
 *
 * This is the most generic template file in a WordPress theme
 * and one of the two required files for a theme (the other being style.css).
 * It is used to display a page when nothing more specific matches a query.
 * E.g., it puts together the home page when no home.php file exists.
 *
 * @link https://developer.wordpress.org/themes/basics/template-hierarchy/
 *
 * @package seizecommand
 */

get_header();
?>
<main class="container">
    <img src="https://www.universetoday.com/wp-content/uploads/2010/08/Horsehead-Nebula-at-the-Orion-Credit-Copyright-Adam-Block-Mt.-Lemmon-SkyCenter-U.-Arizona1.jpg" class="img-responsive"/>
    <section class="sectionRow">
        <h1 class="sectionHeader blue-to-black-gradient">What Is Seize Command?</h1>
        <p class="sectionRowText">&emsp; Seize Command is a top down multiplayer space game which encourages players to use communication and teamwork in order to upgrade their ship and eventually overcome the enemy.  In order to improve, players will need to risk leaving the safety of their ship and board the enemy to either take control or salvage parts to improve their own vessel.
        <br><br>
        &emsp; The intent of this project is to introduce a unique mix of exciting gameplay elements never before seen in the space sim industry while providing a nostalgic feel for veteran players of the genre.
        </p>
    </section>

    <section class="sectionRow">
        <h1 class="sectionHeader blue-to-black-gradient">Features</h1>
        <p class="sectionRowText">
                A variety of features which will be implemented include but are not limited to:
                <ul class="features-list">
                    <li>Intuitive User Interface </li>
                    <li>Multi-Player Support</li>
                    <li>Animations and Sound Effects</li>
                    <li>Particle Systems and Special Effects</li>
                </ul>
        </p>
    </section>

    <section class="sectionRow">
        <h1 class="sectionHeader blue-to-black-gradient">Gallery</h1>
        <div class="row no-gutter">
            <div class="col-md-4">
                <img src="https://www.universetoday.com/wp-content/uploads/2010/08/Horsehead-Nebula-at-the-Orion-Credit-Copyright-Adam-Block-Mt.-Lemmon-SkyCenter-U.-Arizona1.jpg" class="img-responsive"/>      
            </div>   
            <div class="col-md-4">
                <img src="https://www.universetoday.com/wp-content/uploads/2010/08/Horsehead-Nebula-at-the-Orion-Credit-Copyright-Adam-Block-Mt.-Lemmon-SkyCenter-U.-Arizona1.jpg" class="img-responsive"/>      
            </div>  
            <div class="col-md-4">
                <img src="https://www.universetoday.com/wp-content/uploads/2010/08/Horsehead-Nebula-at-the-Orion-Credit-Copyright-Adam-Block-Mt.-Lemmon-SkyCenter-U.-Arizona1.jpg" class="img-responsive"/>      
            </div>  
        </div>
    </section>

    <section class="sectionRow">
        <h1 class="sectionHeader blue-to-black-gradient">Play the Game on Your Computer!</h1>
        <!-- <p class="sectionRowText"></p> -->
        <a href="Seize_Command.exe"><button class="dlButton">Download&nbsp;<i class="fas fa-download"></i></button></a>
    </section>
</main>


<?php
//get_sidebar();
get_footer();
