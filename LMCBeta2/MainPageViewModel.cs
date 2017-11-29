using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Windows.Web.Http;
using Meowtrix.ComponentModel;
using Windows.UI.Xaml;

namespace LMCBeta2
{

    #region public class definitions

    public class SendContent
    {
        public int func_select = 0;
        public LoginContent login = new LoginContent();
        public SearchContent search = new SearchContent();
        public UpdateContent update = new UpdateContent();
        public LogoutContent logout = new LogoutContent();
        public RegisterContent register = new RegisterContent();
        public PersonalInfoContent personalinfo = new PersonalInfoContent();
        public NewBookContent newbook = new NewBookContent();
        public BookEliminationContent bookelimination = new BookEliminationContent();
        public string varification = null;
    }

    public class BookEliminationContent
    {
        public string book_id = null;
    }

    public class LoginContent
    {
        public int login_type;
        public string user_name = null;
        public string password = null;
    }

    public class ReceiveContent
    {
        public int func_select = 0;
        public string content = null;
        public List<Item> data = null;
        public string errormessage = null;
        public string key = null;
    }

    public class SearchContent
    {
        public int match_type = 0;
        public string search_condition = null;
        public string keyword = null;
    }

    public class UpdateContent
    {
        public int update_type = 0;
        public string user = null;
        public string book_id = null;
    }

    public class LogoutContent
    {
        public string user = null;
    }

    public class RegisterContent
    {
        public string user_name = null;
        public string password = null;
        public string email = null;
    }

    public class PersonalInfoContent
    {
        public string username;
        public string email;
    }

    public class NewBookContent
    {
        public string name;
        public string author;
        public int price;
        public string publisher;
        public int publish_year;
    }

    public static class PublicInfo
    {
        public static string user;
        public static string key;
    }


    #endregion

    public class MainPageViewModel : NotificationObject
    {

        #region ViewModel defintions

        private List<Item> items;
        public List<Item> Items
        {
            get => items;
            set { items = value; OnPropertyChanged(); }
        }

        private string username;
        public string Username
        {
            get => username;
            set { username = value; OnPropertyChanged(); }
        }

        private string keyword;
        public string Keyword
        {
            get => keyword;
            set { keyword = value; OnPropertyChanged(); }
        }

        private string password;
        public string Password
        {
            get => password;
            set { password = value; OnPropertyChanged(); }
        }

        private string emailAdderss;
        public string EmailAdderss
        {
            get => emailAdderss;
            set { emailAdderss = value; OnPropertyChanged(); }
        }

        private int selectedIndex;
        public int SelectedIndex
        {
            get => selectedIndex;
            set { selectedIndex = value; OnPropertyChanged(); }
        }

        private int matchIndex;
        public int MatchIndex
        {
            get => matchIndex;
            set { matchIndex = value; OnPropertyChanged(); }
        }

        private Visibility visib1 = new Visibility();
        public Visibility Visib1
        {
            get => visib1;
            set { visib1 = value; OnPropertyChanged(); }
        }

        private Visibility visib2 = new Visibility();
        public Visibility Visib2
        {
            get => visib2;
            set { visib2 = value; OnPropertyChanged(); }
        }

        private Visibility visib3 = new Visibility();
        public Visibility Visib3
        {
            get => visib3;
            set { visib3 = value; OnPropertyChanged(); }
        }

        private Visibility visib4 = new Visibility();
        public Visibility Visib4
        {
            get => visib4;
            set { visib4 = value; OnPropertyChanged(); }
        }

        private Visibility visib5 = new Visibility();
        public Visibility Visib5
        {
            get => visib5;
            set { visib5 = value; OnPropertyChanged(); }
        }

        private Visibility visib6 = new Visibility();
        public Visibility Visib6
        {
            get => visib6;
            set { visib6 = value; OnPropertyChanged(); }
        }

        private Visibility visib7 = new Visibility();
        public Visibility Visib7
        {
            get => visib7;
            set { visib7 = value; OnPropertyChanged(); }
        }

        private Visibility visib8 = new Visibility();
        public Visibility Visib8
        {
            get => visib8;
            set { visib8 = value; OnPropertyChanged(); }
        }

        private string book_id_selected;
        public string Book_id_selected
        {
            get => book_id_selected;
            set { book_id_selected = value; OnPropertyChanged(); }
        }

        private string registerUsername;
        public string RegisterUsername
        {
            get => registerUsername;
            set { registerUsername = value; OnPropertyChanged(); }
        }

        private string registerPassword;
        public string RegisterPassword
        {
            get => registerPassword;
            set { registerPassword = value; OnPropertyChanged(); }
        }

        private string registerPasswordConfirm;
        public string RegisterPasswordConfirm
        {
            get => registerPasswordConfirm;
            set { registerPasswordConfirm = value; OnPropertyChanged(); }
        }

        private string registerEmail;
        public string RegisterEmail
        {
            get => registerEmail;
            set { registerEmail = value; OnPropertyChanged(); }
        }

        private object selectedItem = new Item();
        public object SelectedItem
        {
            get => selectedItem;
            set { selectedItem = value; OnPropertyChanged(); }
        }

        private string usernameMod;
        public string UsernameMod
        {
            get => usernameMod;
            set { usernameMod = value; OnPropertyChanged(); }
        }

        private string emailMod;
        public string EmailMod
        {
            get => emailMod;
            set { emailMod = value; OnPropertyChanged(); }
        }

        private Windows.UI.Color logoutButtonColor = new Windows.UI.Color();
        public Windows.UI.Color LogoutButtonColor
        {
            get => logoutButtonColor;
            set { logoutButtonColor = value; OnPropertyChanged(); }
        }

        private bool userReadOnly;
        public bool UserReadOnly
        {
            get => userReadOnly;
            set { userReadOnly = value; OnPropertyChanged(); }
        }

        private bool emailReadOnly;
        public bool EmailReadOnly
        {
            get => emailReadOnly;
            set { emailReadOnly = value; OnPropertyChanged(); }
        }

        private int loginIndex;
        public int LoginIndex
        {
            get => loginIndex;
            set { loginIndex = value; OnPropertyChanged(); }
        }

        public static string keywordselected = null;
        public static string message = null;

        private bool loginLoading;
        public bool LoginLoading
        {
            get => loginLoading;
            set { loginLoading = value; OnPropertyChanged(); }
        }

        private string newBookName;
        public string NewBookName
        {
            get => newBookName;
            set { newBookName = value; OnPropertyChanged(); }
        }

        private string newBookAuthor;
        public string NewBookAuthor
        {
            get => newBookAuthor;
            set { newBookAuthor = value; OnPropertyChanged(); }
        }


        private int newBookPrice;
        public int NewBookPrice
        {
            get => newBookPrice;
            set { newBookPrice = value; OnPropertyChanged(); }
        }

        private string newBookPublisher;
        public string NewBookPublisher
        {
            get => newBookPublisher;
            set { newBookPublisher = value; OnPropertyChanged(); }
        }

        private int newBookPublishYear;
        public int NewBookPublishYear
        {
            get => newBookPublishYear;
            set { newBookPublishYear = value; OnPropertyChanged(); }
        }


        #endregion

        public async void Login()
        {
            Visib5 = Visibility.Visible;
            try
            {
                SendContent sendcontent = new SendContent();
                var receivecontent = new ReceiveContent();
                sendcontent.login.user_name = Username;
                sendcontent.login.password = Password;
                sendcontent.login.login_type = LoginIndex;
                sendcontent.func_select = 0;


                #region send the sendcontent

                HttpClient httpclient = new HttpClient();
                var headers = httpclient.DefaultRequestHeaders;

                string header = "ie";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value" + header);
                }

                header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }

                //string uristring = System.String.Format("http://localhost:6911/api/values/{0}{1}", temp.user_name, temp.password);

                Uri requestUri = new Uri("http://localhost:6911/api/values");
                HttpResponseMessage httpresponse = new HttpResponseMessage();
                string httpresponsebody;

                string send = JsonConvert.SerializeObject(sendcontent);
                try
                {
                    var senddata = new HttpFormUrlEncodedContent(
                        new Dictionary<string, string>()
                        { [""] = send }
                        );
                    httpresponse = await httpclient.PostAsync(requestUri, senddata);
                    //httpresponse.EnsureSuccessStatusCode();
                    httpresponsebody = await httpresponse.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    httpresponsebody = "Error: " + ex.HResult.ToString("x") + "Message: " + ex.Message;
                }
                receivecontent = JsonConvert.DeserializeObject<ReceiveContent>(httpresponsebody);

                #endregion
                
                message = receivecontent.content.ToString();
                if (System.String.Equals(message, "Login succeed."))
                {
                    Visib1 = Visibility.Collapsed;
                    if (LoginIndex == 0)
                        Visib2 = Visibility.Visible;
                    else
                        Visib8 = Visibility.Visible;
                    PublicInfo.user = Username;
                    PublicInfo.key = receivecontent.key;
                }
                else
                    ShowMessage(message);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.ToString());
            }
            Visib5 = Visibility.Collapsed;
        }

        private async void ShowMessage(string temp)
        {

            var dialog = new Windows.UI.Popups.MessageDialog(temp);

            dialog.Commands.Add(new Windows.UI.Popups.UICommand("OK") { Id = 0 });
            //dialog.Commands.Add(new Windows.UI.Popups.UICommand("No") { Id = 1 });

            //if (Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily != "Windows.Mobile")
            //{
            //    // Adding a 3rd command will crash the app when running on Mobile !!!
            //    dialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe later") { Id = 2 });
            //}

            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;

            var result = await dialog.ShowAsync();

            //var btn = sender as Button;
            //btn.Content = $"Result: {result.Label} ({result.Id})";
        }

        public async void Search()
        {
            Visib6 = Visibility.Visible;
            try
            {
                SendContent sendcontent = new SendContent();
                var receivecontent = new ReceiveContent();
                sendcontent.func_select = 1;

                switch (SelectedIndex)
                {
                    case 0:
                        sendcontent.search.search_condition = "Book_id";
                        break;
                    case 1:
                        sendcontent.search.search_condition = "Book_name";
                        break;
                    case 2:
                        sendcontent.search.search_condition = "Book_author";
                        break;
                    case 3:
                        sendcontent.search.search_condition = "Book_publisher";
                        break;
                    case 4:
                        sendcontent.search.search_condition = "Book_saletime";
                        break;
                }

                sendcontent.search.match_type = MatchIndex;
                sendcontent.search.keyword = Keyword;

                #region Post config

                HttpClient httpclient = new HttpClient();
                var headers = httpclient.DefaultRequestHeaders;

                string header = "ie";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value" + header);
                }

                header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }

                //string uristring = System.String.Format("http://localhost:6911/api/values/{0}{1}", temp.user_name, temp.password);

                Uri requestUri = new Uri("http://localhost:6911/api/values");
                HttpResponseMessage httpresponse = new HttpResponseMessage();
                string httpresponsebody;

                #endregion

                string send = JsonConvert.SerializeObject(sendcontent);
                var senddata = new HttpFormUrlEncodedContent(
                    new Dictionary<string, string>()
                    { [""] = send }
                    );
                httpresponse = await httpclient.PostAsync(requestUri, senddata);
                //httpresponse.EnsureSuccessStatusCode();
                httpresponsebody = await httpresponse.Content.ReadAsStringAsync();
                receivecontent = JsonConvert.DeserializeObject<ReceiveContent>(httpresponsebody);
                if (receivecontent.func_select == 2)
                {
                    Items = receivecontent.data;
                    foreach (Item temp in Items)
                    {
                        temp.Book_status_display = (temp.Book_status == 1) ? "Unavailable" : "Available";
                    }

                    Visib3 = Visibility.Collapsed;
                    Visib4 = Visibility.Visible;
                }
                else
                    ShowMessage(receivecontent.errormessage);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.ToString());
            }
            Visib6 = Visibility.Collapsed;
        }

        public async void Rent()
        {
            visib7 = Visibility.Visible;
            try
            {
                SendContent sendcontent = new SendContent();
                sendcontent.func_select = 2;
                sendcontent.update.update_type = 0;
                sendcontent.update.user = PublicInfo.user;
                sendcontent.update.book_id = Book_id_selected;
                sendcontent.varification = PublicInfo.key;


                HttpClient httpclient = new HttpClient();
                var headers = httpclient.DefaultRequestHeaders;

                string header = "ie";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value" + header);
                }

                header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }

                Uri requestUri = new Uri("http://localhost:6911/api/values");
                HttpResponseMessage httpresponse = new HttpResponseMessage();
                string httpresponsebody;

                string send = JsonConvert.SerializeObject(sendcontent);
                try
                {
                    var senddata = new HttpFormUrlEncodedContent(
                        new Dictionary<string, string>()
                        { [""] = send }
                        );
                    httpresponse = await httpclient.PostAsync(requestUri, senddata);
                    //httpresponse.EnsureSuccessStatusCode();
                    httpresponsebody = await httpresponse.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    httpresponsebody = "Error: " + ex.HResult.ToString("x") + "Message: " + ex.Message;
                }

                ReceiveContent receivecontent = JsonConvert.DeserializeObject<ReceiveContent>(httpresponsebody);
                if (receivecontent.func_select == 0)
                {
                    message = receivecontent.errormessage;
                }
                if (receivecontent.func_select == 1)
                {
                    message = receivecontent.content.ToString();
                }
                if (receivecontent.func_select == 9)
                {
                    message = receivecontent.errormessage;
                    Logout();
                }
                ShowMessage(message);
                Search();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.ToString());
            }
            visib7 = Visibility.Collapsed;
        }

        public async void Return()
        {
            visib7 = Visibility.Visible;
            try
            {
                SendContent sendcontent = new SendContent();
                sendcontent.func_select = 2;
                sendcontent.update.update_type = 1;
                sendcontent.update.user = PublicInfo.user;
                sendcontent.update.book_id = Book_id_selected;
                sendcontent.varification = PublicInfo.key;
                

                HttpClient httpclient = new HttpClient();
                var headers = httpclient.DefaultRequestHeaders;

                string header = "ie";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value" + header);
                }

                header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }

                Uri requestUri = new Uri("http://localhost:6911/api/values");
                HttpResponseMessage httpresponse = new HttpResponseMessage();
                string httpresponsebody;

                string send = JsonConvert.SerializeObject(sendcontent);
                try
                {
                    var senddata = new HttpFormUrlEncodedContent(
                        new Dictionary<string, string>()
                        { [""] = send }
                        );
                    httpresponse = await httpclient.PostAsync(requestUri, senddata);
                    //httpresponse.EnsureSuccessStatusCode();
                    httpresponsebody = await httpresponse.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    httpresponsebody = "Error: " + ex.HResult.ToString("x") + "Message: " + ex.Message;
                }

                ReceiveContent receivecontent = JsonConvert.DeserializeObject<ReceiveContent>(httpresponsebody);
                message = receivecontent.content.ToString();
                if (receivecontent.func_select == 9)
                {
                    message = receivecontent.errormessage;
                    Logout();
                }
                ShowMessage(message);
                Search();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.ToString());
            }
            visib7 = Visibility.Collapsed;
        }

        public async void Logout()
        {
            visib7 = Visibility.Visible;
            try
            {
                SendContent sendcontent = new SendContent();
                var receivecontent = new ReceiveContent();
                sendcontent.logout.user = Username;
                sendcontent.func_select = 3;
                sendcontent.varification = PublicInfo.key;

                HttpClient httpclient = new HttpClient();
                var headers = httpclient.DefaultRequestHeaders;

                string header = "ie";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value" + header);
                }

                header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }


                Uri requestUri = new Uri("http://localhost:6911/api/values");
                HttpResponseMessage httpresponse = new HttpResponseMessage();
                string httpresponsebody;

                string send = JsonConvert.SerializeObject(sendcontent);
                try
                {
                    var senddata = new HttpFormUrlEncodedContent(
                        new Dictionary<string, string>()
                        { [""] = send }
                        );
                    httpresponse = await httpclient.PostAsync(requestUri, senddata);
                    //httpresponse.EnsureSuccessStatusCode();
                    httpresponsebody = await httpresponse.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    httpresponsebody = "Error: " + ex.HResult.ToString("x") + "Message: " + ex.Message;
                }

                receivecontent = JsonConvert.DeserializeObject<ReceiveContent>(httpresponsebody);
                message = receivecontent.content.ToString();
                if (System.String.Equals(message, "Logout succeed."))
                {
                    Visib1 = Visibility.Visible;
                    Visib2 = Visibility.Collapsed;
                    Visib8 = Visibility.Collapsed;
                    Visib3 = Visibility.Collapsed;
                    Visib4 = Visibility.Visible;
                    PublicInfo.user = null;
                }
                else
                {
                    ShowMessage(message);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.ToString());
            }
            visib7 = Visibility.Collapsed;
        }

        public async void Register()
        {
            try
            {
                ReceiveContent receivecontent = new ReceiveContent();
                SendContent sendcontent = new SendContent();
                sendcontent.func_select = 4;
                sendcontent.register.user_name = RegisterUsername;
                sendcontent.register.password = RegisterPassword;
                sendcontent.register.email = RegisterEmail;

                if (System.String.Equals(RegisterPassword, RegisterPasswordConfirm) == false)
                {
                    ShowMessage("Please reconfirm your password.");
                    return;
                }

                #region send the sendcontent

                HttpClient httpclient = new HttpClient();
                var headers = httpclient.DefaultRequestHeaders;

                string header = "ie";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value" + header);
                }

                header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }

                //string uristring = System.String.Format("http://localhost:6911/api/values/{0}{1}", temp.user_name, temp.password);

                Uri requestUri = new Uri("http://localhost:6911/api/values");
                HttpResponseMessage httpresponse = new HttpResponseMessage();
                string httpresponsebody;

                string send = JsonConvert.SerializeObject(sendcontent);
                try
                {
                    var senddata = new HttpFormUrlEncodedContent(
                        new Dictionary<string, string>()
                        { [""] = send }
                        );
                    httpresponse = await httpclient.PostAsync(requestUri, senddata);
                    //httpresponse.EnsureSuccessStatusCode();
                    httpresponsebody = await httpresponse.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    httpresponsebody = "Error: " + ex.HResult.ToString("x") + "Message: " + ex.Message;
                }

                receivecontent = JsonConvert.DeserializeObject<ReceiveContent>(httpresponsebody);
                #endregion

                if (receivecontent.func_select == 1)
                {
                    message = receivecontent.content;
                    ShowMessage(message);
                }
                else
                {
                    message = receivecontent.errormessage;
                    ShowMessage(message);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.ToString());
            }
        }

        public async void ViewPersonalInfo()
        {
            visib7 = Visibility.Visible;
            try
            {
                SendContent sendcontent = new SendContent();
                var receivecontent = new ReceiveContent();
                sendcontent.func_select = 5;
                sendcontent.personalinfo.username = PublicInfo.user;
                sendcontent.varification = PublicInfo.key;

                #region Post config

                HttpClient httpclient = new HttpClient();
                var headers = httpclient.DefaultRequestHeaders;

                string header = "ie";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value" + header);
                }

                header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }

                //string uristring = System.String.Format("http://localhost:6911/api/values/{0}{1}", temp.user_name, temp.password);

                Uri requestUri = new Uri("http://localhost:6911/api/values");
                HttpResponseMessage httpresponse = new HttpResponseMessage();
                string httpresponsebody;

                #endregion

                string send = JsonConvert.SerializeObject(sendcontent);
                try
                {
                    var senddata = new HttpFormUrlEncodedContent(
                        new Dictionary<string, string>()
                        { [""] = send }
                        );
                    httpresponse = await httpclient.PostAsync(requestUri, senddata);
                    //httpresponse.EnsureSuccessStatusCode();
                    httpresponsebody = await httpresponse.Content.ReadAsStringAsync();
                    receivecontent = JsonConvert.DeserializeObject<ReceiveContent>(httpresponsebody);
                    if (receivecontent.func_select == 3)
                    {
                        Items = receivecontent.data;
                        EmailAdderss = receivecontent.content;
                    }
                    else if (receivecontent.func_select == 9)
                    {
                        message = receivecontent.errormessage;
                        Logout();
                    }
                    else
                        ShowMessage(receivecontent.errormessage);

                    Visib3 = Visibility.Visible;
                    Visib4 = Visibility.Collapsed;
                }
                catch (Exception ex)
                {
                    httpresponsebody = "Error: " + ex.HResult.ToString("x") + "Message: " + ex.Message;
                    ShowMessage(httpresponsebody);
                }
            }
            catch(Exception ex)
            {
                ShowMessage(ex.ToString());
            }
            visib7 = Visibility.Collapsed;
        }

        public void selectedItemChanged()
        {
            if (SelectedItem != null)
                Book_id_selected = (SelectedItem as Item).Book_id;
        }

        public async void UsernameModify()
        {
            try
            {
                
                SendContent sendcontent = new SendContent();
                sendcontent.func_select = 6;
                sendcontent.varification = PublicInfo.key;
                sendcontent.personalinfo.username = Username;

                #region Post config

                HttpClient httpclient = new HttpClient();
                var headers = httpclient.DefaultRequestHeaders;

                string header = "ie";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value" + header);
                }

                header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }

                //string uristring = System.String.Format("http://localhost:6911/api/values/{0}{1}", temp.user_name, temp.password);

                Uri requestUri = new Uri("http://localhost:6911/api/values");
                HttpResponseMessage httpresponse = new HttpResponseMessage();
                string httpresponsebody;

                #endregion

                string send = JsonConvert.SerializeObject(sendcontent);
                var senddata = new HttpFormUrlEncodedContent(
                    new Dictionary<string, string>()
                    { [""] = send }
                    );
                httpresponse = await httpclient.PostAsync(requestUri, senddata);
                //httpresponse.EnsureSuccessStatusCode();
                httpresponsebody = await httpresponse.Content.ReadAsStringAsync();
                ReceiveContent receivecontent = JsonConvert.DeserializeObject<ReceiveContent>(httpresponsebody);
                if (receivecontent.func_select == 1)
                {
                    ShowMessage(receivecontent.content);
                }
                else
                {
                    ShowMessage(receivecontent.errormessage);
                }
            }
            catch(Exception ex)
            {
                ShowMessage(ex.ToString());
            }
        }

        public async void EmailModify()
        {
            try
            {

                SendContent sendcontent = new SendContent();
                sendcontent.func_select = 7;
                sendcontent.varification = PublicInfo.key;
                sendcontent.personalinfo.username = Username;

                #region Post config

                HttpClient httpclient = new HttpClient();
                var headers = httpclient.DefaultRequestHeaders;

                string header = "ie";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value" + header);
                }

                header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }

                //string uristring = System.String.Format("http://localhost:6911/api/values/{0}{1}", temp.user_name, temp.password);

                Uri requestUri = new Uri("http://localhost:6911/api/values");
                HttpResponseMessage httpresponse = new HttpResponseMessage();
                string httpresponsebody;

                #endregion

                string send = JsonConvert.SerializeObject(sendcontent);
                var senddata = new HttpFormUrlEncodedContent(
                    new Dictionary<string, string>()
                    { [""] = send }
                    );
                httpresponse = await httpclient.PostAsync(requestUri, senddata);
                //httpresponse.EnsureSuccessStatusCode();
                httpresponsebody = await httpresponse.Content.ReadAsStringAsync();
                ReceiveContent receivecontent = JsonConvert.DeserializeObject<ReceiveContent>(httpresponsebody);
                if (receivecontent.func_select == 1)
                {
                    ShowMessage(receivecontent.content);
                }
                else
                {
                    ShowMessage(receivecontent.errormessage);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.ToString());
            }
        }

        public async void BookAddition()
        {
            try
            {
                ReceiveContent receivecontent = new ReceiveContent();
                SendContent sendcontent = new SendContent();
                sendcontent.func_select = 8;
                sendcontent.newbook.name = NewBookName;
                sendcontent.newbook.author = NewBookAuthor;
                sendcontent.newbook.price = NewBookPrice;
                sendcontent.newbook.publisher = NewBookPublisher;
                sendcontent.newbook.publish_year = NewBookPublishYear;
                sendcontent.varification = PublicInfo.key;
                

                #region send the sendcontent

                HttpClient httpclient = new HttpClient();
                var headers = httpclient.DefaultRequestHeaders;

                string header = "ie";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value" + header);
                }

                header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }

                //string uristring = System.String.Format("http://localhost:6911/api/values/{0}{1}", temp.user_name, temp.password);

                Uri requestUri = new Uri("http://localhost:6911/api/values");
                HttpResponseMessage httpresponse = new HttpResponseMessage();
                string httpresponsebody;

                string send = JsonConvert.SerializeObject(sendcontent);
                try
                {
                    var senddata = new HttpFormUrlEncodedContent(
                        new Dictionary<string, string>()
                        { [""] = send }
                        );
                    httpresponse = await httpclient.PostAsync(requestUri, senddata);
                    //httpresponse.EnsureSuccessStatusCode();
                    httpresponsebody = await httpresponse.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    httpresponsebody = "Error: " + ex.HResult.ToString("x") + "Message: " + ex.Message;
                }

                receivecontent = JsonConvert.DeserializeObject<ReceiveContent>(httpresponsebody);
                #endregion

                if (receivecontent.func_select == 1)
                {
                    message = receivecontent.content;
                    ShowMessage(message);
                }
                else
                {
                    message = receivecontent.errormessage;
                    ShowMessage(message);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.ToString());
            }
        }

        public async void BookElimination()
        {
            try
            {


                SendContent sendcontent = new SendContent();
                sendcontent.varification = PublicInfo.key;
                sendcontent.func_select = 9;
                sendcontent.bookelimination.book_id = Book_id_selected;


                #region send the sendcontent

                HttpClient httpclient = new HttpClient();
                var headers = httpclient.DefaultRequestHeaders;

                string header = "ie";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value" + header);
                }

                header = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
                if (!headers.UserAgent.TryParseAdd(header))
                {
                    throw new Exception("Invalid header value: " + header);
                }

                //string uristring = System.String.Format("http://localhost:6911/api/values/{0}{1}", temp.user_name, temp.password);

                Uri requestUri = new Uri("http://localhost:6911/api/values");
                HttpResponseMessage httpresponse = new HttpResponseMessage();
                string httpresponsebody;

                string send = JsonConvert.SerializeObject(sendcontent);
                try
                {
                    var senddata = new HttpFormUrlEncodedContent(
                        new Dictionary<string, string>()
                        { [""] = send }
                        );
                    httpresponse = await httpclient.PostAsync(requestUri, senddata);
                    //httpresponse.EnsureSuccessStatusCode();
                    httpresponsebody = await httpresponse.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    httpresponsebody = "Error: " + ex.HResult.ToString("x") + "Message: " + ex.Message;
                }

                ReceiveContent receivecontent = JsonConvert.DeserializeObject<ReceiveContent>(httpresponsebody);
                #endregion

                if (receivecontent.func_select == 1)
                {
                    message = receivecontent.content;
                    ShowMessage(message);
                }
                else
                {
                    message = receivecontent.errormessage;
                    ShowMessage(message);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.ToString());
            }
        }
    }
}