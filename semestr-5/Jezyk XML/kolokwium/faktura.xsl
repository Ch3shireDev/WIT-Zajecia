<?xml version="1.0"?>

<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

    <xsl:decimal-format name="pln" decimal-separator="," grouping-separator="."/>
    <xsl:template match="/">
        <html>
            <head>
                <style>
                    .padding{
                        padding: 0 2rem;
                    }

                    h2{
                        width: 100%;
                        text-align:center;
                    }

                    body, html{
                        font-family: Arial, Helvetica, sans-serif;
                    }

                    .border, table, tr, td, th{
                        border: 1px solid black;
                    }

                    table, tr, td, th{
                        border-collapse: collapse;
                        text-align: center;
                        margin:1rem;
                        table-layout: fixed;
                    }

                    .section{
                        display: flex;
                        flex-direction: row;
                        margin:1rem;
                    }

                    .section-element{
                        flex-grow: 1;
                        text-align:center;
                    }

                    table{
                        width:95%;
                        margin:1rem auto;
                    }

                    .details{
                        padding:1rem;
                        margin:2rem 1rem 1rem;
                    }

                    h3{
                        width:100%;
                    }

                    .footer{
                        display: flex;
                        flex-direction: row;
                        margin: 0.5rem auto;
                    }

                    .footer-element{
                        flex-grow: 1;
                        text-align:center;
                        margin: 1rem;
                    }

                    article{
                        width: 90%;
                        max-width: 1000px;
                        margin:auto;
                    }

                    hr{
                        margin:2rem 1rem;
                    }
                    
                    .add-bottom{
                        margin-bottom:3rem;
                    }

                    .text-right{
                        text-align: right;
                        padding-right:5px;
                        font-weight:600;
                    }
                </style>
            </head>
            <body>

                <article>
                    <div class="padding">
                        <div class="section border add-bottom">
                            <h2>
                                <xsl:text>Faktura VAT numer </xsl:text>
                                <xsl:value-of select="/faktura/numer"/>
                            </h2>
                        </div>
                        <div class="section border">
                            <div class="section-element border">
                                <h3>
                                    <xsl:text>Sprzedawca</xsl:text>
                                </h3>
                                <table>
                                    <tr>
                                        <th colspan="2">
                                            <xsl:value-of select="/faktura/sprzedawca/nazwa"/>
                                        </th>
                                    </tr>
                                    <tr>
                                        <td>
                                            <xsl:value-of select="/faktura/sprzedawca/adres/miejscowosc"/>
                                        </td>
                                        <td>
                                            <xsl:value-of select="/faktura/sprzedawca/adres/kod-pocztowy"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <xsl:value-of select="/faktura/sprzedawca/adres/ulica"/>
                                        </td>
                                        <td>
                                            <xsl:value-of select="/faktura/sprzedawca/adres/numer"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <xsl:text>NIP: </xsl:text>
                                            <xsl:value-of select="/faktura/sprzedawca/nip"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <xsl:text>REGON: </xsl:text>
                                            <xsl:value-of select="/faktura/sprzedawca/regon"/>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div class="section-element border">
                                <h3>
                                    <xsl:text>Odbiorca</xsl:text>
                                </h3>
                                <table>
                                    <tr>
                                        <th  colspan="2">
                                            <xsl:value-of select="/faktura/odbiorca/nazwa"/>
                                        </th>
                                    </tr>
                                    <tr>
                                        <td>
                                            <xsl:value-of select="/faktura/odbiorca/adres/miejscowosc"/>
                                        </td>
                                        <td>
                                            <xsl:value-of select="/faktura/odbiorca/adres/kod-pocztowy"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <xsl:value-of select="/faktura/odbiorca/adres/ulica"/>
                                        </td>
                                        <td>
                                            <xsl:value-of select="/faktura/odbiorca/adres/numer"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <xsl:text>NIP: </xsl:text>
                                            <xsl:value-of select="/faktura/odbiorca/nip"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <xsl:text>REGON: </xsl:text>
                                            <xsl:value-of select="/faktura/odbiorca/regon"/>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>

                        <div class="section border">
                            <table>
                                <tr>
                                    <td class="text-right">Data wystawienia:</td>
                                    <td>
                                        <xsl:value-of select="/faktura/data-wystawienia"/>
                                    </td>
                                    <td class="text-right">Data sprzedaży:</td>
                                    <xsl:value-of select="/faktura/data-sprzedazy"/>
                                </tr>
                                <tr>
                                    <td class="text-right">Termin zapłaty:</td>
                                    <td>
                                        <xsl:value-of select="/faktura/termin-zaplaty"/>
                                    </td>
                                    <td class="text-right">Sposób zapłaty:</td>
                                    <xsl:value-of select="/faktura/sposob-zaplaty"/>
                                </tr>
                            </table>
                        </div>
                        <hr/>

                        <table>
                            <tr>
                                <th>LP.</th>
                                <th>Nazwa towaru</th>
                                <th>JM</th>
                                <th>Ilość</th>
                                <th>Cena netto</th>
                                <th>Wartość netto</th>
                                <th>Stawka VAT</th>
                                <th>Wartość z VAT</th>
                            </tr>
                            <xsl:for-each select="/faktura/towary/towar">
                                <tr>
                                    <td>
                                        <xsl:value-of select="position()" />
                                    </td>
                                    <td>
                                        <xsl:value-of select="nazwa"/>
                                    </td>
                                    <td>
                                        <xsl:value-of select="jm"/>
                                    </td>
                                    <td>
                                        <xsl:value-of select="ilosc"/>
                                    </td>
                                    <td>
                                        <xsl:value-of select="format-number(cena-netto, '####,00', 'pln')"/>
                                    </td>
                                    <td>
                                        <xsl:value-of select="format-number(wartosc-netto, '####,00', 'pln')"/>
                                    </td>
                                    <td>
                                        <xsl:value-of select="stawka-vat"/>
                                    </td>
                                    <td>
                                        <xsl:value-of select="format-number(wartosc-z-vat, '####,00', 'pln')"/>
                                    </td>
                                </tr>
                            </xsl:for-each>
                            <tr>
                                <td colspan="5" class="text-right">RAZEM:</td>
                                <td>
                                    <xsl:value-of select="format-number(sum(/faktura/towary/towar/wartosc-netto), '####,00', 'pln')"/>
                                </td>
                                <td>
    -
                                </td>
                                <td>
                                    <xsl:value-of select="format-number(sum(/faktura/towary/towar/wartosc-z-vat), '####,00', 'pln')"/>

                                </td>
                            </tr>
                        </table>

                        <div class="details border">
                            <h3>Do zapłaty zł:</h3>
                            <p>
                                <b>Cyfrowo: </b>
                                <xsl:value-of select="format-number(/faktura/do-zaplaty-cyfrowo, '####,00', 'pln')"/>
                            </p>
                            <p>
                                <b>Słownie: </b>
                                <xsl:value-of select="/faktura/do-zaplaty-slownie"/>
                            </p>
                        </div>
                    </div>
                    <div class="footer">
                        <div class="footer-element border">
                            <p class="add-bottom">Osoba upoważniona do odbioru faktury</p>
                            <p>
                                <xsl:value-of select="/faktura/odbiorca-faktury"/>
                            </p>
                        </div>

                        <div class="footer-element border">
                            <p class="add-bottom">Osoba upoważniona do wystawienia faktury</p>
                            <p>
                                <xsl:value-of select="/faktura/wystawca-faktury"/>
                            </p>
                        </div>
                    </div>
                </article>
            </body>
        </html>
    </xsl:template>

</xsl:stylesheet> 