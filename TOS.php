<!DOCTYPE html>
<html>
  <head>
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link type="text/css" rel="stylesheet" href="materialize/css/materialize.min.css"  media="screen,projection"/>
    <link href="/css/zmd.hierarchical-display.min.css" rel="stylesheet">
    <link rel="icon" href="/favicon.ico?" type="image/x-icon">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <style>  body {
      display: flex;
      min-height: 100vh;
      flex-direction: column;
    }

    main {
      flex: 1 0 auto;
    }
    .logo {
      height: 50px;
      margin-top: 6px;
    }
    .hoverable:hover {
    	transition: all .3s ease-out;
    }
    </style>
  </head>
  <body class="grey lighten-1">
  <header>
    <?php
      include 'header.php';
    ?>
    </header>
    <main>
    <div class="container">
      <div class="card">
        <div class="card-content">
          <span class="card-title">Terms of Service</span>
          <p><b> By using CSGO DARK you agree to the following terms of service. Violators may be refused access to CSGO DARK's services. CSGO DARK reserves the right to refuse access to any user at the sole discretion of CSGO DARK staff. CSGO DARK also reserves the right to not have to provide a reason for suspension from our services. All following terms are subject to change at any given time, without prior warning, at the discretion of CSGO DARK's staff.</b></p>
           
          <span class="card-title">Age Restriction</span>
          <p>You must be at least 18 years or older to log into CSGO DARK with your Steam account. All laws and regulations of the United States of America are applied on CSGO DARK.</p>
           
          <span class="card-title">Privacy Policy</span>
          <p>Steam accounts are used to identify users in CSGO DARK. By using our service you acknowledge and agree that your Steam account, Steam account display name, and Steam account avatar may be shared with other CSGO DARK users. CSGO DARK will never ask for, collect, or share the personal information of any of its users. Additionally, CSGO DARK uses cookies in order to enhance your user experience. Cookies are used to store non-sensitive user data, such as your SteamID and player name. All cookies are fully encrypted and private, and by agreeing to the terms of serice you agree to allow us to use these encrypted cookies in any way we wish.</p>
                       
          <span class="card-title">Code of Conduct</span>
          <p>Users are asked to remain respectful at all times. Harassment, misconduct, excessive spam, solicitation (including begging for coins), advertisement (Including referral codes) in chat - are all prohibited behaviors. CSGO DARK's staff reserves the right to make per-user specific judgement calls on an offender of the Code of Conduct. The Code of Conduct is subject to change at any time.</p>
           
          <span class="card-title">Limited Liability</span>
                      <p>CSGO DARK does not take responsibility for Steam actions (such as trade bans / limitations) by depositing or withdrawing items from our bots. Additionally, by using CSGO DARK, you accept that inevitable problems may arise, leading to missed or unaccounted for bets, deposits, and or withdrawls. Coins will not be returned upon such an occurance. Such issues include, but are not limited to: poor network connection, DDOS attacks, Server crashes, ISP service interruption, Refreshing Site, or especially steam trade cykadowns/bans/escrow trade holds which cause our bots to be unable to confirm your trade.</p>
           
          <span class="card-title">Maximum Bets</span>
          <p>CSGO DARK reserves the right to manipulate the maximum and minimum bet at any time without prior warning to maintain site functionality.</p>
           
          <span class="card-title">Item Pricing</span>
          <p>CSGO DARK reserves the right to deny or discount items based on any reason CSGO DARK views as fit. CSGO DARK does not accept stickers, souvenir items, or name tags. Items of low value, as deemed by CSGO DARK, are also not accepted. These regulations are subject to change at any given time without prior warning at the discretion of CSGO DARK's staff.</p>
          
		  <span class="card-title">Item Tradeup</span>
         <p>CSGO DARK reserves the right to deny or discount items based on any reason CSGO DARK views as fit. CSGO DARK does not accept stickers, souvenir items, or name tags. Items of low value, as deemed by CSGO DARK, are also not accepted. If you deposit an item and want to with draw you will need to bet over 50% of it before the site will accept it. Depositing a bunch of small skins for 1 skin is not allowed and is breaking CSGORakes TOS. These regulations are subject to change at any given time without prior warning at the discretion of CSGO DARK's staff.</p	  
	  </div>
    </div>
    </main>
    <footer class="page-footer" style="padding:0;">
      <?php
        include "footer.php";
      ?>
    </footer>
    <script type="text/javascript" src="http://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="/materialize/js/materialize.min.js"></script>
    <script>
      $(".button-collapse").sideNav();
    </script>
  </body>
</html>