import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ManagerService {

  //backendurl: string = 'http://localhost';
  //backendurl: string = 'http://elrouby.ddns.net';
  backendurl: string = 'https://localhost:7162';
  
  constructor() { }
}
