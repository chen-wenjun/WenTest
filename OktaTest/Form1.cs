using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Okta.Core.Models;
using Okta.Core.Clients;
using Okta.Core;

namespace OktaTest
{
    public partial class Form1 : Form
    {
        private string _apiToken;
        private string _uri;
        private OktaClient _oktaClient;

        public Form1()
        {
            InitializeComponent();

            _apiToken = "000qhx6S4jDT0Eo0ZNbpE1WnGpJi-89A1yUfJYD-R5";
            _uri = @"https://dev-598383.oktapreview.com";
            //_oktaClient = new OktaClient(_apiToken, new Uri(_uri));
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _oktaClient = new OktaClient(_apiToken, new Uri(_uri));
                var usersClient = _oktaClient.GetUsersClient();

                //var user = usersClient.Get("ravi@example.com");
                var user = usersClient.Get("newuser@example.com");
                //var user = usersClient.Get("wchen@mi9retail.com");
                //var user = usersClient.Get("lravi@dev-598383.oktapreview.com");
                //var user = usersClient.Get("isaac@dev-598383.oktapreview.com");

                var groupsUsersClient = _oktaClient.GetUserGroupsClient(user);
                foreach (Group group in groupsUsersClient)
                {
                    ;
                }
            }
            catch (OktaException oktaEx)
            {

            }

        }

        private void groupBtn_Click(object sender, EventArgs e)
        {
            var groupsClient = _oktaClient.GetGroupsClient();
            var groups = groupsClient.GetList();

        }

        private void userApiBtn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string requestUri = string.Format("{0}/api/v1/users//{1}", _uri, "newuser@example.com");

            HttpRequestMessage request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.RequestUri = new Uri(requestUri);
            request.Headers.Add("Authorization", string.Format("SSWS {0}", _apiToken));

            HttpResponseMessage response = client.SendAsync(request).Result;
            string responseStr = response.Content.ReadAsStringAsync().Result;
            var user = JsonConvert.DeserializeObject<User>(responseStr);


        }

        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            var groupsClient = _oktaClient.GetGroupsClient();

            //Group newGroup = new Group("Admin", "Admin");
            //Group newGroup = new Group("SalesAssociate", "Sales Associate");
            Group newGroup = new Group("StoreManager", "Store Manager");

            groupsClient.Add(newGroup);
        }

        private void authUser_Click(object sender, EventArgs e)
        {
            try
            {
                //var authClient = _oktaClient.GetAuthClient();

                OktaClient oktaClient1 = new OktaClient(_apiToken, new Uri(_uri));
                var authClient = oktaClient1.GetAuthClient();

                string username = "ravi@example.com";
                string password = "Raymark1";
                var authResponse = authClient.Authenticate(username, password);

                // Get user's groups
                oktaClient1 = new OktaClient(_apiToken, new Uri(_uri));
                var user = new User() { Id = authResponse.Embedded.User.Id };

                var groupsUsersClient = oktaClient1.GetUserGroupsClient(user);
                foreach (Group group in groupsUsersClient)
                {
                    ;
                }



                //var user = new User();
                //user.Id = authResponse.Embedded.User.Id;
                //var groupsUsersClient = _oktaClient.GetUserGroupsClient(user);
                //foreach (Group group in groupsUsersClient)
                //{
                //    ;
                //}



            }
            catch (OktaException oktaEx)
            {
                
            }
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var usersClient = _oktaClient.GetUsersClient();

                var user = new User("ravi@example.com", "ravi@example.com", "Ravi", "HO");
                user.Credentials = new LoginCredentials();
                user.Credentials.Password.Value = "Raymark1";

                // Create and activate the user
                user = usersClient.Add(user);
            }
            catch (OktaException oktaEx)
            {

            }

        }

        private void addUserToGroupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _oktaClient = new OktaClient(_apiToken, new Uri(_uri));
                var groupsClient = _oktaClient.GetGroupsClient();
                //Group adminGroup = groupsClient.GetByName("Admin");
                //Group adminGroup = groupsClient.GetByName("SalesAssociate");
                Group adminGroup = groupsClient.GetByName("StoreManager");

                _oktaClient = new OktaClient(_apiToken, new Uri(_uri));
                var groupUsersClient =  _oktaClient.GetGroupUsersClient(adminGroup);

                _oktaClient = new OktaClient(_apiToken, new Uri(_uri));
                var usersClient = _oktaClient.GetUsersClient();
                var user = usersClient.Get("newuser@example.com");


                groupUsersClient.Add(user);


            }
            catch (OktaException oktaEx)
            {

            }
        }

        private void getUsersBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OktaClient oktaClient1 = new OktaClient(_apiToken, new Uri(_uri));
                var usersClient = _oktaClient.GetUsersClient();
                var users = usersClient.GetList();

            }
            catch (OktaException oktaEx)
            {

            }
        }
    }
}
