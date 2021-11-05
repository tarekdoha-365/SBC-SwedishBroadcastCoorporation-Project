import React, { useState } from 'react'
import '../Style/index.css'
export default function ReportList({ items }) {
  const ReportItems = items.map((item) => {
    return (
      <div key={item.id}>
        <div className="card">
          <span className="font-link">
            <h4>{item.header}</h4>
            <h6>
              by {item.authorName}
              <br /> {item.reportType} editor
              
            </h6>
          </span>
        </div>
        <a target="_blank" className="ui medium image" href="http://google.com">
          <img src={item.imagePath} />
        </a>
      </div>
    )
  })
  const [keyword, setKeyword] = useState('')

  return <div className="Business-List">{ReportItems}</div>
}
