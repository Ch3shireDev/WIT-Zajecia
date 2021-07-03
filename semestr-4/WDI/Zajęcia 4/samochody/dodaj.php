<?php

require_once 'funkcje.php';

sprawdzLogowanie();

if (isset($_POST['dodaj'])) {
    $pdo = polacz();

    $stmt = $pdo->prepare("INSERT INTO samochody (marka, model, rok, typ_silnika) VALUES (:marka, :model, :rok, :typ_silnika)");
    $wynik = $stmt->execute([
        'marka' => $_POST['marka'],
        'model' => $_POST['model'],
        'rok' => $_POST['rok'],
        'typ_silnika' => $_POST['typ_silnika'],
    ]);

    if ($wynik == true) {
        header("Location: index.php?komunikat=1");
        exit();
    } else {
        die("Operacja się nie powiodła: " . $pdo->errorInfo());
    }
}
?>
<!DOCTYPE html>
<html>

<head>
    <title>Dodaj</title>
    <meta charset="utf-8">
</head>

<body>
    <form method="post" action="">
        <table>
            <tr>
                <td>Marka</td>
                <td><input type="text" name="marka" /></td>
            </tr>
            <tr>
                <td>Model</td>
                <td><input type="text" name="model" /></td>
            </tr>
            <tr>
                <td>Rok</td>
                <td><input type="text" name="rok" /></td>
            </tr>
            <tr>
                <td>Typ silnika</td>
                <td>
                    <select name="typ_silnika">
                        <option value="benzyna">benzyna</option>
                        <option value="diesel">diesel</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td colspan="2"><input type="submit" name="dodaj" value="Dodaj" /></td>
            </tr>
        </table>
    </form>

    <p>
        <a href="index.php">[ Powrót do listy ]</a>
    </p>
</body>

</html>