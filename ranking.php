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
<body style="overflow:auto;">
<div class="fullWitchContent" style="overflow:auto;">
	 <div class="title">Ранги</div>

        <?php
        $playerq=$mysql->query('SELECT * FROM `users` WHERE `wonp`>0 ORDER BY `wonp` DESC LIMIT 15');


        if(isset($_SESSION['steamid']) && !empty($_SESSION['steamid']))
        {
            $userinfoq=$mysql->query('SELECT * FROM `users` WHERE `steamid`="'.$mysql->real_escape_string($_SESSION['steamid']).'"');
            if($userinfoq->num_rows>0){
                $userinfo=$userinfoq->fetch_assoc();

                if(empty($userinfo['name'])){
                    $userinfo['name']=$userinfo['steamid'];
                }
                echo'<table width="100%" cellspacing="0" class="rankingTable">';
                echo'<tr style="background-color:;">';
                            echo'<td style="text-align:left;width:50%;">';
                            echo'</td>';
                            echo'<td style="text-align:left;width:50%;">';
                            echo '<h1 style="    right: 480px;
    position: relative;">Ваша статистика</h1>';
                            echo'</td>';

                            echo'<td style="text-align:right;font-weight:bold;width:40%;">';
                            echo'<h1 style="    right: 70px;
    position: relative;">Игры</h1>';
                            echo'</td>';
                            echo'<td style="text-align:right;font-weight:bold;width:7%;">';
                            echo'<h1 style="position: relative;
    right: 35px;">Выигрыш</h1>';
                            echo'</td>';
                echo'</tr>';
                echo'<tr style="background-color:#;">';
                    echo'<td style="text-align:cyka;width:5%;horizontal-align: left;
    position: left;
    right: 200px;
    padding-top: 20px;
    right: -9px;
    padding-bottom: 20px;
    position: relative;">';
                    echo'<img src="'.$userinfo['avatar'].'" style="border-radius:50%;width:50px;height:50px"/>';
                    echo'</td>';
                    echo'<td style="text-align:left;width:45%;">';
                    echo '<a href="http://steamcommunity.com/profiles/'.$userinfo['steamid'].'"style="    right: 435px;
    top: -17px;
    position: relative;">'.htmlspecialchars(antispam($userinfo['name'])).cc($userinfo['steamid']).'</a>';
                    echo'</td>';
                    echo'<td style="text-align: right;
    font-weight: bold;
    width: 40%;
    position: relative;
    top: -17px;
    right: 94px;">';
                    echo myround($userinfo['games']);
                    echo'</td>';
                    echo'<td style="text-align: center;
    font-weight: bold;
    width: 10%;
    position: relative;
    right: 36px;
    top: -17px;">$';
                    echo myround($userinfo['wonp']);
                    echo'</td>';


                echo'</tr>';
                echo'<tr><td colspan="4"><br/></td></tr>';
                echo'</table>';
            }
        }

        echo'<table width="100%" cellspacing="0">';
        echo'<tr>';
                    echo'<td style="text-align:right;width:5%;">';
                    echo'</td>';
                    echo'<td style="text-align:left;width:45%;">';
                    echo '<h1>PLAYER</h1>';
                    echo'</td>';

                    echo'<td style="text-align:right;font-weight:bold;width:40%;">';
                    echo'<h1>GAMES</h1>';
                    echo'</td>';
                    echo'<td style="text-align:center;font-weight:bold;width:10%;">';
                    echo'<h1>WON</h1>';
                    echo'</td>';
        echo'</tr>';
        while($player=$playerq->fetch_assoc()){
                if(empty($player['name'])){
                    $player['name']=$player['steamid'];
                }

                echo'<tr>';
                    echo'<td style="text-align: right;
    width: 5%;
    position: relative;
    padding-top: 20px;">';
                    echo'<img src="'.$player['avatar'].'" style=" border-radius: 50%;width:50px;height:50px"/>';
                    echo'</td>';
                    echo'<td style="    width: 5%;
    position: relative;
    padding-top: 20px;
    top: -17px;
    right: -20px;">';
                    echo '<a href="http://steamcommunity.com/profiles/'.$player['steamid'].'">'.htmlspecialchars(antispam($player['name'])).cc($player['steamid']).'</a>';
                    echo'</td>';
                    echo'<td style="text-align:right;font-weight:bold;width:40%;">';
                    echo myround($player['games']);
                    echo'</td>';
                    echo'<td style="text-align:center;font-weight:bold;width:10%;">$';
                    echo myround($player['wonp']);
                    echo'</td>';

                echo'</tr>';
        }
        echo'</table>';

        ?>
    </div>

