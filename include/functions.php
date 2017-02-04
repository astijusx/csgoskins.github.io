<?php
if(!isset($secured)){ die('Not authorized.'); }

include'include/pagination.class.php';

function myround($var)
{

	$var=(float)$var;

	if($var>99.99)
	{
		$res=round($var,0);
	}
	elseif($var>9.99 && $var<99.99)
	{
		$res=round($var,1);
	}
	else
	{
		$res=round($var,2);
	}

	return $res;
}

function disguise_curl($url) 
{ 
  $curl = curl_init(); 

  // Setup headers - I used the same headers from Firefox version 2.0.0.6 
  // below was split up because php.net said the line was too long. :/ 
  $header[0] = "Accept: text/xml,application/xml,application/xhtml+xml,"; 
  $header[0] .= "text/html;q=0.9,text/plain;q=0.8,image/png,*/*;q=0.5"; 
  $header[] = "Cache-Control: max-age=0"; 
  $header[] = "Connection: keep-alive"; 
  $header[] = "Keep-Alive: 300"; 
  $header[] = "Accept-Charset: ISO-8859-1,utf-8;q=0.7,*;q=0.7"; 
  $header[] = "Accept-Language: ro,en;q=0.5"; 
  $header[] = "Pragma: "; // browsers keep this blank. 

  curl_setopt($curl, CURLOPT_URL, $url); 
  curl_setopt($curl, CURLOPT_USERAGENT, 'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36'); 
  curl_setopt($curl, CURLOPT_HTTPHEADER, $header); 
  curl_setopt($curl, CURLOPT_REFERER, 'http://steamstat.us'); 
  curl_setopt($curl, CURLOPT_ENCODING, 'gzip,deflate'); 
  curl_setopt($curl, CURLOPT_AUTOREFERER, true); 
  curl_setopt($curl, CURLOPT_RETURNTRANSFER, 1); 
  curl_setopt($curl, CURLOPT_TIMEOUT, 10); 

  $html = curl_exec($curl); // execute the curl command 
  curl_close($curl); // close the connection 

  return $html; // and finally, return $html 
} 

function antispam($nick) {
	$nick2=preg_replace('/\s+?/','',$nick);
	if(preg_match('/(([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?)/i', $nick2) && !preg_match('/YoloSkins?\.com/i',$nick2)){
		return preg_replace('/([\da-z\.-]+)\.([a-z\.]{2,4})([\/\w \.-]*)*\/?/i', '✪',$nick);
	}
	return $nick;
}

function cc($userid){
	global $ccs;
	
	if(isset($ccs[$userid])){
		return '&nbsp;<a href="'.$ccs[$userid]['url'].'" target="_blank" title="'.$ccs[$userid]['title'].'"><img src="'.$ccs[$userid]['icon'].'" alt="[#]"/></a>';
	}else{
		return'';
	}
}


/* jquery func
function myround(inpvar){
  var resultvar;
	if(inpvar>99.99){
		resultvar=Math.round(inpvar);
	}
	else if(inpvar>9.99 && inpvar<99.99){
		resultvar=inpvar.toFixed(1);
	}
	else{
		resultvar=inpvar.toFixed(2);
	}

	return resultvar;
}
*/