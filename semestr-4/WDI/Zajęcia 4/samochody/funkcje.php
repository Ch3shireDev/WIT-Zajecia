<?php

const DB_HOST = 'localhost';
const DB_NAME = 'test';
const DB_USERNAME = 'root';
const DB_PASSWORD = '';

session_start();

function polacz(): PDO
{
    return new PDO(
        sprintf('mysql:host=%s;dbname=%s', DB_HOST, DB_NAME),
        DB_USERNAME,
        DB_PASSWORD
    );
}

function sprawdzLogowanie(): void
{
    if (empty($_SESSION['zalogowany'])) {
        header('Location: logowanie.php');
        exit();
    }
}
