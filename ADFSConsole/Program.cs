using System;
using System.IO;
using System.IdentityModel.Protocols.WSTrust;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Claims;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Xml;
using Thinktecture.IdentityModel.WSTrust;
using System.IdentityModel.Selectors;
using System.Security.Cryptography.X509Certificates;

namespace ADFSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // read token
                var jwtHandler = new JwtSecurityTokenHandler();
                //string jwtEncodedString = "eyJ0eXAiOiJKV1QiLCJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAwLzA5L3htbGRzaWcjcnNhLXNoYTEiLCJ4NXQiOiI0dnk1YV9oM0NVcFJEd3QzbUFCSUdaWlgxMWcifQ.eyJpc3MiOiJodHRwczovL3YtbGFiL2NyYXNlcnZpY2UiLCJhdWQiOiJodHRwczovL3YtbGFiL2NyYXNlcnZpY2UiLCJuYmYiOjE0NDEzNzg0MTQsImV4cCI6MTQ0MTk4MzIxNCwidW5pcXVlX25hbWUiOiJXZW5qdW4iLCJnaXZlbl9uYW1lIjoiV2VuanVuIiwiZ3JvdXAiOlsiUkFZTUFSS0xBQlxcRG9tYWluIEFkbWlucyIsIlJBWU1BUktMQUJcXERvbWFpbiBVc2VycyJdLCJhdXRobWV0aG9kIjoiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2F1dGhlbnRpY2F0aW9ubWV0aG9kL3Bhc3N3b3JkIiwiYXV0aF90aW1lIjoiMjAxNS0wOS0wNFQxNDo1MzoyNi4xNDdaIn0.NTEU48x2-faKVISrv50ucfwJSma4lDuAFGOe5e6QScOxT7rNUilyn3SxIsUVtRKVDLY1Inof8FhARiBUXcoED153z9EyQVoqX4xgWwTccKzcRGdwELn77iK1bGl_Mb51mj4QWbDARSVXS3m4fMrS4V70XuDXhWM5bv7xpRUxW5ibkMu6Ih60OVUvStLb7XM1RZ3mvtqjFhOTO1Omsng5gU2OViLsuPBoNCi-nMyi47qKz5R3X502uFvCQirLud3Igjc0OqMhRkZzz-NNAvo4i_78fTmvrltyLMxHgTuiM7w9vGsGQ-u6SA-PR9LT3lkIlhtuzkBZLi1wWS55Gmc-1g";
                string jwtEncodedString = "eyJ0eXAiOiJKV1QiLCJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAwLzA5L3htbGRzaWcjcnNhLXNoYTEiLCJ4NXQiOiI0dnk1YV9oM0NVcFJEd3QzbUFCSUdaWlgxMWcifQ.eyJpc3MiOiJodHRwczovL3YtbGFiL2NyYXNlcnZpY2UiLCJhdWQiOiJodHRwczovL3YtbGFiL2NyYXNlcnZpY2UiLCJuYmYiOjE0NDEzNzg0MTQsImV4cCI6MTQ0MTk4MzIxNCwidW5pcXVlX25hbWUiOiJXZW5qdW4iLCJnaXZlbl9uYW1lIjoiV2VuanVuIiwiZ3JvdXAiOlsiUkFZTUFSS0xBQlxcRG9tYWluIEFkbWlucyIsIlJBWU1BUktMQUJcXERvbWFpbiBVc2VycyJdLCJhdXRobWV0aG9kIjoiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2F1dGhlbnRpY2F0aW9ubWV0aG9kL3Bhc3N3b3JkIiwiYXV0aF90aW1lIjoiMjAxNS0wOS0wNFQxNDo1MzoyNi4xNDdaIn0.NTEU48x2-faKVISrv50ucfwJSma4lDuAFGOe5e6QScOxT7rNUilyn3SxIsUVtRKVDLY1Inof8FhARiBUXcoED153z9EyQVoqX4xgWwTccKzcRGdwELn77iK1bGl_Mb51mj4QWbDARSVXS3m4fMrS4V70XuDXhWM5bv7xpRUxW5ibkMu6Ih60OVUvStLb7XM1RZ3mvtqjFhOTO1Omsng5gU2OViLsuPBoNCi-nMyi47qKz5R3X502uFvCQirLud3Igjc0OqMhRkZzz-NNAvo4i_78fTmvrltyLMxHgTuiM7w9vGsGQ-u6SA-PR9LT3lkIlhtuzkBZLi1wWS55Gmc-1g";
                SecurityToken sToken = jwtHandler.ReadToken(jwtEncodedString);

                X509Store store = new X509Store(StoreName.TrustedPeople, StoreLocation.LocalMachine);
                store.Open(OpenFlags.ReadOnly);

                var cs = store.Certificates.Find(X509FindType.FindByThumbprint, "E2FCB96BF877094A510F0B77980048199657D758", false);
                X509Certificate2 certificate = store.Certificates.Find(X509FindType.FindByThumbprint, "E2FCB96BF877094A510F0B77980048199657D758", false)[0];

                TokenValidationParameters validationParameters = new TokenValidationParameters()
                {
                    AllowedAudience = "https://v-lab/craservice",
                    ValidIssuer = "https://v-lab/craservice",

                    // Fetch the signing token from the FederationMetadata document of the tenant.
                    SigningToken = new X509SecurityToken(certificate)
                };

                var claims1 = jwtHandler.ValidateToken(jwtEncodedString, validationParameters);

                {

                    var configuration = new SecurityTokenHandlerConfiguration();
                    configuration.AudienceRestriction.AudienceMode = AudienceUriMode.Never;
                    configuration.CertificateValidationMode = X509CertificateValidationMode.None;
                    configuration.RevocationMode = X509RevocationMode.NoCheck;
                    configuration.CertificateValidator = X509CertificateValidator.None;

                    var registry = new ConfigurationBasedIssuerNameRegistry();
                    registry.AddTrustedIssuer("e2fcb96bf877094a510f0b77980048199617d758", "V-LAB.RAYMARKLAB.COM");
                    configuration.IssuerNameRegistry = registry;


                    jwtHandler.Configuration = configuration;

                    //var claimP = jwtHandler.ValidateToken(jwtEncodedString);
                    var claims = jwtHandler.ValidateToken(sToken);

                }
            }


            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                const string relyingPartyId = "https://adfsserver.security.net/MyApp"; //ID of the relying party in AD FS
                const string adfsEndpoint = "https://adfsserver.security.net/adfs/services/trust/13/windowsmixed";
                const string certSubject = "CN=adfsserver.security.net";

                //Setup the connection to ADFS
                var factory = new WSTrustChannelFactory(new WindowsWSTrustBinding(SecurityMode.TransportWithMessageCredential), new EndpointAddress(adfsEndpoint))
                {
                    TrustVersion = TrustVersion.WSTrust13
                };

                //Setup the request object 
                var rst = new RequestSecurityToken
                {
                    RequestType = RequestTypes.Issue,
                    KeyType = KeyTypes.Bearer,
                    AppliesTo = new EndpointReference(relyingPartyId)
                };

                //Open a connection to ADFS and get a token for the logged in user
                var channel = factory.CreateChannel();
                var genericToken = channel.Issue(rst) as GenericXmlSecurityToken;

                if (genericToken != null)
                {
                    //Setup the handlers needed to convert the generic token to a SAML Token
                    var tokenHandlers = new SecurityTokenHandlerCollection(new SecurityTokenHandler[] { new SamlSecurityTokenHandler() });
                    tokenHandlers.Configuration.AudienceRestriction = new AudienceRestriction();
                    tokenHandlers.Configuration.AudienceRestriction.AllowedAudienceUris.Add(new Uri(relyingPartyId));

                    var trusted = new TrustedIssuerNameRegistry(certSubject);
                    tokenHandlers.Configuration.IssuerNameRegistry = trusted;

                    //convert the generic security token to a saml token
                    var samlToken = tokenHandlers.ReadToken(new XmlTextReader(new StringReader(genericToken.TokenXml.OuterXml)));

                    //convert the saml token to a claims principal
                    var claimsPrincipal = new ClaimsPrincipal(tokenHandlers.ValidateToken(samlToken).First());

                    //Display token information
                    Console.WriteLine("Name : " + claimsPrincipal.Identity.Name);
                    Console.WriteLine("Auth Type : " + claimsPrincipal.Identity.AuthenticationType);
                    Console.WriteLine("Is Authed : " + claimsPrincipal.Identity.IsAuthenticated);
                    foreach (var c in claimsPrincipal.Claims)
                        Console.WriteLine(c.Type + " / " + c.Value);
                    Console.ReadLine();
                }
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                var stsEndpoint = "https://[server]/adfs/services/trust/13/windowstransport";
                var relayPartyUri = "https://localhost:8080/WebApp";

                var factory = new WSTrustChannelFactory(
                    new WindowsWSTrustBinding(SecurityMode.Transport),
                    new EndpointAddress(stsEndpoint));

                factory.TrustVersion = TrustVersion.WSTrust13;

                var rst = new RequestSecurityToken
                {
                    RequestType = RequestTypes.Issue,
                    //AppliesTo = new EndpointAddress(relayPartyUri),
                    AppliesTo = new EndpointReference(relayPartyUri),
                    KeyType = KeyTypes.Symmetric
                };

                var channel = factory.CreateChannel();

                SecurityToken token = channel.Issue(rst);
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                var stsEndpoint = "https://[server]/adfs/services/trust/13/UsernameMixed";
                var relayPartyUri = "https://localhost:8080/WebApp";

                var factory = new WSTrustChannelFactory(
                    new UserNameWSTrustBinding(SecurityMode.TransportWithMessageCredential),
                    new EndpointAddress(stsEndpoint));

                factory.TrustVersion = TrustVersion.WSTrust13;

                // Username and Password here...
                factory.Credentials.UserName.UserName = "";
                factory.Credentials.UserName.Password = "";

                var rst = new RequestSecurityToken
                {
                    RequestType = RequestTypes.Issue,
                    //AppliesTo = new EndpointAddress(relayPartyUri),
                    AppliesTo = new EndpointReference(relayPartyUri),
                    KeyType = KeyTypes.Bearer,
                };

                var channel = factory.CreateChannel();

                SecurityToken token = channel.Issue(rst);
            }


        }

        //The token handler calls this to check the token is from a trusted issuer before converting it to a claims principal
        //In this case I authenticate this by checking the certificate name used to sign the token
        public class TrustedIssuerNameRegistry : IssuerNameRegistry
        {
            private string _certSubject;

            public TrustedIssuerNameRegistry(string certSubject)
            {
                _certSubject = certSubject;
            }

            public override string GetIssuerName(SecurityToken securityToken)
            {
                var x509Token = securityToken as X509SecurityToken;
                if (x509Token != null && 
                    x509Token.Certificate.SubjectName.Name!=null &&
                    x509Token.Certificate.SubjectName.Name.Contains(_certSubject))
                    return x509Token.Certificate.SubjectName.Name;
                throw new SecurityTokenException("Untrusted issuer.");
            }
        }
    }
}
