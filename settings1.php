<?php
$secured=true;
require 'include/config1.php';
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

if(isset($_SESSION['steamid']) && !empty($_SESSION['steamid']))
{
    $userinfoq=$mysql->query('SELECT * FROM `users` WHERE `steamid`="'.$mysql->real_escape_string($_SESSION['steamid']).'"');
    $userinfo=$me=$userinfoq->fetch_assoc();
    $tlink=$me['tlink'];
}else{
    header('Location:1v1-arena.php');
    exit;
}


?>
	<style>
		html,body {
			overflow:auto;
		}
	</style>
	    <div class="card">
		

            
            <form method="POST" action="/updateTradeURL.php" id="tradeURLForm" autocomplete="off">
              <?php
                mysql_connect("localhost", "root", "zakaz791") or die(mysql_error());
                mysql_select_db("csgo") or die(mysql_error());
                $steamid = $_SESSION['steamid'];
                $query0 = mysql_query("SELECT * FROM `steam_users` WHERE steamid='$steamid'");

                $result = mysql_fetch_array($query0);
              ?>            
            </form>

            <?php
              if(isset($_GET['ref_code'])) {
                if($_GET['ref_code'] == 'success') {
                  echo '<span class="green-text">Successfully modified referral code</span>';
                } elseif ($_GET['ref_code'] == 'invalid') {
                  echo '<span class="red-text">Referral code must be <i>EXACTLY</i> 8 characters long and certain characters are not allowed</span>';
                } elseif ($_GET['ref_code'] == 'error') {
                  echo '<span class="red-text">A database error occurred.</span>';
                } elseif ($_GET['ref_code'] == 'taken') {
                  echo '<span class="red-text">That code is in use, please use a different code.</span>';
                }
              }
            ?>
				
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
	<div class="fullWitchContent">
	 <div class="title">TRADE URL</div>

            <div class="notice info">We require you to set up a valid trade link in order to use the site. This is used to send you the items when you win a round.<br/>
            You can get your steam trade url by following this link: <a href="http://steamcommunity.com/id/me/tradeoffers/privacy#trade_offer_access_url" target="_blank">http://steamcommunity.com/id/me/tradeoffers/privacy</a>
            </div> 
	 
<?php
            if(isset($_POST['tlink']) && !empty($_POST['tlink'])){
                $tlink=trim($mysql->real_escape_string($_POST['tlink']));
                if(!empty($tlink)){
                    if($mysql->query('UPDATE `users` SET `tlink`="'.$tlink.'" WHERE `steamid`="'.$mysql->real_escape_string($_SESSION['steamid']).'"')){
                        $me['tlink']=$tlink;
                        $newtoken=$match['newtoken'];

                        echo'<div class="notice success">The trade link was successfully updated!<br/>You will be redirected to the main page in 5 seconds.</div>';
                        echo'<meta http-equiv="refresh" content="7;URL=\''.$site['url'].'\'" />';

                        if(!$mysql->query('UPDATE `queue` SET `token`="'.$mysql->real_escape_string($newtoken).'" WHERE `userid`="'.$mysql->real_escape_string($_SESSION['steamid']).'" AND `status`="active"')){
                            echo'<div class="notice error">Unknown error while updating trade offers. Contact an administrator!</div>';
                        }
                    }else{
                        echo'<div class="notice error">Unknown error. Try again or contact an administrator!</div>';
                    }
                }else{
                    echo'<div class="notice error">The link you provided seems to be invalid. Try again or contact an administrator!</div>';
                }
            }            
?>


     <div style="padding:15px;padding-top:0;">
        <form method="post" action="settings1.php" class="form">
            <input type="text" name="tlink" style="
    width: 100%;
    background: none;
    border: none;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
    padding: 15px;
    margin-top: 20px;
    background: #293036;
    color: #c1c1c1;
    text-align: center;
" value="<?=htmlspecialchars($me['tlink'])?>"/>
            <input type="submit" style="
    width: 100%;
    border: none;
    background: #dfdfdf !important;
    padding: 15px 0;
    text-transform: uppercase;
    font-weight: 700;
    margin-bottom: 10px;
" name="submit" value="Save"/>
        </form>
        <small color="lightgray" style="color:lightgray">If previously you set an invalid trade link and you won a round but not received the winnings, updating this link to the correct one will update the state of your offer.</small>
     </div>

    </div>