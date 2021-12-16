<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/">
		<html>
			<head>
				<title>Klient</title>
			</head>
			<body>
				<table width="200" border="1">
					<tbody>
						<tr>
							<th colspan="2" align="center">Klient</th>
						</tr>
						<tr>
							<td align="right">Imie:</td>
							<td align="center">
								<xsl:value-of select="klient/imie" />
							</td>
						</tr>
						<tr>
							<td align="right">Nazwisko:</td>
							<td align="center">
								<xsl:value-of select="klient/nazwisko" />
							</td>
						</tr>
						<tr>
							<td align="right">Data urodzenia:</td>
							<td align="center">
								<xsl:value-of select="klient/data_urodzenia" />
							</td>
						</tr>
						<tr>
							<td align="right">PESEL:</td>
							<td align="center">
								<xsl:value-of select="klient/pesel" />
							</td>
						</tr>
						<tr>
							<td align="right">Wiek:</td>
							<td align="center">
								<xsl:value-of select="klient/wiek" />
							</td>
						</tr>
					</tbody>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>