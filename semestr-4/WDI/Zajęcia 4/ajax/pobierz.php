<?php

const DB_HOST = 'localhost';
const DB_NAME = 'test';
const DB_USERNAME = 'root';
const DB_PASSWORD = '';

function polacz(): PDO
{
    return new PDO(
        sprintf('mysql:host=%s;dbname=%s', DB_HOST, DB_NAME),
        DB_USERNAME,
        DB_PASSWORD
    );
}

$pdo = polacz();
$stmt = $pdo->prepare('SELECT * FROM samochody ORDER BY marka, model');
$stmt->execute();
$samochody = $stmt->fetchAll(PDO::FETCH_ASSOC);

header('Content-Type: application/json');
echo json_encode($samochody);