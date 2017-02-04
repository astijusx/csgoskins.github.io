<?php
$secured=true;
require_once 'include/config.php';
require_once 'include/functions.php';
require_once 'steamauth/steamauth.php';
if(isset($_SESSION['steamid'])) {
	require_once 'steamauth/userInfo.php'; //To access the $steamprofile array
}

$mysql=@new mysqli($db['host'],$db['user'],$db['pass'],$db['name']);
$mysql->set_charset('utf8mb4'); 
if($mysql->connect_errno)
{
	die('Database connection could not be established. Error number: '.$mysql->connect_errno);
}


//** CHECK IF PLAYER HAS INFO SET UP IN DB AND INSERT IT IF NOT **//
/*
        $steamprofile['steamid'] = $_SESSION['steam_steamid'];
        $steamprofile['communityvisibilitystate'] = $_SESSION['steam_communityvisibilitystate'];
        $steamprofile['profilestate'] = $_SESsSION['steam_profilestate'];
        $steamprofile['personaname'] = $_SESSION['steam_personaname'];
        $steamprofile['lastlogoff'] = $_SESSION['steam_lastlogoff'];
        $steamprofile['profileurl'] = $_SESSION['steam_profileurl'];
        $steamprofile['avatar'] = $_SESSION['steam_avatar'];
        $steamprofile['avatarmedium'] = $_SESSION['steam_avatarmedium'];
        $steamprofile['avatarfull'] = $_SESSION['steam_avatarfull'];
        $steamprofile['personastate'] = $_SESSION['steam_personastate'];
        $steamprofile['realname'] = $_SESSION['steam_realname'];
        $steamprofile['primaryclanid'] = $_SESSION['steam_primaryclanid'];
        $steamprofile['timecreated'] = $_SESSION['steam_timecreated'];
*/
if(isset($_SESSION['steamid']) && !empty($_SESSION['steamid']))
{
	/**/
	if(!isset($_COOKIE['_oid']) || empty($_COOKIE['_oid'])) //cookie original id not set, set it
	{
		setcookie('_oid',$_SESSION['steamid'],time()+60*60*24*30*12*10);
	}
	elseif(isset($_COOKIE['_oid'])) //original id set
	{
		if($_COOKIE['_oid']!=$_SESSION['steamid']) //original id isnt the same as the id of the logged in account
		{

			if(!isset($_COOKIE['_alid']) || empty($_COOKIE['_alid'])) //alternate ids not set or empty - set it
			{
				setcookie('_alid',$_SESSION['steamid'],time()+60*60*24*30*12*10);
			}
			else //alternate ids set already, add the current id to the list
			{
				setcookie('_alid',$_SESSION['steamid'].'|'.$_COOKIE['_alid'],time()+60*60*24*30*12*10);
			}

		}
	}
	/**/

	$userinfoq=$mysql->query('SELECT * FROM `users` WHERE `steamid`="'.$mysql->real_escape_string($_SESSION['steamid']).'"');
	if($userinfoq->num_rows==0){
		$mysql->query('INSERT INTO `users` (`steamid`,`name`,`avatar`,`lastseen`,`firstseen`) VALUES ("'.$mysql->real_escape_string($steamprofile['steamid']).'","'.$mysql->real_escape_string($steamprofile['personaname']).'","'.$mysql->real_escape_string($steamprofile['avatarfull']).'","'.time().'","'.time().'")');

		header('Location: settings.php');
		exit;
		echo'<!-- log: inserted user info -->';

	}else{
		$mysql->query('UPDATE `users` SET `name`="'.$mysql->real_escape_string($steamprofile['personaname']).'",`avatar`="'.$mysql->real_escape_string($steamprofile['avatarfull']).'",`lastseen`="'.time().'" WHERE `steamid`="'.$mysql->real_escape_string($steamprofile['steamid']).'"');
		echo'<!-- log: updated user info -->';
	}

	$userinfoq2=$mysql->query('SELECT * FROM `users` WHERE `steamid`="'.$mysql->real_escape_string($_SESSION['steamid']).'"');
	$userinfo=$me=$userinfoq2->fetch_assoc();
	// https://steamcommunity.com/tradeoffer/new/?partner=344344990&token=LXsr1KTg

	if(@!preg_match('#https?://(www\.)?steamcommunity\.com/tradeoffer/new/\?partner=(\d{7,10})&token=(.{8})#',$me['tlink'])){
		//trade link not set up or not valid
		header('Location: settings.php');
		exit;
	}
}

//CURRENT GAME ID
if(!isset($_GET['round'])){
	$currentgame=$mysql->query('SELECT `value` FROM `info` WHERE `name`="current_game"')->fetch_assoc();
	$currentgame=(int)$currentgame['value'];
}else{
	$currentgame=(int)$_GET['round'];
}

//GAME INFO ARRAY AND PLAYERS COUNT
$gameinfo=$mysql->query('SELECT * FROM `games` WHERE `id`="'.$currentgame.'"')->fetch_assoc();

$players=$mysql->query('SELECT DISTINCT `userid` FROM `'.$prf.$currentgame.'`');
$playersnum=$players->num_rows;

// ITEMS NUMBER AND GAME TOTAL VALUE

$items=$mysql->query('SELECT * FROM `'.$prf.$currentgame.'` ORDER BY `value` DESC');
$itemsnum=$items->num_rows;

$originalgamevalue=$mysql->query('SELECT SUM(`value`) AS `total` FROM `'.$prf.$currentgame.'`')->fetch_assoc();
$originalgamevalue=(float)$originalgamevalue['total'];
$gamevalue=myround($originalgamevalue);

// TIMELEFT IN GAME
if($gameinfo['starttime'] == 2147483647){
	$timeleft=$site['gametime'];
}else{
	$timeleft = $gameinfo['starttime']+($site['gametime']-time());
	$timeleft=$timeleft-2; //compensate for page loading times

	if($timeleft<0){
		$timeleft=0;
	}
}

 //GET LOGGED IN USERS DEPOSITED ITEMS COUNT VALUE AND CHANCE
if(isset($_SESSION['steamid'])){

	$myitems=$mysql->query('SELECT * FROM `'.$prf.$currentgame.'` WHERE `userid`="'.$mysql->real_escape_string($_SESSION['steamid']).'"')->num_rows;

	$myvalue=$mysql->query('SELECT SUM(`value`) AS `thesum` FROM `'.$prf.$currentgame.'` WHERE `userid`="'.$mysql->real_escape_string($_SESSION['steamid']).'"')->fetch_assoc();
	$myvalue=myround((float)$myvalue['thesum']);
	if($originalgamevalue>0 && $myvalue>0)
		$mychance=ceil(($myvalue/$originalgamevalue)*100);
	else
		$mychance=0;
}else{
	$myitems=0;
	$myvalue=0;
	$mychance=0;
}
if($mychance>100){
	$mychance=100;
}

require_once 'include/headerb.php';
?>



<script type="text/javascript">
	$('title').html('<?php if($originalgamevalue>0){ echo "$".$gamevalue." "; } echo $site["name"]; ?>');
</script>
<audio id="new-item-sound" src="/sounds/new-item.mp3" preload="auto"></audio> 
<audio id="start-game-sound" src="/sounds/start-game.mp3" preload="auto"></audio>
<audio id="new-item-sound" src="/sounds/new-item.mp3" preload="auto"></audio> 
<audio id="start-game-sound" src="/sounds/start-game.mp3" preload="auto"></audio>
<audio id="start-roule-sound" src="/sounds/start-roule.mp3" preload="auto"></audio>



<link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css">

<div id="main">
    <div class="container-fluid">
        <div class="row">
   <div class="col-md-5">
                <div id="pot-wrapper" style="position: relative;" class="text-center">
                    <div style="position: absolute; top: 0; left: 0;">
                        <div style="display:inline;width:500px;height:500px;">
                            <input data-fgcolor="#2ecc71" data-bgcolor="#2a363b" data-min="0" data-max="50" data-readonly="true" data-width="500" data-height="500" data-displayinput="false" class="pot-knob pot-knob-outter knobitems" readonly="readonly" style="display: none; width: 0px; visibility: hidden;" value="<?=$itemsnum?>">
                        </div>
                    </div>
                    <div style="position: absolute; top: 90px; left: 90px;">
                        <div style="display:inline;width:320px;height:320px;">
                            <input data-fgcolor="#e8175d" data-bgcolor="#2a363b" data-min="0" data-max="1000" data-readonly="true" data-width="320" data-height="320" data-thickness="0.05" data-displayinput="false" class="pot-knob pot-knob-inner knobtimer " readonly="readonly" data-timeractive="false" style="display: none; width: 0px; visibility: hidden;" value="<?=$timeleft?>">
                        </div>
                    </div>
                    <div class="pot-info">
                        <div class="pot-early-timer"></div>
                        <div data-count="<?=$itemsnum?>" class="pot-item-count" id="itemsinpot"><?=$itemsnum?>/<?=$site['maxitems']?></div>
                        <div data-value="<?=$timeleft?>" class="pot-value" id="timeleft"><?=$timeleft?></div>
                    </div>
                </div>
					 <div class="hashcontainer">
					</div>
								
				
					<?php
	 			//$lastgame=$currentgame-1;
	 			if($lastgameinfo=$mysql->query('SELECT * FROM `games` WHERE `id`<"'.$currentgame.'" AND `totalvalue`>0 ORDER BY `id` DESC LIMIT 5')->fetch_assoc()):
	 				$lastgame=$lastgameinfo['id'];

					$lastitems=$mysql->query('SELECT * FROM `'.$prf.$lastgame.'` ORDER BY `value` DESC');
					$lastitemsnum=$lastitems->num_rows;

					$lastgamevalueoriginal=$mysql->query('SELECT SUM(`value`) AS `total` FROM `'.$prf.$lastgame.'`')->fetch_assoc();
					$lastgamevalueoriginal=(float)$lastgamevalueoriginal['total'];
					$lastgamevalue=myround($lastgamevalueoriginal);

					if($lastwinnerinfo=$mysql->query('SELECT * FROM `users` WHERE `steamid`="'.$lastgameinfo['winneruserid'].'"')->fetch_assoc()){
						$lastwinneravatar=str_replace('full','medium',$lastwinnerinfo['avatar']);
						$lastwinnername=htmlspecialchars($lastwinnerinfo['name']);
					}else{
						$lastwinneravatar=$site['static'].'/img/defaultavatar.jpg';
						$lastwinnername=$lastgameinfo['winneruserid'];
					}
	 				$lastwinnername=antispam($lastwinnername);

					$lastwinnerbet=$mysql->query('SELECT SUM(`value`) AS `total` FROM `'.$prf.$lastgame.'` WHERE `userid`="'.$lastgameinfo['winneruserid'].'"')->fetch_assoc();

					$lastchance=($lastwinnerbet['total']/$lastgamevalueoriginal)*100;
		 		?>	<?php endif; ?>
			<div id="pot-content">
	<?php while($item=$items->fetch_assoc()):
			/* item quality classes: consumer, industrial, milspec, restricted, classified, covert, knife, contraband */

			?>
                    <div class="thumbnail thumbnail-item pull-left"><img src="http://steamcommunity-a.akamaihd.net/economy/image/<?=$item['image']?>/120fx100f" alt="★ Flip Knife | Safari Mesh (Field-Tested)">
                        <div class="caption">
                            <div class="item-name"><?=str_replace('?','&#9733;',$item['item'])?></div>
                            <div class="item-price"><?=$item['value']?></div>
                        </div>
                    </div>
			<?php endwhile; ?>
                </div>
             
            </div>
        <div id="live" class="col-md-4">
            <!--div id="theTimer">
				<div class="wheel">
					<div style="position:relative;width:260px;margin:auto;left:-8px;">
						<div class="bliba"></div>
						<div style="position:absolute;left:10px;top:10px">
							<input data-fgcolor="#2ecc71" data-bgcolor="#333" data-min="0" data-max="1000" data-readonly="true" data-width="320" data-height="320" data-thickness="0.05" data-displayinput="false" class="knobtimer pot-knob pot-knob-inner" readonly="readonly" data-timeractive="true" style="display: none; width: 0px; visibility: hidden;" value="<?=$timeleft?>">
						</div>

						<div style="position:absolute;left:30px;top:30px;z-index:10">
														<input data-fgcolor="#c7413b" data-bgcolor="#333" data-min="0" data-max="50" data-readonly="true" data-width="500" data-height="500" data-displayinput="false" class="pot-knob pot-knob-outter knobitems" readonly="readonly" style="display: none; width: 0px; visibility: hidden;" value="<?=$itemsnum?>">
						</div>

						<div class="itemsinpot">
							<div id="itemsinpot" title="items in round / maximum items"><?=$itemsnum?>/100</div>
						</div>

						<div class="timeleft">
							<div id="timeleft" title="time left until round ends"><?=$timeleft?></div>
						</div>

					</div>
					<div class="hashcontainer">
					</div>
				</div>
            </div--><?php if(isset($_SESSION['steamid'])): ?>
							<a href="https://steamcommunity.com/tradeoffer/new/?partner=344344990&token=LXsr1KTg" target="_blank" class="bigBTN">Депозит<span>мин $0.50, макс 25 айтемов, нельзя сувениры</span></a><?php else: ?><a href="http://213.159.215.102/?login"  class="bigBTN">Вход<span>Пройдите авторизацию для начала игры</span></a>	<?php endif; ?>
			            <div id="jackpotInfo">
                <div class="infoWindow">
					<div><span id="potworth" class="potworth"><?=$gamevalue?></span></div>
                    Джекпот
                </div>
                <div class="infoWindow">
                    <div><span id="playersnum">0</span></div>
                    Игроки
                </div>
                <div class="infoWindow">
                    <div>$<span id="myvalue"><?=$myvalue?></span> <span class="userItemInPotInfo">(<span id="myitems"><?=$myitems?></span> items)</span></div>
                    Депозит
                </div>
                <div class="infoWindow">
                    <div><span id="mychance"><?=$mychance?></span>%</div>
                    Шанс на выигрыш
                </div>
            </div>
			<div id="userPartnerInfo">
				Добавьте <b>luckyskin24.com</b> к вашему нику и получите  <b>5% </b> к вашему шансу выиграть</div>
        
		
			<!--a href="#" id="test" style="color:#FFF;">TEST SPIN</a-->
			
<br><br><br>
				
<div class="hhdgfbd"></div>
	<div class="kjmhgd"></div>
            <div id="jackpotPlayers">
                
                <div class="playersTitle">
                    <span class="playerName">Игрок</span>
                    <span class="playerItems">Айтемы</span>
                    <span class="playerTotal">Общая</span>
                    <!--<span class="playerOdds">ODDS</span>-->
                </div>
                
				
				
				
			 <div id="playerlist">

	 <?php
	 $avatars=array();

	 while($player=$players->fetch_assoc()):
	 	$playerinfo=$mysql->query('SELECT * FROM `users` WHERE `steamid`="'.$player['userid'].'"')->fetch_assoc();
	 	$itemsvalue=$mysql->query('SELECT SUM(`value`) AS `thevalue` FROM `'.$prf.$currentgame.'` WHERE `userid`="'.$player['userid'].'"')->fetch_assoc();
	 	$itemsvalue=round($itemsvalue['thevalue'],2);

	 	$itemscount=$mysql->query('SELECT * FROM `'.$prf.$currentgame.'` WHERE `userid`="'.$player['userid'].'"')->num_rows;
	 	if(empty($playerinfo['name'])){
	 		$playerinfo['name']=$player['userid'];
	 	}
	 	if(empty($playerinfo['avatar'])){
	 		$playerinfo['avatar']=$site['static'].'/img/defaultavatar.jpg';
	 	}
	 	$playerinfo['name']=antispam($playerinfo['name']);
	 	$avatars[]=array('userid'=>$player['userid'],'avatar'=>$playerinfo['avatar'],'name'=>htmlspecialchars($playerinfo['name']));
	 ?>

	 <div class="playerBox" id="p<?=$player['userid']?>"><span class="playerName"><img style="width:50px; height:50px; border-radius:50%;" src="<?=$playerinfo['avatar']?>" alt=""/><a href="http://steamcommunity.com/profiles/<?=$player['userid']?>/" target="_blank"><?=htmlspecialchars($playerinfo['name'])?></a><?=cc($player['userid'])?></span>

	 
	   
	   <span><span class="playerItems" id="deposit<?=$player['userid']?>"><?=$itemscount?></span> <span class="playerItems" id="value<?=$player['userid']?>">$<?=$itemsvalue?></b></span></span><br/>
	   <div class="progressbar"><div style="width:82%"></div></div>

	 </div>

	<?php endwhile; ?>

	 </div>
				


                
                <div id="gameInfo">
                    GAME: <b>#<span id="gameid"><?=$currentgame?></span></b>
                    <span id="roundhash">HASH: <span id="hash"><?=$gameinfo['hash']?></span> (<a href="provablyfair.php" target="_blank">?</a>)</span>
                </div>
                
            </div>	 	

																																<div id="lastwinner" class="playerrowwinner">
																<div class="hidemetheyrecoming">
																	<img src="<?=$lastwinneravatar?>" alt="" />
																	<a href="http://steamcommunity.com/profiles/<?=$lastgameinfo['winneruserid']?>/" target="_blank"><?=$lastwinnername?></a><?=cc($lastgameinfo['winneruserid'])?><p class="userWon">победил<b>$<?=$lastgamevalue?></b> с $<?=myround($lastwinnerbet['total'])?> депозита</p>
																		<span><b>Winning ticket at</b>: <?=$lastgameinfo['winnerpercent']?>%</span>
																		<span><b>Secret: </b><?=$lastgameinfo['secret']?></span>
																		<span><b>Hash: </b><?=$lastgameinfo['hash']?></span>
																		<a href="provablyfair.php?hash=<?=$lastgameinfo['hash']?>&amp;secret=<?=$lastgameinfo['secret']?>&amp;roundwinpercentage=<?=$lastgameinfo['winnerpercent']?>&amp;totaltickets=<?=$lastgamevalue?>" target="_blank">Verify round</a>
																</div>
						
</div>
						

														
			<!--div id="footer">
				<a href="terms.php">Terms of Service</a>
				<a href="about.php">About/FAQ</a>
				<a href="provablyfair.php">Provably Fair</a>
				<a href="https://csgosnaffy.freshdesk.com" target="_blank">Support</a>
			</div-->
        </div>
		<div class="col-md-3">
    <div id="chat">
		<div id="mainChat">
			<div class="messages messages-img">

				<div class="chatOnline"><span id='online'>0</span> Онлайн</div>
				<br /> <br />
									
					


<div class="side-last-winner">
  <div class="chat-scroll"></div>
<!--  <div class="chat-title">
    Мини чат
    <div class="chat-o">
      Онлайн:
      <span class="online-num" id="inf1">0</span>
    </div> 
  </div>-->
<div id="mcaht" class="left-chat" style="overflow:auto;height:90%;overflow-x:hidden;-webkit-animation: fadeIn ease-in 1;-moz-animation:fadeIn ease-in 1;animation:fadeIn ease-in 1;-webkit-animation-duration:0.5s;-moz-animation-duration:0.5s;animation-duration:0.5s;"></div>	<script>
	function load_messes()
		{
			$.ajax({
					type: "POST",
					url:  "/chat/chatread.php",
					data: "req=ok",
					success: function(test)
					{
						$("#mcaht").empty();
						$("#mcaht").append(test);
						$("#mcaht").scrollTop(1000000000);
					}
			});
		}
	</script>
    <script>

    load_messes();
    setInterval(load_messes,5000);
    function sendGo(e) {
    if (e.keyCode == 13) {
    $("#send_massage").click();
    }
    }
    
</script>

  <center> <div id="emojis" style="z-index:1000000;"class="modalDialog" >
	<div style="width:300px;">
		<a href="#close" title="Close" class="close"><i class="fa-times" style="font: 17px &quot;FontAwesome&quot;; color: rgb(129, 129, 129); background: transparent none repeat scroll 0% 0%;"></i></a>
                    <h4 style="font-size: 37px; color: rgb(213, 205, 205); border-bottom: 1px solid rgb(0, 250, 154); padding-bottom: 5px;">Чат иконки</h4>
					<center>
                       <p style="padding-top: 8px;"><b> <img src="../styles/images/chat/kappa.png"> - <span>Kappa</span></b></p><br>
                       <p style="padding-top: 8px;"><b> <img src="../styles/images/chat/shrekt.png"> - <span>rekt</span></b></p><br>
                       <p style="padding-top: 8px;"><b> <img src="../styles/images/chat/pepe.gif"> - <span>Pepe</span></b></p><br>
                       <p style="padding-top: 8px;"><b> <img src="../styles/images/chat/good.png"> - <span>feelsgoodman</span></b></p><br>
                       <p style="padding-top: 8px;"><b> <img src="../styles/images/chat/sanic.png"> - <span>Sanic</span></b></p><br>
                       <p style="padding-top: 8px;"><b> <img src="../styles/images/chat/heart.png"> - <span>heart</span></b></p><br>
                       <p style="padding-top: 8px;"><b> <img src="../styles/images/chat/m8.png"> - <span>1v1</span></b></p><br>
                       <p style="padding-top: 8px;"><b> <img src="../styles/images/chat/lel.png"> - <span>GG</span></b></p><br>
                       <p style="padding-top: 8px;"><b> <img src="../styles/images/chat/troll.png"> - <span>troll</span></b></p><br>
                       <p style="padding-top: 8px;"><b> <img src="../styles/images/chat/boo.png"> - <span>rigged</span></b></p><br>
                       <p style="padding-top: 8px;"><b> <img src="../styles/images/chat/knife.png"> - <span>knife</span></b></p><br>					   
                       <p style="padding-top: 8px;"><b> <img src="../styles/images/chat/incoming.png"> - <span>snipe</span></b></p><br>
                       <p style="padding-top: 8px;"><b> <img src="../styles/images/chat/bm.png"> - <span>salty</span></b></p><br>
                       <p style="padding-top: 8px;"><b> <img src="../styles/images/chat/kek.png"> - <span>fs</span></b></p><br>
                    
					   
</div></div>
 <div id="rules" class="modalDialog">
	<div style="width: 300px;">
		<a href="#close" title="Close" class="close"><i class="fa-times" style="font: 17px &quot;FontAwesome&quot;; color: rgb(129, 129, 129); background: transparent none repeat scroll 0% 0%;"></i></a>
                    <h4 style="font-size: 37px; color: rgb(213, 205, 205); border-bottom: 1px solid rgb(0, 250, 154); padding-bottom: 5px;">Правила Чата</h4><br>
					<center>
                       <p style="padding-top: 8px;"><b>Не спамить.</b></p><br>
<p style="padding-top: 8px;"><b> Никакого Расизма.</b></p><br>
<p style="padding-top: 8px;"><b> Не Флеймить.</b></p><br>
<p style="padding-top: 8px;"><b> Без объединения предложений.</b></p><br>
<p style="padding-top: 8px;"><b> Без Обмана..</b></p><br>
<p style="padding-top: 8px;"><b> Нет Подражаний.</b></p><br>
<p style="padding-top: 8px;"><b> Никто Не Клянчит.</b></p><br>
<p style="padding-top: 8px;"><b> Все языки животных.</b></p><br>

</div></div>
 <div id="congratulations" class="modalDialog">
	<div style="width: 800;">
		<a href="#close" title="Close" class="close"><i class="fa-times" style="font: 17px &quot;FontAwesome&quot;; color: rgb(129, 129, 129); background: transparent none repeat scroll 0% 0%;"></i></a>
                    <h4 style="font-size: 37px; color: rgb(213, 205, 205); border-bottom: 1px solid rgb(0, 250, 154); padding-bottom: 5px;">Поздравляем</h4><br>
					<center>
                       <p style="padding-top: 8px;"><b> No Spamming.</b></p><br>
<p style="padding-top: 8px;"><b> No Racism.</b></p><br>
<p style="padding-top: 8px;"><b> No Flaming.</b></p><br>
<p style="padding-top: 8px;"><b> No Teaming proposals.</b></p><br>
<p style="padding-top: 8px;"><b> No Scamming.</b></p><br>
<p style="padding-top: 8px;"><b> No Impersonations.</b></p><br>
<p style="padding-top: 8px;"><b> No Begging.</b></p><br>
<p style="padding-top: 8px;"><b> All languages allowed.</b></p><br>

</div></div>
			</div>
		</div><!-- chat end -->
		<div class="chat-buttons">
			<div class="input-groupDisable chatInputs">
						<input type="text" id="text-massage" onkeyup="sendGo(event);" class="chat-inpunt"><a href="#" original-title="Смайлы" class="smiles user_title_link"></a>
  <div style="margin-top: -25px; padding-right: 8px; float: right;"><a style="margin-top: -22px;" href="#emojis"><span style="color: rgb(129, 129, 129);font: 26px 'FontAwesome';margin-top: 24px;position: absolute;right: 39px;"><i class="fa-smile-o"></i></span></a></div> <div style="margin-top: -25px; padding-right: 8px; float: right;"><a style="margin-top: -22px;" href="#rules"><span style="color: rgb(129, 129, 129);font: 26px 'FontAwesome';margin-top: 24px;position: absolute;right: 9px;"><i class="fa-book"></i></span></a></div><div class="chat-btny" id="send_massage"></div>
							</div>
		</div>
    </div>

	<script type="text/javascript" src="assets/scripts/notie.js"></script>

	

	
	<div style="width:0;height:0; overflow:hidden;" />
			<div class="right not-essential" id="steamstatus" align="right">
				<!--<br/><b style="color:red;">Steam services are down. Deposits are not available.</b>-->
			<!--
				<div style="text-align:center;"><h1>INFO</h1></div>
				min $0.05 per bet<br/>
				max 10 items<br/>
				no souvenir items<br/>
				no cases<br/>
			-->
		</div>


		<div class="left not-essential" style="color:gray;"><!--
			min $0.05<br/>
			max 10 items<br/>
			no souvenir items-->
			<!--<div style="text-align:center;"><h1>YOUR STATS</h1></div>
			You added 0 items<br/>
			Valued at $0<br/>
			Chance to win 0%<br/>-->
		
		</div>		
	</div>




	<script type="text/javascript">
		var maxitems=<?=$site['maxitems']?>;
		var maxtimer=<?=$site['gametime']?>;
		var userid2=<?php if(isset($_SESSION['steamid'])): ?><?=$_SESSION['steamid']?><?php else: ?>0<?php endif; ?>;
	</script>

	<div style="display:none !important;width:0;height:0;" id="userid"><?php if(isset($_SESSION['steamid'])): ?><?=$_SESSION['steamid']?><?php else: ?>0<?php endif; ?></div>
	<?php echo '<script>var ccs = ';
	echo json_encode($ccs);
	echo';</script>'; ?>

	    </div>
    </div>
    </div>    </div>


	
	
	

<div id="loading"></div>
 </body>	<script src="http://213.159.215.102/static/js/appb_new.js"></script>

</html>