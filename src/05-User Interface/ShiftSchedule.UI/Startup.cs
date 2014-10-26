using Microsoft.Owin;
using Owin;


namespace ShiftSchedule.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
