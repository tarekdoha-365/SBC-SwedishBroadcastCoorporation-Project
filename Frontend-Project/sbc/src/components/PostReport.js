import React,{useEffect,useState} from 'react'
import axios from 'axios'
import { Button, Form, Segment } from 'semantic-ui-react'
import SelectReportType from './SelectReportType'
import DateReportPublish from './DateReportPublish'
import ImageReportPublish from './ImageReportPublish'
export default function PostReport() {
    const [PostInput, setPostInput] = useState('')
    const [results, SetResults] = useState([])
    console.log(PostInput)
    useEffect(() => {
     //To be implemented for Next Time
    }, [])

  return (
    <Segment inverted>
      <Form inverted>
        <Form.Group widths="equal">
          <Form.Select>
            <SelectReportType />
          </Form.Select>
          <Form.Input fluid label="Header" placeholder="Header" onChange={(e)=>setPostInput(e.target.value)}/>
          <Form.Input fluid label="Title" placeholder="Title" onChange={(e)=>setPostInput(e.target.value)}/>
          <Form.Input fluid label="Description" placeholder="Description" onChange={(e)=>setPostInput(e.target.value)}/>
          <Form.Input fluid label="Author" placeholder="Author Name" onChange={(e)=>setPostInput(e.target.value)}/>
          <Form.Input fluid label="Date Time:" ><DateReportPublish/></Form.Input>
          <ImageReportPublish></ImageReportPublish>
          </Form.Group>
        <Form.Checkbox label="I agree to the Terms and Conditions" />
        <Button type="submit">Submit</Button>
      </Form>
    </Segment>
  )
}
