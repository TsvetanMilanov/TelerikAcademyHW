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
          {
			for $album in doc("catalog-backup.xml")//album
			let $songs := distinct-values($album//songs)
			return
				<tr>
					<td>
						{string($album/name)}
					</td>
				</tr>
		  }
        </table>
      </body>
    </html>