<?php session_start();

@include_once('set.php');
if($_POST['message']){

  if(isset($_SESSION["steamid"])) {

    
require('steamauth/steamauth.php');

$msg = $_POST['message'];
$msg = str_replace("\"", "", $msg);
$msg = str_replace("\'", "", $msg);
$msg = str_replace("\\", "", $msg);
$msg = str_replace("'", "", $msg);
$msg = str_replace("<", "", $msg);
$msg = str_replace(">", "", $msg);
$steamid = (int)$_SESSION["steamid"];
$ban = fetchinfo("ban","users","steamid",$steamid);
// if(stristr($msg,".ru") == NULL)
if($ban!=1 && $msg!="" && stristr($msg,".ru") == NULL){
$sql = "INSERT INTO `chat` (`id`, `text`, `steamid`) VALUES (NULL, '".mysql_real_escape_string($msg)."', '$steamid');";
mysql_query($sql);
}
}
}
else
{
   $sql = "SELECT * FROM  `chat` ORDER BY  `id` DESC LIMIT 0 , 20";
   $q = mysql_query($sql);
  
   $arr = array();
   $c = count($res);
   while( $res = mysql_fetch_array($q)) {
    $a = array();
    $a['steamid'] = $res['steamid'];
    $a['message'] = $res['text'];
    $id = (int)$res['steamid'];
    $sql = "SELECT * FROM  `users` where `steamid` = '$id'";
    $ma = mysql_fetch_assoc(mysql_query($sql));
    $status = (int)$ma['status'];
    if($status==1){
        $a['name'] = '<b style="color: pink;">[VIP] </b>'.$ma['name'];
        $a['avatar'] =$ma['avatar'];
        $arr[] = $a;
    }else if($status==2) {
        $a['name'] = '<b style="color: red;">[OWNER] </b>'.$ma['name'];
        $a['avatar'] =$ma['avatar'];
        $arr[] = $a;
		}else if($status==3) {
        $a['name'] = '<b style="color: blue;">[ADMIN] </b>'.$ma['name'];
        $a['avatar'] =$ma['avatar'];
        $arr[] = $a;
		}else if($status==4) {
        $a['name'] = '<b style="color: green;">[Mod] </b>'.$ma['name'];
        $a['avatar'] =$ma['avatar'];
        $arr[] = $a;
    }
		else
	{
        
    $a['name'] = $ma['name'];
    $a['avatar'] = $ma['avatar'];
    $arr[] = $a;
    }
    
   }
print_r(json_encode($arr));
}

?>