import { Injectable, Inject } from '@angular/core';
import { MessageService } from 'primeng/api';
import { Router } from "@angular/router";


@Injectable({
  providedIn: 'root'
})
export class HarperCollinsCommonFunctions {
  constructor(
    private messageService: MessageService,
    private router: Router,
  ) {
  }

  navigateToRoute(route: any[]) {
    this.router.navigate(route);
  }

  routeToSalesPage() {

    this.navigateToRoute(['/app-viewSales']);
  }

  public generateGuid() {
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
      var r = Math.random() * 16 | 0,
        v = c == 'x' ? r : (r & 0x3 | 0x8);
      return v.toString(16);
    });
  }

  public writeIt(message: string) {
    console.info(message);
  }


  showToasterInfo(summary: string, detail: string) {

    this.messageService.add({ key: 'toast', severity: 'info', summary: summary, detail: detail });

  }

  showToasterError(summary: string, detail: string) {

    this.messageService.add({ key: 'toast', severity: 'error', summary: summary, detail: detail });

  }

  showToasterSuccess(summary: string, detail: string) {
    this.messageService.add({ key: 'toast', severity: 'success', summary: summary, detail: detail });
  }
}
