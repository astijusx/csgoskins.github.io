<?php if(!isset($secured)){ die('Not authorized.'); } ?>
<?php include_once("analyticstracking.php") ?>
<html>
 <head>

	<!-- meta -->
	<meta charset="utf-8"/>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
	<meta http-equiv="Content-Script-Type" content="text/javascript" />
	<meta name="description" content="YoloSkins is the place to bet your CS:GO skins. Deposit them and try to take everyone else's items."/>
    <meta name="keywords" content="CSGO, YoloSkins, CSGOJackpot, jackpot, gambling, skins,case,Counter Strike,Counter-Strike: Global Offensive,Counter,Strike,Global,Offense,Offensive,Gamble,Giveaway,Knife,Gun,Items,Won,deposit,winning,Round,csgojackpot">
	<meta http-equiv="content-language" content="en-us">
	<title><?=$site['name']?></title>

	<!-- jquery -->
	<script type="text/javascript" src="http://code.jquery.com/jquery-latest.min.js"></script>
	<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1/jquery-ui.min.js"></script> 

	<!-- tipTip -->
	<script type="text/javascript" src="<?=$site['static']?>/js/tipTip/jquery.tipTip.js"></script>

	<!-- isotope -->
	<script type="text/javascript" src="<?=$site['static']?>/js/isotope/isotope.pkgd.min.js"></script>

	<!-- knob -->
	<!--[if IE]><script type="text/javascript" src="<?=$site['static']?>/js/knob/excanvas.js"></script><![endif]-->
	<script type="text/javascript" src="<?=$site['static']?>/js/knob/jquery.knob.min.js"></script>

	<!-- scrollbar -->
	<script type="text/javascript" src="<?=$site['static']?>/js/scrollbar/jquery.scrollbar.min.js"></script>
	
	<!-- particles.js -->
	<!--<script type="text/javascript" src="<?=$site['static']?>/js/particles/particles.min.js"></script>
	<script type="text/javascript" src="<?=$site['static']?>/js/particles/loadparticles.js"></script>-->

	<!-- pace -->
	<script type="text/javascript" src="<?=$site['static']?>/js/pace/pace.min.js"></script>

	<!-- roulette -->
	<!--<script type="text/javascript" src="<?=$site['static']?>/js/roulette/roulette.min.js"></script>-->

	<!-- socket.io -->
	<script src="http://cdn.socket.io/socket.io-1.3.5.js"></script>

	<link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

	<!-- -->
	<script type="text/javascript">
	$(document).ready(function(){
		$('[title]').tipTip({maxWidth:"350px"});
	    	$('.scrollbar-inner').scrollbar();
	});
    	</script>

	<!-- css -->
	<link rel="stylesheet" type="text/css" href="<?=$site['static']?>/css/tipTip.css"/>
	<link rel="stylesheet" type="text/css" href="<?=$site['static']?>/css/pace.css"/>
	<link rel="stylesheet" type="text/css" href="<?=$site['static']?>/css/style.css"/>

	<!-- favicon(sss) -->
	<?php /* http://realfavicongenerator.net/ */ ?>
	<link rel="apple-touch-icon" sizes="57x57" href="<?=$site['static']?>/favicon/apple-touch-icon-57x57.png">
	<link rel="apple-touch-icon" sizes="60x60" href="<?=$site['static']?>/favicon/apple-touch-icon-60x60.png">
	<link rel="apple-touch-icon" sizes="72x72" href="<?=$site['static']?>/favicon/apple-touch-icon-72x72.png">
	<link rel="apple-touch-icon" sizes="76x76" href="<?=$site['static']?>/favicon/apple-touch-icon-76x76.png">
	<link rel="apple-touch-icon" sizes="114x114" href="<?=$site['static']?>/favicon/apple-touch-icon-114x114.png">
	<link rel="apple-touch-icon" sizes="120x120" href="<?=$site['static']?>/favicon/apple-touch-icon-120x120.png">
	<link rel="apple-touch-icon" sizes="144x144" href="<?=$site['static']?>/favicon/apple-touch-icon-144x144.png">
	<link rel="apple-touch-icon" sizes="152x152" href="<?=$site['static']?>/favicon/apple-touch-icon-152x152.png">
	<link rel="apple-touch-icon" sizes="180x180" href="<?=$site['static']?>/favicon/apple-touch-icon-180x180.png">
	<link rel="icon" type="image/png" href="<?=$site['static']?>/favicon/favicon-32x32.png" sizes="32x32">
	<link rel="icon" type="image/png" href="<?=$site['static']?>/favicon/android-chrome-192x192.png" sizes="192x192">
	<link rel="icon" type="image/png" href="<?=$site['static']?>/favicon/favicon-96x96.png" sizes="96x96">
	<link rel="icon" type="image/png" href="<?=$site['static']?>/favicon/favicon-16x16.png" sizes="16x16">
	<link rel="manifest" href="<?=$site['static']?>/favicon/manifest.json">
	<meta name="msapplication-TileColor" content="#ffc40d">
	<meta name="msapplication-TileImage" content="<?=$site['static']?>/favicon/mstile-144x144.png">
	<meta name="theme-color" content="#ffffff">

	<!-- Histats.com  START (hidden counter)-->
	<script type="text/javascript">document.write(unescape("%3Cscript src=%27http://s10.histats.com/js15.js%27 type=%27text/javascript%27%3E%3C/script%3E"));</script>
	<a href="http://www.histats.com" target="_blank" title="" ><script  type="text/javascript" >
	try {Histats.start(1,3207040,4,0,0,0,"");
	Histats.track_hits();} catch(err){};
	</script></a>
	<noscript><a href="http://www.histats.com" target="_blank"><img  src="http://sstatic1.histats.com/0.gif?3207040&101" alt="histats" border="0"></a></noscript>
	<!-- Histats.com  END  -->

 </head>
 <body>
 <?php include_once("socialmedia.php") ?>
	<div id="particles-js" style="position:fixed;top:0;width:100%;height:100%;"></div>

<!-- i'm not a wrapper i'm an adaptor -->
<div id="wrapper">


	<!-- start: top nav -->

	<ul id="topnav">
	 <li class="link"><a href="http://gleam.io/competitions/yW6Qs-ak-vulcan-field-tested-giveaway">GIVEAWAY</a></li>
	 <li class="link"><a href="history.php">История</a></li>
	 <li class="link"><a href="ranking.php">Ранги</a></li>
         <li class="link"><a href="http://steamcommunity.com/id/69ingMonkeys/">Поддержка</a></li>
	 <li class="link"><a href="<?=$site['url']?>">PLAY</a></li>
	<?php if(isset($_SESSION['steamid'])): ?>
	 <li class="logout"><a href="steamauth/logout.php" title="Log Out"><img src="<?=$site['static']?>/img/logout.png" alt=""/></a></li>

	 <li class="separator"></li>
	 <li class="avatar"><a href="settings.php" title="Edit Settings"><img src="<?=$steamprofile['avatarfull']?>" alt=""/></a></li>

	 <li class="separator"></li>
	 <?php else: ?>
	 <li class="login">
	 	<?=steamlogin()?>
	 </li>
	<?php endif; ?>

	</ul>


		<div id="container">
		