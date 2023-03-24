import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ofertas',
  templateUrl: './ofertas.component.html',
  styleUrls: ['./ofertas.component.scss']
})
export class OfertasComponent implements OnInit {
  public ofertas: any;

  constructor(private http: HttpClient){}

  ngOnInit(): void {
  }

  public getOfertas(): void{
    this.http.get('http://localhost:5001/v1/ofertas/{idOferta}').subscribe(
      response => this.ofertas = response,
      error => console.log(error)
    );
  }

  public getAllOfertas(): void{
    
  }
}
