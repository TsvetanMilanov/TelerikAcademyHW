<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:template match="/">
    <html>
      <head>
        <title>Catalog</title>
      </head>
      <body>
        <h3>Catalog:</h3>
        <table border="1">
          <tr>
            <th>Name:</th>
            <th>Artist:</th>
            <th>Year:</th>
            <th>Producer:</th>
            <th>Price:</th>
            <th>Songs:</th>
          </tr>
          <xsl:for-each select="/albums/album">
            <tr>
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="artist"/>
              </td>
              <td>
                <xsl:value-of select="year"/>
              </td>
              <td>
                <xsl:value-of select="producer"/>
              </td>
              <td>
                <xsl:value-of select="price"/>
              </td>
              <td>
                <table border="1">
                  <tr>
                    <th>
                      Title:
                    </th>
                    <th>
                      Duration:
                    </th>
                  </tr>
                  <xsl:for-each select="songs/song">
                    <tr>
                      <td>
                        <xsl:value-of select="title"/>
                      </td>
                      <td>
                        <xsl:value-of select="duration"/>
                      </td>
                    </tr>
                  </xsl:for-each>

                </table>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
