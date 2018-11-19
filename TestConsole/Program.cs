using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Okta.Core.Clients;
using TestClassLibrary;
using Newtonsoft.Json;
using Okta.Core.Models;
using Okta.Core;
using System.Configuration;
using System.Collections.Specialized;
using System.Xml.Serialization;

namespace TestConsole
{
    public class store
    {
        public string name { get; set; }
        public List<book> books { get; set; }
    }
    public class book
    {
        public string name { get; set; }
        public string desc { get; set; }
        public string date { get; set; }
    }

    class Program
    {
        public static List<string> testfunc(string p1, ProcessWindowStyle? style)
        {
            List<string> re = new List<string>();

            return re;
        }

        public class Product
        {
            public decimal? Quantity { get; set; }
        }

        static IEnumerable<int> Lists()
        {
            int i1 = 3;
            yield return i1;
            int i2 = 4;
            yield return i2;
            yield break;
            int i3 = 5;
            yield return i3;
            int i4 =6;
            yield return i4;
        }



        static void Main(string[] args)
        {
            {
                string xml = @"
<store>
    <name>store1</name>
    <books>
        <book>
            <name>book1</name>
            <desc>good book</desc>
            <date>2014</date>
        </book>
        <book>
            <name>book2</name>
            <desc>better book</desc>
            <date>2015</date>
        </book>
        <book>
            <name>book3</name>
            <desc>best book</desc>
            <date>2016</date>
        </book>
    </books>
</store>
";
                var serializer = new XmlSerializer(typeof(store));
                using (var textReader = new StringReader(xml))
                {
                    {
                        XmlReaderSettings settings = new XmlReaderSettings();
                        using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
                        {
                            var store = (store)serializer.Deserialize(xmlReader);
                        }
                    }

                }



                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xml);

            }

            {
                List<CusotmerInfo> customers = new List<CusotmerInfo>();
                customers.Add(new CusotmerInfo() { FirstName = "first1", LastName = "last1", Code = "f1" });
                customers.Add(new CusotmerInfo() { FirstName = "first2", LastName = "last2", Code = "f2" });
                customers.Add(new CusotmerInfo() { FirstName = "first3", LastName = "last3", Code = "f3" });
                customers.Add(new CusotmerInfo() { FirstName = "first4", LastName = "last4", Code = "f4" });

                foreach(var cust in customers.ToList())
                {
                    string code = cust.Code;

                    customers.Add(new CusotmerInfo() { FirstName = "first5", LastName = "last5", Code = "f5" });

                }


                return;
            }


            {
                List<string> s1 = new List<string>() { "a", "b", "c" };
                List<string> s2 = s1;
                List<string> s3 = new List<string>(s1);

                s2[1] = "bbbbb";
                s3[1] = "zzzzz";

                return;
            }


            {
                var section = ConfigurationManager.GetSection("server") as NameValueCollection;
                var value = section["url"];

                Console.WriteLine(string.Format("url={0}", value));
                Console.Read();
            }
            return;

            {
                foreach (int list in Lists())
                {
                    int i = list;
                    int j = i;
                }
            }

            {
                string s = "Dave56678";
                string base64string = Base64.Base64.Base64Encode(s);
                string mybase64string = Base64.Base64.MyBase64Encode(s);

                string text = "Dave56678";
                byte[] bytes = System.Text.Encoding.ASCII.GetBytes(text);
                string base64 = System.Convert.ToBase64String(bytes);

                byte[] bytes2 = System.Convert.FromBase64String(base64);

                return;
            }

            {
                List<string> lines = new List<string>();
                lines.Add("safassa saf safa f1");
                lines.Add("safassa saf safa f2");
                lines.Add("safassa saf safa f3");
                lines.Add("safassa saf safa f4");
                lines.Add("safassa saf safa f5");
                lines.Add("safassa saf safa f6");

                string result = string.Join("\r\n", lines);

                return;
            }

            {
                Class1.Instance.GetStr();
                Class1.Instance.GetStr();
                Class1.Instance.GetStr();
            }

            return;
            

            {
                try
                {
                    string apiToken = "000qhx6S4jDT0Eo0ZNbpE1WnGpJi-89A1yUfJYD-R5";
                    string uri = "https://dev-598383.oktapreview.com";

                    var oktaClient = new OktaClient(apiToken, new Uri(uri));

                    var groupsClient = oktaClient.GetGroupsClient();
                    var groups = groupsClient.GetList();





                    var usersClient = oktaClient.GetUsersClient();

                    var user = usersClient.Get("newuser@example.com");

                    var groupsUsersClient = oktaClient.GetUserGroupsClient(user);







                    ////user.GetProperty("mycustom_attr");
                    //user.SetProperty("mycustom_attr", "1234");
                    //user = usersClient.Update(user);



                    //var filter = new FilterBuilder()
                    //                .Where(Filters.User.Status)
                    //                .EqualTo(UserStatus.Active)
                    //                .And()
                    //                .Where(Filters.User.LastUpdated)
                    //                .GreaterThanOrEqual(new DateTime(2016, 5, 3));

                    //foreach (User user in usersClient.GetFilteredEnumerator(filter))
                    //{
                    //    var profile = user.Profile;
                    //}


                    //foreach(var user in usersClient)
                    //{
                    //    var profile = user.Profile; // Do something with each user
                    //}

                    //var users = usersClient.GetList();

                    //var user = new User("newuser@example.com", "newuser@example.com", "New", "User");

                    //// Create and activate the user
                    //user = usersClient.Add(user);

                    //// Retrieve the user
                    //user = usersClient.Get("newuser@example.com");

                    //// Update the user's first name
                    //user.Profile.FirstName = "Old";
                    //user = usersClient.Update(user);
                }
                catch (Exception ex)
                {
                    if (ex is OktaException)
                    {
                        var oktaEx = (OktaException) ex;
                        
                    }
                }

                return;
                //var usersClient = new UsersClient(apiToken, subDomain);

            }



            {
                var folder1 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData);

                
                return;
            }


            {
                string sessionToken = "9f317e9e-8aad-4eed-a6a6-49d492276162";
                string userName = "ravi";

                bool isTokenValid = false;

                HttpClient client = new HttpClient();
                string requestUri = string.Format("{0}/{1}", "http://localhost/craservice.mosaic2.8.2000", "api/auth/ValidateToken");

                HttpRequestMessage request = new HttpRequestMessage();
                request.Method = HttpMethod.Get;
                request.RequestUri = new Uri(requestUri);
                request.Headers.Add("X-RM-API-TOKEN", sessionToken);

                HttpResponseMessage response = client.SendAsync(request).Result;
                string responseStr = response.Content.ReadAsStringAsync().Result;
                responseStr = @"{""IsTokenValid"":true,""AppSecUserName"":""ravi"",""StaffCode"":""ravi"",""LastActiveTime"":""2016-04-14T15:27:31.804698Z""}";
                responseStr = @"{""IsTokenValid"":true,""AppSecUserName"":""ravi"",""StaffCode"":""ravi"",""LastActiveTime"":""2015-08-31T07:05:58-07:00""}";
                responseStr = @"{""IsTokenValid"":true,""AppSecUserName"":""ravi"",""StaffCode"":""ravi"",""LastActiveTime"":""2015-08-31T03:10:00Z""}";
                var tokenResponse = JsonConvert.DeserializeObject<ValidateCraTokenResponse>(responseStr);

                if (tokenResponse != null)
                    if (tokenResponse.IsTokenValid &&
                        (string.Compare(tokenResponse.AppSecUserName, userName, true) == 0 ||
                         string.Compare(tokenResponse.StaffCode, userName, true) == 0))

                        isTokenValid = true;

                return;
            }


            {
                for (int j = 1; j < 50; j++)
                {


                    ProcessStartInfo i = new ProcessStartInfo();
                    i.UseShellExecute = true;
                    i.WindowStyle = ProcessWindowStyle.Normal;
                    i.CreateNoWindow = false;
                    i.FileName = @"C:\Program Files (x86)\Raymark\XIP\Raymark.XIP.PrinterApp.exe";
                    i.Arguments = @"/s V-AQUARIUS\SQL2012 /d Merch_DEV_2_7 /u RaymApp /p raym /store 3 /transnum 2 /cais 473 /transtype ""SALE"" /app ""XPERT"" /preview N /nbcopies 1 /printer_name ""Microsoft XPS Document Writer""";

                    Process pp = Process.Start(i);


                }

                return;
            }

            {
                string from = "Thu Oct 08 2015 00:00:00 GMT1100 (AUS Eastern Daylight Time)";
                string to = "Fri Jan 08 2016 00:00:00 GMT1100 (AUS Eastern Daylight Time)";

                //string from = "Wed Oct 07 2015 00:00:00 GMT-0400 (Eastern Daylight Time)";
                //string to = "Thu Jan 07 2016 00:00:00 GMT-0500 (Eastern Standard Time)";


                DateTime fromDate = DateTime.Now;
                DateTime toDate = DateTime.Now;

                fromDate = DateTime.Parse(from);


                if (from != null)
                {
                    string trim = from.Substring(0, from.IndexOf(" ("));
                    fromDate = DateTime.ParseExact(trim, "ddd MMM dd yyyy HH:mm:ss 'GMT'zzz", CultureInfo.InvariantCulture);
                }

                if (to != null)
                {
                    string trim = to.Substring(0, to.IndexOf(" ("));
                    toDate = DateTime.ParseExact(trim, "ddd MMM dd yyyy hh:mm:ss 'GMT'zzz", CultureInfo.InvariantCulture);
                    toDate = toDate.AddHours(24);
                }
            }

            {


                // this is what we are sending
                string post_data = ""; // "foo=bar&baz=oof";

                // this is where we will send it
                string uri = "https://pos.cherrera.com/PosService.rest-training/posservice.svc/get-service-info";

                // create a request
                HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create(uri); request.KeepAlive = false;
                request.ProtocolVersion = HttpVersion.Version10;
                request.Method = "POST";

                // turn our request string into a byte stream
                byte[] postBytes = Encoding.ASCII.GetBytes(post_data);

                // this is important - make sure you specify type this way
                //request.ContentType = "application/x-www-form-urlencoded";
                request.ContentType = "application/json";
                request.ContentLength = postBytes.Length;
                Stream requestStream = request.GetRequestStream();

                // now send it
                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();

                // grab te response and print it out to the console along with the status code
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(new StreamReader(response.GetResponseStream()).ReadToEnd());
                Console.WriteLine(response.StatusCode);

                return;

            }


            {
                MakeHTTPSPostCall("https://pos.cherrera.com/PosService.rest-training/posservice.svc/get-service-info", "");

                return;
            }


            {
                decimal? d1 = 1.0M;
                decimal? d2 = 2.0M;

                decimal d3 = d1 + d2 ?? 0M;

            }

            {
                DateTime now = DateTime.Now;

                DateTime newDate = now.AddYears(1901 - now.Year);
                DateTime newDate2 = newDate.AddYears(1901);

            }


            {
                List<Product> products = new List<Product>()
                {
                    new Product(){ Quantity = 1.0M },
                    new Product(){ Quantity = 2.0M },
                    new Product(){ Quantity = 3.0M },
                    new Product()

                };

                decimal? sum = products.Sum(e => e.Quantity);



            }

            {
                const string file = "cmd.exe";

                var sspw = new SecureString();

                foreach (var c in "cwj109@gmail")
                    sspw.AppendChar(c);

                var proc = new Process();

                proc.StartInfo.UseShellExecute = false;

                proc.StartInfo.WorkingDirectory = Path.GetDirectoryName(file);

                proc.StartInfo.FileName = Path.GetFileName(file);

                proc.StartInfo.Domain = "raymarkx.com";
                proc.StartInfo.Arguments = "";
                proc.StartInfo.UserName = "wch";
                proc.StartInfo.Password = sspw;
                proc.StartInfo.LoadUserProfile = false;
                proc.Start();
            }


            {
                bool isHosted = true;
                string rootDir = @"\\server\image";

                if (isHosted)
                {
                    const string fileIdentifier = @":\";
                    string httpPath = string.Empty;
                    string imageServerHttp = @"http://hostname/";
                    imageServerHttp = (imageServerHttp == null ? "http:/localhost/" : imageServerHttp);

                    int startPos = rootDir.IndexOf(fileIdentifier) + fileIdentifier.Length;
                    if (startPos < rootDir.Length)
                    {
                        httpPath = imageServerHttp + rootDir.Substring(startPos).Replace("\\", "/");
                    }

                    if (httpPath.Substring(httpPath.Length - 1, 1) != "//")
                    {
                        httpPath += "//";
                    }
                    rootDir = httpPath;
                }

                //Do some adjustment of this parameter if this parameter's value is not end with '/'
                if (string.IsNullOrEmpty(rootDir))
                {
                    throw new Exception("Parameter {0} is not set correctly.");
                }
                else
                {
                    //if (sessionContext.IsHosted == false && rootDir.Substring(rootDir.Length - 1, 1) != "\\")
                    if (isHosted == false && rootDir.Substring(rootDir.Length - 1, 1) != "\\")
                    {
                        rootDir += "\\";
                    }
                }


            }



            {
                string path = @"\\aleph";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }


            }


            {
                DateTimeFormatInfo dateTimeInfo = System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat;

                DateTimeFormatInfo dateTimeInfo1 = DateTimeFormatInfo.CurrentInfo;

                string ampm = DateTime.Now.ToString("tt");
                string time1 = DateTime.Now.ToString("hh:mm", DateTimeFormatInfo.InvariantInfo);
                string time2 = DateTime.Now.ToString("hh:mm:ss tt", DateTimeFormatInfo.InvariantInfo);

            }
            return;

            {
                CultureInfo cul = new CultureInfo("zh-CN");
                //CultureInfo cul = new CultureInfo("en-US");

                System.Threading.Thread.CurrentThread.CurrentCulture = cul;

                string time1 = DateTime.Now.ToString("hh:mm", DateTimeFormatInfo.InvariantInfo);
                string time2 = DateTime.Now.ToString("hh:mm:ss tt", DateTimeFormatInfo.InvariantInfo);

            }
            return;

            {
                decimal? quantity = null;

                decimal a = Math.Abs(quantity ?? 10M);

                int int1 = 10;
                int1 = Convert.ToInt32(quantity);

                if (quantity == 0)
                    throw new Exception("");

                decimal? qty1 = quantity;

                decimal qty = quantity.Value;


            }


            {
                string colorDescription = "color Description";
                string storeName = "store Name";
                string storeCode = "store Code";

                StringBuilder builder = new StringBuilder();

                builder.AppendFormat(@"{{""ColorDescription"":""{0}"",""StoreCode"":""{1}"",""StoreName"":""{2}""",
                    colorDescription, storeCode, storeName);

            }
            return;

            {
                //////////////////////////////////////////////
                //string email = @"cwj109@gmail.com";
                //string email = @"wchen@raymark.com";
                string email = @"chen_wenjun@yahoo.com";
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(email);
                mailMessage.To.Add(email);


                mailMessage.Subject = "Raymark PMW Notification: Task # has been pushed to you";
                mailMessage.IsBodyHtml = true;

                //string MailBody = @" test body";


                //MailBody = MailBody.Replace("%RECIPIENTNAME%", staffToName);
                //MailBody = MailBody.Replace("%TASKNUMBER%", taskNum.ToString());
                //MailBody = MailBody.Replace("%SENDER%", staffFromName);
                //MailBody = MailBody.Replace("%DESCRIPTION%", tasksShortDescription);
                ////  MailBody = MailBody.Replace("%TASKNUMBER%", dtTask.Rows[0]["IssuePriority"].ToString());
                //MailBody = MailBody.Replace("%DURATION%", assignedHours);
                //MailBody = MailBody.Replace("%DATE%", tasksFromDate);
                //MailBody = MailBody.Replace("%WO%", woId);
                //MailBody = MailBody.Replace("%CUSTOMERNAME%", customerId);


                mailMessage.Body = "<h1>test body</h1>";

                SmtpClient Sc = new SmtpClient("colorado");

                //Sc.Credentials = new NetworkCredential(@"raymarkx.com\infos", "d4mph0u553");


                Sc.Send(mailMessage);
            }
            return;


            {
                string input = "normal1";

                ProcessWindowStyle? printMethod = null;
                ProcessWindowStyle printMethod1;
                if (Enum.TryParse<ProcessWindowStyle>(input, out printMethod1))
                {
                    printMethod = printMethod1;
                }

                testfunc("1", printMethod);

            }
            return;

            {
                PrintDocument printDoc = new PrintDocument();

                // Add list of installed printers found to the combo box. 
                // The pkInstalledPrinters string will be used to provide the display string. 
                int i;
                string pkInstalledPrinters;

                PrinterSettings set = new PrinterSettings();

                string name = set.PrinterName;

                for (i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                {
                    pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                    //comboInstalledPrinters.Items.Add(pkInstalledPrinters);
                    if (printDoc.PrinterSettings.IsDefaultPrinter)
                    {
                        string t = printDoc.PrinterSettings.PrinterName;
                    }
                }


            }
            return;





            {
                ProcessStartInfo info1 = new ProcessStartInfo();
                info1.Verb = "print";
                info1.FileName = @"C:\Temp\lov.pdf";
                info1.CreateNoWindow = true;
                info1.WindowStyle = ProcessWindowStyle.Hidden;
                info1.Arguments = " /T DEV";

                Process p = new Process();
                p.StartInfo = info1;
                p.Start();

                //p.WaitForInputIdle();
                //System.Threading.Thread.Sleep(3000);
                //if (false == p.CloseMainWindow())
                //	p.Kill();



            }
            return;




            {
                ProcessStartInfo i = new ProcessStartInfo();
                i.UseShellExecute = true;
                i.WindowStyle = ProcessWindowStyle.Normal;
                i.CreateNoWindow = false;
                i.FileName = @"D:\Projects\Wen.Try2012\WenTest\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe";
                //i.FileName = @"Notepad.exe";
                i.Arguments = "";

                i.UseShellExecute = false;
                i.Domain = "raymarkx.com";
                i.UserName = "wch";
                //i.Password = "cwj109@gmail.com";
                SecureString ssPwd = new SecureString();
                string password = "cwj109@gmail.com";
                for (int x = 0; x < password.Length; x++)
                {
                    ssPwd.AppendChar(password[x]);
                }

                ssPwd.MakeReadOnly();
                i.Password = ssPwd;

                Process pp = Process.Start(i);
            }
            return;


            //////////////////////////////////////////////////

            {
                List<Address> addressList = new List<Address>();

                int pageSize = 2;
                int pageIndex = 0;

                int startIndex = pageSize * pageIndex;
                int endIndex = pageSize * (pageIndex + 1) - 1;


                addressList.Add(new Address() { Line1 = "1" });
                addressList.Add(new Address() { Line1 = "2" });
                addressList.Add(new Address() { Line1 = "3" });
                addressList.Add(new Address() { Line1 = "4" });
                addressList.Add(new Address() { Line1 = "5" });
                addressList.Add(new Address() { Line1 = "6" });

                List<Address> newList = addressList.Where((e, index) => index >= startIndex && index <= endIndex).ToList();

                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var firstBigNumbers = numbers.TakeWhile((n, index) => n >= index);




                CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("CA");


                String pkInstalledPrinters;
                for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                {
                    pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                    Console.WriteLine(pkInstalledPrinters);
                }


                char cha = char.Parse("\t");

                string str = @"s\ty";
                foreach (char c in str)
                {
                    char ch = c;
                }

                CultureInfo info = CultureInfo.CurrentCulture;

                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");


                DateTime date123 = new DateTime();


                string str1 = "zzz";
                string str2 = null;
                int res = string.Compare(str1, "a", StringComparison.Ordinal);


                if (str1.Equals("1"))
                    str1 = "11";
                else
                {
                    str2 = "22";
                }




                XmlDocument doc = new XmlDocument();
                XmlElement transactionsElement = doc.CreateElement("Transactions");
                doc.AppendChild(transactionsElement);

                for (int i = 0; i < 3; i++)
                {
                    XmlElement transactionElement = doc.CreateElement("Transaction");
                    transactionsElement.AppendChild(transactionElement);

                    XmlNode storeNode = doc.CreateElement("StoreId");
                    storeNode.AppendChild(doc.CreateTextNode("7"));
                    transactionElement.AppendChild(storeNode);


                    XmlNode caisNode = doc.CreateElement("Cais");
                    caisNode.AppendChild(doc.CreateTextNode("252"));
                    transactionElement.AppendChild(caisNode);

                    XmlNode transNumNode = doc.CreateElement("TransNum");
                    transNumNode.AppendChild(doc.CreateTextNode("14"));
                    transactionElement.AppendChild(transNumNode);
                }


                DataTable customerTransactionTable = new DataTable("CustomerTransaction");
                customerTransactionTable.Columns.Add(new DataColumn("CustomerCode", typeof(string)));
                customerTransactionTable.Columns.Add(new DataColumn("TransactionNumber", typeof(string)));

                // Loop to populate data table
                for (int i = 1; i < 5; i++) // Table name: Last60Transactions
                {
                    string clientNumber = string.Format("clientNumber{0}", i);
                    string transactionNumber = string.Format("transactionNumber{0}", i);

                    DataRow newRow = customerTransactionTable.NewRow();
                    newRow["CustomerCode"] = clientNumber;
                    newRow["TransactionNumber"] = transactionNumber;

                    customerTransactionTable.Rows.Add(newRow);
                }

                customerTransactionTable.AcceptChanges();


                // Convert DataTable to XML string
                string customerTransactionXml;
                using (StringWriter sw = new StringWriter())
                {
                    customerTransactionTable.WriteXml(sw);
                    customerTransactionXml = sw.ToString();
                }






                string date = "20140222 154535";
                DateTime datetime = DateTime.ParseExact(date, "yyyyMMdd HHmmss", null);

                Enum1 e1 = Enum1.Item2;

                Enum2 e2 = (Enum2)e1;



                int? number;
                number = null;
                bool y = number.HasValue;

                number = new Nullable<int>();


                bool test = Convert.ToBoolean(DBNull.Value);


                List<int> randomList = new List<int>();

                for (int j = 0; j < 1000000; j++)
                {
                    //Console.WriteLine(DateTime.Now.Millisecond);
                    //////Console.WriteLine(DateTime.Now.ToString("hh:mm:ss:fffffff"));
                    //Console.WriteLine(DateTime.Now.Ticks);

                    //randomList.Add(DateTime.Now.Millisecond);


                    byte[] seed = Guid.NewGuid().ToByteArray();
                    for (int i = 0; i < 3; i++)
                    {
                        seed[i] ^= seed[i + 4];
                        seed[i] ^= seed[i + 8];
                        seed[i] ^= seed[i + 12];
                    }

                    int seedInt = BitConverter.ToInt32(seed, 0);
                    //Console.WriteLine(seedInt);
                    Random rnd = new Random(seedInt);
                    randomList.Add(rnd.Next(9999999));


                    //Console.WriteLine(rnd.Next(9999999));

                }

                var duplicates = randomList.GroupBy(a => a).SelectMany(ab => ab.Skip(1).Take(1)).ToList();

                List<CusotmerInfo> custList = new List<CusotmerInfo>();

                custList.Add(new CusotmerInfo()
                {
                    Code = "a",
                    FirstName = "F1",
                    LastName = "L1",
                    Address1 = new Address()
                    {
                        IsDefault = false,
                        Line1 = "Line11",
                        ZipCode = "Zip1"
                    }
                });

                custList.Add(new CusotmerInfo()
                {
                    Code = "a",
                    FirstName = "F2",
                    LastName = "L2",
                    Address1 = new Address()
                    {
                        IsDefault = true,
                        Line1 = "Line12",
                        ZipCode = "Zip2"
                    }
                });

                custList.Add(new CusotmerInfo()
                {
                    Code = "b",
                    FirstName = "F3",
                    LastName = "L3",
                    Address1 = new Address()
                    {
                        IsDefault = false,
                        Line1 = "Line13",
                        ZipCode = "Zip3"
                    }
                });

                //var result = from cust in custList
                //			 group cust by cust.Code into g
                //			 select new CusotmerInfo()
                //			 {
                //				 Code = g.Key,
                //				 Address1 = g.FirstOrDefault(e => e.Address1.IsDefault) == null ? g.FirstOrDefault().Address1 : g.FirstOrDefault(e => e.Address1.IsDefault).Address1
                //			 };

                var result = from cust in custList
                             group cust by cust.Code into g
                             select g.FirstOrDefault(e => e.Address1.IsDefault) == null ? g.FirstOrDefault() : g.FirstOrDefault(e => e.Address1.IsDefault);


                List<CusotmerInfo> re = result.ToList();



                //List<Address> addressList = new List<Address>();
                //addressList.Add(new Address() { AddressLine1 = "a1", Sequence = 2 });
                //addressList.Add(new Address() { AddressLine1 = "a2", Sequence = 3 });
                //addressList.Add(new Address() { AddressLine1 = "a3", Sequence = 1 });
                //addressList.Add(new Address() { AddressLine1 = "a4", Sequence = 4 });

                //int minSequence = addressList.Min(address => address.Sequence);

                //addressList.Sort(delegate(Address a1, Address a2) { return a1.Sequence - a2.Sequence; });
            }
            return;
        }

        static void MakeHTTPSPostCall(string url, string requestBody)
        {
            HttpWebRequest webRequest = WebRequest.CreateHttp(url);
            webRequest.Method = "POST";
            webRequest.BeginGetRequestStream(
                requestResult =>
                {

                    using (Stream postStream = webRequest.EndGetRequestStream(requestResult))
                    {
                        if (requestBody != null)
                        {
                            byte[] byteArray = Encoding.UTF8.GetBytes(requestBody);
                            postStream.Write(byteArray, 0, requestBody.Length);
                        }
                    }
                    webRequest.BeginGetResponse(
                        responseResult =>
                        {
                            try
                            {
                                using (var response =
                                    (HttpWebResponse)webRequest.EndGetResponse(responseResult))
                                using (var streamResponse = response.GetResponseStream())
                                using (var streamRead = new StreamReader(streamResponse))
                                {
                                    var responseString = streamRead.ReadToEnd();
                                    var success = response.StatusCode == HttpStatusCode.OK;

                                    // do something here with response...
                                }
                            }
                            catch (Exception ex)
                            {

                            }
                        },
                        null);
                },
                null);
        }
    }

    public enum Enum1
    {
        Item1,
        Item2,
        Item3
    }

    public enum Enum2
    {
        Item1,
        Item2,
        Item3
    }

    public class CusotmerInfo
    {
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address1 { get; set; }

    }

    public class Address
    {
        public string Line1 { get; set; }
        public string ZipCode { get; set; }
        public bool IsDefault { get; set; }

    }

    public class ValidateCraTokenResponse
    {
        public bool IsTokenValid { get; set; }
        public string AppSecUserName { get; set; }
        public string StaffCode { get; set; }
        public DateTime? LastActiveTime { get; set; }
    }
}
