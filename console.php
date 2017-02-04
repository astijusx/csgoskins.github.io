<?php
$secured=true;
require 'include/config.php';
require 'include/functions.php';

if(!isset($_GET['pw']) || empty($_GET['pw']) || $_GET['pw']!=$accesspassword){
	die('unauthorized');
}


ob_start();
include('admin/bot/money.log'); //the relative path to the debug log of the bot (this is used in /admin.php) - if you're hosting the bot on a different server than the site this will not work, so delete this line if thats the case

$log=ob_get_clean();

$boom=explode(PHP_EOL,$log);

//$boom=array_reverse($boom);

$revcount=count($boom);

$iequals=(($revcount>700) ? ($revcount-700) : $revcount);
echo $iequals.'<'.$revcount;

for($i=$iequals;$i<$revcount;$i++){
	echo htmlspecialchars($boom[$i]).'<br/>'."\r\n";
}

