import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class YtcgService {
  private baseUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php"; 

  constructor(private http: HttpClient){}

  

}
