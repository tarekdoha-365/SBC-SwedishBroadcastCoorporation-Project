import React from 'react'
import Select from 'react-select'

const reportOptions= [

    {value:'Business', label:'Business'},
    {value:'Climate', label:'Climate'},
    {value:'Science', label:'Science'},
    {value:'Technology', label:'Technology'},
    {value:'EntertainmentAndArt', label:'Entertainment And Art'},
    {value:'Politics', label:'Politics'},
    {value:'Stories', label:'Stories'}
    
]
const SelectReportType = () => (
    <Select placeholder='Select Report Type' options = {reportOptions} />
    )
export default SelectReportType;