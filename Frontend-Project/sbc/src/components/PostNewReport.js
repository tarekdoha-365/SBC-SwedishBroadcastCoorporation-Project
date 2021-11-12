import react, { useState, useEffect } from 'react'
import axios from 'axios'
import { DateTimePickerComponent } from '@syncfusion/ej2-react-calendars'
export default function PostNewReport() {
  const [PostInputs, setPostInputs] = useState('')
  const [PostReportTypeInputs, setPostReportTypeInputs] = useState('')
  const [PostHeaderInputs, setPostHeaderInputs] = useState('')
  const [PostTitleInputs, setPostTitleInputs] = useState('')
  const [PostDescriptionInputs, setPostDescriptionInputs] = useState('')
  const [PostPublishedInputs, setPostPublishedInputs] = useState('')
  const [PostAuthorNamedInputs, setPostAuthorNamedInputs] = useState('')
  const [picture, setPicture] = useState(null)
  const [imgData, setImgData] = useState(null)

  const data = {
    reportType: PostReportTypeInputs,
    header: PostHeaderInputs,
    title: PostTitleInputs,
    description: PostDescriptionInputs,
    published: PostPublishedInputs,
    modified: false,
    isExpired: false, //To implement >30 Days condition
    authorName: PostAuthorNamedInputs,
    imagePath: imgData,
  }
  console.log(data)

  const onChangePicture = (e) => {
    if (e.target.files[0]) {
      console.log('picture: ', e.target.files)
      setPicture(e.target.files[0])
      const reader = new FileReader()
      reader.addEventListener('load', () => {
        setImgData(reader.result)
      })
      reader.readAsDataURL(e.target.files[0])
    }
    console.log('********************IMGDATA********************', imgData)
  }

  const PostMethod = async () => {
    try {
      const response = await axios({
        method: 'post',
        url: 'https://localhost:44335/api/Reports',
        data: data,
        headers: { 'Content-Type': 'application/json' },
      })
      console.log(response)
      console.log(data)
    } catch (error) {
      console.log(error)
    }
  }

  useEffect(() => {
    PostMethod()
  }, [])
  
  return (
    <form className="ui form" onSubmit={PostMethod}>
      <div className="field">
        <label>Create Report Form</label>
        <select
          onChange={(e) => setPostReportTypeInputs(e.target.value)}
          value={PostReportTypeInputs}
          multiple=""
          className="ui dropdown"
        >
          <option value="">Select Report Type</option>
          <option value="Business">Business</option>
          <option value="Climate">Climate</option>
          <option value="EntertainmentAndArt">EntertainmentAndArt</option>
          <option value="Health">Health</option>
          <option value="Politics">Politics</option>
          <option value="Science">Science</option>
          <option value="Stories">Stories</option>
          <option value="Technology">Technology</option>
        </select>
      </div>
      <div className="field">
        <label>Header</label>
        <input
          type="text"
          name="header"
          placeholder="header"
          onChange={(e) => setPostHeaderInputs(e.target.value)}
          value={PostHeaderInputs}
        />
      </div>
      <div className="field">
        <label>Title</label>
        <input
          type="text"
          name="Title"
          placeholder="Title"
          onChange={(e) => setPostTitleInputs(e.target.value)}
          value={PostTitleInputs}
        />
      </div>
      <div className="field">
        <label>Author Name</label>
        <input
          type="text"
          name="AuthorName"
          placeholder="AuthorName"
          onChange={(e) => setPostAuthorNamedInputs(e.target.value)}
          value={PostAuthorNamedInputs}
        />
      </div>
      <div className="field">
        <label>Date Time</label>
        <DateTimePickerComponent
          format="yy-MM-dd HH:mm:ss"
          placeholder="Choose a date and time"
          onChange={(e) => setPostPublishedInputs(e.target.value)}
          value={PostPublishedInputs}
        />
      </div>
      <div className="field">
        <label>Description</label>
        <textarea
          onChange={(e) => setPostDescriptionInputs(e.target.value)}
          value={PostDescriptionInputs}
        ></textarea>
      </div>

      <div className="ui medium image">
        <input id="profilePic" type="file" onChange={onChangePicture} />
        <img className="playerProfilePic_home_tile" src={imgData} alt="" />
      </div>

      <div>
        <button className="ui button" type="submit">
          Submit
        </button>
      </div>
    </form>
  )
}
