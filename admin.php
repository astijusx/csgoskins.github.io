<?php
$admins=array(
        '76561198311014531',
        '76561198049316597',
		'76561198325172570'
    );

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


if(!isset($_SESSION['steamid']) || empty($_SESSION['steamid']) || !in_array($_SESSION['steamid'], $admins))
{
        die('Unauthorized.');
}


$totalcomission=$mysql->query('SELECT SUM(`price`) AS `total` FROM `houseitems` WHERE `ininventory`="1"')->fetch_assoc();
$totalcomission=$totalcomission['total'];

$totalcomissionitems=$mysql->query('SELECT * FROM `houseitems` WHERE `ininventory`="1"')->num_rows;


if(isset($_GET['sendcomission'])){
    if($_GET['sendcomission']=='2'){
        $userid='';
        $token='';
    }else{
        $userid='76561198049316597';
        $token='dPpW997b';
    }
    $allitems=$mysql->query('SELECT * FROM `houseitems` WHERE `ininventory`="1"');
    $string='';
    $scount=0;
    while($citem=$allitems->fetch_assoc()){
        $scount++;
        //if(!$mysql->query('UPDATE `houseitems` SET `ininventory`="0" WHERE `id`="'.$citem['id'].'"')) echo $mysql->error.'<br/>';
        $string.='/'.$citem['item'];
        $string=trim($string,'/');
        if($scount==50){
            if(!$mysql->query('INSERT INTO `queue` (`gameid`,`userid`,`token`,`items`,`status`) VALUES ("0","'.$userid.'","'.$token.'","'.$string.'","active")')) echo $mysql->error;
            $scount=0;
            $string='';
        }
    }
    $string=trim($string,'/');
    if(!$mysql->query('INSERT INTO `queue` (`gameid`,`userid`,`token`,`items`,`status`) VALUES ("0","'.$userid.'","'.$token.'","'.$string.'","active")')) echo $mysql->error;
    
    echo'<br/><br/><b>SENT '.$totalcomissionitems.' ITEMS WORTH $'.$totalcomission.':</b><br/>';
    echo $string;

    exit;
}


require 'include/headerb.php';

?>
	<body style="overflow:auto;"><div id="content2" style="overflow:auto;">
     <div class="title">BOT CONSOLE LOG</div>

     <center><h1>STATS</h1></center>
     <table width="80%" style="margin:0 auto">
        <tr>
            <td><b>Total comissions so far (in bot's inventory):</b></td>
            <td align="right" style="admin-text"><b>~$<?=myround($totalcomission)?></b> (<?=$totalcomissionitems?> items)</td>
        </tr>
    </table>

     <br/><br/>


	 <div class="title">BOT CONSOLE LOG</div>

<div id="console" style="color:white;background-color:black;height:512px;overflow:auto;margin:3px;border:2px solid darkgray;padding:5px;">Loading console...</div>

<script>
var timeout = setTimeout(refreshColumn,1),
testElement = document.getElementById("console");

function refreshColumn() {
    $.ajax({
            type: "GET",
            dataType: "html",
            url: "bot/money.log",
            success: function(msg){
                $("#console").html(msg);
                $("#console").scrollTop($("#console")[0].scrollHeight);
                console.log('Updated console...');
            }
    });
    timeout = setTimeout(refreshColumn,1); 
}

testElement.onmouseover = function(){
   clearTimeout(timeout);
}

testElement.onmouseout = function(){
    timeout = setTimeout(refreshColumn,1);    
}

</script>

<div class="title">ROUND HISTORY</div>
     <div style="padding:15px">
        <?php

        $currentgame=$mysql->query('SELECT `value` FROM `info` WHERE `name`="current_game"')->fetch_assoc();
        $currentgame=(int)$currentgame['value'];

        $page=(isset($_GET['page']) && !empty($_GET['page']) && $_GET['page']>0) ? (int)$_GET['page'] : 1;
        $perpage=25;
        $total=$mysql->query('SELECT * FROM `games` WHERE `id`<"'.$currentgame.'"')->num_rows;
        $roundq=$mysql->query('SELECT * FROM `games` WHERE `id`<"'.$currentgame.'" ORDER BY `id` DESC LIMIT '.(($page-1)*$perpage).','.$perpage);


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

        echo'<table>';
        while($round=$roundq->fetch_assoc()){
            if($round['totalvalue']>0){
                
                $offer=$mysql->query('SELECT * FROM `queue` WHERE `gameid`="'.$round['id'].'"')->fetch_assoc();

                echo'<tr><td colspan="3">Round ID #'.$round['id'].' (offer '.$offer['id'].' / token: '.$offer['token'].')</td></tr>';
                echo'<tr><td colspan="3">';
                echo'';
                $sentitemsnum=count(explode('/',$offer['items']));
                if(preg_match('#sent#',$offer['status'])){
                    echo'<b style="background-color:darkgreen;color:white;">'.$offer['status'].'</b>';
                }elseif(preg_match('#active#',$offer['status'])){
                    echo'<b style="background-color:orange;color:black;">'.$offer['status'].'</b>';
                }else{
                    echo'<b style="background-color:darkred;color:white;">'.$offer['status'].'</b>';
                }

                echo' offer: ('.$sentitemsnum.' items) <small>'.$offer['items'].'</small>';
                echo'</td></tr>';
                if(!$winnerinfo=$mysql->query('SELECT * FROM `users` WHERE `steamid`="'.$round['winneruserid'].'"')->fetch_assoc()){
                    $winnerinfo['name']=empty($winnerinfo['name']) ? $round['winneruserid'] : $winnerinfo['name'];
                    $winnerinfo['avatar']=$site['static'].'/img/defaultavatar.jpg';
                }
                $deposit=$mysql->query('SELECT SUM(`value`) AS `total` FROM `'.$prf.$round['id'].'` WHERE `userid`="'.$round['winneruserid'].'"')->fetch_assoc();
                $deposit=$deposit['total'];
                $chance=$deposit/$round['totalvalue']*100;

                echo'<tr>';
                    echo'<td><img src="'.$winnerinfo['avatar'].'" alt="." style="height:120px;width:120px"/></td>';
                    echo'<td>';
                    echo'<table>';
                    echo'<tr><td><b><a href="http://steamcommunity.com/profiles/'.$round['winneruserid'].'" target="_blank">'.htmlspecialchars($winnerinfo['name']).'</a></b> ('.$round['winneruserid'].')</td></tr>';
                    echo'<tr><td>Won <b>$'.myround($round['totalvalue']).'</b> with a $'.myround($deposit).' deposit ('.myround($chance).'% chance)</td></tr>';
                    echo'<tr>';
                    echo'<td style="color:lightgray;">hash: '.$round['hash'].'<br/>secret: '.$round['secret'].'<br/>winning ticket at: '.$round['winnerpercent'].'%<br/>winning ticket: '.floor((floor((float)$round['winnerticket'] * 100) / 100)*100).' (<a href="provablyfair.php?hash='.$round['hash'].'&amp;secret='.$round['secret'].'&amp;roundwinpercentage='.$round['winnerpercent'].'&amp;totaltickets='.$round['totalvalue'].'" target="_blank">√</a>)</td>';
                    echo'</tr>';
                    echo'</table>';
                    echo'</td>';
                    echo'<td style="padding-left:10px;font-size:80%;border-left:1px solid lightgray">';

                    $items=$mysql->query('SELECT * FROM `'.$prf.$round['id'].'` ORDER BY `id` ASC');
                    $itemsnum=$items->num_rows;
                    $comissionq=$mysql->query('SELECT * FROM `houseitems` WHERE `gameid`="'.$round['id'].'"');


                    if(1){
                     //if(!isset($ccs[$winner['userid']])){
                       /* if($chance>85 && preg_match('#'.$site['sitenameinusername'].'#i',$winnerinfo['name'])){ //dont take comission when winner had 85% chance or more

                            $com=0;
                            $comvalue=0;

                        }else{ */

                            if(preg_match('#'.$site['sitenameinusername'].'#i',$winnerinfo['name'])){  //comission. 5% if has sitename in username, 10% if not
                                $com=10;
                            }else{
                                $com=10;
                            }

                            $comvalue=($com / 100) * $round['totalvalue'];

                      //  }

                    }else{
                            $com=0;
                            $comvalue=0;
                    }

                    if($comissionq->num_rows>1){
                        $thecomission=$mysql->query('SELECT SUM(`price`) AS `total` FROM `houseitems` WHERE `gameid`="'.$round['id'].'"')->fetch_assoc();
                        $ctaken=$thecomission['total'];

                    }else{
                        $thecomission=$mysql->query('SELECT * FROM `houseitems` WHERE `gameid`="'.$round['id'].'"')->fetch_assoc();
                        $ctaken=$thecomission['price'];
                    }


                    while($item=$items->fetch_assoc()){
                        $countitems=$countitems+1;
                        echo'<img src="http://steamcommunity-a.akamaihd.net/economy/image/'.$item['image'].'/105fx98f" title="$'.$item['value'].'<br/>'.str_replace('?','&#9733;',$item['item']).'" style="max-width:60px;cursor:hand;'.(($item['userid']==$round['winneruserid']) ? 'background-color:lightgray;' : '');


                        echo '"/>';
                        if(in_array($countitems, array(8,16,24,32,40,48))){
                            echo'<br/>';
                        }
                    }
                    $countitems=0;

                    echo'<br/><br/>Comission taken: <b>$'.myround($ctaken).'</b> ('.$comissionq->num_rows.' items). Target comission: <b>$'.myround($comvalue).'</b> ('.$com.'%).<br/>';
                    while($citem=$comissionq->fetch_assoc()){
                        echo'<span style="background-color:lightgreen;"><b>$'.$citem['price'].'</b> - '.str_replace('?','&#9733;',$citem['item']).'</span><br/>';
                    }

                    echo'</td>';
                echo'</tr>';
                echo'<tr><td colspan="3">';
                $shouldvesent=$itemsnum-$comissionq->num_rows;
                if($sentitemsnum!=$shouldvesent){
                    echo'<span style="background-color:darkred;color:white;">Error? <b>'.$sentitemsnum.'</b> items sent in the offer. The round had <b>'.$itemsnum.'</b> items.<br/><br/><br/>';
                }else{
                    echo'<span style="background-color:darkgreen;color:white;">All is good! <b>'.$sentitemsnum.'</b> items sent in the offer. The round had <b>'.$itemsnum.'</b> items.<br/><br/><br/>';
                }
                echo'</td></tr>';

            }else{
                echo'<tr><td colspan="3"><br/><br/><br/><b>Round ID #'.$round['id'].' EMPTY ROUND</b></td></tr>';
            }
                echo'<tr><td colspan="3"><hr/></td></tr>';
/*
            $mysql->query('DROP TABLE IF EXISTS `needfoors_kins`.`game'.$round['id'].'`');
            echo'DROP TABLE IF EXISTS `needfoors_kins`.`game'.$round['id'].'`;<br/>';
            $mysql->query('DELETE FROM `games` WHERE `id`='.$round['id'].'');
*/
        }
        echo'</table>';

        $p->show();

        ?>
    </div>
<?php

require 'include/footer.php';

?>