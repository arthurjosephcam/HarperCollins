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

  loadSales()
  {
    this.hcApi.getAllSales().subscribe(result =>
    {
      this.sales = <HarperCollins.saleData[]>result;
    });
  }

}

