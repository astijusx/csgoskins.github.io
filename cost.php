<?php
$secured=true;
require 'include/config.php';
require 'include/functions.php';

if(!isset($_GET['pw']) || empty($_GET['pw']) || $_GET['pw']!=$accesspassword){
	die('unauthorized');
}

$mysql=@new mysqli($db['host'],$db['user'],$db['pass'],$db['name']);

if($mysql->connect_errno)
{
	die('Database connection could not be established. Error number: '.$mysql->connect_errno);
}

$item=str_replace(array(' ','"','\'','\\\'','\\'),array('%20',null,null,null,null),$_GET['item']);

$result=$mysql->query('SELECT * FROM `items` WHERE `name`="'.$mysql->real_escape_string($_GET['item']).'"')->fetch_assoc();

if(!empty($result)) { //259200=3 days
        if(time()-$result["lastupdate"] < 259200) exit($result["cost"]);
}

$link = "http://steamcommunity.com/market/priceoverview/?currency=1&appid=730&market_hash_name=".$item;
$string = @file_get_contents($link);
if(!$string){
	die('notfound');
}
$json = $string;
 
$obj = json_decode($json);
//print $obj->{"median_price"}; // 12345
//$obj = json_decode($string);
if($obj->{'success'} == "0") exit("notfound");

$median_price = $obj->{'median_price'};
$median_price=str_replace("$", "", $median_price);
$median_price = (float)($median_price);

$lowest_price = $obj->{'lowest_price'};
$lowest_price=str_replace("$", "", $lowest_price);
$lowest_price = (float)($lowest_price);

if($median_price<$lowest_price){
	$pricetodb=$median_price;
}else{
	$pricetodb=$lowest_price;
}

if(!empty($result)){
	$mysql->query('UPDATE `items` SET `cost`="'.$pricetodb.'", `lastupdate`="'.time().'" WHERE `name`="'.$mysql->real_escape_string($_GET['item']).'"');
}else{
	$mysql->query('INSERT INTO `items` SET `cost`="'.$pricetodb.'", `lastupdate`="'.time().'", `name`="'.$mysql->real_escape_string($_GET['item']).'"');
}

echo $lowest_price;