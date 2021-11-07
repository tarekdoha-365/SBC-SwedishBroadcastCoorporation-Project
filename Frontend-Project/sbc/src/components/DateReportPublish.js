import React, { useState } from "react";
import DatePicker from "react-datepicker";
import {DateTimePickerComponent} from '@syncfusion/ej2-react-calendars'

const DateReportPublish = () => {
  return (
    <DateTimePickerComponent format="yy-MM-dd HH:mm:ss" placeholder="Choose a date and time"/>
  );
};
export default DateReportPublish;