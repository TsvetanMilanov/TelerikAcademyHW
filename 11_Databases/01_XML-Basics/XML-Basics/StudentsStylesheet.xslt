<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
                xmlns:student="urn:student"
                xmlns:exam="urn:exam"
                xmlns:enrollment="urn:enrollment"
                xmlns:endorsement="urn:endorsement"
>
  <xsl:template match="/">
    <html>
      <head>
        <title>
          Students XML To HTML View
        </title>
      </head>
      <body>
        <table cellpadding="1" cellspacing="1" border="1">
          <tr>
            <th>
              Name:
            </th>
            <th>
              Sex:
            </th>
            <th>
              Birth Date:
            </th>
            <th>
              Phone:
            </th>
            <th>
              E-mail:
            </th>
            <th>
              Course:
            </th>
            <th>
              Specialty:
            </th>
            <th>
              Faculty Number:
            </th>
            <th>
              Exams:
            </th>
            <th>
              Enrollment:
            </th>
            <th>
              Endorsements:
            </th>
          </tr>
          <xsl:for-each select="/students/student:student">
            <tr>
              <td>
                <xsl:value-of select="student:name"/>
              </td>
              <td>
                <xsl:value-of select="student:sex"/>
              </td>
              <td>
                <xsl:value-of select="student:birth-date"/>
              </td>
              <td>
                <xsl:value-of select="student:phone"/>
              </td>
              <td>
                <xsl:value-of select="student:e-mail"/>
              </td>
              <td>
                <xsl:value-of select="student:course"/>
              </td>
              <td>
                <xsl:value-of select="student:specialty"/>
              </td>
              <td>
                <xsl:value-of select="student:faculty-number"/>
              </td>
              <td>
                <table cellpadding="1" cellspacing="1" border="1">
                  <tr>
                    <th>Name:</th>
                    <th>Tutor:</th>
                    <th>Score:</th>
                  </tr>
                  <xsl:for-each select="student:taken-exams/exam:exam">
                    <tr>
                      <td>
                        <xsl:value-of select="exam:name"/>
                      </td>
                      <td>
                        <xsl:value-of select="exam:tutor"/>
                      </td>
                      <td>
                        <xsl:value-of select="exam:score"/>
                      </td>
                    </tr>
                  </xsl:for-each>
                </table>
              </td>
              <td>
                <table cellpadding="1" cellspacing="1" border="1">
                  <tr>
                    <th>Date:</th>
                    <th>Exam score:</th>
                  </tr>
                  <tr>
                    <td>
                      <xsl:value-of select="enrollment:enrollment[enrollment:date]"/>
                    </td>
                    <td>
                      <xsl:value-of select="enrollment:enrollment[enrollment:score]"/>
                    </td>
                  </tr>
                </table>
              </td>
              <td>
                <table cellpadding="1" cellspacing="1" border="1">
                  <tr>
                    <th>
                      Endorsement:
                    </th>
                  </tr>
                  <xsl:for-each select="student:teachers-endorsements/endorsement:endorsement">
                    <tr>
                      <td>
                        <xsl:value-of select="." />
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
