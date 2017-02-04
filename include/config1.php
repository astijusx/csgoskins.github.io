<?php
if(!isset($secured)){ die('Not authorized.'); }

//** LANGUAGE **//
$lang=array('en','ro');
if(isset($_COOKIE['lang']) && !empty($_COOKIE['lang']) && in_array($_COOKIE['lang'],$lang)){
	$langpath=$_COOKIE['lang'];
}else{
	$langpath='en';
}
require 'include/lang/'.$langpath.'.php';

$accesspassword='hshshfsfssfafsa'; //set this up in bot_source as well, for accessing /cost.php, /endgame.php

//** DATABASE **//
$db=array( //mysql credentials
			'host'		=>		'localhost',
			'user'		=>		'root',
			'pass'		=>		'zakaz791',
			'name'		=>		'1v1',
	);


//** SITE DETAILS (URL/NAME/DESCRIPTION) **//
$site=array(
		'url'			=>			'luckyskin24.com',
		'static'		=>			'luckyskin24.com/static', //get a subdomain static.site.com with /static/ path to host static files like css,js,images - helps with loading times
		'name'			=>			'luckyskin24.com',
		'sitenameinusername'	=>			'luckyskin24.com', //what people need to have in their steam name to get +5% to winnings (5% comission instead of 10)
		'description'		=>			$l->description,
		'depositlink'		=>			'https://steamcommunity.com/tradeoffer/new/?partner=332022596',
		'maxitems'		=>			20, //max items in a round
		'minvalue'		=>			'3', // in $, float values supported. you need to edit this info in the bot_source as well.
		'maxbet'		=>			10, //max number of items a person can deposit in a round
		'gametime'		=>			1,
		'gamedbprefix'		=>			'z_round_',
	);

$adminslist=array(
		'76561198252982272', // people that can access /admin.php while logged in
		'76561198072212608', //
	);

header("Access-Control-Allow-Origin: ".$site['static']); //fonts from static. subdomain won't load without this

$prf=$site['gamedbprefix'];

$ccs=array( //content creators
	'76561198252982272'=>array( //facebook template
		'type'=> 'Owner',

		'title'=> 'NeoN',
		'desc'=>  'Owner of csgosnaffy.com',

		//for play sidebar
		'url'=> 'http://steamcommunity.com/id/NeoNpozarevac123',
		'icon'=> 'http://i.imgur.com/TUFFU7N.png',
	),
	'76561198072212608'=>array( //facebook template
		'type'=> 'Head-Admin',

		'title'=> 'Wolf',
		'desc'=>  'Head-Admin of csgosnaffy.com',

		//for play sidebar
		'url'=> 'http://steamcommunity.com/id/',
		'icon'=> 'http://i.imgur.com/TUFFU7N.png',
	),
	'76561198073600914'=>array( //twitch template
		'type'=> 'twitch',
		'tname'=> 'Twitch Streamer',

		//
		'title'=> '?',
		'desc'=>  'Twitch Streamer',

		//for play sidebar
		'url'=> 'http://www.twitch.tv/',
		'icon'=> 'http://i.imgur.com/xup9Jyr.png',
	),
	'76561198088099694'=>array( //twitch template
		'type'=> 'twitch',
		'tname'=> '?',

		//
		'title'=> '?',
		'desc'=>  '',

		//for play sidebar
		'url'=> 'http://twitch.tv/?',
		'icon'=> 'http://i.imgur.com/xup9Jyr.png',
	),
	
);


//dev
$allowips=array( //if you only want to allow certain ips to access the site (kinda like a developer mode), uncomment the line under this
	'127.0.0.1', //server
	'', //ads

	);
if(!in_array($_SERVER['http_CF_CONNECTING_IP'], $allowips)){
	//die('Coming soon...');

}