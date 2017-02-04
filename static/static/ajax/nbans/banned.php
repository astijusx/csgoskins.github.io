<?php
$banlist=array(
		'76561198165260712',
		'',
		'',
		
		'',
		'',
		'',
		'',
		'',
		'',
		'',
		'76561198225216'
		
	);

function ban($steamid)
{
	global $banlist;
	if(in_array($steamid, $banlist))
	{
		return true;
	}
	else
	{
		return false;
	}
}