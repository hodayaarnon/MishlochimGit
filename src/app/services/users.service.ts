import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class UsersService {
  constructor(private myhttp: HttpClient) {}

result:any;

  getCount() {
    this.myhttp.get('/api/Users').subscribe((res) => {
      console.log(res);
      this.result=res;
    });
    return this.result;
  }

  getName() {
    this.myhttp.get('/api/Users').subscribe((res) => {
      console.log(res);
      this.result=res;
    });
    return this.result;
  }
}


