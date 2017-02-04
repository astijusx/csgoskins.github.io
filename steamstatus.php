<?php
$secured=true;
require_once 'include/config.php';
require_once 'include/functions.php';

if(!isset($_GET['pw']) || empty($_GET['pw']) || $_GET['pw']!=$accesspassword){
	die('unauthorized');
}

$url='http://crowbar.steamdb.info/Barney';
$get=disguise_curl($url);

$response=json_decode($get);

if($response->success=='true'){
	echo'<table style="float:right;color:gray;">';
	if(!empty($response->psa) && preg_match('/down|offline/i', $response->psa) && !preg_match('/bot/i', $response->psa)){
		//echo'<tr><td colspan="2">'.$response->psa.'</td></tr>';
		//echo'<tr><td colspan="2"><b>Steam is down.</b></td></tr>';
	}

	echo'<tr><td>inventories:</td><td align="right" style="padding-left:15px;'.(($response->services->csgo_community->status=='major')?'color:red':'').'">'.(($response->services->csgo_community->title=='Unknown') ? 'API Offline' : $response->services->csgo_community->title).'</td></tr>';
	echo'<tr><td>community:</td><td align="right" style="padding-left:15px;'.(($response->services->community->status=='major')?'color:red':'').'">'.(preg_match('/normal/i',$response->services->community->title) ? 'Normal' : $response->services->community->title).'</td></tr>';
	echo'<tr><td>store:</td><td align="right" style="padding-left:15px;'.(($response->services->store->status=='major')?'color:red':'').'">'.$response->services->store->title.'</td></tr>';
	echo'<tr><td colspan="2" align="right"><small style="color:lightgray;">stats by <a href="http://steamstat.us/" target="_blank" style="color:lightgray !important;text-decoration:underline;">steamstat.us</a></small></td></tr>';
	echo'</table>';
}
//var_dump($response);

/*if($response->services->store->status=='major' || $response->services->community->status=='major' || $response->services->csgo_community->status=='major'){
	echo'<center><b>WARNING!</b><br/>Steam servers are experiencing issues at the moment! Your offers may be delayed or not go through at all!<br/><br/>';
	echo'Steam store: '.$response->services->store->title.'<br/>';
	echo'Steam community: '.$response->services->community->title.'<br/>';
	echo'CS:GO inventories: '.$response->services->csgo_community->title.'<br/>';
	echo'</center>';
}else{*/