import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class GuideApiService {
  private baseUrl = "https://yugioexodiaguideapi.azurewebsites.net/api";
  
  
  constructor() { }
}
