using System;

namespace BlabberApp.Domain.Models {
    public class Blab : Model {
        public DateTime DateTime { get; set; }
        public String Message { get; set; }
        public String UserID { get; set; }
    }
}