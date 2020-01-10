import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {HarperCollinsService } from '../ServiceLayer/harperCollins.Service'
import {HarperCollins } from '../ServiceLayer/harperCollins.Objects'

@Component({
  selector: 'app-titles',
  templateUrl: './titles.component.html'
})
export class TitlesComponent
{

  titles: HarperCollins.tileData[];

  constructor(
    private hcApi: HarperCollinsService,

  )
  {
  }

  ngOnInit()
  {
    this.loadTitles();
  }

  loadTitles()
  {
    this.hcApi.getAllTitles().subscribe(result =>
    {
      this.titles = <HarperCollins.tileData[]>result;
    });
  }

}

