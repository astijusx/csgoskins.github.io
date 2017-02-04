<?php
$secured=true;
require 'include/config.php';
require 'include/functions.php';
require 'steamauth/steamauth.php';
if(isset($_SESSION['steamid'])) {
	require 'steamauth/userInfo.php'; //To access the $steamprofile array
}

$mysql=@new mysqli($db['host'],$db['user'],$db['pass'],$db['name']);

if($mysql->connect_errno)
{
	die('Database connection could not be established. Error number: '.$mysql->connect_errno);
}

require 'include/headerb.php';

?>
	
	<style>
		html,body {
			overflow:auto;
		}
	</style>
	<div class="fullWitchContent">
	 <div class="title">ABOUT</div>
<b><br/>How it works:</b><br/>
The higher your deposit is in the pool percentage-wise, the higher chances of winning it all!<br/>
<br/>
<b><br/>Getting started:</b><br/>
1. You should have been prompted to enter your Steam Trade URL with signing in. If not, click on your steam icon to set it<br/>
2. Send a trade offer to "[csgosnaffy.com] BOT #1" by clicking the "deposit" button and send the skins you want to play with<br/>
3. Your skins will be deposited in the pool within 10-30 seconds and a winner will be drawn 75 seconds after 2 players (or more) joined the game<br/>
4. If you won, you will receive a trade offer from the bot after the round. If not, better luck next time!<br/>
<b>Note:</b> It usually takes no more than 5 minutes to receive an offer, but there are times when steam servers are really slow and it can take up to several hours to receive the trade offer with your winnings.<br/>

<b><br/>5% More Winnings!</b><br/>
All you have to do is add "csgosnaffy.com" in your steam name and relog.<br/>
You will get a 5% bonus to your jackpot winnings! <br/>
<br/>
<b><br/>How do I know this is legit?</b><br/>
We can prove each of our games. After each game, a series of information will be displayed about the round draw. <br/>
You will be provided the: winning percentage, round hash and round secret to validate each round.<br/>
To check the round, visit: http://csgosnaffy.com/provablyfair.php<br/>
<br/>
<b><br/>A fair website!</b><br/>
We do our best to provide top notch service to our players. We ensure that you will ALWAYS get your own deposit back if you win, on top of other skins you've won.<br/>
<del style="color:gray;">If you win a round with over 85% chance, you will not get taxed by our commission!</del>
</div><br/>
	
	<div class="fullWitchContent">
	 <div class="title">ABOUT</div>
<b><br/>Q: What can I deposit?</b><br/>
A: Most CS:GO Skins are accepted. Souvenirs are not unless otherwise stated and items that do not have a price on SteamAnalyst. If we cannot price your item the offer gets declined.<br/>
<br/>
<b><br/>Q: Is my information safe/private?</b><br/>
A: Logging on to our website is as simple as connecting with Steam. We only save the public information that is available on steam (your username, avatar, and profile url). Steam does not provide us with any personal information such as your password. Jackpot logs will never be distributed in any form.<br/>
*Your public steam info will be public.<br/>
<br/>
<b><br/>Q: I won a Jackpot but didn't get an offer! What do I do?</b><br/>
A: Generally you will get your offer within 5 minutes. If not, check steamstat.us and see if steam is normal. <br/>
If Steam is normal, After 12 hours, Create a Support ticket and we will get to you within 3-5 business days. You will not lose your items.<br/>
<br/>
<b><br/>Q: Why was my offer not accepted?</b><br/>
A: You can deposit up to 10 items MAX, with a combined value of $0.5 MIN.<br/>
<br/>
<b><br/>Q: How long do I have to accept my winning?</b><br/>
A: You have 3 guarenteed hours until it's cancelled. This is to ensure accessability to the bot for all players. Submit a ticket afterwards.<br/>
<br/>
<b><br/>Q: Why do I not get all my winnings?</b><br/>
A: We take 10% commission (5% with csgosnaffy.com in your Steam name) for server upkeep monthly, promotions, sponsorships and many more throughout the CS:GO Community.<br/>
<br/>
<b><br/>Q: How can I contact you for sponsorship/partnering?</b><br/>
A: Check the steam group here: http://steamcommunity.com/groups/CSGOSNAFFY <br/>
<br/>
Best of luck with your Yolos !<br/>
-CSGOBacon Team
</div>

</div>
