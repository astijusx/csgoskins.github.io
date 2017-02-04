<?php
$secured=true;
require 'include/config.php';
require 'include/functions.php';
require 'steamauth/steamauth.php';
if(isset($_SESSION['steamid'])) {
	require 'steamauth/userInfo.php'; //To access the $steamprofile array
	
}

$mysql=@new mysqli($db['host'],$db['user'],$db['pass'],$db['name']);
$mysql->set_charset('utf8mb4'); 

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
	 <div class="title">История раунда</div>
 <div class="pagination">
        <?php

        $currentgame=$mysql->query('SELECT `value` FROM `info` WHERE `name`="current_game"')->fetch_assoc();
        $currentgame=(int)$currentgame['value'];

        $total=$mysql->query('SELECT * FROM `games` WHERE `id`<"'.$currentgame.'" AND `id`>4')->num_rows;

        $page=(isset($_GET['page']) && !empty($_GET['page']) && $_GET['page']>0 && $_GET['page']<$total) ? (int)$_GET['page'] : 1;
        $perpage=15;
        $roundq=$mysql->query('SELECT * FROM `games` WHERE `id`<"'.$currentgame.'" AND `id`>4 ORDER BY `id` DESC LIMIT '.(($page-1)*$perpage).','.$perpage);


        //http://mis-algoritmos.com/digg-style-pagination-class
        $p = new pagination;
        $p->Items($total);
        $p->limit($perpage);
        $p->currentPage($page);
        $p->nextLabel('');//removing next text
        $p->prevLabel('');//removing previous text
        $p->nextIcon('&#9658;');//Changing the next icon
        $p->prevIcon('&#9668;');//Changing the previous icon

        $p->show();

        echo'<div id="historyTable">';
        while($round=$roundq->fetch_assoc()){
            if($round['totalvalue']>0){
                echo'<tr><td><br/><b>Раунд #'.$round['id'].'</b></td></tr>';
                if(!$winnerinfo=$mysql->query('SELECT * FROM `users` WHERE `steamid`="'.$round['winneruserid'].'"')->fetch_assoc()){
                    $winnerinfo['name']=empty($winnerinfo['name']) ? $round['winneruserid'] : $winnerinfo['name'];
                    $winnerinfo['avatar']=$site['static'].'/img/defaultavatar.jpg';
                }
                $deposit=$mysql->query('SELECT SUM(`value`) AS `total` FROM `'.$prf.$round['id'].'` WHERE `userid`="'.$round['winneruserid'].'"')->fetch_assoc();
                $deposit=$deposit['total'];
                $chance=$deposit/$round['totalvalue']*100;

                echo'<div id="historyTable">';
                    echo'<div class="historyItem" style="    width: 100%;
    overflow: hidden;
    margin: 30px 0;"><img class="historyPic" src="'.$winnerinfo['avatar'].'" alt="'.$winnerinfo['name'].'" style="height:120px;width:120px;border-radius:50%; -webkit-border-radius: 50%;
    -moz-border-radius: 50%;
    border-radius: 50%;
    float: left;
    margin-right: 30px;
    width: 120px;"/>';
                    echo'<div class="historyInfo" style="    float: left;
    width: calc(100% - 150px);" >';
                    echo'<b><a class="HistoryUserLink" href="http://steamcommunity.com/profiles/'.$round['winneruserid'].'" target="_blank">'.htmlspecialchars(antispam($winnerinfo['name'])).cc($winnerinfo['steamid']).'</a></b></br>';
                    echo'<span class="HistoryWon" style="    top: 6px;
    position: relative;">Выиграл <b>$'.myround($round['totalvalue']).'</b> с $'.myround($deposit).' депозита ('.myround($chance).'% chance)</span></br>';
                    echo'<br>';
                    echo'<b style="color:#818181;">Hash: '.$round['hash'].'<br/>Secret: '.$round['secret'].'<br/>Winning ticket at: '.$round['winnerpercent'].'%<br/>Winning ticket: '.floor((floor((float)$round['winnerticket'] * 100) / 100)*100).' (<a href="provablyfair.php?hash='.$round['hash'].'&amp;secret='.$round['secret'].'&amp;roundwinpercentage='.$round['winnerpercent'].'&amp;totaltickets='.$round['totalvalue'].'" target="_blank">√</a>)</b>';
                    echo'</br>';
                    echo'</div>';
                    echo'</b>';
                    echo'<div class="historyDeposit" style="    width: 100%;
    width: calc(100% - 150px);
    float: right; position:relative; top:5px;">';

                    $items=$mysql->query('SELECT * FROM `'.$prf.$round['id'].'` ORDER BY `id` ASC');
                    $itemsnum=$items->num_rows;

                    echo $itemsnum.' Внесено айтемы:<br/>';

                    while($item=$items->fetch_assoc()){
                        $countitems=$countitems+1;
                        echo'<img src="http://steamcommunity-a.akamaihd.net/economy/image/'.$item['image'].'/50x46" title="$'.$item['value'].'<br/>'.str_replace('?','&#9733;',$item['item']).'" alt="'.$item['item'].'" style="max-width:70px;cursor:hand;'.(($item['userid']==$round['winneruserid']) ? 'background-color:rgba(255, 255, 255, 0);' : '').'"/>';
                        if(in_array($countitems, array(8,16,24,32,40,48))){
                            echo'<br/>';
                        }
                    }
                    $countitems=0;

                    echo'</div>';
                echo'</div>';
            }else{
            }

        }
        echo'</div>';

        $p->show();

        ?>
    </div>
</div>
<!--div class="chat">
<div class="chat-scroll">
 <!--  <header class="close_head hidden">
    <h2 class="title"><a>Online:</a></h2>
    <ul class="tools"><li><a class="fa fa-minus closech hidden">↑</a> <a class="fa fa-minus closechs">↓</a></li></ul>
  </header> -->
  <!--header class="chat-ttl">
    <h2 class="title">Online: <span class="online-num" id="inf1">0</span></h2>
    <!-- <ul class="tools"><li><a class="fa fa-minus closech hidden">↑</a> <a class="fa fa-minus closechs">↓</a></li></ul> -->
  <!--/header>
	<div id="page-wrap" class="hjgf">
        <!-- <p id="name-area"></p> -->
        <!--div id="chat-wrap">
        <div id="chat-area"></div></div>
		<div id="otpsoob"><div style="padding-top: 7px;">
		                <div class="chat_button">
                    <a href="?login" class="btn-yellow action-login">
                        <span class="icon-steam"></span>
                        <span class="text">Log in</span>
                    </a>
                </div>
                                </div>
            </div>
        </div>
    </div>
</div-->