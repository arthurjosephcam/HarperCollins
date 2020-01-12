import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {HarperCollinsService } from '../ServiceLayer/harperCollins.Service'
import { HarperCollins } from '../ServiceLayer/harperCollins.Objects'
import { HarperCollinsCommonFunctions } from '../ServiceLayer/harperCollins.CommonFunctions'
import { error } from 'protractor';

@Component({
  selector: 'app-sales',
  templateUrl: './sales.component.html'
})
export class SalesComponent
{

  customers: HarperCollins.customerData[];
  titles: HarperCollins.tileData[];
  titlesToSale: Array<HarperCollins.tileData> = new Array();

  selectedCustomer: HarperCollins.customerData;
  searchKeyword: String;
  isProcessing: boolean;
  step: String = "selectCustomer";

  ccRegex: RegExp = /[0-9]+$/;

  //noSpecial: RegExp = /^[^<>*!]+$/


  constructor(
    private hcApi: HarperCollinsService,
    private commonFunctions: HarperCollinsCommonFunctions

  )
  {
  }

  ngOnInit()
  {
    //this.loadCustomers();
  }

  loadCustomers()
  {
    this.hcApi.getAllClients().subscribe(result =>
    {
      this.customers = <HarperCollins.customerData[]>result;
    });
  }

  

  searchCustomers()
  {
    if (this.searchKeyword == '' || this.searchKeyword == null) return;
    this.isProcessing = true;

    this.hcApi.searchCustomers(this.searchKeyword).subscribe(result =>
    {
      this.customers = <HarperCollins.customerData[]>result;
    },
      error => {
        this.commonFunctions.writeIt(error);
        this.commonFunctions.showToasterError("Error loading customer.", "A server side error occured! Please see the console for error details!");
        this.isProcessing = false;},
      () =>
      {
        this.isProcessing = false;
      }

    );
  }


  selectCustomer(customer: HarperCollins.customerData)
  {
    this.selectedCustomer = customer;
    this.step = "selectTitle";
    
  }

  searchTitles(searchKey: String)
  {
    this.isProcessing = true;

    this.hcApi.searchTitles(searchKey).subscribe(result =>
    {
      this.titles = <HarperCollins.tileData[]>result;
    },
      error =>
      {
        this.commonFunctions.writeIt(error);
        this.commonFunctions.showToasterError("Error loading titles.", "A server side error occured! Please see the console for error details!");
        this.isProcessing = false;
      },
      () =>
      {
        this.isProcessing = false;
      }

    );
  }


  selectTitle(title: HarperCollins.tileData)
  {
    if (this.titlesToSale.includes(title)) return;

    title.orderQuantity = 1;
    this.titlesToSale.push(title);
  }


  validateQuantity(quantity: number, row: HarperCollins.tileData)
  {
    if (quantity < 1)
    {
      this.commonFunctions.showToasterError("validation Error", "Order Quantity cannot be zero.");
      return;
    }

    row.orderQuantity = quantity;
  }

}

