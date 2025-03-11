<?php 

namespace ScreenMatch\Calculos;

use ScreenMatch\Modelo\Avaliavel;

class ConversorNotaEstrela{
    public function convert(Avaliavel $avaliavel): float{
        $nota = $avaliavel->media();

        return round($nota) / 2;
    }
}

?>