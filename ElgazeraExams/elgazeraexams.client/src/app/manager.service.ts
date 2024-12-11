import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ManagerService {

  backendurl: string = 'http://localhost:5082';
  
  constructor() { }
}
