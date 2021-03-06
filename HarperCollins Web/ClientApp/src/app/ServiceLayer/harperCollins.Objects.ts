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
    public salesId: String;
    public orderDate: Date;
    public orderQuantity: number;
    public orderStatus: String;
    public customerNumber: number;
    public customerName: String;
    //public customerData?: HarperCollins.customerData;
    public isbn: String;
    public title: String;
    public author: String;
    public format: String;
    public listPrice: number;
    //public tileData?: HarperCollins.saleData;
   
  }
}
