<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8" />

    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Przykład 2</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style>
        .yellow {
            background-color: yellow;
        }
    </style>
</head>

<body>
    <table>
        <tr>
            <th>Paragrafy</th>
        </tr>
        <?php for ($i = 0; $i < 10; $i++) :
           
        ?>
                <tr <?php  if ($i % 2 == 0) { ?>class="yellow" <?php } ?>>
                    <td><p>Paragraf #<?= $i ?></p></td>
                </tr>
            <?php endfor; ?>
    </table>
</body>

</html>