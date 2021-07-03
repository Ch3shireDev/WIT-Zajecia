<?php

require_once 'funkcje.php';

sprawdzLogowanie();

if (isset($_GET['id'])) {
    $pdo = polacz();

    $stmt = $pdo->prepare("SELECT * FROM samochody WHERE id = :id");
    $stmt->execute(['id' => $_GET['id']]);
    $wiersz = $stmt->fetch();

    if (!$wiersz) {
        die("Nie znaleziono podanego samochodu!");
    }
} else {
    die("Nie podano parametru!");
}
?>
<!DOCTYPE html>
<html>

<head>
    <title>Szczegóły</title>
    <meta charset="utf-8">
</head>

<body>
    <table>
        <tr>
            <td>Marka</td>
            <td><?= $wiersz['marka'] ?></td>
        </tr>
        <tr>
            <td>Model</td>
            <td><?= $wiersz['model'] ?></td>
        </tr>
        <tr>
            <td>Rok</td>
            <td><?= $wiersz['rok'] ?></td>
        </tr>
        <tr>
            <td>Pojemność</td>
            <td><?= $wiersz['pojemnosc'] ?></td>
        </tr>
        <tr>
            <td>Typ silnika</td>
            <td><?= $wiersz['typ_silnika'] ?></td>
        </tr>
        <tr>
            <td>Liczba poduszek</td>
            <td><?= $wiersz['liczba_poduszek'] ?></td>
        </tr>
        <tr>
            <td>ABS</td>
            <td><?= $wiersz['abs'] ?></td>
        </tr>
        <tr>
            <td>ESP</td>
            <td><?= $wiersz['esp'] ?></td>
        </tr>
    </table>

    <p>
        <a href="index.php">[ Powrót do listy ]</a>
    </p>
</body>

</html>