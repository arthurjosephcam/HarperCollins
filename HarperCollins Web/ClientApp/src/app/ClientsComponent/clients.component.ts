import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {HarperCollinsService } from '../ServiceLayer/harperCollins.Service'
import {HarperCollins } from '../ServiceLayer/harperCollins.Objects'

@Component({
  selector: 'app-clients',
  templateUrl: './clients.component.html'
})
export class ClientsComponent
{

  customers: HarperCollins.customerData[];

  constructor(
    private hcApi: HarperCollinsService,

  )
  {
  }

  ngOnInit()
  {
    this.loadCustomers();
  }

  loadCustomers()
  {
    this.hcApi.getAllClients().subscribe(result =>
    {
      this.customers = <HarperCollins.customerData[]>result;
    });
  }

}

