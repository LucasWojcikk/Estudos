<?php 

class ConversorNotaEstrela{
    public function convert(Avaliavel $avaliavel): float{
        $nota = $avaliavel->media();

        return round($nota) / 2;
    }
}

?>