﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CNC12.Model
{
    public class DataRequest
    {
        /// <summary>
        ///emun Http request method
        /// </summary>
        public enum HttpRequestOption
        {
            GET,
            PATCH
        }
        public delegate void ResquestRespondedCallback(string raw_data);
        public delegate void ResquestOccurredErrorCallback(Exception e);
        public class AdvantechHttpWebUtility
        {
            public event ResquestRespondedCallback ResquestResponded;
            public event ResquestOccurredErrorCallback ResquestOccurredError;

            public string BasicAuthAccount = "root";
            public string BasicAuthPassword = "00000000";
            public string URL = @"http://192.168.1.1/di_value/slot_0";
            public string JsonifyString { get; set; }

            protected bool HasData { get; set; }
            protected HttpRequestOption Method { get; set; }

            public AdvantechHttpWebUtility()
            {
            }
            /// <summary>
            /// Invoke ResquestResponded Callback function
            /// </summary>
            /// <param name="raw_data"></param>
            protected virtual void OnResquestResponded(string raw_data)
            {
                if (ResquestResponded != null)
                {
                    ResquestResponded.Invoke(raw_data);
                }
            }
            /// <summary>
            /// Invoke ResquestOccurredError Callback function
            /// </summary>
            /// <param name="raw_data"></param>
            protected virtual void OnResquestOccurredError(Exception e)
            {
                if (ResquestOccurredError != null)
                {
                    ResquestOccurredError.Invoke(e);
                }
            }
            public void SendGETRequest(string account, string password, string URL)
            {
                this.BasicAuthAccount = account;
                this.BasicAuthPassword = password;
                this.URL = URL;
                this.HasData = false;
                this.Method = HttpRequestOption.GET;
                SendRequest();
            }
            public void SendPATCHRequest(string account, string password, string URL, string JSONString)
            {
                this.BasicAuthAccount = account;
                this.BasicAuthPassword = password;
                this.URL = URL;
                this.JsonifyString = JSONString;
                this.HasData = true;
                this.Method = HttpRequestOption.PATCH;
                SendRequest();
            }
            protected void SendRequest()
            {
                HttpWebRequest myRequest;
                System.IO.Stream outputStream;// End the stream request operation

                myRequest = (HttpWebRequest)WebRequest.Create(this.URL); // create request
                myRequest.Headers.Add("Authorization", "Basic " +
                    Convert.ToBase64String(Encoding.ASCII.GetBytes(this.BasicAuthAccount + ":" + this.BasicAuthPassword)));
                myRequest.Method = Method.ToString();
                myRequest.KeepAlive = false;
                myRequest.ContentType = "application/x-www-form-urlencoded";
                myRequest.ReadWriteTimeout = 1000;
                // Create the patch data
                if (this.HasData)//Append data for send
                {
                    byte[] byData = Encoding.ASCII.GetBytes(this.JsonifyString); // convert POST data to bytes
                    myRequest.ContentLength = byData.Length;
                    // Add the post data to the web request
                    outputStream = myRequest.GetRequestStream();
                    outputStream.Write(byData, 0, byData.Length);
                    outputStream.Close();
                }
                try
                {
                    myRequest.BeginGetResponse(new AsyncCallback(GetResponsetStreamCallback), myRequest);
                }
                catch (Exception e)
                {
                    OnResquestOccurredError(e);
                }
            }
            void GetResponsetStreamCallback(IAsyncResult callbackResult)
            {
                bool bRet = false;
                HttpWebRequest request = (HttpWebRequest)callbackResult.AsyncState;
                string result = "";
                try
                {
                    HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(callbackResult);
                    using (System.IO.StreamReader httpWebStreamReader = new System.IO.StreamReader(response.GetResponseStream()))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            if (response.ContentLength > 0)
                            {
                                result = httpWebStreamReader.ReadToEnd();
                            }
                            else
                            {
                                result = ((int)(HttpStatusCode.OK)).ToString() + " " + response.StatusDescription;
                            }
                            bRet = true;
                        }
                        else
                            OnResquestOccurredError(new Exception(response.StatusCode.ToString()));
                    }
                    response.Close();
                }
                catch (Exception e)
                {
                    OnResquestOccurredError(e);
                }
                finally
                {
                    request.Abort();
                    if (bRet)
                        OnResquestResponded(result);
                }
            }
        }
    }
}
