export namespace HarperCollins
{
  export class customerData
  {
    public customerNumber: number;
    public customerName: String;
    public addressLine1: String;
    public addressLine2: String;
    public addressLine3: String;
  }

  export class tileData
  {
    public isbn: String;
    public title: String;
    public author: String;
    public format: String;
    public listPrice: number;
    public orderQuantity: number; //I will use it to track order quantity.
        
  }

  export class saleData
  {
    public Guid: String;
    //public Guid SalesId { get; set; }
    //    public DateTime OrderDate { get; set; }

    //    public Int32 OrderQuantity { get; set; }
    //    public String OrderStatus { get; set; }

    //    public Int32 CustomerNumber { get; set; }
    //    public CustomerData CustomerData { get; set; }

    //    public String ISBN { get; set; }
    //    public TileData TileData { get; set; }
  }
}
