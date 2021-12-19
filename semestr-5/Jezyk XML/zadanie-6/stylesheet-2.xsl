<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <head>
        <title>Mój wspaniały zestaw danych</title>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <style>

          body{
            font-family: Arial, Helvetica, sans-serif;
            padding:1rem;
          }

          table, th, tr, td{
            margin:auto;
            border-collapse: collapse;
            border: 1px solid #ddd;
            text-align: left;
          }

          td, th{
            padding: 0.5rem 1rem;
          }

          .section{
            text-transform: capitalize;
            font-weight:700;
            letter-spacing: 1px;
          }

          .section > td::after{
            content: ":";
          }

          tr:nth-child(even){background-color: #f2f2f2;}

          th {
            padding-top: 12px;
            padding-bottom: 12px;
            text-align: left;
            background-color: #04AA6D;
            color: white;
          }
        </style>
      </head>
      <body>
        <table>
          <thead>
            <tr>
              <th colspan="4">Zestawienia</th>
            </tr>
          </thead>
          <tbody>

            <!-- Na podstawie: https://newbedev.com/how-to-use-xslt-to-create-distinct-values -->
            <xsl:for-each select="/zestawienia/zestawienie/@typ[generate-id()
      = generate-id(key('typ',.)[1])]">
              <xsl:apply-templates select="/zestawienia">
                <xsl:with-param name="typ" select="."/>
              </xsl:apply-templates>
            </xsl:for-each>
          </tbody>
        </table>
      </body>
    </html>
  </xsl:template>

  <xsl:key name="typ" match="/zestawienia/zestawienie/@typ" use="." />

  <xsl:template match="/zestawienia">
    <xsl:param name="typ"/>
    <tr class="section">
      <td colspan="4">
        <xsl:choose>
          <xsl:when test="$typ='ks'">księgowe</xsl:when>
          <xsl:when test="$typ='ka'">kasowe</xsl:when>
          <xsl:when test="$typ='ma'">marketingowe</xsl:when>
          <xsl:otherwise>-</xsl:otherwise>
        </xsl:choose>
      </td>
    </tr>
    <xsl:apply-templates select="zestawienie[ @typ = $typ ]">
      <xsl:sort select="okres" order="descending" />
    </xsl:apply-templates>

  </xsl:template>

  <xsl:template match="/zestawienia/zestawienie">
    <tr>
      <td>
        <xsl:value-of select="number(position())"/>
      </td>
      <td>
        <xsl:choose>
          <xsl:when test="@typ='ks'">księgowe</xsl:when>
          <xsl:when test="@typ='ka'">kasowe</xsl:when>
          <xsl:when test="@typ='ma'">marketingowe</xsl:when>
          <xsl:otherwise>-</xsl:otherwise>
        </xsl:choose>

      </td>
      <td>
        <xsl:value-of select="okres"/>
      </td>
      <td>
        <xsl:value-of select="tytul"/>
      </td>
    </tr>
  </xsl:template>

</xsl:stylesheet>
