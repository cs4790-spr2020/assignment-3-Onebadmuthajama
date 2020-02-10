using System;

namespace BlabberApp.Domain
{
    public class Blab : IDatum
    {
        public DateTime DateTime { get; set; }
        public String Message { get; set; }
        public string UserID { get; set; }

        public string getSysId() {
            return string.Empty;
        }
    }
}