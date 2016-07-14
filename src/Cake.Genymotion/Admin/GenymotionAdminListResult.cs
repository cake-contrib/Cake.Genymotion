namespace Cake.Genymotion.Admin
{
    public class GenymotionAdminListResult
    {
        public string IpAddress { get; set; }
        public string Name { get; set; }
        public GenymotionSimulatorState State { get; set; }
        public string UUID { get; set; }
    }
}