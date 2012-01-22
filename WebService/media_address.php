<?php
/*

This service will return list of base media addresses that can be
used to stream video and cover art.

Returns Address


*/

require_once("connection_info.php");
require("security.php");


// This will immediatly kill the script if the username
// password combination is wrong
do_login_basic();

try{
	// TODO: Hard coded addresses for now.  Needs to be changed to read from a config file.
	$json = '[{"Address":"http://files.majorsilence.com/mediaservice"}, ';
	$json = $json . '{"Address":"http://files.majorsilence.com/mediaservice"}]';

	header('Content-type: application/json');
	// Notice that it is Products with an S
	echo $json;
}
catch(Exception $e){
	print "Error!: " . $e->getMessage() . "<br/>";
    die();
}

?>
