import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Title } from '@angular/platform-browser';
import { Injectable, Inject } from '@angular/core';
import { HarperCollins } from './harperCollins.Objects';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class HarperCollinsService {
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    private titleService: Title,
  ) { }



  completeSale(sales: HarperCollins.saleData[]) {
    var ret = this.http.post(this.baseUrl + 'api/SalesData/SaveSales', sales, httpOptions);
    return ret;
  }

  getAllSales() {
    var ret = this.http.get(this.baseUrl + 'api/SalesData/GetAllSales');
    return ret;
  }
  searchCustomers(keyword: String) {
    var ret = this.http.get(this.baseUrl + 'api/CustomerData/SearchClients?Keyword=' + keyword);
    return ret;
  }

  searchTitles(keyword: String) {
    var ret = this.http.get(this.baseUrl + 'api/TileData/SearchTiles?Keyword=' + keyword);
    return ret;
  }

  getAllClients() {
    var ret = this.http.get(this.baseUrl + 'api/CustomerData/getAllClients');
    return ret;
  }

  getAllTitles() {
    var ret = this.http.get(this.baseUrl + 'api/TileData/getAllTiles');
    return ret;
  }
}
