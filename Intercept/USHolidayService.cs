﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5466
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.3038.
// 

namespace Intercept
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "USHolidayServiceSoap", Namespace = "http://www.27seconds.com/Holidays/US/")]
    public partial class USHolidayService : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback GetHolidaysAvailableOperationCompleted;

        private System.Threading.SendOrPostCallback GetHolidayDateOperationCompleted;

        private System.Threading.SendOrPostCallback GetHolidaysForDateRangeOperationCompleted;

        private System.Threading.SendOrPostCallback GetHolidaysForMonthOperationCompleted;

        private System.Threading.SendOrPostCallback GetHolidaysForYearOperationCompleted;

        /// <remarks/>
        public USHolidayService()
        {
            this.Url = "http://www.holidaywebservice.com/Holidays/US/USHolidayService.asmx";
        }

        /// <remarks/>
        public event GetHolidaysAvailableCompletedEventHandler GetHolidaysAvailableCompleted;

        /// <remarks/>
        public event GetHolidayDateCompletedEventHandler GetHolidayDateCompleted;

        /// <remarks/>
        public event GetHolidaysForDateRangeCompletedEventHandler GetHolidaysForDateRangeCompleted;

        /// <remarks/>
        public event GetHolidaysForMonthCompletedEventHandler GetHolidaysForMonthCompleted;

        /// <remarks/>
        public event GetHolidaysForYearCompletedEventHandler GetHolidaysForYearCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.27seconds.com/Holidays/US/GetHolidaysAvailable", RequestNamespace = "http://www.27seconds.com/Holidays/US/", ResponseNamespace = "http://www.27seconds.com/Holidays/US/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetHolidaysAvailable()
        {
            object[] results = this.Invoke("GetHolidaysAvailable", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetHolidaysAvailable(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetHolidaysAvailable", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public System.Data.DataSet EndGetHolidaysAvailable(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public void GetHolidaysAvailableAsync()
        {
            this.GetHolidaysAvailableAsync(null);
        }

        /// <remarks/>
        public void GetHolidaysAvailableAsync(object userState)
        {
            if ((this.GetHolidaysAvailableOperationCompleted == null))
            {
                this.GetHolidaysAvailableOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetHolidaysAvailableOperationCompleted);
            }
            this.InvokeAsync("GetHolidaysAvailable", new object[0], this.GetHolidaysAvailableOperationCompleted, userState);
        }

        private void OnGetHolidaysAvailableOperationCompleted(object arg)
        {
            if ((this.GetHolidaysAvailableCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetHolidaysAvailableCompleted(this, new GetHolidaysAvailableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.27seconds.com/Holidays/US/GetHolidayDate", RequestNamespace = "http://www.27seconds.com/Holidays/US/", ResponseNamespace = "http://www.27seconds.com/Holidays/US/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.DateTime GetHolidayDate(string holidayName, int year)
        {
            object[] results = this.Invoke("GetHolidayDate", new object[] {
                    holidayName,
                    year});
            return ((System.DateTime)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetHolidayDate(string holidayName, int year, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetHolidayDate", new object[] {
                    holidayName,
                    year}, callback, asyncState);
        }

        /// <remarks/>
        public System.DateTime EndGetHolidayDate(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.DateTime)(results[0]));
        }

        /// <remarks/>
        public void GetHolidayDateAsync(string holidayName, int year)
        {
            this.GetHolidayDateAsync(holidayName, year, null);
        }

        /// <remarks/>
        public void GetHolidayDateAsync(string holidayName, int year, object userState)
        {
            if ((this.GetHolidayDateOperationCompleted == null))
            {
                this.GetHolidayDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetHolidayDateOperationCompleted);
            }
            this.InvokeAsync("GetHolidayDate", new object[] {
                    holidayName,
                    year}, this.GetHolidayDateOperationCompleted, userState);
        }

        private void OnGetHolidayDateOperationCompleted(object arg)
        {
            if ((this.GetHolidayDateCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetHolidayDateCompleted(this, new GetHolidayDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.27seconds.com/Holidays/US/GetHolidaysForDateRange", RequestNamespace = "http://www.27seconds.com/Holidays/US/", ResponseNamespace = "http://www.27seconds.com/Holidays/US/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetHolidaysForDateRange(System.DateTime startDate, System.DateTime endDate)
        {
            object[] results = this.Invoke("GetHolidaysForDateRange", new object[] {
                    startDate,
                    endDate});
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetHolidaysForDateRange(System.DateTime startDate, System.DateTime endDate, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetHolidaysForDateRange", new object[] {
                    startDate,
                    endDate}, callback, asyncState);
        }

        /// <remarks/>
        public System.Data.DataSet EndGetHolidaysForDateRange(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public void GetHolidaysForDateRangeAsync(System.DateTime startDate, System.DateTime endDate)
        {
            this.GetHolidaysForDateRangeAsync(startDate, endDate, null);
        }

        /// <remarks/>
        public void GetHolidaysForDateRangeAsync(System.DateTime startDate, System.DateTime endDate, object userState)
        {
            if ((this.GetHolidaysForDateRangeOperationCompleted == null))
            {
                this.GetHolidaysForDateRangeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetHolidaysForDateRangeOperationCompleted);
            }
            this.InvokeAsync("GetHolidaysForDateRange", new object[] {
                    startDate,
                    endDate}, this.GetHolidaysForDateRangeOperationCompleted, userState);
        }

        private void OnGetHolidaysForDateRangeOperationCompleted(object arg)
        {
            if ((this.GetHolidaysForDateRangeCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetHolidaysForDateRangeCompleted(this, new GetHolidaysForDateRangeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.27seconds.com/Holidays/US/GetHolidaysForMonth", RequestNamespace = "http://www.27seconds.com/Holidays/US/", ResponseNamespace = "http://www.27seconds.com/Holidays/US/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetHolidaysForMonth(int year, int month)
        {
            object[] results = this.Invoke("GetHolidaysForMonth", new object[] {
                    year,
                    month});
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetHolidaysForMonth(int year, int month, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetHolidaysForMonth", new object[] {
                    year,
                    month}, callback, asyncState);
        }

        /// <remarks/>
        public System.Data.DataSet EndGetHolidaysForMonth(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public void GetHolidaysForMonthAsync(int year, int month)
        {
            this.GetHolidaysForMonthAsync(year, month, null);
        }

        /// <remarks/>
        public void GetHolidaysForMonthAsync(int year, int month, object userState)
        {
            if ((this.GetHolidaysForMonthOperationCompleted == null))
            {
                this.GetHolidaysForMonthOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetHolidaysForMonthOperationCompleted);
            }
            this.InvokeAsync("GetHolidaysForMonth", new object[] {
                    year,
                    month}, this.GetHolidaysForMonthOperationCompleted, userState);
        }

        private void OnGetHolidaysForMonthOperationCompleted(object arg)
        {
            if ((this.GetHolidaysForMonthCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetHolidaysForMonthCompleted(this, new GetHolidaysForMonthCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.27seconds.com/Holidays/US/GetHolidaysForYear", RequestNamespace = "http://www.27seconds.com/Holidays/US/", ResponseNamespace = "http://www.27seconds.com/Holidays/US/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetHolidaysForYear(int year)
        {
            object[] results = this.Invoke("GetHolidaysForYear", new object[] {
                    year});
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetHolidaysForYear(int year, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetHolidaysForYear", new object[] {
                    year}, callback, asyncState);
        }

        /// <remarks/>
        public System.Data.DataSet EndGetHolidaysForYear(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public void GetHolidaysForYearAsync(int year)
        {
            this.GetHolidaysForYearAsync(year, null);
        }

        /// <remarks/>
        public void GetHolidaysForYearAsync(int year, object userState)
        {
            if ((this.GetHolidaysForYearOperationCompleted == null))
            {
                this.GetHolidaysForYearOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetHolidaysForYearOperationCompleted);
            }
            this.InvokeAsync("GetHolidaysForYear", new object[] {
                    year}, this.GetHolidaysForYearOperationCompleted, userState);
        }

        private void OnGetHolidaysForYearOperationCompleted(object arg)
        {
            if ((this.GetHolidaysForYearCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetHolidaysForYearCompleted(this, new GetHolidaysForYearCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void GetHolidaysAvailableCompletedEventHandler(object sender, GetHolidaysAvailableCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetHolidaysAvailableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetHolidaysAvailableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Data.DataSet Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void GetHolidayDateCompletedEventHandler(object sender, GetHolidayDateCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetHolidayDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetHolidayDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.DateTime Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void GetHolidaysForDateRangeCompletedEventHandler(object sender, GetHolidaysForDateRangeCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetHolidaysForDateRangeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetHolidaysForDateRangeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Data.DataSet Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void GetHolidaysForMonthCompletedEventHandler(object sender, GetHolidaysForMonthCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetHolidaysForMonthCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetHolidaysForMonthCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Data.DataSet Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void GetHolidaysForYearCompletedEventHandler(object sender, GetHolidaysForYearCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetHolidaysForYearCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetHolidaysForYearCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Data.DataSet Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}
