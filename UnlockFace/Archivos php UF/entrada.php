<?php
include('functions.php');
$alumno = array();	
$correot= $_GET['correot'];
if($resultset=getSQLResultSet("SELECT Nombre, ApellidoP, ApellidoM, Matricula, Nombre_Tutor, Tel_Tutor, Entrada, Salida FROM alumnos_bachillerato WHERE CorreoTutor= '$correot'"))
{
	
    while ($row = $resultset->fetch_array(MYSQLI_NUM))
    {
		$e = array();
                $e['Nombre'] = $row[0];
                $e['ApellidoP'] = $row[1];
                $e['ApellidoM'] = $row[2];
                $e['Matricula'] = $row[3];
                $e['Nombre_Tutor'] = $row[4];
                $e['Tel_Tutor'] = $row[5];
                $e['Entrada'] = $row[6];
                $e['Salida'] = $row[7];
                array_push($alumno,$e);
	}
        echo json_encode($alumno[0]);
}
?>

