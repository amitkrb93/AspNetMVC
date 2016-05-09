using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MLCP
{
    public class User: System.Web.UI.Page
    {
        public string Eid { get; set; }
        public string Pass { get; set; }

    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
               
            using (HttpClient client = new HttpClient())
            {
                CookieContainer cookies = new CookieContainer();
                HttpClientHandler handler = new HttpClientHandler();
                handler.CookieContainer = cookies;
                var postData = new List<KeyValuePair<string, string>>
                               {
                                   new KeyValuePair<string, string>("username", txtempid.Text),
                                   new KeyValuePair<string, string>("password ", txtpass.Text)
                               };

                HttpContent content = new FormUrlEncodedContent(postData);
                //string send = "%%ModDate=0000000000000001&Username=" + txtempid.Text + "&Password=" + txtpass.Text;
                //client.BaseAddress = new Uri( "https://webmail.tcs.com/names.nsf?Login");
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //HttpWebRequest request = new HttpWebRequest();
                Uri uri = new Uri("https://webmail.tcs.com/names.nsf?Login");
                //HttpWebRequest webrequest = (HttpWebRequest) WebRequest.Create(uri);
                //webrequest.AllowAutoRedirect = false;
                //HttpClient hr = new HttpClient();
                //client.BaseAddress = new Uri("https://webmail.tcs.com/names.nsf?Login");
               
                 var response = client.PostAsync(uri,content);             
                HttpResponseMessage i = response.Result;
                IEnumerable<Cookie> responseCookies = cookies.GetCookies(uri).Cast<Cookie>();
                foreach (Cookie cookie in responseCookies)
                    Console.WriteLine(cookie.Name + ": " + cookie.Value);

                Console.ReadLine();
    //            for(int i = 0 ; i < cookie.length ;i++){
    //System.out.println("Cookie Name " + cookie[i].getName() );
    //if( cookie[i].getName().equals("LtpaToken"))
      //string val = cookie[0].Value;
    
            }
        }
    }
}