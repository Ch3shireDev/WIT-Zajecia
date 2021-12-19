<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
<body>
  <table border="1">
    <thead>
      <th colspan="4">Zestawienia</th>
    </thead>
    <tbody>
      <xsl:for-each select="/zestawienia/zestawienie">
      <tr>
        <td><xsl:number/></td>
        <td>
          <xsl:choose>
            <xsl:when test="@typ='ks'">księgowe</xsl:when>
            <xsl:when test="@typ='ka'">kasowe</xsl:when>
            <xsl:when test="@typ='ma'">marketingowe</xsl:when>
            <xsl:otherwise>-</xsl:otherwise>
          </xsl:choose>
        
        </td>
        <td><xsl:value-of select="okres"/></td>
        <td><xsl:value-of select="tytul"/></td>
      </tr></xsl:for-each>
    </tbody>
  </table>
</body>
</html>
</xsl:template>
</xsl:stylesheet>
