<?php 
session_start();
include ('../steamauth/userInfo.php');
include 'nbans/banned.php';
if(isset($_SERVER['HTTP_X_REQUESTED_WITH']) && !empty($_SERVER['HTTP_X_REQUESTED_WITH']) && strtolower($_SERVER['HTTP_X_REQUESTED_WITH']) == 'xmlhttprequest') {
    $today = date("H:i:s | d.m.Y");
if ($_POST['massage'] == '') {
    die('Error, message cant be empty.');
}
if (strlen($_POST['massage']) < 2) {
    die('Error, message cant contain less than 2 chars.');
}
if (strlen($_POST['massage']) > 100) {
    die('Error, message cant contain more than 50 chars.');
}
if(!isset($_SESSION['steamid'])) {
echo 'Error, cookies expired, please relog to the site.';
}

else {
    $massage = $_POST['massage'];
    $massage = str_ireplace('>', '*', $massage);
    $massage = str_ireplace('<', '*', $massage);
    $massage = str_ireplace('/', '*', $massage);
    $massage = str_ireplace('iframe', '*', $massage);
	$massage = str_ireplace('leaked', 'unique', $massage);
    $massage = str_ireplace('script', '*', $massage);
    $massage = str_ireplace('CSGO', '****', $massage);
    $massage = str_ireplace('csgo', '****', $massage);
    $massage = str_ireplace('http:', '****', $massage);
    $massage = str_ireplace('www', '****', $massage);
    $massage = str_ireplace('http:', '****', $massage);
    $massage = str_ireplace('src', '****', $massage);
    $massage = str_ireplace('.com', '****', $massage);
    $massage = str_ireplace('.org', '****', $massage);
    $massage = str_ireplace('csgobig.com', '****', $massage);
    $massage = str_ireplace('.net', '****', $massage);
    $massage = str_ireplace('allahu akbar', '****', $massage);
    $massage = str_ireplace('9/11', '****', $massage);
    $massage = str_ireplace('hitler', '****', $massage);
    $massage = str_ireplace('nazi', '****', $massage);
    $massage = str_ireplace('faggot', '****', $massage);
    $massage = str_ireplace('nigga', '****', $massage);
    $massage = str_ireplace('nigger', '****', $massage);
	$steamprofile['personaname'] = str_ireplace('>', 'imafaggot', $steamprofile['personaname']);
$steamprofile['personaname'] = str_ireplace('<', 'imafaggot', $steamprofile['personaname']);
$steamprofile['personaname'] = str_ireplace('>', 'imafaggot', $steamprofile['personaname']);
$steamprofile['personaname'] = str_ireplace('script', 'imafaggot', $steamprofile['personaname']);
    $massage = str_ireplace('aids', '****', $massage);
    $massage = str_ireplace('knulla', '****', $massage);
    $massage = str_ireplace('fitta', '****', $massage);
    $massage = str_ireplace('kuk', '****', $massage);
    $massage = str_ireplace('hora', '****', $massage);
    $massage = str_ireplace('cyka cyka', '****', $massage);
    $massage = str_ireplace('whore', '****', $massage);
    $massage = str_ireplace('fuck', '****', $massage);
    $massage = str_ireplace('&#60;', '****', $massage);
    $massage = str_ireplace('&#62;', '****', $massage);
	$massage = str_ireplace('lenny', '( ͡° ͜ʖ ͡°)', $massage);
    $massage = str_ireplace('csvuclan.com', 'csvuclan.com', $massage);
    $massage = str_ireplace('scam', 'imgay', $massage);
    $massage = str_ireplace('scammed', 'imgay', $massage);
	
$massage =str_replace("👏","<img style='background:none;' id=smile src=/styles/images/chat/D83DDC4F.png>",$massage);
$massage =str_replace(":punch:","<img style='background:none;' id=smile src=/styles/images/chat/D83DDC4A.png>",$massage);
$massage =str_replace("✋","<img style='background:none;' id=smile src=/styles/images/chat/270B.png>",$massage);
$massage =str_replace("🙏","<img style='background:none;' id=smile src=/styles/images/chat/D83DDE4F.png>",$massage);
$massage =str_replace("👃","<img style='background:none;' id=smile src=/styles/images/chat/D83DDC43.png>",$massage);
$massage =str_replace("👆","<img style='background:none;' id=smile src=/styles/images/chat/D83DDC46.png>",$massage);
$massage =str_replace("👇","<img style='background:none;' id=smile src=/styles/images/chat/D83DDC47.png>",$massage);
$massage =str_replace("👈","<img style='background:none;' id=smile src=/styles/images/chat/D83DDC48.png>",$massage);
$massage =str_replace("💪","<img style='background:none;' id=smile src=/styles/images/chat/D83DDCAA.png>",$massage);
$massage =str_replace("👂","<img style='background:none;' id=smile src=/styles/images/chat/D83DDC42.png>",$massage);
$massage =str_replace("💋","<img style='background:none;' id=smile src=/styles/images/chat/D83DDC8B.png>",$massage);
$massage =str_replace("💩","<img style='background:none;' id=smile src=/styles/images/chat/D83DDCA9.png>",$massage);
$massage =str_replace("❄","<img style='background:none;' id=smile src=/styles/images/chat/2744.png>",$massage);
$massage =str_replace("🍷","<img style='background:none;' id=smile src=/styles/images/chat/D83CDF77.png>",$massage);
$massage =str_replace("🍸","<img style='background:none;' id=smile src=/styles/images/chat/D83CDF78.png>",$massage);
$massage =str_replace("🎅","<img style='background:none;' id=smile src=/styles/images/chat/D83CDF85.png>",$massage);
$massage =str_replace("Rekt","<img style='background:none;' id=smile src=/styles/images/chat/shrekt.png>",$massage);
$massage =str_replace("FeelsGoodMan","<img style='background:none;' id=smile src=/styles/images/chat/good.png>",$massage);
$massage =str_replace("Pepe","<img style='background:none;' id=smile src=/styles/images/chat/bad.png>",$massage);
$massage =str_replace(":duck:","<img style='background:none;' id=smile src=/styles/images/chat/duck.png>",$massage);
$massage =str_replace(":win:","<img style='background:none;' id=smile src=/styles/images/chat/D83CDFC6.png>",$massage);
$massage =str_replace(":dice:","<img style='background:none;' id=smile src=/styles/images/chat/D83CDFB2.png>",$massage);
$massage =str_replace("rip","<img style='background:none;' id=smile src=/styles/images/chat/rip.png>",$massage);
$massage =str_replace("kappa","<img style='background:none;' id=smile src=/styles/images/chat/kappa.png>",$massage);
$massage =str_replace("Rip","<img style='background:none;' id=smile src=/styles/images/chat/rip.png>",$massage);
$massage =str_replace("doge","<img style='background:none;' id=smile src=/styles/images/chat/doge.png>",$massage);
$massage =str_replace("doglyfe","<img style='background:none;' id=smile src=/styles/images/chat/thugdoge.png>",$massage);
$massage =str_replace("jcena","<img style='background:none;' id=smile src=/styles/images/chat/jcena.png>",$massage);
$massage =str_replace("cena","<img style='background:none;' id=smile src=/styles/images/chat/cena.png>",$massage);
$massage =str_replace("sanic","<img style='background:none;' id=smile src=/styles/images/chat/sanic.png>",$massage);
$massage =str_replace("troll","<img style='background:none;' id=smile src=/styles/images/chat/troll.png>",$massage);
$massage =str_replace("dank","<img style='background:none;' id=smile src=/styles/images/chat/dank.png>",$massage);
$massage =str_replace("dew","<img style='background:none;' id=smile src=/styles/images/chat/dew.png>",$massage);
$massage =str_replace("rekt","<img style='background:none;' id=smile src=/styles/images/chat/shrekt.png>",$massage);
$massage =str_replace("feelsgoodman","<img style='background:none;' id=smile src=/styles/images/chat/good.png>",$massage);
$massage =str_replace("pepe","<img style='background:none;' id=smile src=/styles/images/chat/bad.png>",$massage);
$massage =str_replace(":duck:","<img style='background:none;' id=smile src=/styles/images/chat/duck.png>",$massage);
$massage =str_replace("Kappa","<img style='background:none;' id=smile src=/styles/images/chat/kappa.png>",$massage);
$massage =str_replace("Doge","<img style='background:none;' id=smile src=/styles/images/chat/doge.png>",$massage);
$massage =str_replace("Doglyfe","<img style='background:none;' id=smile src=/styles/images/chat/thugdoge.png>",$massage);
$massage =str_replace("Jcena","<img style='background:none;' id=smile src=/styles/images/chat/jcena.png>",$massage);
$massage =str_replace("Cena","<img style='background:none;' id=smile src=/styles/images/chat/cena.png>",$massage);
$massage =str_replace("Sanic","<img style='background:none;' id=smile src=/styles/images/chat/sanic.png>",$massage);
$massage =str_replace("Troll","<img style='background:none;' id=smile src=/styles/images/chat/troll.png>",$massage);
$massage =str_replace("Dank","<img style='background:none;' id=smile src=/styles/images/chat/dank.png>",$massage);
$massage =str_replace("Dew","<img style='background:none;' id=smile src=/styles/images/chat/dew.png>",$massage);
$massage =str_replace("rigged","<img style='background:none;' id=smile src=/styles/images/chat/boo.png>",$massage);
$massage =str_replace("Rigged","<img style='background:none;' id=smile src=/styles/images/chat/boo.png>",$massage);
$massage =str_replace("RIGGED","<img style='background:none;' id=smile src=/styles/images/chat/boo.png>",$massage);
$massage =str_replace("GG","<img style='background:none;' id=smile src=/styles/images/chat/lel.png>",$massage);
$massage =str_replace("gg","<img style='background:none;' id=smile src=/styles/images/chat/lel.png>",$massage);
$massage =str_replace("shit","<img style='background:none;' id=smile src=/styles/images/chat/poo.png>",$massage);
$massage =str_replace("SHIT","<img style='background:none;' id=smile src=/styles/images/chat/poo.png>",$massage);
$massage =str_replace("Shit","<img style='background:none;' id=smile src=/styles/images/chat/poo.png>",$massage);
$massage =str_replace("snipe","<img style='background:none;' id=smile src=/styles/images/chat/incoming.png>",$massage);
$massage =str_replace("Snipe","<img style='background:none;' id=smile src=/styles/images/chat/incoming.png>",$massage);
$massage =str_replace("SNIPE","<img style='background:none;' id=smile src=/styles/images/chat/incoming.png>",$massage);
$massage =str_replace("knife","<img style='background:none;' id=smile src=/styles/images/chat/knife.png>",$massage);
$massage =str_replace("Knife","<img style='background:none;' id=smile src=/styles/images/chat/knife.png>",$massage);
$massage =str_replace("KNIFE","<img style='background:none;' id=smile src=/styles/images/chat/knife.png>",$massage);
$massage =str_replace("salty","<img style='background:none;' id=smile src=/styles/images/chat/bm.png>",$massage);
$massage =str_replace("Salty","<img style='background:none;' id=smile src=/styles/images/chat/bm.png>",$massage);
$massage =str_replace("SALTY","<img style='background:none;' id=smile src=/styles/images/chat/bm.png>",$massage);
$massage =str_replace("salt","<img style='background:none;' id=smile src=/styles/images/chat/bm.png>",$massage);
$massage =str_replace("Salt","<img style='background:none;' id=smile src=/styles/images/chat/bm.png>",$massage);
$massage =str_replace("SALT","<img style='background:none;' id=smile src=/styles/images/chat/bm.png>",$massage);
$massage =str_replace("1v1","<img style='background:none;' id=smile src=/styles/images/chat/m8.png>",$massage);
$massage =str_replace("1V1","<img style='background:none;' id=smile src=/styles/images/chat/m8.png>",$massage);
$massage =str_replace("fs","<img style='background:none;' id=smile src=/styles/images/chat/kek.png>",$massage);
$massage =str_replace("Fs","<img style='background:none;' id=smile src=/styles/images/chat/kek.png>",$massage);
$massage =str_replace("FS","<img style='background:none;' id=smile src=/styles/images/chat/kek.png>",$massage);

$file = 'chat.txt';
if ($steamprofile['steamid'] == '76561198252982272') {
    $massage = '<font color="#D2303D"><i>'.$massage.'</i></font>';
}
if ($steamprofile['steamid'] == '76561198137405577') {
    $massage = '<font color="#cc883c"><i>'.$massage.'</i></font>';
}
if ($steamprofile['steamid'] == '76561198194153457') {
    $massage = '<font color="#cc883c"><i>'.$massage.'</i></font>';
}
if ($steamprofile['steamid'] == '76561197969864656') {
    $massage = '<font color="#D2303D"><i>'.$massage.'</i></font>';
}
if ($steamprofile['steamid'] == '76561198074625962') {
    $massage = '<font color="#D2303D"><i>'.$massage.'</i></font>';
}
if ($steamprofile['steamid'] == '76561198056633125') {
    $massage = '<font color="#cc883c"><i>'.$massage.'</i></font>';
}
if ($steamprofile['steamid'] == '76561198160657448') {
    $massage = '<font color="#cc883c"><i>'.$massage.'</i></font>';
}
// UntamedFPS
if ($steamprofile['steamid'] == '76561198181903085') {
          $steamprofile['personaname']= '<font color=#fff><b>'.htmlspecialchars($steamprofile['personaname']).'</b></font><a href="twitch.tv/UntamedFPS"><i style="font: 14px &quot;FontAwesome&quot;; position: inherit; color: rgb(100, 65, 165); padding-left: 5px;" class="fa-twitch"></i></a>';
}
if ($steamprofile['steamid'] == '76561198073600914') {
          $steamprofile['personaname']= '<font color=#fff><b>'.htmlspecialchars($steamprofile['personaname']).'</b></font><a href="http://twitch.tv/captainbaconz"><i style="font: 14px &quot;FontAwesome&quot;; position: inherit; color: rgb(100, 65, 165); padding-left: 5px;" class="fa-twitch"></i></a>';
}
// Ali
if ($steamprofile['steamid'] == '76561198137405577') {
          $steamprofile['personaname']= '<font color=#fff><b>'.htmlspecialchars($steamprofile['personaname']).'</b></font><span style="position: inherit; font: 14px; color: #fff; margin-left: 5px; background: #cc883c; border-radius: 5px; border: 1px #cc883c solid;">MOD</span>';
}
//TJ
if ($steamprofile['steamid'] == '76561198194153457') {
          $steamprofile['personaname']= '<font color=#fff><b>'.htmlspecialchars($steamprofile['personaname']).'</b></font><span style="position: inherit; font: 14px; color: #fff; margin-left: 5px; background: #cc883c; border-radius: 5px; border: 1px #cc883c solid;">MOD</span>';
}
//Ognjen
if ($steamprofile['steamid'] == '76561198072212608') {
          $steamprofile['personaname']= '<font color=#fff><b>'.htmlspecialchars($steamprofile['personaname']).'</b></font><span style="position: inherit; font: 14px; color: #fff; margin-left: 5px; background: #D2303D; border-radius: 5px; border: 1px #D2303D solid;">ADMIN</span>';
}
//Vidmar
if ($steamprofile['steamid'] == '76561198250718750') {
          $steamprofile['personaname']= '<font color=#fff><b>'.htmlspecialchars($steamprofile['personaname']).'</b></font><span style="position: inherit; font: 14px; color: #fff; margin-left: 5px; background: #D2303D; border-radius: 5px; border: 1px #D2303D solid;">OWNER</span>';
}
//Nix
if ($steamprofile['steamid'] == '76561198093374830') {
          $steamprofile['personaname']= '<font color=#fff><b>'.htmlspecialchars($steamprofile['personaname']).'</b></font><a href="http://twitch.tv/nixtys" target="_blank"><i style="font: 14px &quot;FontAwesome&quot;; position: inherit; color: rgb(100, 65, 165); padding-left: 5px;" class="fa-twitch"></i></a>';
}
//Jamal
if ($steamprofile['steamid'] == '76561198074625962') {
          $steamprofile['personaname']= '<font color=#fff><b>'.htmlspecialchars($steamprofile['personaname']).'</b></font><span style="position: inherit; font: 14px; color: #fff; margin-left: 5px; background: #D2303D; border-radius: 5px; border: 1px #D2303D solid;">ADMIN</span>';
}
//Biff
if ($steamprofile['steamid'] == '76561198056633125') {
          $steamprofile['personaname']= '<font color=#fff><b>'.htmlspecialchars($steamprofile['personaname']).'</b></font><span style="position: inherit; font: 14px; color: #fff; margin-left: 5px; background: #cc883c; border-radius: 5px; border: 1px #cc883c solid;">MOD</span>';
}
//DrLol
if ($steamprofile['steamid'] == '76561198160657448') {
          $steamprofile['personaname']= '<font color=#fff><b>'.htmlspecialchars($steamprofile['personaname']).'</b></font><a href="http://www.twitch.tv/drlollipop" target="_blank"><i style="font: 14px &quot;FontAwesome&quot;; position: inherit; color: rgb(100, 65, 165); padding-left: 5px;" class="fa-twitch"></i></a>';
}
if (ban($_SESSION['steamid'])) { 
$person = '<div></div>'; } else { $person = '<div class="chat-msg" >
            <div class="caht-ava"><img style="border-radius:50%;"src="'.$steamprofile['avatarmedium'].'" width="30px; "></div>
            <div class="caht-name"><a href="'.$steamprofile['profileurl'].'" target="_blank">'.$steamprofile['personaname'].'</a></div>
            <div class="msg-text">'.$massage.'</div>
</div>'; }

// Пишем содержимое в файл,
// используя флаг FILE_APPEND flag для дописывания содержимого в конец файла
// и флаг LOCK_EX для предотвращения записи данного файла кем-нибудь другим в данное время
file_put_contents($file, $person, FILE_APPEND | LOCK_EX);
}
    exit;
}


 ?>
