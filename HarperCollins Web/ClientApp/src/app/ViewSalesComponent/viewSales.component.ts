import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {HarperCollinsService } from '../ServiceLayer/harperCollins.Service'
import {HarperCollins } from '../ServiceLayer/harperCollins.Objects'

@Component({
  selector: 'app-viewSales',
  templateUrl: './viewSales.component.html'
})
export class ViewSalesComponent
{
  rowGroupMetadata: any;
  sales: HarperCollins.saleData[];

  constructor(
    private hcApi: HarperCollinsService,

  )
  {
  }

  ngOnInit()
  {
    this.loadSales();
    
    
  }


  updateRowGroupMetaData()
  {
    this.rowGroupMetadata = {};
    if (this.sales)
    {
      for (let i = 0; i < this.sales.length; i++)
      {
        let rowData = this.sales[i];
        let salesId = rowData.salesId;
        if (i == 0)
        {
          this.rowGroupMetadata[salesId.toString()] = { index: 0, size: 1 };
        }
        else
        {
          let previousRowData = this.sales[i - 1];
          let previousRowGroup = previousRowData.salesId;
          if (salesId === previousRowGroup)
            this.rowGroupMetadata[salesId.toString()].size++;
          else
            this.rowGroupMetadata[salesId.toString()] = { index: i, size: 1 };
        }
      }
    }
  }

  loadSales()
  {
    this.hcApi.getAllSales().subscribe(result =>
    {
      this.sales = <HarperCollins.saleData[]>result;
      this.updateRowGroupMetaData();
    },
      () =>
      {
        //this.updateRowGroupMetaData();
      }
    );
  }

}

