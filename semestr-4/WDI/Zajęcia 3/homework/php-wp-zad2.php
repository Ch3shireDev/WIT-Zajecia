<!DOCTYPE html>

<html>

<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">

    <title>Przykład 3</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
</head>

<body>
    <ul>
        <?php
        $colors = array(
            "black" =>    "#000000",
            "silver" => "#C0C0C0",
            "gray" => "#808080",
            "white" => "#FFFFFF",
            "maroon" => "#800000",
            "red" => "#FF0000",
            "purple" => "#800080",
            "fuchsia" => "#FF00FF",
            "green" => "#008000",
            "lime" => "#00FF00",
            "olive" => "#808000",
            "yellow" => "#FFFF00",
            "navy" => "#000080",
            "blue" => "#0000FF",
            "teal" => "#008080",
            "aqua" => "#00FFFF"
        );
        foreach ($colors as $name => $hex) {
            echo "<li style=\"color: $hex\">$name</li>";
        }
        ?>
    </ul>
</body>

</html>