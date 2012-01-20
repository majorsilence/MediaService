<?php
require_once("connection_info.php");
require("security.php");


// This will immediatly kill the script if the username
// password combination is wrong
do_login_basic();

try{

	$search = base64_decode(filter_input(INPUT_GET, 'search', FILTER_SANITIZE_STRING));
	$dbh = get_connection();
	
	$stmt = $dbh->prepare('CALL MediaInfoSLikeCmd(:pMediaName)');
	$stmt->bindParam(':pMediaName', $email, PDO::PARAM_STR, 200); 
	
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
