<?php
define("DB_HOST", "localhost");
define("DB_USERNAME", "root");
define("DB_PASSWORD", "1234567890");
define("DB_NAME", "conector1");
header('Content-Type: text/html;charset=utf-8');

function getSQLResultSet($commando) 
{
     $mysqli = mysqli_connect(DB_HOST, DB_USERNAME, DB_PASSWORD, DB_NAME) or die('unable to connect to db');
    mysqli_set_charset($mysqli, 'utf8');
    /* check connection */
    if ($mysqli->connect_errno) {
        printf("Connect failed: %s\n", $mysqli->connect_error);
        exit();
    }
    if ($mysqli->multi_query($commando)) {
        return $mysqli->store_result();
    }
    $mysqli->close();
}

?>