import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {

  users: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getUsers()
  }
  getUsers()
  {
    this.http.get("https://localhost:5001/User").subscribe(data=> {
      this.users = data;
    }, error => {
      console.log(error);
    })
  }
}
