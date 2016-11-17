namespace AspNetStarter.Shared.Wowza
{
    public class live_stream
    {
        public string id { get; set; }
        public string name { get; set; }

        public string broadcast_location { get; set; }
        public string transcoder_type => "transcoded";
        public string billing_mode => "pay_as_you_go";
        public string encoder => "other_rtmp";
        public string delivery_method = "push";
        public int aspect_ratio_width => 1920;
        public int aspect_ratio_height => 1080;
    }
}