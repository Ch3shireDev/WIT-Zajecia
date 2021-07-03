<?php

require_once 'funkcje.php';

sprawdzLogowanie();

if (isset($_GET['id'])) {
	$pdo = polacz();
	$stmt = $pdo->prepare("DELETE FROM samochody WHERE id = :id");
	$wynik = $stmt->execute(['id' => $_GET['id']]);

	if ($wynik == true) {
		header("Location: index.php?komunikat=2");
	} else {
		echo "<p style='color:red; font-weight:bold;'>Usuwanie nie powiodlo sie.</p>";
	}
}
