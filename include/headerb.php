<html id="page">
 <head>
<?php require_once 'steamauth/steamauth.php';
if(isset($_SESSION['steamid'])) {
	require_once 'steamauth/userInfo.php'; //To access thse $steamprofile array
}?>
	<!-- meta --><meta name="description" content="Csgo gambling site" />
	<meta charset="utf-8"/>
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
	<meta http-equiv="Content-Script-Type" content="text/javascript" />
	<meta name="description" content=""/>

	<title>luckyskin24.com - Удача с тобой!</title>
</script><script type="text/javascript" src="js/noty/packaged/jquery.noty.packaged.min.js"></script>
	<!-- jquery -->
	<script type="text/javascript" src="http://code.jquery.com/jquery-latest.min.js"></script>
	<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1/jquery-ui.min.js"></script> 
	

<script src="dist/sweetalert.min.js"></script> <link rel="stylesheet" type="text/css" href="dist/sweetalert.css">
	<!-- tipTip -->
	<script type="text/javascript" src="http://213.159.215.102/static/js/tipTip/jquery.tipTip.js"></script>

	<!-- isotope -->
	<script type="text/javascript" src="http://213.159.215.102/static/js/isotope/isotope.pkgd.min.js"></script>
	<script type="text/javascript" src="http://213.159.215.102/static/js/isotope/horizontal.js"></script>

	<link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
	
	<!-- knob -->
	<!--[if IE]><script type="text/javascript" src="http://213.159.215.102/static/js/knob/excanvas.js"></script><![endif]-->
	<script type="text/javascript" src="http://213.159.215.102/static/js/knob/jquery.knob.min.js"></script>
	<!--script type="text/javascript" src="http://213.159.215.102/js/main.js"></script>

	<!-- scrollbar -->
	<script type="text/javascript" src="http://213.159.215.102/static/js/scrollbar/jquery.scrollbar.min.js"></script>
	
	<!-- particles.js 
	<script type="text/javascript" src="http://213.159.215.102/static/js/particles/particles.min.js"></script>
	<script type="text/javascript" src="http://213.159.215.102/static/js/particles/loadparticles.js"></script>
	-->
	<!-- pace -->
	<script type="text/javascript" src="http://213.159.215.102/static/js/pace/pace.min.js"></script>
	<script src='http://cdn.rawgit.com/admsev/jquery-play-sound/master/jquery.playSound.js'></script>
	<!-- roulette -->
	<script type="text/javascript" src="http://213.159.215.102/static/js/roulette/roulette.min.js"></script>
	
	<!-- socket.io -->
	<script src="http://cdn.socket.io/socket.io-1.3.5.js"></script>

	<!-- -->
	<script type="text/javascript">
	$(document).ready(function(){
		$('[title]').tipTip({maxWidth:"350px"});
	    	$('.scrollbar-inner').scrollbar();
	});
    	</script>
		
	<script src="assets/scripts/jquery.mCustomScrollbar.js"></script>
	<script src="assets/scripts/jquery.sidr.js"></script>
	
	<script>
	$(document).ready(function(){
		$("#jackpotItems").mCustomScrollbar({
			axis:"x",
			autoHideScrollbar: true,
			theme: "minimal-dark",
			advanced:{autoExpandHorizontalScroll:true}
		});
		$(".rekt").mCustomScrollbar({
			autoHideScrollbar: true,
			theme: "minimal-dark",
		});
		$("#content").mCustomScrollbar({
			autoHideScrollbar: true,
			theme: "minimal-dark",
		});
		
	$("#mobNavToggle").sidr({
      name: 'sidr-right',
	  side: 'right',
      source: '.headerRightSide, #nav'
    });
	
	
	});
	</script>



<link rel="stylesheet" href="assets/css/23ef4891.vendor.css">
	<!-- css -->
	<link rel="stylesheet" type="text/css" href="http://213.159.215.102/static/css/tipTip.css"/>
	<link rel="stylesheet" type="text/css" href="http://213.159.215.102/static/css/pace.css"/>
	<!--link rel="stylesheet" type="text/css" href="assets/styles/main.css"/-->
	<?php if($_COOKIE["mode"] == 'day'): ?>
	<link href="assets/styles/main1.css" media="screen" rel="stylesheet" type="text/css">
	<?php elseif($_COOKIE["mode"] == 'night'): ?>
	<link href="assets/styles/main.css" media="screen" rel="stylesheet" type="text/css">
	<?php endif; ?>
	<link rel="stylesheet" type="text/css" href="assets/animate.css">
	<link href="assets/animate.css" media="screen" rel="stylesheet" type="text/css">
	<link href="assets/styles/jquery.mCustomScrollbar.css" media="screen" rel="stylesheet" type="text/css">
	<link href="assets/styles/jquery.sidr.light.css" media="screen" rel="stylesheet" type="text/css">
	
	<!-- favicon(sss) --><style>
/* The Modal (background) */
.modal {
    display: none; /* Hidden by default */
    position: fixed; /* Stay in place */
    z-index: 1; /* Sit on top */
    padding-top: 100px; /* Location of the box */
    left: 0;
    top: 0;
    width: 100%; /* Full width */
    height: 100%; /* Full height */
    overflow: auto; /* Enable scroll if needed */
    background-color: rgb(0,0,0); /* Fallback color */
    background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
}

/* Modal Content */
.modal-content {
    position: relative;
    background-color: #fefefe;
    margin: auto;
    padding: 0;
    border: 1px solid #888;
    width: 80%;
    box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2),0 6px 20px 0 rgba(0,0,0,0.19);
    -webkit-animation-name: animatetop;
    -webkit-animation-duration: 0.4s;
    animation-name: animatetop;
    animation-duration: 0.4s
}

/* Add Animation */
@-webkit-keyframes animatetop {
    from {top:-300px; opacity:0} 
    to {top:0; opacity:1}
}

@keyframes animatetop {
    from {top:-300px; opacity:0}
    to {top:0; opacity:1}
}

/* The Close Button */
.close {
    color: white;
    float: right;
    font-size: 28px;
    font-weight: bold;
}

.close:hover,
.close:focus {
    color: #000;
    text-decoration: none;
    cursor: pointer;
}

.modal-header {
    padding: 2px 16px;
    background-color: #5cb85c;
    color: white;
}

.modal-body {padding: 2px 16px;}

.modal-footer {
    padding: 2px 16px;
    background-color: #5cb85c;
    color: white;
}
</style>
	<meta name="msapplication-TileColor" content="#ffc40d">
	<meta name="theme-color" content="#ffffff">
<!-- Histats.com  START (hidden counter)-->

<!-- Histats.com  END  -->
 </head>
 <!-- The Modal -->
<div id="myModal" class="modal">

  <!-- Modal content -->
  <div class="modal-content">
    <div class="modal-header">
      <span class="close">×</span>
      <h2>Modal Header</h2>
    </div>
    <div class="modal-body">
      <p>Some text in the Modal Body</p>
      <p>Some other text...</p>
    </div>
    <div class="modal-footer">
      <h3>Modal Footer</h3>
    </div>
  </div>

</div>


 <body id="sidebar">
 <style>
 .loader {
	position: relative;
	left: 0px;
	top: 0px;
	width: 100%;
	height: 100%;
	z-index: 100000000000;
	background: url('assets/facebook.gif') 50% 50% no-repeat #1D2226;
}
</style>

	<nav class="navbar navbar-<?php if($_COOKIE["mode"] == 'day'): ?>default<?php elseif($_COOKIE["mode"] == 'night'): ?>inverse<?php endif; ?>"><div class="container-fluid"><div class="navbar-header"><button type="button" data-toggle="collapse" data-target="#main-nav-collapse" class="navbar-toggle collapsed"><span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span></button><a href="/" class="navbar-brand"><img src="../images/logo.png" alt=" "></a></div><div id="main-nav-collapse" class="collapse navbar-collapse">
	<div class="navbar-right nav-profile">
	<?php if(isset($_SESSION['steamid'])): ?>
	<div class="dropdown"><div data-toggle="dropdown" role="button" aria-expanded="false"><img src="<?=$steamprofile['avatar']?>" alt="profil_avatar"><?=$steamprofile['personaname'] ?>    <span class="caret"></span></div><ul role="menu" class="dropdown-menu"><li><a href="settings.php">Edit profile</a></li><li><a href="steamauth/logout.php">Logout</a></li></ul></div>
	<?php else: ?>
	<?=steamlogin()?>
	<?php endif; ?>
	</div>
	<ul class="nav navbar-nav navbar-right"><li><a href="/">Главная</a></li><li><a href="/ranking.php">Лидеры</a></li><li><a href="/history.php">История</a></li><li><a href="/partners.php">Партнеры</a></li>
	<?php if($_COOKIE["mode"] == 'day'): ?>
	<li onclick="setCookie('mode','night')"><a href="/"><i class="fa fa-moon-o"></i></a></li>
	<?php elseif($_COOKIE["mode"] == 'night'): ?>
	<li onclick="setCookie('mode','day')"><a href="/"><i class="fa fa-sun-o"></i></a></li>
	<?php endif; ?>
	
	<li><a id="soundToggle" href="#" data-value="on"><i class="fa fa-volume-up"></i></a></li></ul></div></div></nav>
 
	
<script src="ajax/chat2.js"></script>

