using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using YammerCrawlSync.Data;

namespace YammerConsole
{
    class Program
    {

        //******************************************************************
        //CHANGE HISTORY:
        //12/17/2013 - MODIFIED CODE TO GET ACCESS TOKEN BASED ON CHANGES 
        //IN YAMMER AUTH PROCEDURE


        private static string sessionCookie = string.Empty;
        private static string yamtrackCookie = string.Empty;
        private static CookieContainer cc = new CookieContainer(2);
        private static HttpWebResponse wResp;
        private static HttpWebRequest wr;

        private enum YammerAction
        {
            GetAllGroups,
            GetAllUsers,
            GetOnePerson,
            PostMessage,
            PostToApp,
            ReadAllMessages
        }



        static void Main(string[] args)
        {
            try
            {
                string yammerVerifiedAdminToken = "q0GDG1ayUuRat4Vp8H8LA";
                string yammerClientId = "y6S4FgjV2faSL0zGigXSQ";
                string yammerUserId = string.Empty; // = "1554119433";
                string yammerTokenEndpoint = "https://www.yammer.com/api/v1/oauth/tokens.json";
                string userEmail = "wenjun@raymarklab.com";

                // Get Yammer user by email
                string yammerUserEndpointByEmail = "https://www.yammer.com/api/v1/users/by_email.json";
                string userInfo = MakeGetRequest(string.Format("{0}?email={1}", yammerUserEndpointByEmail, userEmail), yammerVerifiedAdminToken);
                List<YammerUser> users = JsonConvert.DeserializeObject<List<YammerUser>>(userInfo);

                if (users.Count > 0)
                {
                    yammerUserId = users[0].UserID;
                }

                // Get Yammer user access token
                string tokenInfo = MakeGetRequest(string.Format("{0}?user_id={1}&consumer_key={2}", yammerTokenEndpoint, yammerUserId, yammerClientId), yammerVerifiedAdminToken);
                List<YammerToken> tokens = JsonConvert.DeserializeObject<List<YammerToken>>(tokenInfo);

                if (tokens.Count > 0)
                {
                    string yammerUserAccessToken = tokens[0].AccessToken;

                    string tokenInfoMsg = MakeGetRequest("https://www.yammer.com/api/v1/messages.json", yammerUserAccessToken);

                    YammerMessages messages = JsonConvert.DeserializeObject<YammerMessages>(tokenInfoMsg);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred in Main:  " + ex.Message);
            }

            return;

            try
            {
                const string CLIENT_ID = "lajdsfljdsaflkjdsaf";
                const string CLIENT_SECRET = "alsjasdfljadslkjdsaf";
                const string REDIR_URL = "http://sppdxwin8";

                string userName = "speschka@contoso.com";
                string pwd = "asdfasdfa";

                string permUrl = "https://www.yammer.com/dialog/oauth?client_id=" + CLIENT_ID + "&redirect_uri=" + REDIR_URL;
                string authUrl1 = "https://www.yammer.com/session?client_id=" + CLIENT_ID;
                string authUrl2 = "https://www.yammer.com/contoso.com/oauth2/" + CLIENT_ID +
                    "/authorize?client_id=" + CLIENT_ID + "&display=page&redirect_uri=" + HttpUtility.UrlEncode(REDIR_URL) +
                    "&response_type=code";

                string accTokenUrl = "https://www.yammer.com/oauth2/access_token.json?client_id=" +
                    CLIENT_ID + "&client_secret=" + CLIENT_SECRET + "&code=";


                //**********************************************************************************************
                //APPLICATION ENDPOINTS

                string graphPostUrl = "https://www.yammer.com/api/v1/activity.json";
                string messageUrl = "https://www.yammer.com/api/v1/messages";
                string currentUserUrl = "https://www.yammer.com/api/v1/users/current.json";
                string allUsersUrl = "https://www.yammer.com/api/v1/users.json";
                string allGroupsUrl = "https://www.yammer.com/api/v1/groups.json";
                string oneUserUrl = "https://www.yammer.com/api/v1/users/[:id].json";

                //**********************************************************************************************


                //string activityUrl = "https://www.yammer.com/api/v1/streams/activities.json?access_token=adsfasdfasdf";

                string qsCode = string.Empty;
                string accessToken = "";
                string postResults = string.Empty;
                string response = string.Empty;

                if (string.IsNullOrEmpty(accessToken))
                {
                    while (string.IsNullOrEmpty(qsCode))
                    {
                        response = MakeGetRequest(permUrl);

                        //look for authenticity token
                        string authToken = GetAuthenticityToken(response);

                        if (!string.IsNullOrEmpty(authToken))
                        {
                            //POST /session?client_id=zdpOzrUurBtvHhoTJ00wQ HTTP/1.1

                            //sample post body:
                            //utf8=%E2%9C%93&authenticity_token=bP%2Bh0zNGkeL7z%2Bj5stJ%2FPsyZb1O75SPmS5RpkXfSFgo%3D&network_permalink=&login=speschka@contoso.com&password=asdfadsf&remember_me=on
                            //string foo = System.Web.HttpUtility.UrlEncodeUnicode("bP+h0zNGkeL7z+j5stJ/PsyZb1O75SPmS5RpkXfSFgo="); //.net recommends UrlEncode

                            //*****************************************************
                            //need to abstract the post calls to a generic function
                            //*****************************************************
                            string postBody = "utf8=%E2%9C%93&authenticity_token=" + System.Web.HttpUtility.UrlEncode(authToken) + "&network_permalink=&login=" +
                                userName + "&password=" + pwd + "&remember_me=on";

                            //make the first post for code
                            postResults = MakePostRequest(postBody, authUrl1);

                            //get the next auth token that was returned and can be used to get an access code
                            string preCodeToken = GetAuthenticityToken(postResults);

                            //********************************************************************
                            //REMOVED 12/17/2013 TO REFLECT CHANGES YAMMER MADE IN AUTH PROCEDURE
                            ////POST /contoso.com/oauth2/adsfasdfsadf/authorize?client_id=asdfasdfasdf&display=page&redirect_uri=http%3A%2F%2Fsppdxwin8&response_type=code HTTP/1.1
                            ////sample post body:
                            ////authenticity_token=KBBgLyjZYGKzUs616hEV5BGqgX6N4D0ejJZ%2FG4zvDsI%3D&_method=post

                            //postBody = "authenticity_token=" + preCodeToken + "&_method=post";

                            ////make the next post
                            //postResults = MakePostRequest(postBody, authUrl2);  
                            //********************************************************************

                            //******************************************************************
                            //ADDED 12/17/2013 TO REFLECT CHANGES YAMMER MADE IN AUTH PROCEDURE
                            response = MakeGetRequest(permUrl, string.Empty, true);
                            //******************************************************************
                        }

                        //now look for the query string
                        qsCode = wResp.ResponseUri.Query;
                    }

                    if (qsCode.IndexOf("code") > -1)
                    {
                        string accessCode = qsCode.Substring(qsCode.IndexOf("=") + 1);

                        response = MakeGetRequest(accTokenUrl + accessCode);

                        if (!string.IsNullOrEmpty(response))
                        {
                            YammerAccessToken jat = YammerAccessToken.GetInstanceFromJson(response);

                            if (!string.IsNullOrEmpty(jat.TokenResponse.Token))
                                accessToken = jat.TokenResponse.Token;
                        }
                    }
                }

                YammerAction action = YammerAction.ReadAllMessages;

                if (!string.IsNullOrEmpty(accessToken))
                {

                    if (action == YammerAction.PostToApp)
                    {
                        #region Post To An App Page using Object Graph
                        //create a new object to write to the graph

                        YammerGraphObject go = new YammerGraphObject();
                        go.Activity.Action = "create";
                        go.Activity.Actor = new YammerActor("Steve Peschka", "speschka@contoso.com");
                        go.Activity.Message = "Hey can we finally get this crazy write stuff working??";

                        go.Activity.Users.Add(new YammerActor("Anne Wallace", "annew@contoso.com"));
                        go.Activity.Users.Add(new YammerActor("Garth Fort", "garthf@contoso.com"));

                        YammerGraphObjectInstance jo = new YammerGraphObjectInstance();
                        jo.Url = "http://www.vbtoys.com";
                        jo.Title = "yammo objectola";

                        go.Activity.Object = jo;

                        string postData = go.ToString();

                        #region Working Sample Post Data
                        //test3
                        //                            postData = @"{
                        //    ""activity"": {
                        //        ""actor"": {
                        //            ""name"": ""Steve Peschka"",
                        //            ""email"": ""speschka@contoso.com""
                        //        },
                        //        ""action"": ""create"",
                        //        ""object"": {
                        //            ""url"": ""http://localhost:33128/media/detail?id=34"",
                        //            ""description"": ""dfdgfdgf"",
                        //            ""title"": ""fdgfdgf"",
                        //            ""image"": ""https://mug0.assets-yammer.com/mugshot/images/75x75/LBZq1qTjmSd9XkzdkNJnRKCVGQD38MF6""
                        //        },
                        //        ""private"": ""false"",
                        //        ""message"": """",
                        //        ""users"": [{""email"":""annew@contoso.com"",""name"":""Anne Wallace""},{""email"":""garthf@contoso.com"",""name"":""Garth Fort""}]
                        //    }";
                        #endregion

                        response = MakePostRequest(postData, graphPostUrl, accessToken, "application/json");
                        #endregion
                    }
                    else if (action == YammerAction.ReadAllMessages)
                    {
                        #region Read All Messages
                        response = MakeGetRequest(messageUrl + ".json", accessToken);
                        YammerMessages yms = YammerMessages.GetInstanceFromJson(response);

                        foreach (YammerMessage ym in yms.Messages)
                        {
                            if (!string.IsNullOrEmpty(ym.MessageContent.PlainText))
                                Console.WriteLine("Message:  " + ym.MessageContent.PlainText + Environment.NewLine);
                            else
                                Console.WriteLine("Message ID " + ym.ID + "had no message in the body.");
                        }
                        #endregion
                    }
                    else if (action == YammerAction.PostMessage)
                    {
                        #region Post A New Message
                        //get info about the current user so you can see the group memberships
                        response = MakeGetRequest(currentUserUrl, accessToken);
                        YammerUser yu = YammerUser.GetInstanceFromJson(response);

                        //get only the groups out of there
                        var groups = from YammerGroupsAndFeeds y in yu.SettingsAndFeedsAndGroups.GroupsAndFeeds
                                     where y.Type == "group"
                                     select y;

                        List<YammerGroupsAndFeeds> myGroups = groups.ToList<YammerGroupsAndFeeds>();

                        //enumerate all the groups
                        //foreach (YammerGroupsAndFeeds y in myGroups)
                        //{
                        //    Console.WriteLine(y.GroupID);
                        //}

                        //just as an example, getting the IT Support group
                        var itGroup = from YammerGroupsAndFeeds yg in myGroups
                                      where yg.Name == "IT Support"
                                      select yg;

                        YammerGroupsAndFeeds it = itGroup.First<YammerGroupsAndFeeds>();

                        if (it != null)
                        {
                            //let's post a message now to this group
                            bool broadcastToAll = false;

                            //form POST - these are the variables:
                            //body - The text of the message body.
                            //group_id - The ID of the group to which the message should be posted.
                            //replied_to_id - The message ID this message is in reply to.
                            //direct_to_id - Send a private message directly to the user indicated.
                            //broadcast=true - This message should be broadcast to all users. The access token should belong to a verified admin user in paid Yammer networks.
                            //topicn - Topics to apply to the message. Can use topic1 through topic20.

                            //Console.WriteLine("Type in the message you want posted to the Yammer IT Group then press enter:");
                            //string myMessage = Console.ReadLine();

                            //string msg = "body=" + myMessage + "&group_id=" +
                            //    it.GroupID + "&broadcast=" + broadcastToAll.ToString();

                            string msg = "body=Thanks [[user:1504829560]] for your big sale!" + "&group_id=3095986" +
                                "&broadcast=" + broadcastToAll.ToString();

                            //try adding the message
                            response = MakePostRequest(msg, messageUrl + ".json", accessToken);

                            if (!string.IsNullOrEmpty(response))
                            {
                                YammerMessages newMsg = YammerMessages.GetInstanceFromJson(response);
                                Console.WriteLine("message sent: " + newMsg.Messages[0].MessageContent.PlainText);
                            }
                        }
                        #endregion
                    }
                    else if (action == YammerAction.GetAllUsers)
                    {
                        #region Get All Users
                        ////get info about the current user so you can see the group memberships
                        //response = MakeGetRequest(allUsersUrl, accessToken);
                        //List<YammerUser> users = JsonConvert.DeserializeObject<List<YammerUser>>(response);
                        List<YammerUser> users = GetPagedData<YammerUser>(allUsersUrl, accessToken);

                        //you could take each user though and emit Xml where
                        //you have email, UserID, JobTitle, FullName, FirstName, Lastname, Department and 
                        //a semi-colon delimited list of group and feed IDs

                        //when they authenticate, you could lookup into Xml based on their email claim (identity claim)
                        //and get JobTitle, Department and list of group IDs, and then lookup each group in the Xml
                        //and add a role claim

                        //the JobTitle and Department are probably useful claims for granting rights, but the 
                        //email, FullName, FirstName and LastName probably just good for finding a person, and
                        //then you grant rights to the associated email address

                        ////returns null
                        //YammerUser steve = users.Where(e => 
                        //    e.ContactInfo.EmailAddresses.Contains(
                        //    new YammerEmailAddresses("speschka@contoso.com", "primary"))).FirstOrDefault<YammerUser>();


                        //foreach (YammerUser user in users)
                        //{
                        //    Console.WriteLine(user.FullName);
                        //}
                        #endregion
                    }
                    else if (action == YammerAction.GetAllGroups)
                    {
                        #region Get All Groups
                        //Stopwatch sw = new Stopwatch();
                        //sw.Start();

                        //total groups:  18616
                        List<YammerGroup> groups = GetPagedData<YammerGroup>(allGroupsUrl, accessToken);

                        //total public groups:  9791
                        List<YammerGroup> publicGroups = groups.Where(p => p.PrivacyLevel == "public").ToList<YammerGroup>();

                        //time to filter in where loop:  509184 ms
                        //time to filter once after data's returned:  509205 ms
                        //total time approx 8.48 minutes

                        //sw.Stop();
                        //Debug.WriteLine(sw.ElapsedMilliseconds);   
                        #endregion
                    }
                    else if (action == YammerAction.GetOnePerson)
                    {
                        #region Get One User
                        //1504829560 - anne wallace
                        //get info about the current user so you can see the group memberships
                        response = MakeGetRequest(oneUserUrl.Replace("[:id]", "1504829560"), accessToken);
                        YammerUser yu = YammerUser.GetInstanceFromJson(response);
                        #endregion
                    }
                }
                else
                {
                    Console.WriteLine("Failed to get access token!");
                }

                //close our response object
                wResp.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred in Main:  " + ex.Message);
            }
        }

        private static List<T> GetPagedData<T>(string Url, string accessToken)
        {
            List<T> results = new List<T>();

            try
            {
                //set up paging
                int curPage = 0;
                string response = "start";

                string qsOperator = (Url.IndexOf("?") > -1) ? "&" : "?";

                while (response != "[]")
                {
                    //NOTE:  Yammer only allows 10 requests in 10 seconds for this
                    //type of data so you need to put a one second sleep in between
                    //each request or you will get a 429 response code back 
                    //(too many requests)
                    System.Threading.Thread.Sleep(1000);
                    curPage += 1;
                    response = MakeGetRequest(Url + qsOperator + "page=" + curPage.ToString(), accessToken);
                    List<T> resultSet = JsonConvert.DeserializeObject<List<T>>(response);

                    //if (typeof(T) == typeof(YammerGroup))
                    //{
                    //    List<YammerGroup> filteredList = resultSet.OfType<YammerGroup>().Where(p => p.PrivacyLevel == "public").ToList();
                    //    results.AddRange(filteredList.OfType<T>().AsEnumerable());
                    //}
                    //else
                    results.AddRange(resultSet);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting paged data: " + ex.Message);
            }

            return results;
        }

        private static string GetAuthenticityToken(string rawHtml)
        {
            string result = string.Empty;

            try
            {
                int at = rawHtml.IndexOf("<meta name=\"authenticity_token\" id=\"authenticity_token\"");

                if (at > -1)
                {
                    //get the authenticity token string
                    int et = rawHtml.IndexOf("/>", at + 1);
                    string tokenText = rawHtml.Substring(at, et - at);

                    //get the token value
                    int ts = tokenText.IndexOf("content=");
                    int es = tokenText.LastIndexOf("\"");

                    result = tokenText.Substring(ts + 9, es - ts - 9);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetAuthenticityToken: " + ex.Message);
            }

            return result;
        }

        private static void SetCookies()
        {
            try
            {
                const string YAMTRAK_COOKIE = "yamtrak_id";
                const string SESSION_COOKIE = "_workfeed_session_id";

                //no normalization to Set-Cookie content and Cookies on WebRequest is not populated so 
                //we are doing guesstimating parsing
                //Set-Cookie: yamtrak_id=2f1621f7-7452-4f7e-a974-6a85eb5ca22d; path=/; expires=Fri, 26-Sep-2014 15:20:54 GMT; secure; HttpOnly,_workfeed_session_id=34a53fdeab7da22fc4ae088fb19a2307; path=/; secure; HttpOnly
                string cookies = wResp.Headers["Set-Cookie"];

                if (string.IsNullOrEmpty(cookies))
                {
                    cc = new CookieContainer();
                }
                else
                {
                    int cStart = cookies.IndexOf("=");
                    int cEnd = cookies.IndexOf("HttpOnly,");

                    //sometimes the cookie ends with "HttpOnly," and sometimes it ends with "secure"
                    if (
                        (cookies.Substring(cStart + 1, cEnd + 8 - cStart - 1).IndexOf(YAMTRAK_COOKIE) > -1) ||
                         (cookies.Substring(cStart + 1, cEnd + 8 - cStart - 1).IndexOf(SESSION_COOKIE) > -1)
                        )
                    {
                        //change the end to look for secure
                        cEnd = cookies.IndexOf("secure,");
                    }

                    string tempCook1 = cookies.Substring(cStart + 1, cEnd + 8 - cStart - 1);
                    tempCook1 = tempCook1.Remove(tempCook1.IndexOf(";"));

                    cStart = cookies.IndexOf("=", cEnd);
                    string tempCook2 = cookies.Substring(cStart + 1);
                    tempCook2 = tempCook2.Remove(tempCook2.IndexOf(";"));

                    if (cookies.StartsWith("yamtrak"))
                    {
                        yamtrackCookie = tempCook1;
                        sessionCookie = tempCook2;
                    }
                    else
                    {
                        sessionCookie = tempCook1;
                        yamtrackCookie = tempCook2;
                    }

                    //yamtrackCookie = wResp.Cookies[YAMTRAK_COOKIE].Value;
                    //sessionCookie = wResp.Cookies[SESSION_COOKIE].Value;

                    cc = new CookieContainer();
                    cc.Add(new Cookie(YAMTRAK_COOKIE, yamtrackCookie, "/", "www.yammer.com"));
                    cc.Add(new Cookie(SESSION_COOKIE, sessionCookie, "/", "www.yammer.com"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in SetCookies: " + ex.Message);
            }
        }

        private static string MakePostRequest(string postBody, string url, string authHeader = null, string contentType = null)
        {
            string results = string.Empty;

            try
            {
                //get the session and yamtrack cookie
                SetCookies();

                wr = WebRequest.CreateHttp(url);
                wr.Method = "POST";
                wr.CookieContainer = cc;

                //if an authHeader was provided, add it as a Bearer token to the request
                if (!string.IsNullOrEmpty(authHeader))
                    wr.Headers.Add("Authorization", "Bearer " + authHeader);

                byte[] postByte = Encoding.UTF8.GetBytes(postBody);

                if (string.IsNullOrEmpty(contentType))
                    wr.ContentType = "application/x-www-form-urlencoded";
                else
                    wr.ContentType = contentType;

                wr.ContentLength = postByte.Length;
                Stream postStream = wr.GetRequestStream();
                postStream.Write(postByte, 0, postByte.Length);
                postStream.Close();

                wResp = (HttpWebResponse)wr.GetResponse();
                postStream = wResp.GetResponseStream();
                StreamReader postReader = new StreamReader(postStream);

                results = postReader.ReadToEnd();

                postReader.Close();
                postStream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in MakePostRequest: " + ex.Message);
            }

            return results;
        }

        private static string MakeGetRequest(string Url, string authHeader = null, bool AddCookies = false)
        {
            string results = string.Empty;

            try
            {
                wr = WebRequest.CreateHttp(Url);
                wr.Method = "GET";

                //******************************************************************
                //ADDED 12/17/2013 TO REFLECT CHANGES YAMMER MADE IN AUTH PROCEDURE
                if (AddCookies)
                {
                    SetCookies();
                    wr.CookieContainer = cc;
                }
                //******************************************************************                           

                if (!string.IsNullOrEmpty(authHeader))
                    wr.Headers.Add("Authorization", "Bearer " + authHeader);

                wResp = (HttpWebResponse)wr.GetResponse();

                Stream dataStream = wResp.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                results = reader.ReadToEnd();

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in MakeGetRequest: " + ex.Message);
            }

            return results;
        }
    }
}
