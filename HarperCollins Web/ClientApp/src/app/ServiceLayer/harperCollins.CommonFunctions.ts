import { Injectable, Inject } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HarperCollinsCommonFunctions
{
  constructor()
  {
  }

  public writeIt(message: string)
  {
    console.info(message);
  }
}
