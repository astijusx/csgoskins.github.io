<?php
$secured=true;
require 'include/config.php';
require 'include/functions.php';
require 'steamauth/steamauth.php';

$l=$_GET['lang'];
if(in_array($l,$lang))
	setcookie('lang',$l,time()+60*60*60*24*365);
else
	setcookie('lang_error','1',time()+60*60*60*24*365);

header('Location:'.$site['url']);