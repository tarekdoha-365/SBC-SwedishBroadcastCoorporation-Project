import React,{useState} from 'react'

export default function ReportBusinessList() {
  const [keyword, setKeyword] = useState("")
  
  return <div className="Business-List">
    <div class="ui items">
  <div class="item">
    <div class="ui small image">
      <img src="/images/image1.jpg" />
    </div>
    <div class="content">
      <div class="header">Arrowhead Valley Camp</div>
      <div class="meta">
        <span class="price">$1200</span>
        <span class="stay">1 Month</span>
      </div>
      <div class="description">
        <p></p>
      </div>
    </div>
  </div>
  <div class="item">
    <div class="ui small image">
      <img src="/images/wireframe/image.png" />
    </div>
    <div class="content">
      <div class="header">Buck's Homebrew Stayaway</div>
      <div class="meta">
        <span class="price">$1000</span>
        <span class="stay">2 Weeks</span>
      </div>
      <div class="description">
        <p></p>
      </div>
    </div>
  </div>
  <div class="item">
    <div class="ui small image">
      <img src="/images/image2.jpg"/>
    </div>
    <div class="content">
      <div class="header">Astrology Camp</div>
      <div class="meta">
        <span class="price">$1600</span>
        <span class="stay">6 Weeks</span>
      </div>
      <div class="description">
        <p></p>
      </div>
    </div>
  </div>
</div>
  </div>
}
