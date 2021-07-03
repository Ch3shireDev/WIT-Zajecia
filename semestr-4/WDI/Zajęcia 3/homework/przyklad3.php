<?php
session_start();
if (!empty($_POST)) {
    if ($_POST['uzytkownik'] == 'admin' && $_POST['haslo'] == 'tajne') {
        $_SESSION['zalogowany'] = 'tak';
        header("Location: tajne.php");
    }
    else{ header("Location: bad_password.php");
    }

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
    <?php if (isset($_GET['komunikat']) && $_GET['komunikat'] == 1) : ?>
        <p style='color: red;'>Najpierw musisz sie zalogowac!</p>
    <?php endif; ?>
    <form method="post" action="przyklad3.php">
        Nazwa użytkownika:
        <input type="text" name="uzytkownik" />
        <br />

        Hasło:
        <input type="password" name="haslo" />
        <br />
        <br />
        <button type="submit">Zaloguj</button>
    </form>
</body>

</html>