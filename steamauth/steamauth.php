<?php
ob_start();
session_start();
require ('steamauth/openid.php');

function logoutbutton() {
    echo "<form action=\"steamauth/logout.php\" method=\"post\"><input value=\"Logout\" type=\"submit\" /></form>"; //logout button

}

function steamlogin()
{
    try {
        require("steamauth/settings.php");
        $openid = new LightOpenID($steamauth['domainname']);

        $button['small'] = "small";
        $button['large_no'] = "large_noborder";
        $button['large'] = "large_border";
        $button = $button[$steamauth['buttonstyle']];
        
        if(!$openid->mode) {
            if(isset($_GET['login'])) {
                $openid->identity = 'http://steamcommunity.com/openid';
                header('Location: ' . $openid->authUrl());
            }

        return '<a href="?login"><img src="http://cdn.steamcommunity.com/public/images/signinthroughsteam/sits_'.$button.'.png" alt="Sign in through Steam"/></a>';
        }

         elseif($openid->mode == 'cancel') {
            echo 'User has canceled authentication!';
        } else {
            if($openid->validate()) { 
                    $id = $openid->identity;
                    $ptn = "/^http:\/\/steamcommunity\.com\/openid\/id\/(7[0-9]{15,25}+)$/";
                    preg_match($ptn, $id, $matches);
                  
                    $_SESSION['steamid'] = $matches[1]; 

                    //Determine the return to page. We substract "login&"" to remove the login var from the URL.
                    //"file.php?login&foo=bar" would become "file.php?foo=bar"
                    $returnTo = str_replace('login&', '', $_GET['openid_return_to']);
                    //If it didn't change anything, it means that there's no additionals vars, so remove the login var so that we don't get redirected to Steam over and over.
                    if($returnTo === $_GET['openid_return_to']) $returnTo = str_replace('?login', '', $_GET['openid_return_to']);
                    header('Location: '.$returnTo);
            } else {
                    echo "User is not logged in.\n";
            }

        }
    } catch(ErrorException $e) {
        echo $e->getMessage();
    }
}

?>
