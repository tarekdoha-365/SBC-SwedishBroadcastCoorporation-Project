import React from 'react'
import ReportList from './ReportList'

import axios from 'axios'
export default function App() {
  const items = [
    {
      id: 1,
      reportType: 'Business',
      header: 'The Bank of England says cutting carbon could push up prices',
      title:
        'Netflix is launching its first games worldwide as it seeks to break into the game Soren Skou, the boss of shipping firm Maersk, assured that Christmas trading will be safe from supply chain issues, adding the caveat:',
      description:
        "The company handles almost 20% of the world's shipping containers.Mr Skou said the firm is chartering more ships, keeping ports open longer and has opened more warehouses to help.",
      published: '2021-11-02T04:06:05.117Z',
      modified: true,
      isExpired: true,
      authorName: 'TD',
      imagePath: './Images/logo192.png',
    },
    {
      id: 2,
      reportType: 'Climate',
      header: 'Shipping boss: Christmas will be safe from shortages',
      title:
        'Netflix is launching its first games worldwide as it seeks to break into the game Soren Skou, the boss of shipping firm Maersk, assured that Christmas trading will be safe from supply chain issues, adding the caveat:',
      description:
        "The company handles almost 20% of the world's shipping containers.Mr Skou said the firm is chartering more ships, keeping ports open longer and has opened more warehouses to help.",
      published: '2021-11-02T04:06:05.117Z',
      modified: true,
      isExpired: true,
      authorName: 'TD',
      imagePath: './Images/image2.jpg',
    },
    {
      id: 3,
      reportType: 'Science',
      header: 'Shipping boss: Christmas will be safe from shortages',
      title:
        'Netflix is launching its first games worldwide as it seeks to break into the game Soren Skou, the boss of shipping firm Maersk, assured that Christmas trading will be safe from supply chain issues, adding the caveat:',
      description:
        "The company handles almost 20% of the world's shipping containers.Mr Skou said the firm is chartering more ships, keeping ports open longer and has opened more warehouses to help.",
      published: '2021-11-02T04:06:05.117Z',
      modified: true,
      isExpired: true,
      authorName: 'TD',
      imagePath: './Images/image2.jpg',
    },
  ]
  return (
    <div>
      <ReportList items={items}>{items}</ReportList>
    </div>
  )
}
