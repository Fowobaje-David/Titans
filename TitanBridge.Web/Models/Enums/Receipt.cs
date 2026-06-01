namespace TitanBridge.Web.Models.Enums
{
    public class Receipt
    {
        public int Id { get; set; }
        public string ReceiptNumber { get; set; }
        public string ReceiptType { get; set; }
        public string ReceiptDescription { get; set; }
        public string ReceiptId { get; set; }
        public DateTime DateIssued { get; set; }
    }
 }
