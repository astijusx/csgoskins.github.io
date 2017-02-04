<?php
$banlist=array(
		'76561198165260712',
		'76561198046033419',
		'76561198172545183',
		'76561198231288528',
		'76561197997827285',
		'76561198076287583',
		'76561198128841014',
		'76561198299293909',
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