import React, { useState, useEffect } from 'react'
import axios from 'axios'
import CssBaseline from '@material-ui/core/CssBaseline'
import Container from '@material-ui/core/Container'

export default function SearchReports() {
  const [searchInput, setSearchInput] = useState('')
  const [results, SetResults] = useState([])
  
  useEffect(() => {
    const search = async () => {
      const { data } = await axios.get('https://localhost:44335/api/Reports', {
        params: {
          reportType: searchInput,
        },
      })

      SetResults(data)
      console.log(data)
    }
    search()
  }, [searchInput])

  const renderedReports = results.map((result) => {
    return (
      <React.Fragment key={result.id}>
        <CssBaseline />
        <Container maxWidth="sm">
          <span className="font-link">
            <h4>{result.header}</h4>
            <h6>
              by {result.authorName}
              <br /> {result.reportType} editor
            </h6>
          </span>
            <img src={result.imagePath} alt=""/>
          <div>
            <h3>{result.title}</h3>
            <p>{result.description}</p>
          </div>
        </Container>
      </React.Fragment>
    )
  })

  return (
    <div>
      <input
        value={searchInput}
        icon="search"
        placeholder="Search..."
        onChange={(e) => setSearchInput(e.target.value)}
      />
      <div>{renderedReports}</div>
    </div>
  )
}
