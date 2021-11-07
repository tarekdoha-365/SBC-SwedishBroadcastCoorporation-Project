import React, { useState, useEffect } from 'react'
import axios from 'axios'

export default function SearchReport() {
  const [searchInput, setSearchInput] = useState('')
  const [results, SetResults] = useState([])
  console.log(results)
  useEffect(async () => {
    const search = async () => {
      const { data } = await axios.get('https://localhost:44335/api/Reports', {
        params: {
          reportType: searchInput,
        },
      })

      SetResults(data)
    }
    search()
  }, [searchInput])

  const renderedReports = results.map(result=>{
    return <div key={result.id}>
        <div className="card">
          <span className="font-link">
            <h4>{result.header}</h4>
            <h6>
              by {result.authorName}
              <br /> {result.reportType} editor
            </h6>
          </span>
        </div>
        <a target="_blank" className="ui medium image" href="http://google.com">
          <img src={result.imagePath} />
        </a>
        <div>
          <p>{result.description}</p>
        </div>

    </div>
  })

  return (
    <div>
      <input
        value={searchInput}
        icon="search"
        placeholder="Search..."
        onChange={(e) => setSearchInput(e.target.value)}
      />
      <div>
        {renderedReports}
      </div>
    </div>
  )
}
