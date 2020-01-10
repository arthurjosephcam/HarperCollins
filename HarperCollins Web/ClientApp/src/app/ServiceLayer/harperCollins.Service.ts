import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Title } from '@angular/platform-browser';
import { Injectable, Inject } from '@angular/core';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class HarperCollinsService
{
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    private titleService: Title,
  ) { }


  getAllClients()
  {
    var ret = this.http.get(this.baseUrl + 'api/CustomerData/getAllClients');
    return ret;
  }

  getAllTitles()
  {
    var ret = this.http.get(this.baseUrl + 'api/TileData/getAllTiles');
    return ret;
  }
}
