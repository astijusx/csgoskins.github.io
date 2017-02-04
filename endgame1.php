<?php

$ai=array(); //array info

$secured=true;
require 'include/config1.php';
require 'include/functions.php';

if(!isset($_GET['pw']) || empty($_GET['pw']) || $_GET['pw']!=$accesspassword){
	die('unauthorized');
}

$mysql=@new mysqli($db['host'],$db['user'],$db['pass'],$db['name']);

if($mysql->connect_errno){
	die('Database connection could not be established. Error number: '.$mysql->connect_errno);
}

//** GET INFO ON THE CURRENT GAME **//
if(!$curgame=$mysql->query('SELECT `value` FROM `info` WHERE `name`="current_game"')->fetch_assoc()) echo $mysql->error;
$cg=$curgame['value']; //current game id

if(!$gameinfo=$mysql->query('SELECT * FROM `games` WHERE `id`="'.$cg.'"')->fetch_assoc()) echo $mysql->error;
$totalvalue=$gameinfo['totalvalue']; //value of the pot
$winnerpercent=(float)$gameinfo['winnerpercent']; //winning percentage

$wincost=($winnerpercent/100)*$totalvalue; //TICKET


//** GET USER WITH THAT PERCENTAGE **//
if(!$winner=$mysql->query('SELECT * FROM `'.$prf.$cg.'` WHERE `from`<='.$wincost.' AND `to`>='.$wincost.'')->fetch_assoc()) echo $mysql->error;
//var_dump($winner);

//echo'...WINNER PERCENT: '.$winnerpercent;
//echo'...WINNER TICKET (COST): '.$wincost;



if(empty($winner['username'])){
	$winner['name']=$winner['userid'];
}else{
	$winner['name']=$winner['username'];
}
$ai['winnerid']=$winner['userid'];
//$ai['winnername']=htmlspecialchars($mysql->real_escape_string($winner['name'])); //make sure it doesnt break the json
$ai['winnername']=$winner['name']; //make sure it doesnt break the json
$ai['winneravatar']=$winner['avatar'];
$ai['winnerpercent']=$winnerpercent;
$ai['winnerticket']=$wincost;
$ai['winnersecret']=$gameinfo['secret'];
$ai['winnerhash']=$gameinfo['hash'];
$ai['totalvalue']=$totalvalue;
$winnerdeposit=$mysql->query('SELECT SUM(`value`) AS `total` FROM `'.$prf.$cg.'` WHERE `userid`="'.$winner['userid'].'"')->fetch_assoc();
$ai['winnerdeposit']=$winnerdeposit['total'];

//echo'...WINNER: '.($winner['userid']).' ('.$winner['username'].')';

if(!$winnerinfo=$mysql->query('SELECT * FROM `users` WHERE `steamid`="'.$winner['userid'].'"')->fetch_assoc()) echo $mysql->error;


//

$originalgamevalue=$mysql->query('SELECT SUM(`value`) AS `total` FROM `'.$prf.$cg.'`')->fetch_assoc();
$originalgamevalue=(float)$originalgamevalue['total'];

$winnervalue=$mysql->query('SELECT SUM(`value`) AS `thesum` FROM `'.$prf.$cg.'` WHERE `userid`="'.$winner['userid'].'"')->fetch_assoc();
$winnervalue=(float)$winnervalue['thesum'];

//

$pureprofit=$originalgamevalue-$ai['winnerdeposit'];


//** SET THE WINNER ID IN THE DATABASE AND UPDATE THE USERS TABLE **//
if(!$mysql->query('UPDATE `games` SET `winneruserid`="'.$winner['userid'].'", `winnername`="'.$mysql->real_escape_string($winner['name']).'",`winnerticket`="'.$wincost.'" WHERE `id`="'.$cg.'"')) echo $mysql->error;
if(!$mysql->query('UPDATE `users` SET `won`=`won`+"'.$originalgamevalue.'", `wonp`=`wonp`+"'.$pureprofit.'", `games`=`games`+1 WHERE `steamid`="'.$winner['userid'].'"')) echo $mysql->error;


//** POPULATE AN ARRAY ($itemsarr) WITH ALL ITEMS INCLUDING THE INFO ON VALUE AND WHO ADDED THEM **//
if(!$items=$mysql->query('SELECT `userid`,`item`,`value` FROM `'.$prf.$cg.'` ORDER BY `value` ASC')) echo $mysql->error;
$itemscount=0;
while($item=$items->fetch_assoc()){
	$itemsarr[$itemscount]=array(
					'userid'	=>	$item['userid'],
					'item'		=>	$item['item'],
					'value'		=>	$item['value'],
				);
	$itemscount++;
}


//** COMISSION **//

//if(!isset($ccs[$winner['userid']])){
if(1){

	$winnerchance=ceil(($winnervalue/$originalgamevalue)*100);
/*	if(($winnerchance>85 && preg_match('#'.$site['sitenameinusername'].'#i',$winner['name'])) || $winnerchance>94){ //dont take comission when winner had 85% chance or more

		$com=0;
		//echo'...0% COMISSION';

		$comvalue=0;

	}else{*/
		if(preg_match('#'.$site['sitenameinusername'].'#i',$winner['name'])){  //comission. 5% if has sitename in username, 10% if not
			$com=10;
			//echo'...5% COMISSION';
		}else{
			$com=10;
			//echo'...10% COMISSION';
		}
		$comvalue=($com / 100) * $totalvalue;
//	}

}else{ //no comission for content creators
	$com=0;

	$comvalue=0;
}

//echo'...COMISSION VALUE (TARGET): '.$comvalue;

//** GO THROUGH THE ITEMS BACKWARDS FROM THE MOST VALUABLE, THEN WHEN WE FIND ONE THAT IS EQUAL TO OR LOWER THAN OUR DESIRED COMISSION ($comvalue) WE TAKE THAT **//

$csofar=0; //comission so far
$comitems=array();
$mcom=10; //max items for comission (1-3 recommended)
$ctaken=0;
if($comvalue>0){
	for($i=$itemscount-1; $i>=0; $i--){ //get comission items

		$itemsarr[$i]['value']=(float)$itemsarr[$i]['value']; //cast it as float just in case

		if($itemsarr[$i]['userid']!=$winner['userid']){ //don't take shit from the winner bro

			//if($itemsarr[$i]['value']<0.05 && false){ //end the loop if we get to items cheaper than 5 cents, no reason to take that shit
			//	$i=-1;
			//}else{
				if( ( $csofar + $itemsarr[$i]['value'] ) <= $comvalue ){

					$csofar=$csofar+$itemsarr[$i]['value']; //update the comission taken so far
					$ctaken++; //update the number of items taken as comission

					//insert it to database
					if(!$mysql->query('INSERT INTO `houseitems` (`gameid`,`price`,`item`,`timestamp`,`ininventory`) VALUES ("'.$cg.'","'.$itemsarr[$i]['value'].'","'.$itemsarr[$i]['item'].'","'.time().'","1")')) echo $mysql->error;

					$itemsarr[$i]=''; //remove the item from the array which will be sent to the user

					if($ctaken>=$mcom){ //if the number if items taken exceeds the maxim number of comission items end the loop (set i = -1)
						$i=-1;
					}

				}
			//}

		}

	}
}

/*for($i=$itemscount-1; $i>=0; $i--){ //get comission items

	if($itemsarr[$i]['userid']!=$winner['userid']){ //don't take shit from the winner bro

		if($itemsarr[$i]['value']<=$comvalue){

			//echo'...MATCHED ITEM FOR COMISSION: '.$itemsarr[$i]['item'].'='.$itemsarr[$i]['value'];
			$comission=$itemsarr[$i];
			$itemsarr[$i]=''; //remove the item from the array which will be sent to the user
			$i=-1; //only take 1 item you greedy prick

		}

	}

}*/

//** POPULATE ARRAY $queuestringtodatabase THAT WOULD BE THE LIST OF THE ITEMS SEPARATED BY / THAT NEED TO BE SENT TO THE WINNER**//
$queuestringtodatabase='';
for($i=0;$i<count($itemsarr);$i++){
	if(!empty($itemsarr[$i])){
		if($i!=0){ //don't add / in front at the begining of the loop (when $i=0)
			$queuestringtodatabase.='/';
		}
		$queuestringtodatabase.=$itemsarr[$i]['item'];
	}
}
$queuestringtodatabase=trim($queuestringtodatabase,'/'); //there were instances where the item taken as comission was the first one and the string was begining with /, bot would get confused and thought there was 1 more items to send and send a random one (nothing before /)


//** ADD THINGS TO DATABASE (ITEMS TO OFFER, COMISSION ITEMS) **//
$tradelink = $winnerinfo["tlink"];
$token = substr(strstr($tradelink, 'token='),6); //get last part of trade link containing the "token"
if(empty($token)){
	if(!$mysql->query('INSERT INTO `queue` (`gameid`,`userid`,`token`,`items`,`status`) VALUES ("'.$cg.'","'.$winner['userid'].'","'.$token.'","'.$queuestringtodatabase.'","EMPTY TOKEN")')) echo $mysql->error;
}
else{
	if(!$mysql->query('INSERT INTO `queue` (`gameid`,`userid`,`token`,`items`,`status`) VALUES ("'.$cg.'","'.$winner['userid'].'","'.$token.'","'.$queuestringtodatabase.'","active")')) echo $mysql->error;
}
/*
if(isset($comission['value'])){
	//echo'...COMISSION ITEM(S): '.$comission['item'].'='.$comission['value'];

	if(!$mysql->query('INSERT INTO `houseitems` (`gameid`,`price`,`item`,`timestamp`,`ininventory`) VALUES ("'.$cg.'","'.$comission['value'].'","'.$comission['item'].'","'.time().'","1")')) echo $mysql->error;
}*/


//** GENERATE NEW MODULE, ROUND SECRET, AND CREATE NEW TABLES FOR NEXT GAME **//
if ($steamprofile['steamid'] == $winner['userid']) {
	header('Location: http://csgosnaffy.com/#congratulations'); 
}
	
$cg++;
$winnerpercent = (float) mt_rand(0,99).'.'.mt_rand(00000001,99999999); //winner percent
$secret = mb_substr(sha1(md5(rand())),0,16); //round secret
$hash=md5($secret.'-'.$winnerpercent);

$ai['newgame']=$cg;
$ai['newhash']=$hash;

if(!$mysql->query("INSERT INTO `games` (`id`,`starttime`,`totalvalue`,`winneruserid`,`winnername`,`itemsnum`,`winnerpercent`,`winnerticket`,`secret`,`hash`) VALUES ('$cg','2147483647','0','0','','0','".$winnerpercent."','','".$secret."','".$hash."')")) echo $mysql->error;
if(!$mysql->query("CREATE TABLE `".$prf."$cg` (
  `id` int(11) NOT NULL auto_increment,
  `offerid` varchar(100) NOT NULL,
  `userid` varchar(70) NOT NULL,
  `username` varchar(70) NOT NULL,
  `item` text,
  `qualityclass` varchar(100),
  `color` text,
  `value` float,
  `avatar` varchar(512) NOT NULL,
  `image` text NOT NULL,
  `from` float,
  `to` float,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 AUTO_INCREMENT=1;")) echo $mysql->error;

if(!$mysql->query('UPDATE info SET `value`="'.$cg.'" WHERE `name`="current_game"')) echo $mysql->error;

$encoded=json_encode($ai,JSON_UNESCAPED_UNICODE);
echo $encoded;