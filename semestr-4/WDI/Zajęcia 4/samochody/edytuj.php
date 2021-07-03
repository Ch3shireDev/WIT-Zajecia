<?php

require_once 'funkcje.php';

sprawdzLogowanie();

if (isset($_GET['id'])) {
    $id = (int) $_GET['id'];
    $pdo = polacz();

    if (isset($_POST['zapisz'])) {
        // obsługa edycji rekordu
        $stmt = $pdo->prepare("UPDATE samochody SET marka = :marka, model = :model, rok = :rok, typ_silnika = :typ_silnika WHERE id = :id");
        $wynik = $stmt->execute([
            'marka' => $_POST['marka'],
            'model' => $_POST['model'],
            'rok' => $_POST['rok'],
            'typ_silnika' => $_POST['typ_silnika'],
            'id' => $id,
        ]);

        if ($wynik == true) {
            header("Location: edytuj.php?id=$id&komunikat=1");
            exit();
        } else {
            die("Operacja się nie powiodła: " . $pdo->errorInfo());
        }
    } else {
        // wczytanie danych samochodu z bazy
        $stmt = $pdo->prepare("SELECT * FROM samochody WHERE id = :id");
        $stmt->execute(['id' => $id]);
        $wiersz = $stmt->fetch();

        if (!$wiersz) {
            die("Nie znaleziono podanego samochodu!");
        }
    }
} else {
    die("Nie podano ID");
}
?>
<!DOCTYPE html>
<html>

<head>
    <title>Edycja</title>
    <meta charset="utf-8">
</head>

<body>
    <?php if (($_GET['komunikat'] ?? null) == 1) : ?>
        <p style='color:red; font-weight:bold;'>Dane zostaly zapisane.</p>
    <?php endif; ?>

    <form method="post" action="">
        <table>
            <tr>
                <td>Marka</td>
                <td><input type="text" name="marka" value="<?= $wiersz['marka'] ?? '' ?>" /></td>
            </tr>
            <tr>
                <td>Model</td>
                <td><input type="text" name="model" value="<?= $wiersz['model'] ?? '' ?>" /></td>
            </tr>
            <tr>
                <td>Rok</td>
                <td><input type="text" name="rok" value="<?= $wiersz['rok'] ?? '' ?>" /></td>
            </tr>
            <tr>
                <td>Typ silnika</td>
                <td>
                    <select name="typ_silnika">
                        <option value="benzyna" <?= ($wiersz['typ_silnika'] ?? '') == 'benzyna' ? 'selected' : '' ?>>benzyna</option>
                        <option value="diesel" <?= ($wiersz['typ_silnika'] ?? '') == 'diesel' ? 'selected' : '' ?>>diesel</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td colspan="2"><input type="submit" name="zapisz" value="Zapisz" /></td>
            </tr>
        </table>
    </form>

    <p>
        <a href="index.php">[ Powrót do listy ]</a>
    </p>
</body>

</html>