<?php
//   $valorA = 50;
//    $valorB = 10;

//    // . para concaternar


//   if ($valorA > $valorB){
//        echo "O valor " . $valorA . " é maior";
//    }
   
//   elseif ($valorA < $valorB){
//        echo "O valor " . $valorB . " é maior";
//    }

//    else {
//        echo "iguais";
//    }
?>


<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>

    <form action="#" method=POST>
        Nota: <input type="text" name=nota required> <br>
        Percentual de faltas: <input type="text" name=perc_falta required><br>
        <input type="submit" name=botao value="Mostrar"> <br>

    </form>

    <?php
        // nota 7 perc_faltas 25

        if (@$_REQUEST['botao']){
            $nota = $_POST['nota'];
            $perc_faltas = $_POST['perc_falta'];

            if ($nota >= 7 && $perc_faltas >= 25){
                echo "Nota: ".$nota . "<br>";
                echo "Porcentual de fatas: ". $perc_faltas . "<br>";
                echo "Resultado Aprovado" . "<br>";
            }

            else {
                echo "Nota: ".$nota . "<br>";
                echo "Porcentual de fatas: ".$perc_faltas . "<br>";
                echo "Resultado Reprovado" . "<br>";
            }
        }
    ?>
    
</body>
</html>



