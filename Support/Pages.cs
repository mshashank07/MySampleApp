using MySampleApp.PageObjects;


namespace MySampleApp.Support
{
    public abstract class Pages:Base
    {

        public static ChannelPage ChannelPage
        {
            get { var channel = new ChannelPage();return channel;}
        }

        public static HomePage HomePage
        {
            get { var home = new HomePage(); return home; }
        }





    }
}
