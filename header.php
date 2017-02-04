</script>  <script type="text/javascript" src="//code.jquery.com/jquery-2.1.1.min.js"></script>
<link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
<link rel="icon" type="image/ico" href="../favicon.ico"/>
<meta name="description" content="Service where CS:GO players can try their luck and get awesome skins! Just deposit your skins to the raffle, become a winner and sweep the board!" />
	<meta name="msapplication-TileColor" content="#ffc40d">
	<meta name="msapplication-TileImage" content="http://213.159.215.102/static/favicon/mstile-144x144.png">
	<meta name="theme-color" content="#ffffff">
<style>
	::-webkit-scrollbar {
    width: 6px;
}
 
/* Track */
::-webkit-scrollbar-track {
    -webkit-box-shadow: inset 0 0 6px rgba(0,0,0,0.3); 
    -webkit-border-radius: 10px;
    border-radius: 10px;
}

::-webkit-scrollbar-thumb {
    -webkit-border-radius: 10px;
    border-radius: 10px;
    background: 	; 
    -webkit-box-shadow: inset 0 0 6px rgba(0,0,0,0.5); 
}
::-webkit-scrollbar-thumb:window-inactive {
	background: #057acd; 
}
</style>

	  <link type="text/css" rel="stylesheet" href="../css/main.css"/>

 <body id="sidebar">
 <style>
 .loader {
	position: relative;
	left: 0px;
	top: 0px;
	width: 100%;
	height: 100%;
	z-index: 100000000000;
	background: url('../assets/facebook.gif') 50% 50% no-repeat #1D2226;
}
</style>
 <div class="loader"></div>
	<title>luckyskin24.com</title>
   <div id="header">
        <div id="mainHeader">
            <a href="http://213.159.215.102" id="logo"><img src="../images/logo.png" alt="logo" style="width: 250px;height: 79px;margin-top: 7px;"></a>
            <div id="nav" style="z-index:1000000000; position:relative;margin-left:-50px;" >
                <a href="http://213.159.215.102">джекпот</a>
                <a href="../spinhistory.php">Spin History</a>   
              <a href='#freecoins' class='modal-trigger'><Бесплатные коины</a>
				<a href="../deposit.php">Депозит</a><a href="../withdraw.php">Вывод</a><a href="../minigames">Coin Flip</a><a href="../roulette">Рутелка</a>
            </div>
        </div>
		<div id="mobNavToggle"></div>
        <div class="headerRightSide">
		<?php if(isset($_SESSION['steamid'])): ?>
							<div id="userPanel">
					<a href="settings.php" title="Edit Settings"><img src="<?=$_SESSION['avatar']?>" alt=""/></a>
					<div class="UserPanelInfo">
						<a href="http://213.159.215.102/settings.php" class="username"><?=$_SESSION['name'] ?></a>
										<a href="../steamauth/logout.php" class="logout" style="
    top: -8px;
    position: relative;
">Вход</a>
						<br><a href="../referrals.php" class="logout" style="
    left: 80px;
    position: relative;
    top: -19px;
">Рефералы</a>
					</div>
				</div>
				<?php else: ?>
					<li class="login" style="
    top: 20px;
    position: relative;
    left: 56px;
">
	 
	 </li>
	<?php endif; ?>
					</div>
		
    </div>
    <script>
      var path = window.location.pathname;
      var page = path.split("/").pop();
      $('a').each(function() {
        if($(this).attr('href') == '/'+page) {
          $(this).parent().addClass('active')
        }
      });
    </script>
    <div class="modal" id="tos-modal">
                <div class="modal-content">
                    <h4>Terms of Service Agreement</h4>
                       <p><b> By using CSGOSNAFFY you agree to the following terms of service. Violators may be refused access to CSGOSNAFFY's services. CSGOSNAFFY reserves the right to refuse access to any user at the sole discretion of CSGOSNAFFY staff. CSGOSNAFFY also reserves the right to not have to provide a reason for suspension from our services. All following terms are subject to change at any given time, without prior warning, at the discretion of CSGOSNAFFY's staff.</b></p>
           
                      <span class="card-title">Age Restriction</span>
                      <p>You must be at least 18 years or older to log into CSGOSNAFFY with your Steam account. All laws and regulations of the United States of America are applied on CSGOSNAFFY.</p>
                       
                      <span class="card-title">Privacy Policy</span>
                      <p>Steam accounts are used to identify users in CSGOSNAFFY. By using our service you acknowledge and agree that your Steam account, Steam account display name, and Steam account avatar may be shared with other CSGOSNAFFY users. CSGOSNAFFY will never ask for, collect, or share the personal information of any of its users. Additionally, CSGOSNAFFY uses cookies in order to enhance your user experience. Cookies are used to store non-sensitive user data, such as your SteamID and player name. All cookies are fully encrypted and private, and by agreeing to the terms of serice you agree to allow us to use these encrypted cookies in any way we wish.</p>
                       
                      <span class="card-title">Code of Conduct</span>
                      <p>Users are asked to remain respectful at all times. Harassment, misconduct, excessive spam, solicitation (including begging for coins), advertisement (Including referral codes) in chat - are all prohibited behaviors. CSGOSNAFFY's staff reserves the right to make per-user specific judgement calls on an offender of the Code of Conduct. The Code of Conduct is subject to change at any time.</p>
                       
                      <span class="card-title">Limited Liability</span>
                      <p>CSGOSNAFFY does not take responsibility for Steam actions (such as trade bans / limitations) by depositing or withdrawing items from our bots. Additionally, by using CSGOSNAFFY, you accept that inevitable problems may arise, leading to missed or unaccounted for bets, deposits, and or withdrawls. Coins will not be returned upon such an occurance. Such issues include, but are not limited to: poor network connection, DDOS attacks, Server crashes, ISP service interruption, or especially steam trade cykadowns/bans/escrow trade holds which cause our bots to be unable to confirm your trade.</p>
                       
                      <span class="card-title">Maximum Bets</span>
                      <p>CSGOSNAFFY reserves the right to manipulate the maximum and minimum bet at any time without prior warning to maintain site functionality.</p>
                       
                      <span class="card-title">Item Pricing</span>
                      <p>CSGOSNAFFY reserves the right to deny or discount items for any reason. CSGOSNAFFY does not accept stickers, souvenir items, or name tags. Items of low value, as deemed by CSGOSNAFFY, are also not accepted. These regulations are subject to change at any given time without prior warning at the discretion of CSGOSNAFFY's staff.</p>

                </div>
                <div class='modal-footer row valign-wrapper'>
                  <div class="col s10"><input type="checkbox" id="tos-accept"><label for="tos-accept">I accept the Terms of Service and I am at least 18 years of age.</label></div>
                  <?php
              if(isset($_GET['referral'])) {
                $referral = $_GET['referral'];
                echo "<a href='/?login&referral=$referral' ";
              } else {
                echo "<a href='/?login' ";
              }?>id="login-accepted-tos" class="btn green waves-effect waves-light col s2 disabled">Sign In</a>
                </div>
              </div>

              <script>
                $("#tos-accept").click(function() {
                  $("#login-accepted-tos").toggleClass('disabled');
                });
              </script>