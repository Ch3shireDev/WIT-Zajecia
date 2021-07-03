<?php
session_start();
if (empty($_SESSION['zalogowany'])) {
    header("Location: przyklad3.php?komunikat=1");
    exit();
}
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>WIT</title>
</head>

<body>
    Tajna strona.
</body>

</html>