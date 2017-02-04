<?php
$sitebanlist=array(
		'76561198167523212',
		
		'76561198250718750',
		'76561198299293909',
		'76561198128841014',
		'',
		'',
		'',
		'',
		'',
		'',
		'',
		'76561198225216'
		
	);

function siteban($steamid)
{
	global $sitebanlist;
	if(in_array($steamid, $sitebanlist))
	{
		return true;
	}
	else
	{
		return false;
	}
}