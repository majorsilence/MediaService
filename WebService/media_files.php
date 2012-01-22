<?php
/*

This service is used to retrieve video address so they 
can be streamed.  It will return
IdMediaFiles, IdMediaInfo, FileLocation, VideoBitrate (in kb), 
MediaFileTypeCode, MediaLength (in seconds)

The file location is a link to the location of the cover art and must be
joined with the base url.

*/

require_once("connection_info.php");
require("security.php");


// This will immediatly kill the script if the username
// password combination is wrong
do_login_basic();

try{

	$search = $_REQUEST["search"];
	if(!filter_var($search, FILTER_VALIDATE_INT))
	{
		"Invalid ?search value";
		exit();
	}

	$dbh = get_connection();
	
	$stmt = $dbh->prepare('CALL MediaFilesSCmd(:pIdMediaInfo)');
	$stmt->bindParam(':pIdMediaInfo', $search, PDO::PARAM_INT); 
	
	$stmt->execute();
    $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
	
	header('Content-type: application/json');
	// Notice that it is Products with an S
	echo json_encode($result);
}
catch(Exception $e){
	print "Error!: " . $e->getMessage() . "<br/>";
    die();
}

?>
