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
<style type="text/css">
.partnerimg {
		max-width: 160px;

	}
.flagimg {
	display:inline-block;
	height:22px;
	width:22px;
}
</style>
	<div class="fullWitchContent">
	
		<div class="title">PARTNERS</div>
			<h1>Youtube/Twitch partners:</h1>
		<?php

foreach($ccs as $ccid=>$cc){
	$basetemplate='<a href="'.$cc['url'].'" target="_blank"><img src="'.$cc['icon'].'" alt=""/> '.$cc['title'].'</a>'.(isset($cc['desc']) ? ' <small>'.$cc['desc'].'</small>' :'');

	//var_dump($cc);
	if($cc['type']=='twitch' && ($twitchinfo = json_decode(@file_get_contents('http://api.twitch.tv/kraken/streams?channel=' . $cc['tname']), true))!==null && !empty($twitchinfo['streams'][0]['preview']['small'])){
		echo'<table><tr>';
		echo'<td align="center" style="vertical-align: middle;">';
		echo'<img src="'.$twitchinfo['streams'][0]['preview']['small'].'" alt="" style="height:36px"/>';
		echo'</td><td>';
		echo $basetemplate;
		echo'&nbsp;<small><b style="color:red;">LIVE</b></small><br/><small>'.$twitchinfo['streams'][0]['viewers'].' viewers</small>';
		echo'</td>';
		echo'</tr></table><br/>';
	}else{
		$collect.=$basetemplate.'<br/><br/>';
	}
}
	echo $collect;
		?>
		<br/>
		<!--h1>We previously worked with teams like:</h1-->
		<table>


		<br/>
		</div>		<div class="title">How do I get partnered/sponsored?</div>
			<h1>Partnership</h1>
				<p>If you are a content creator (twitch streamer) we can promote your channel on this page and in the site's sidebar (main page) in exchange for promoting our website (csgosnaffy.com) on your channel. For more information about this contact us by <a href="http://steamcommunity.com/groups/CSGOSNAFFY">opening a ticket</a>.</p>
			<h1>Sponsorship</h1>
				<p>If you are in charge of a CS:GO team and you are interested in getting sponsored, contact us at <u>http://steamcommunity.com/groups/CSGOSNAFFY</u></p>

	 </div>
	</div>
