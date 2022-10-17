using System;

namespace litehtml
{
    /// <summary>
    /// XMLHttpRequest
    /// https://www.w3schools.com/xml/ajax_xmlhttprequest_create.asp
    /// </summary>
    public class XMLHttpRequest
    {
        /// <summary>
        /// Creates a new XMLHttpRequest object
        /// </summary>
        public XMLHttpRequest() { }

        /// <summary>
        /// Cancels the current request
        /// </summary>
        public void abort()
        {
        }

        /// <summary>
        /// Returns header information
        /// </summary>
        public void getAllResponseHeaders()
        {
        }

        /// <summary>
        /// Returns specific header information
        /// </summary>
        public void getResponseHeader()
        {
        }

        /// <summary>
        /// Defines a function to be called when the readyState property changes
        /// </summary>
        public Action<XMLHttpRequest> onreadystatechange;

        /// <summary>
        /// Specifies the request
        /// </summary>
        /// <param name="method">the request type GET or POST</param>
        /// <param name="url">the file location</param>
        /// <param name="async">true (asynchronous) or false (synchronous)</param>
        /// <param name="user">optional user name</param>
        /// <param name="psw">optional password</param>
        public void open(string method, string url, bool async = true, string user = null, string psw = null)
        {
        }

        /// <summary>
        /// Holds the status of the XMLHttpRequest.
        /// 0: request not initialized
        /// 1: server connection established
        /// 2: request received
        /// 3: processing request
        /// 4: request finished and response is ready
        /// </summary>
        public int readyState { get; }

        /// <summary>
        /// Returns the response data as a string
        /// </summary>
        public string responseText { get; }

        /// <summary>
        /// Returns the response data as XML data
        /// </summary>
        public Document responseXML { get; }

        /// <summary>
        /// Sends the request to the server
        /// </summary>
        public void send(string body = null)
        {
        }

        /// <summary>
        /// Adds a label/value pair to the header to be sent
        /// </summary>
        public void setRequestHeader()
        {
        }

        /// <summary>
        /// Returns the status-number of a request
        /// </summary>
        public int status { get; }

        /// <summary>
        /// Returns the status-text
        /// </summary>
        public string statusText { get; }
    }
}
