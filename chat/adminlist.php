<?php
$adminslist=array(
		'76561198252982272', // ENTER ADMINS - STEAM64ID CAN BE GET THROUGH : * STEAMID.IO *
		'76561198225545216', // ENTER ADMINS - STEAM64ID CAN BE GET THROUGH : * STEAMID.IO *
		'76561198074625962'
	);

function isadmin($steamid)
{
	global $adminslist;
	if(in_array($steamid, $adminslist))
	{
		return true;
	}
	else
	{
		return false;
	}
}