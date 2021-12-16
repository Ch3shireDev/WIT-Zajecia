<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <head>
                <title>Klient</title>
                <style>
                    html, body{
                        height:100vh;
                        margin:0;
                    }

                    body{
                        font-family: Arial, Helvetica, sans-serif;
                        font-size: 14px;
                    }

                    .center{
                        display:grid;
                        place-items:center;
                    }

                    table {
                        border-collapse: collapse;
                        margin:auto;
                    }
                    th{
                        background: green;
                        color: white;
                    }

                    td, th {
                        border: 5px solid white;
                        padding: 5px;
                        text-align: center;
                        box-shadow: 0 0 5px black;
                    }
                    img {
                        width: 100px;
                    }
                </style>
            </head>
            <body class="center">

                <table>
                    <thead>
                        <th>Imię</th>
                        <th>Nazwisko</th>
                        <th>Data urodzenia</th>
                        <th>Pesel</th>
                        <th>Wiek</th>
                        <th>Typ</th>
                        <th>Zdjęcie</th>
                    </thead>
                    <tbody>
                        <xsl:for-each select="klienci/klient">
                            <tr>
                                <xsl:attribute name="style">
                                    background-color: <xsl:value-of select="kolor"/>
                                </xsl:attribute>
                                <td>
                                    <xsl:value-of select="imie" />
                                </td>
                                <td>
                                    <xsl:value-of select="nazwisko" />
                                </td>
                                <td>
                                    <xsl:value-of select="data_urodzenia" />
                                </td>
                                <td>
                                    <xsl:value-of select="pesel" />
                                </td>
                                <td>
                                    <xsl:value-of select="wiek" />
                                </td>
                                <td>
                                    <xsl:value-of select="@typ" />
                                </td>
                                <td>
                                    <img>
                                        <xsl:attribute name="src">
                                            <xsl:value-of select="obraz" />
                                        </xsl:attribute>
                                    </img>
                                </td>
                            </tr>
                        </xsl:for-each>
                    </tbody>
                    <br />
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>