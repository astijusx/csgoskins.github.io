<?php 
session_start();
include ('/steamauth/userInfo.php');
if(isset($_SERVER['http_X_REQUESTED_WITH']) && !empty($_SERVER['http_X_REQUESTED_WITH']) && strtolower($_SERVER['http_X_REQUESTED_WITH']) == 'xmlhttprequest') {
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
    $massage = str_replace('>', '*', $massage);
    $massage = str_replace('<', '*', $massage);
    $massage = str_replace('/', '*', $massage);
    $massage = str_replace('iframe', '*', $massage);
    $massage = str_replace('script', '*', $massage);
    $massage = str_replace('CSGO', '****', $massage);
    $massage = str_replace('csgo', '****', $massage);
    $massage = str_replace('http:', '****', $massage);
    $massage = str_replace('www', '****', $massage);
    $massage = str_replace('http:', '****', $massage);
    $massage = str_replace('src', '****', $massage);
    $massage = str_replace('.com', '****', $massage);
    $massage = str_replace('.org', '****', $massage);
    $massage = str_replace('csgobig.com', '****', $massage);
    $massage = str_replace('.net', '****', $massage);
    $massage = str_replace('allahu akbar', '****', $massage);
    $massage = str_replace('9/11', '****', $massage);
    $massage = str_replace('hitler', '****', $massage);
    $massage = str_replace('nazi', '****', $massage);
    $massage = str_replace('faggot', '****', $massage);
    $massage = str_replace('nigga', '****', $massage);
    $massage = str_replace('nigger', '****', $massage);
    $massage = str_replace('aids', '****', $massage);
    $massage = str_replace('knulla', '****', $massage);
    $massage = str_replace('fitta', '****', $massage);
    $massage = str_replace('kuk', '****', $massage);
    $massage = str_replace('hora', '****', $massage);
    $massage = str_replace('cyka cyka', '****', $massage);
    $massage = str_replace('whore', '****', $massage);
    $massage = str_replace('fuck', '****', $massage);
    $massage = str_replace('&#60;', '****', $massage);
    $massage = str_replace('&#62;', '****', $massage);
    $massage = str_replace('. COM', '****', $massage);
    $massage = str_replace('.COM', '****', $massage);
    $massage = str_replace('C S G O', '****', $massage);
    $massage = str_replace(' ', '****', $massage);
    $massage = str_replace('  ', '****', $massage);
    $massage = str_replace('   ', '****', $massage);
    $massage = str_replace('    ', '****', $massage);
    $massage = str_replace('     ', '****', $massage);
    $massage = str_replace('      ', '****', $massage);
    $massage = str_replace('       ', '****', $massage);
    $massage = str_replace('        ', '****', $massage);
    $massage = str_replace('         ', '****', $massage);    
    $massage = str_replace('          ', '****', $massage);
    $massage = str_replace('           ', '****', $massage);
    $massage = str_replace('            ', '****', $massage);
    $massage = str_replace('             ', '****', $massage);
    $massage = str_replace('              ', '****', $massage);
    $massage = str_replace('               ', '****', $massage);
    $massage = str_replace('                ', '****', $massage);
    $massage = str_replace('                 ', '****', $massage);
    $massage = str_replace('                  ', '****', $massage);
    $massage = str_replace('                   ', '****', $massage);
    $massage = str_replace('                    ', '****', $massage);
    $massage = str_replace('                     ', '****', $massage);
    $massage = str_replace('                      ', '****', $massage);
    $massage = str_replace('                       ', '****', $massage);
    $massage = str_replace('                        ', '****', $massage);
    $massage = str_replace('                         ', '****', $massage);
    $massage = str_replace('                          ', '****', $massage);
    $massage = str_replace('                           ', '****', $massage);
    $massage = str_replace('                            ', '****', $massage);
    $massage = str_replace('                             ', '****', $massage);
    $massage = str_replace('                              ', '****', $massage);
    $massage = str_replace('                               ', '****', $massage);
    $massage = str_replace('                                ', '****', $massage);
    $massage = str_replace('                                 ', '****', $massage);
    $massage = str_replace('csvuclan.com', 'csvuclan.com', $massage);
    $massage =str_replace("👏","<img style='background:none;' id=smile 

src=/styles/images/chat/D83DDC4F.png>",$massage);
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
$massage =str_replace("Rekt","<img style='background:none;' id=smile src=/styles/images/chat/rekt.png>",$massage);
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
$massage =str_replace("rekt","<img style='background:none;' id=smile src=/styles/images/chat/rekt.png>",$massage);
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

$file = 'chat.txt';
if ($steamprofile['steamid'] == '76561198167523241') {
    $massage = '<font color="#D2303D"><i>'.$massage.'</i></font>';
}
if ($steamprofile['steamid'] == '76561198137405577') {
    $massage = '<font color="#cc883c"><i>'.$massage.'</i></font>';
}
if ($steamprofile['steamid'] == '76561198252982272') {
    $massage = '<font color="#D2303D"><i>'.$massage.'</i></font>';
}

// Новый человек, которого нужно добавить в файл
$person = '<div class="chat-msg">
            <div class="caht-ava"><img src="'.$steamprofile['avatarmedium'].'" width="30px"></div>
            <div class="caht-name"><a href="'.$steamprofile['profileurl'].'" target="_blank">'.$steamprofile['personaname'].'</a></div>
            <div class="msg-text">'.$massage.'</div>
        </div>';
// Пишем содержимое в файл,
// используя флаг FILE_APPEND flag для дописывания содержимого в конец файла
// и флаг LOCK_EX для предотвращения записи данного файла кем-нибудь другим в данное время
file_put_contents($file, $person, FILE_APPEND | LOCK_EX);
}
    exit;
}


 ?>
