<?php
include('functions.php');
$alumno = array();
$correot= $_GET['correot'];
if($resultset=getSQLResultSet("SELECT Nombre, CorreoTutor FROM alumnos_bachillerato WHERE CorreoTutor= '$correot'"))
{
        while ($row = $resultset->fetch_array(MYSQLI_NUM))
        {
                $e = array();
                $e['Nombre'] = $row[0];
                $e['Correo'] = $row[1];
                array_push($alumno,$e);
        }
        echo json_encode($alumno[0]);
}
?>

